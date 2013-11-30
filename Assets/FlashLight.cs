using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {
	
	private Light flashLight;
	void Start(){
		
		flashLight = GetComponent<Light>();
		
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			flashLight.enabled = !flashLight.enabled;
		}
	}
}
