using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller2 : MonoBehaviour
{
    // Start is called before the first frame update
   // Start is called before the first frame update

   
    public void StartGame()
    {
        SceneManager.LoadScene("correctdemo");
        
    }

    public void Quit(){
        Application.Quit();
    }

}
