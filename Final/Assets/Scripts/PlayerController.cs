using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {

	public Transform target;
	//Changable key settings, change by going to the player object.
	public KeyCode fwd;
	public KeyCode back;
	public KeyCode left;
	public KeyCode right;

	//How fast the player will move.
	public float playerSpeed;
	float collisionSpeed;
	float speed;

	void Start(){
		speed = playerSpeed;
		collisionSpeed = (playerSpeed * -1);
	}
	
	void Update () {

		//How to move player!
		Vector3 pos = transform.position;
		if (Input.GetKey(fwd)) {
			pos.z += speed;
		}
		if (Input.GetKey(back)) {
			pos.z -= speed;		
		}
		if (Input.GetKey(left)) {
			pos.x -= speed;
		}
		if (Input.GetKey(right)) {
			pos.x += speed;					
		}
		/*
		if( target )
		{
			Vector3 dist = pos - target.localPosition;
			if( dist.sqrMagnitude < 1 && Input.GetKey( left ) )
			{
				pos.x += 0.15f;
				
			}
			
			if( dist.sqrMagnitude < 1 && Input.GetKey( fwd ) )
			{
				pos.z -= 0.15f;
				
			}
			
			if( dist.sqrMagnitude < 1 && Input.GetKey( back ) )
			{
				pos.z += 0.15f;
				
			}
			
			if( dist.sqrMagnitude < 1 && Input.GetKey( right ) )
			{
				pos.x -= 0.15f;
				
			}
		}
		*/
		//Move the playrer!
		transform.position = pos;
	}

	public void OnCollisionEnter(Collision c){
		Vector3 pos = transform.position;
		if (Input.GetKey(fwd)) {
			pos.z -= speed;
		}
		if (Input.GetKey(back)) {
			pos.z += speed;		
		}
		if (Input.GetKey(left)) {
			pos.x += speed;
		}
		if (Input.GetKey(right)) {
			pos.x -= speed;					
		}
		transform.position = pos;

	}
//	public void OnCollisionExit(Collision c){
//		speed = playerSpeed;
//	}
}
