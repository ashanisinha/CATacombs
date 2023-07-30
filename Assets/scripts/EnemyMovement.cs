using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float speed = 5.0f;
	public Vector3 direction;
    public float rotate = 90.0f;
	
	void Start() 
	{
		direction = (new Vector3(Random.Range(-1.0f,1.0f), Random.Range(-1.0f,1.0f),0.0f)).normalized;
		transform.Rotate(direction);
	}
	
	void Update()
	{
		Vector3 newPos = transform.position + direction * speed * Time.deltaTime;
		GetComponent<Rigidbody2D>().MovePosition (newPos);
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