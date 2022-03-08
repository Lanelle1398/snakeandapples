using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
 
public class CountdownTimer : MonoBehaviour
{
 
   public string levelToLoad;
   public float timer=120f;
   //private Text timerSeconds;
   public TextMeshProUGUI timer_Text;
  public GameObject apple;
 
   // Start is called before the first frame update
   void Start()
   {
       //timerSeconds=GetComponent<Text>();
 
   }
 
   // Update is called once per frame
   void Update()
   {
     if(timer>=0){ //only keep the timer when the game hasn’t ended or gotten to 0
       timer-=Time.deltaTime;
       timer_Text.SetText("Timer:"+ timer);   
     }	
     else{
      DestroyGameObject(); //if the game has ended we don't want the user to be able to get an apple
 
     }
     //if(timer<=0){
           //SceneManager.LoadScene(levelToLoad);
       //}   
   }


   void DestroyGameObject()
    {
        Destroy(apple);
    }


}
