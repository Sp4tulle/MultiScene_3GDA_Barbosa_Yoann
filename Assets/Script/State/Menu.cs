using UnityEngine;

public class Menu : State
{
    private SceneSM _sm;

    public Menu(SceneSM stateMachine) : base("Menu", stateMachine)
    {
        _sm = (SceneSM)stateMachine;
    }
    public override void Enter()
    {
        Debug.Log("Enter Menu");
        base.Enter();
    }

    public override void Tick()
    {
        Debug.Log("Tick Menu");
        base.Tick();
        
        // Transition
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Ouverture Scene : LoadingGame");
            // GetComponent<SceneSM>().ChangeState(GetComponent<LoadingGame>());
            stateMachine.ChangeState(_sm.loadingState);
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Menu");
        base.Exit();
    }
}