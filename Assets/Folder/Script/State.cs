using UnityEngine;

public class State : MonoBehaviour
{
    
    private string name;
    protected SceneSM stateMachine;

    public State(string name, SceneSM stateMachine)
    {
        this.name = name; 
        this.stateMachine = stateMachine;
    }
    public virtual void Enter()
    {

    }

    public virtual void Tick()
    {

    }

    public virtual void Exit()
    {

    }
}
