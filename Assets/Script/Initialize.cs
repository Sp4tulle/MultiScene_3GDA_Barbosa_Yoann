using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initialize : State
{
    public SceneReference menuSceneRef;
    private AsyncOperation async;

    public override void Enter()
    {
        Debug.Log("Enter Initialize");

        // Transition
        
        //SceneManager.LoadScene(1); // Premiere facon de charger une Scene
        
        //SceneManager.LoadScene(1, LoadSceneMode.Additive); // Charge la scene suivant et l'ajoute au Scene active
        
        async = SceneManager.LoadSceneAsync(menuSceneRef.BuildIndex); // Permet de charger une Scene de maniere Asyncroniser
        
    }

    public override void Tick()
    {
        Debug.Log(async.progress);

        // Transition
        if (async.progress >= 1f) 
        {
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Menu>());
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Initialize");
    }
}
