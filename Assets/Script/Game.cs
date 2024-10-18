using UnityEngine;

public class Game : State
{
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
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Pause>());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Changement Etat : GameOver");
            GetComponent<GameStateMachine>().ChangeState(GetComponent<GameOver>());
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Game");
    }
}
