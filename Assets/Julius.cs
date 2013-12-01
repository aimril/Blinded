using UnityEngine;
using System.Collections;

public class Julius : MonoBehaviour {
	
	public float moveSpeed = 3.0f;
	public int rotateSpeed = 90;
	private float smooth = 2.0f;
	int x = 0;

	private CharacterController controller;
	
	void Start () {
		controller = (CharacterController) GetComponent("CharacterController");
	}
	
	void Update () {
		
		var target = Quaternion.Euler (0, x, 0);
		
		if(Input.GetKeyDown(KeyCode.D)){
			x += rotateSpeed;
			target = Quaternion.Euler (0, x, 0);
			Debug.Log(x+ " is the value of x.");
		}
		else if(Input.GetKeyDown(KeyCode.A)){
			x -= rotateSpeed;
			target = Quaternion.Euler (0, x, 0);
			Debug.Log(x+ " is the value of x.");
			
		}
		
		if(Input.GetKey(KeyCode.Space)){
			//rigidbody.AddForce(Vector3.back);
			//transform.Translate(0,0,5*Time.deltaTime);
			Debug.Log ("rigidbody rotation = " + rigidbody.rotation);
			//gameObject.rigidbody.AddForce(rigidbody.rotation * Vector3.forward * moveSpeed);
			controller.Move (rigidbody.rotation * Vector3.forward * moveSpeed * Time.deltaTime);

		} else if(Input.GetKey(KeyCode.S)){
			controller.Move (rigidbody.rotation * Vector3.back * moveSpeed * Time.deltaTime);
			
		}
		
	
	// Apply the direction to the CharacterMotor
		
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		
	}

}
