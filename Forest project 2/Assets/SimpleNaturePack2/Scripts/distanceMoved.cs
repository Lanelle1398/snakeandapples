using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class distanceMoved : MonoBehaviour
{
private Vector3 lastPosition ;
private float totalDistance ;
public TextMeshProUGUI distance_Text;

public float timer=120f;
    // Start is called before the first frame update
    void Start()
    {
         lastPosition = transform.position ;
        
    }

    // Update is called once per frame
    void Update()
    {

    if(timer>=0){ //only calculate the distance when the game hasn’t ended or gotten to 0
    timer-=Time.deltaTime;
    float distance = Vector3.Distance( lastPosition, transform.position ) ;
    totalDistance += distance ;
    lastPosition = transform.position ;
    distance_Text.SetText("distance:"+ totalDistance); 
    }	
    
    }
}
