using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public float RestartDelay = 1f;
    public GameObject completeLevelUI;
    bool GameHasEnded = false;
        
    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        
    }
    
    public void EndGame() {
        if (!GameHasEnded) {
            GameHasEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", RestartDelay);
        }

        
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
