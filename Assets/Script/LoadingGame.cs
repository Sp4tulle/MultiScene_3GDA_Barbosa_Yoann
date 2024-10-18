using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingGame : State
{
    public SceneReference menuSceneRef;
    private AsyncOperation async;
    private bool isLoaded;

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
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Game>());
        }

    }

    public override void Exit()
    {
        Debug.Log("Exit LoadingGame");
    }
}