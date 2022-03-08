using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{

    public void startButton(){
        SceneManager.LoadScene("SimpleNaturePack_Demo2");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
