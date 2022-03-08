using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//This code has been referenced from unity answers and and cited accordingly
// ***************************************************************************************/
// *	Title: How to measure the overall distance traveled
// *	Author: Helium
// *	Date: 2018
// *	Code version: N/A
// *	Availability:https://answers.unity.com/questions/1494589/how-to-measure-the-overall-distance-travelled.html
// *
// ***************************************************************************************/


public class DistanceMoved : MonoBehaviour
{

private Vector3 lastPosition ;
 private float totalDistance ;
 public TextMeshProUGUI distance_Text;
 public float timer;
 
 private void Start()
 {
     lastPosition = transform.position ;
 }
 
 private void Update()
 {


     timer-=Time.deltaTime;
    if(timer>0){
            float distance = Vector3.Distance(lastPosition, transform.position ) ;
            totalDistance += distance ;
            lastPosition = transform.position ;
            distance_Text.SetText("Distance:"+ totalDistance);
     }
    
 }
}
