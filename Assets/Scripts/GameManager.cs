using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

      bool GameHasEnded = false;

      public float restartDelay = 1f;

    public GameObject completeLevelUI;

      public void CompleteLevel()
      {
        completeLevelUI.SetActive(true);
      }


      public void EndGame()
      {

        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
        
      }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
