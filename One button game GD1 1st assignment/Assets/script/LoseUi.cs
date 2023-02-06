using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUi : MonoBehaviour
{
    public GameObject gameoverscreen;
    public void Restartgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
   public void gameOver()
    {

    }
  public void Gameover()
    {
        Application.Quit();
    }
}
