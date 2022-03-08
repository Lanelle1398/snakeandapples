using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
 
 
//code has been significantly modified, but used these sources for assistance
//***************************************************************************************/
// *	Title: Unity Game Dev Full Tutorial - 3D Snake Game
// *	Author: Smith, J
// *	Date: 2018
// *	Code version: NA
// *	Availability: https://www.youtube.com/watch?v=8ztq9fQT6Kc
// *
//***************************************************************************************/
 
// ***************************************************************************************/
// *	Title: How to make snake in Unity
// *	Author: Zigurous
// *	Date: 2021
// *	Code version: NA
// *	Availability: https://youtu.be/U8gUnpeaMbQ
// *
// ***************************************************************************************/
 
public class food : MonoBehaviour
{
   float min_x=(float)-9f, max_x=(float)18f, min_z=(float)0.05f, max_z=(float)-20f;
   float y_pos=(float)0.60f;
   public TextMeshProUGUI score_Text;
   public AudioSource source;
  // public gameObject apple;
   public int scoreCount;
   void Start()
   {
       RandomizePosition();
       source = GetComponent<AudioSource>();
   }
 
   void RandomizePosition(){
        this.transform.position=new Vector3(Random.Range(min_x, max_x), y_pos,Random.Range(min_z, max_z));
   }
   // Update is called once per frame
  void OnTriggerEnter(Collider other){
     Debug.Log(gameObject.tag + " entered Trigger tagged " + other.gameObject.tag);
      if(other.tag=="Player"){
          RandomizePosition();
          scoreCount++;
           score_Text.SetText("Score:"+ scoreCount);
           source.Play();
              
      }
  }
 
}
