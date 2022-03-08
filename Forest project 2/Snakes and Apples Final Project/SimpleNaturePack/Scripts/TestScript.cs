using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour{
public float timer=60f; 
 public LineRenderer line;
public Transform pos1;
public Transform pos2;
public Transform pos3;



// ***************************************************************************************/
// */	Title: How to Make a Line from One Point to Another in Unity
// *	Author: Greyseth
// *	Date: 2021
// *	Code version: N/A
// *	Availability:https://youtu.be/SY2npMqaOpc
// *
// ***************************************************************************************/
// */
    // Start is called before the first frame update
    void Start()
    {

         line=GetComponent<LineRenderer>();
         
         line.positionCount=2;
    }

    // Update is called once per frame
    void Update()
    {

        timer-=Time.deltaTime;

        line.SetPosition(0, pos1.position);
        line.SetPosition(1, pos2.position);

        if(timer<=0){

           //Destroy(line.gameObject, 5);
           line.SetPosition(0, pos1.position);
           line.SetPosition(1, pos3.position);
          //this.GetComponent<LineRenderer>().enabled = false;
     
        }
    }

    
}
