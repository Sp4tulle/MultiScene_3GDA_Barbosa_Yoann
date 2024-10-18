using UnityEngine;

public class Pause : State
{
    //public GameObject panel;

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
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Game>());
        }

        if (Input.GetKeyDown(KeyCode.R)) // Pour Reload
        {
            Debug.Log("Ouverture Scene : LoadingGame");
            GetComponent<GameStateMachine>().ChangeState(GetComponent<LoadingGame>());
        }

        if (Input.GetKeyDown(KeyCode.M)) // Pour retour Menu
        {
            Debug.Log("Ouverture Scene : Initialize");
            GetComponent<GameStateMachine>().ChangeState(GetComponent<Initialize>());
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit Pause");
        //panel.SetActive(false);
    }
}
