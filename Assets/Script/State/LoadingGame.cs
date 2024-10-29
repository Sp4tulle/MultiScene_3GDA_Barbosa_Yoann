using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingGame : State
{
    public SceneReference menuSceneRef;
    private AsyncOperation async;
    private bool isLoaded;
    
    private SceneSM _sm;
    
    public LoadingGame(SceneSM stateMachine) : base("LoadingGame", stateMachine)
    {
        _sm = (SceneSM)stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("Enter LoadingGame");
        Debug.Log("Chargement Scene : " + menuSceneRef);
        async = SceneManager.LoadSceneAsync(menuSceneRef.BuildIndex); // Permet de charger une Scene de maniere Asyncroniser
    }

    public override void Tick()
    {
        Debug.Log(async.progress);

        if (async.progress >= 1f)
        {
            Debug.Log("Ouverture Scene : " + menuSceneRef);
            // GetComponent<SceneSM>().ChangeState(GetComponent<Game>());
            stateMachine.ChangeState(_sm.gameState);
        }

    }

    public override void Exit()
    {
        Debug.Log("Exit LoadingGame");
    }
}