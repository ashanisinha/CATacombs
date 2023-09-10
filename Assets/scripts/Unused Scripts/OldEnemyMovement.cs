/*using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Adjust the speed of the enemy
    public float changeDirectionInterval = 2f; // Adjust the interval for changing direction

    private Vector2 currentDirection;
    private float timer;

    private void Start()
    {
        // Start by moving in a random horizontal or vertical direction
        ChooseRandomDirection();
    }

    private void Update()
    {
        // Move the enemy in the current direction
        transform.Translate(currentDirection * moveSpeed * Time.deltaTime);

        // Update the timer
        timer += Time.deltaTime;

        // Change direction at the specified interval
        if (timer >= changeDirectionInterval)
        {
            ChooseRandomDirection();
            timer = 0f;
        }
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

	private void OnCollisionEnter2D(Collision2D collision) {
        transform.Translate(-currentDirection * moveSpeed * Time.deltaTime);
        // if(collision.gameObject.tag == "Wall") {
        //    // transform.Translate(0 ,0 ,0);
        //     ChooseRandomDirection();
        //     transform.Translate(currentDirection * moveSpeed * Time.deltaTime);
		// }

        // if(collision.gameObject.tag == "Enemy") {
        //     ChooseRandomDirection();
        //     transform.Translate(currentDirection * moveSpeed * Time.deltaTime);
        // }

        // if(collision.gameObject.tag == "Key") {
        //     transform.Translate(-currentDirection * moveSpeed * Time.deltaTime);
        // } 
        // else {
        //     ChooseRandomDirection();
        //     transform.Translate(currentDirection * moveSpeed * Time.deltaTime);
        // }
	}
}
*/