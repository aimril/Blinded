using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {
	private float speed = 50;
	
	void FixedUpdate () {
		transform.Rotate(Vector3.up*speed*Time.deltaTime);
		transform.Rotate(Vector3.forward*(speed+70)*Time.deltaTime);
	}
}
