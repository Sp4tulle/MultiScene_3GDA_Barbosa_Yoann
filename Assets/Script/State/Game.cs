using UnityEngine;

public class Game : State
{
    private SceneSM _sm;
    
    public Game(SceneSM stateMachine) : base("Game", stateMachine)
    {
        _sm = (SceneSM)stateMachine;
    }
    public override void Enter()
    {
        Debug.Log("Enter Game");
    }

    public override void Tick()
    {
        Debug.Log("Tick Game");
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Changement Etat : Pause");
            // GetComponent<SceneSM>().ChangeState(GetComponent<Pause>());
            stateMachine.ChangeState(_sm.pauseState);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Changement Etat : GameOver");
            // GetComponent<SceneSM>().ChangeState(GetComponent<GameOver>());
            stateMachine.ChangeState(_sm.gameOverState);
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Game");
    }
}
