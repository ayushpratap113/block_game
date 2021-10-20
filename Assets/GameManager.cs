using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool IsGameEnded = false;
    public float RestartDelay = 1f;
    public GameObject levelCompleatedUI;

    public void LevelCompleated()
    {
        levelCompleatedUI.SetActive(true);
        Debug.Log("You Won &&HUEHUE@@");

    }
    public void EndGame(){

        if(IsGameEnded == false)
        {
            IsGameEnded = true;
            Debug.Log("GAME OVER!! , Now Fuck Off");
            Invoke("Restart", RestartDelay);       
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
