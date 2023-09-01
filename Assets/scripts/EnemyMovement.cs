using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	//setting initial speeds
	public float speed = 5.0f;
	public Vector3 direction;
    public float rotate = 90.0f;
	
	void Start() 
	{
		//initial directions of all the ghosts
		direction = (new Vector3(Random.Range(-1.0f,1.0f), Random.Range(-1.0f,1.0f),0.0f)).normalized;
		transform.Rotate(direction);
	}
	
	void Update()
	{
		Vector3 newPos = transform.position + direction * speed * Time.deltaTime;
		GetComponent<Rigidbody2D>().MovePosition (newPos); //calculating new position and moving ghost to said position
	}
	
	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("Collision");
		if (col.gameObject.tag == "Wall")   
		{
			direction = col.contacts[0].normal;
			direction = Quaternion.AngleAxis(rotate, Vector3.forward) * direction;
			transform.rotation = Quaternion.LookRotation(direction);
		}
	}
}