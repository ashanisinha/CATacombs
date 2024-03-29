using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3.2f; // Adjust the speed of the enemy
    public float changeDirectionInterval = 2f; // Adjust the interval for changing direction

    public Rigidbody2D rb;
    private Vector2 currentDirection;
    private float timer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Start by moving in a random horizontal or vertical direction
        ChooseRandomDirection();
    }

    private void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Change direction at the specified interval
        if (timer >= changeDirectionInterval)
        {
            ChooseRandomDirection();
            timer = 0f;
        }
    }

    private void FixedUpdate()
    {
        // Move the enemy using physics-based forces
       rb.velocity = currentDirection * moveSpeed;
    }


    private void ChooseRandomDirection()
    {
        // Generate a random integer between 0 and 3 (0 for up, 1 for down, 2 for left, 3 for right)
        int randomDirection = Random.Range(0, 4);

        // Set the current direction based on the random integer
        switch (randomDirection)
        {
            case 0:
                currentDirection = Vector2.up;
                break;
            case 1:
                currentDirection = Vector2.down;
                break;
            case 2:
                currentDirection = Vector2.left;
                break;
            case 3:
                currentDirection = Vector2.right;
                break;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            currentDirection = -currentDirection;
            return;
        }

        int random = Random.Range(0,2);

        if (currentDirection == Vector2.up || currentDirection == Vector2.down)
        {
            switch (random)
            {
                case 0:
                    currentDirection = Vector2.right;
                    break;

                case 1:
                    currentDirection = Vector2.left;
                    break;
            }
        }

        else
        {
            switch (random)
            {
                case 0:
                    currentDirection = Vector2.up;
                    break;

                case 1:
                    currentDirection = Vector2.down;
                    break;
            }
        }

        rb.velocity = currentDirection * moveSpeed;

    }

}