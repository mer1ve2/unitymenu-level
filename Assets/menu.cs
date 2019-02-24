using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject level;
    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }
   // public GameObject level1,level2,level3;

   /*  public void sahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    } 

    public void button1()
    {
       SceneManager.LoadScene("Level1");
       Debug.Log("level 1 ");
    }
    public void button2()
    {
       SceneManager.LoadScene("Level2");
        Debug.Log("level 2)");
    }
    public void button3()
    {
       SceneManager.LoadScene("Level3");
        Debug.Log("level 3");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }*/
}
