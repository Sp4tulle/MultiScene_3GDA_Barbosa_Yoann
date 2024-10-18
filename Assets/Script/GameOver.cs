using UnityEngine;

public class GameOver : State
{
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
            GetComponent<GameStateMachine>().ChangeState(GetComponent<LoadingGame>());
        }

        if (Input.GetKeyDown(KeyCode.M)) // Pour retour Menu
        {
            Debug.Log("Ouverture Scene : Initialize");
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Initialize>());
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit GameOver");
    }
}
