#pragma strict

var timeLeft = 5;

 function Update()
 {
     timeLeft -= Time.deltaTime;
     if ( timeLeft < 0 )
     {
         Application.LoadLevel("cenario3");
     }
 }