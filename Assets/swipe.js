#pragma strict
var player : Transform;  // Drag your player here
private var fp : Vector2;
private var lp : Vector2;


var smooth: float = 2.0f;
var x :int = 0;
function Update()
{
var target = Quaternion.Euler (0, x, 0);

    for (var touch : Touch in Input.touches)
    {
     if (touch.phase == TouchPhase.Began)
     {
      fp = touch.position;
      lp = touch.position;
     }
     if (touch.phase == TouchPhase.Moved )
     {
      lp = touch.position;
     }
     if(touch.phase == TouchPhase.Ended)
     { 
      
      if((fp.x - lp.x) > 80) // left swipe
      {
       	x -= 90;
		target = Quaternion.Euler (0, x, 0);
		Debug.Log(x+ " is the value of x.");
       //player.Rotate(0,-90,0);
       
      }
      else if((fp.x - lp.x) < -80) // right swipe
      {
     	x += 90;
		target = Quaternion.Euler (0, x, 0);
		Debug.Log(x+ " is the value of x.");
      // player.Rotate(0,90,0);
      }
      else if((fp.y - lp.y) < -80 ) // up swipe
      {
       // do jumping here
      }
     }
    }
 transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);  

}