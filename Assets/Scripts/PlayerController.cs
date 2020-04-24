using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 20.0f;
    private float xRange = 20;
    private float acceleration;
    public GameObject projectilePrefab;
    GameManager gameManager;
    public int munitions = 10;
    [SerializeField] TextMeshProUGUI munitionsUI;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        munitionsUI.text = "Munitions: " + munitions.ToString();

        // Check for left and right bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            acceleration = 2f;
        }
        else
        {
            acceleration = 1f;
        }

        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput * acceleration);
        if (gameManager.gameIsActive)
        {

            if (Input.GetKeyDown(KeyCode.Space) && munitions > 0)
            {
                munitions--;
                // No longer necessary to Instantiate prefabs
                // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

                // Get an object object from the pool
                GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();

                if (pooledProjectile != null)
                {
                    pooledProjectile.SetActive(true); // activate it
                    pooledProjectile.transform.position = transform.position; // position it at player
                }
            }
        }

    }
}
