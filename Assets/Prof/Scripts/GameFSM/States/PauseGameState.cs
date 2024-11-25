using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameState : GameState
{
    public GameObject pauseMenuPanel;
    
    public override void Enter()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible   = true;
    }
    
    //todo Return to game
    //todo Return to menu

    public void Resume()
    {
        fsm.ChangeState(GetComponent<PlayingGameState>());
    }

    public void ToMenu()
    {
        SceneManager.UnloadScene(SceneManager.GetActiveScene());
        fsm.ChangeState(GetComponent<MainMenuGameState>());
    }
    
    public override void Exit()
    {
        pauseMenuPanel.SetActive(false);
        //Mettre le jeu en pause = responsabilité de PauseState.
        Time.timeScale = 1f; 
    }
}