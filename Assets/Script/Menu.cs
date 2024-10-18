using UnityEngine;

public class Menu : State
{
    public override void Enter()
    {
        Debug.Log("Enter Menu");
    }

    public override void Tick()
    {
        Debug.Log("Tick Menu");
        
        // Transition
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Ouverture Scene : LoadingGame");
            GetComponent<GameStateMachine>().ChangeState(GetComponent<LoadingGame>());
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Menu");
    }
}