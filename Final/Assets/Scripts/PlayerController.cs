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
	bool talkAble;

	//How fast the player will move.
	public float playerSpeed;

	void Update () {

		//How to move player!
		Vector3 pos = transform.position;
		if (Input.GetKey (fwd)) {
			pos.z += playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKey (back)) {
			pos.z -= playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKey (left)) {
			pos.x -= playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKey (right)) {
			pos.x += playerSpeed * Time.deltaTime;
			transform.position = pos;
		} 
		else if (Input.GetKeyDown (interact) && talkAble == true) {
			Debug.Log ("Talking");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Dialogue")) {
			Debug.Log ("ready to talk");
			talkAble = true;
		}
		if (other.CompareTag("Environment"))
		{
			Vector3 pos = transform.position;
			if (Input.GetKey (fwd)) {
				pos.z -= playerSpeed * Time.deltaTime;
			}
			if (Input.GetKey(back)) {
				pos.z += playerSpeed * Time.deltaTime;		
			}
			if (Input.GetKey(left)) {
				pos.x += playerSpeed * Time.deltaTime;
			}
			if (Input.GetKey(right)) {
				pos.x -= playerSpeed * Time.deltaTime;					
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Dialogue")) {
			Debug.Log ("can not talk");
			talkAble = false;
		}
	}

}
