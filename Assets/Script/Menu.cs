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
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Game>());
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Menu");
    }
}