using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverGameState : GameState
{
    public GameObject gameOverMenuPanel;
    
    public override void Enter()
    {
        gameOverMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible   = true;
    }
    
    public void ToMenu()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        fsm.ChangeState(GetComponent<MainMenuGameState>());
    }

    public override void Exit()
    {
        gameOverMenuPanel.SetActive(false);
    }
}