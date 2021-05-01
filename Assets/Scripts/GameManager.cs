using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject levelcompleteui, levelfailedui; //<-
    // public GameManager gameManager;

    public void LevelComplete ()
    {
        levelcompleteui.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            levelfailedui.SetActive(true); //<-
           Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // public void CoinPick()
    // {

    // }
}
