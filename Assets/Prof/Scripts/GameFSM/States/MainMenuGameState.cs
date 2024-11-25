using UnityEngine;

public class MainMenuGameState : GameState
{
    public GameObject menuGO;
    
    public override void Enter()
    {
        menuGO.SetActive(true);
    }
    
    //Used by button - single responsibility
    public void TransitionToGame()  
    {
        fsm.ChangeState(GetComponent<LoadingLevelGameState>());
    }

    public override void Exit()
    {
        menuGO.SetActive(false);
    }
}