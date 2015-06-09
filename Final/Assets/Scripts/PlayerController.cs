using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {

	public Transform target;
	//Changable key settings, change by going to the player object.
	public KeyCode fwd;
	public KeyCode back;
	public KeyCode left;
	public KeyCode right;
	public KeyCode interact;
	bool talkAble1;
	bool talkAble2;

	//How fast the player will move.
	public float playerSpeed;

	//Reference to the collision stuff
	private PlayerCollision collisions;

	void Start() {
		collisions = GetComponent<PlayerCollision>();
	}

	void Update () {

		//How to move player!
		Vector3 pos = transform.position;
		if (Input.GetKey (fwd) && !collisions.collisionUp) {
			pos.z += playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKey (back) && !collisions.collisionDown) {
			pos.z -= playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKey (left) && !collisions.collisionLeft) {
			pos.x -= playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKey (right) && !collisions.collisionRight) {
			pos.x += playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKeyDown (interact) && talkAble1 == true) {
			Debug.Log ("piss");
		}
		else if (Input.GetKeyDown (interact) && talkAble2 == true) {
			Debug.Log ("shit");
		}
	}
	//Check if the player is in a Dialogue zone.
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Dialogue1")) //repeat for # of Dialogue boxes.
			{
				Debug.Log ("ready to talk 1");
				talkAble1 = true;
			}
		if (other.CompareTag ("Dialogue2"))
		{
			Debug.Log ("Ready to talk 2");
			talkAble2 = true;
		}

	}
  //make the player unable to talk when they lave a Dialogue zone.
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Dialogue1")) //repeat for # of Dialogue boxes.
		{
			Debug.Log ("can not talk 1");
			talkAble1 = false;
		}
		if (other.CompareTag ("Dialogue2")) //repeat for # of Dialogue boxes.
		{
			Debug.Log ("can not talk 2");
			talkAble2 = false;
		}
	}
}
