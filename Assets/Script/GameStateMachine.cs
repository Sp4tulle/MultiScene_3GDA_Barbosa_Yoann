using UnityEngine;

public class GameStateMachine : State
{
    private State currentState;

    void Start()
    {
        // Lorsqu'on va charger une scene, on veut garder notre GameStateMachine
        DontDestroyOnLoad(gameObject);

        currentState = GetComponent<Initialize>();
        currentState.Enter();
    }
    // Update is called once per frame
    void Update()
    {
        currentState.Tick();
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
