using UnityEngine;

public class GameOver : State
{
    private SceneSM _sm;
    
    public GameOver(SceneSM stateMachine) : base("GameOver", stateMachine)
    {
        _sm = (SceneSM)stateMachine;
    }
    public override void Enter()
    {
        Debug.Log("Enter GameOver");
    }

    public override void Tick()
    {
        Debug.Log("Tick GameOver");

        if (Input.GetKeyDown(KeyCode.R)) // Pour Reload
        {
            Debug.Log("Ouverture Scene : LoadingGame");
            // GetComponent<SceneSM>().ChangeState(GetComponent<LoadingGame>());
            stateMachine.ChangeState(_sm.loadingState);
        }

        if (Input.GetKeyDown(KeyCode.M)) // Pour retour Menu
        {
            Debug.Log("Ouverture Scene : Initialize");
            // GetComponent<SceneSM>().ChangeState(GetComponent<Initialize>());
            stateMachine.ChangeState(_sm.initializeState);
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit GameOver");
    }
}
