using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    //delat to amke the gameoversben apperar to 2 seconds
    [SerializeField] float delayInSeconds = 2f;

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Gameover");
    }

    public void LoadStartMenu()
    {
        //we have to gove the number of the scene
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        //load the scene of the game
        SceneManager.LoadScene("CarGame");
    }

    public void GameOver()
    {
        //load the scene if player loses
        StartCoroutine(WaitAndLoad());

    }

    public void Winnner()
    {
        //load the scene if player loses
        SceneManager.LoadScene("Winner");
    }

    public void QuitGame()
    {
        //the game will quit
        Application.Quit();
    }
}
