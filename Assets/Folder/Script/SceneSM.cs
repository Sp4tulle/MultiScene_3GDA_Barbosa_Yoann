using UnityEngine;

public class SceneSM : StateMachine
{
    #region firstSM

    // private State currentState;
    // void Start()
    // {
    //     // Lorsqu'on va charger une scene, on veut garder notre GameStateMachine
    //     DontDestroyOnLoad(gameObject);
    //
    //     currentState = GetComponent<Initialize>();
    //     currentState.Enter();
    // }
    // // Update is called once per frame
    // void Update()
    // {
    //     currentState.Tick();
    // }
    //
    // public void ChangeState(State newState)
    // {
    //     currentState.Exit();
    //     currentState = newState;
    //     currentState.Enter();
    // }

    #endregion firstSM

    [HideInInspector] public Menu menuState;
    [HideInInspector] public LoadingGame loadingState;
    [HideInInspector] public Game gameState;
    [HideInInspector] public Pause pauseState;
    [HideInInspector] public GameOver gameOverState;
    [HideInInspector] public Initialize initializeState;

    private void Awake()
    {
        menuState = new Menu(this);
        loadingState = new LoadingGame(this);
        gameState = new Game(this);
        pauseState = new Pause(this);
        gameOverState = new GameOver(this);
        initializeState = new Initialize(this);

    }

    protected override State GetInitialState()
    {
        return initializeState;
    }
}