using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour {

	public Transform lookingAt;
	public float smooth;
	
	Vector3 second = new Vector3(19.10242f, 4.017602f, 38.70352f);
	Vector3 first = new Vector3(33.27234f,4.017602f,38.70352f);
	private Vector3 newPosition = new Vector3(19.10242f, 4.017602f, 38.70352f);
	
	void Update () {
		//transform.LookAt(lookingAt);
		var rotate = Quaternion.LookRotation(lookingAt.position - transform.position);
		
		transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime*smooth);
		
		if(Input.GetKeyDown(KeyCode.L)){
			newPosition = second;
		}
		else if(Input.GetKeyDown(KeyCode.K)){
			newPosition = first;
		}
		
		transform.position = Vector3.Lerp(transform.position, newPosition, smooth* Time.deltaTime);
	}
}
