using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initialize : State
{
    public SceneReference menuSceneRef;
    private AsyncOperation async;
    
    private SceneSM _sm;
    
    public Initialize(SceneSM stateMachine) : base("Initialize", stateMachine)
    {
        _sm = (SceneSM)stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("Enter Initialize");

        // Transition

        //SceneManager.LoadScene(1); // Premiere facon de charger une Scene

        //SceneManager.LoadScene(1, LoadSceneMode.Additive); // Charge la scene suivant et l'ajoute au Scene active

        Debug.Log("Chargement Scene : " + menuSceneRef);
        async = SceneManager.LoadSceneAsync(menuSceneRef.BuildIndex); // Permet de charger une Scene de maniere Asyncroniser
        
    }

    public override void Tick()
    {
        //Debug.Log(async.progress);

        // Transition
        if (async.progress >= 1f) 
        {
            Debug.Log("Ouverture Scene : " + menuSceneRef);
            // GetComponent<SceneSM>().ChangeState(GetComponent<Menu>());
            stateMachine.ChangeState(_sm.menuState);
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Initialize");
    }
}
