using UnityEngine;

public class Pause : State
{
    //public GameObject panel;
    
    private SceneSM _sm;
    
    public Pause(SceneSM stateMachine) : base("Pause", stateMachine)
    {
        _sm = (SceneSM)stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("Enter Pause");
        //panel.SetActive(true);
    }

    public override void Tick()
    {
        Debug.Log("Tick Pause");

        if (Input.GetKeyDown(KeyCode.Escape)) // Pour fermer le menu pause
        {
            Debug.Log("Changement Etat : Game");
            // GetComponent<SceneSM>().ChangeState(GetComponent<Game>());
            stateMachine.ChangeState(_sm.gameState);
        }

        if (Input.GetKeyDown(KeyCode.R)) // Pour Reload
        {
            Debug.Log("Ouverture Scene : LoadingGame");
            // GetComponent<SceneSM>().ChangeState(GetComponent<LoadingGame>());
            stateMachine.ChangeState(_sm.loadingState);
        }

        if (Input.GetKeyDown(KeyCode.M)) // Pour retour Menu
        {
            Debug.Log("Ouverture Scene : Initialize");
            // GetComponent<SceneSM>().ChangeState(GetComponent<Initialize>());
            stateMachine.ChangeState(_sm.initializeState);
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Pause");
        //panel.SetActive(false);
    }
}
