var flickerSpeed : float = 0.1;
var waiting : float = 1.0;
var counter = 0; 

while (true) {
if(counter % 3 == 0){
    light.enabled = true;

    yield WaitForSeconds (flickerSpeed);

    light.enabled = false;

    yield WaitForSeconds (flickerSpeed);
    
    light.enabled = true;

    yield WaitForSeconds (flickerSpeed);

    light.enabled = false;

    yield WaitForSeconds (flickerSpeed);
	
	light.enabled = true;
	
    yield WaitForSeconds (waiting);
    
     light.enabled = false;
     
}
else{
	light.enabled = true;

    yield WaitForSeconds (waiting);

    light.enabled = false;

    yield WaitForSeconds (flickerSpeed);
    
    light.enabled = false;

    yield WaitForSeconds (flickerSpeed);

    light.enabled = true;

    yield WaitForSeconds (flickerSpeed);
	
	light.enabled = true;
	
    yield WaitForSeconds (waiting);
    
     light.enabled = false;

}
counter++;
}