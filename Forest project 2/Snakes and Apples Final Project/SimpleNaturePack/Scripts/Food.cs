using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//I used the sources below to help me with my game. My code has been moderately modified
// ***************************************************************************************/
// *	Title: How to make a snake in Unity
// *	Author: Zigurous
// *	Date: 2021
// *	Code version: N/A
// *	Availability:https://youtu.be/U8gUnpeaMbQ
// *
// ***************************************************************************************/


// ***************************************************************************************/
// *	Title: Unity Game Dev Full Tutorial - 3D Snake Game
// *	Author: freeCodeCamp
// *	Date: 2018
// *	Code version: N/A
// *	Availability:https://youtu.be/8ztq9fQT6Kc
// *
// ***************************************************************************************/
public class Food : MonoBehaviour
{

 
    public AudioSource tickSource;

    float min_x=(float)-35f, max_x=(float)22f, min_z=(float)-16f, max_z=(float)23f;
    float y_pos=(float)0.85f;
    public TextMeshProUGUI score_Text;
   public TextMeshProUGUI apples_Text;
    public int scoreCount;
    //public int applespicked;
    void Start()
    {
        RandomizePosition();
        tickSource=GetComponent<AudioSource>();
    }

    public void GameOver(){
        GameOverScript.Setup(scoreCount);
    }

    void RandomizePosition(){
         this.transform.position=new Vector3(Random.Range(min_x, max_x), y_pos,Random.Range(min_z, max_z)); 
    }
    // Update is called once per frame
   void OnTriggerEnter(Collider other){
      Debug.Log(gameObject.tag + " entered Trigger tagged " + other.gameObject.tag);
       if(other.tag=="Player"){
           RandomizePosition();
           tickSource.Play();
           scoreCount++;
           //applespicked++;
           score_Text.SetText("Score:"+ scoreCount);
       }
   }
}
