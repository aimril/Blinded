using UnityEngine;
using System.Collections;

public class Julius : MonoBehaviour {

	private float smooth = 2.0f;
	int x = 0;

	
	void Update () {
		
		var target = Quaternion.Euler (0, x, 0);
		
		if(Input.GetKeyDown(KeyCode.D)){
			x += 90;
			target = Quaternion.Euler (0, x, 0);
			Debug.Log(x+ " is the value of x.");
		}
		else if(Input.GetKeyDown(KeyCode.A)){
			x -= 90;
			target = Quaternion.Euler (0, x, 0);
			Debug.Log(x+ " is the value of x.");
			
		}
		
		if(Input.GetKey(KeyCode.Space)){
		
			//rigidbody.AddForce(Vector3.back);
			//transform.Translate(0,0,5*Time.deltaTime);

			
		}		
		
	
	// Apply the direction to the CharacterMotor
		
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		
	}

}
