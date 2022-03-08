using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CountdownTimer : MonoBehaviour
{

    public float timer=60f; 
    public GameObject objToDestroy;
 
    public TextMeshProUGUI timer_Text;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
           timer-=Time.deltaTime;
            timer_Text.SetText("Timer:"+ timer);
        
       if(timer<0){
           Destroy(objToDestroy);
            timer_Text.SetText("Game Over. Walk to the menu options and pick an option");
        }
        
    }
}
