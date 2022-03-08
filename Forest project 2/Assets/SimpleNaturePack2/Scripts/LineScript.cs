using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

 
public class LineScript : MonoBehaviour{
 
public LineRenderer line;
public Transform pos1;
public Transform pos2;
public Transform pos3;
public TextMeshProUGUI timer_Text;
public float timer;
 
// ***************************************************************************************/
// *	Title: How to Make a Line from One Point to Another in Unity
// *	Author: Greyseth
// *	Date: 2021
// *	Code version: NA
// *	Availability: https://youtu.be/SY2npMqaOpc
// *
// ***************************************************************************************/
   // Start is called before the first frame update
   void Start()
   {
 
        line=GetComponent<LineRenderer>();
       
        line.positionCount=2;
   }
 
   // Update is called once per frame
   void Update()
   {
       line.SetPosition(0, pos1.position);
       line.SetPosition(1, pos2.position);
 
    timer-=Time.deltaTime;
    if(timer<=0){
        line.SetPosition(0, pos1.position);
        line.SetPosition(1, pos3.position);
        timer_Text.fontSize=12f;
        timer_Text.SetText("Game over. Follow the new path to the main menu");
        
    }
  }
}
