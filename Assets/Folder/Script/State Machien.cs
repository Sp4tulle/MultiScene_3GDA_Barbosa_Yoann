using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State currentState;

    void Start()
    {
        // Lorsqu'on va charger une scene, on veut garder notre GameStateMachine
        DontDestroyOnLoad(gameObject);

        // currentState = GetComponent<Initialize>();
        // currentState.Enter();

        currentState = GetInitialState();
        if (currentState != null)
        {
            currentState.Enter();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (currentState != null)
        {
            currentState.Tick();
        }
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    protected virtual State GetInitialState()
    {
        return null;
    }
}