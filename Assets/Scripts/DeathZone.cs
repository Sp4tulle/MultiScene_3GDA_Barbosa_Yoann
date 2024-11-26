using UnityEngine;

public class DeathZone : GameState
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //GameManagerFSM.Instance.ChangeState(GetComponent<GameOverGameState>());
            fsm.ChangeState(GetComponent<MainMenuGameState>());
        }
    }
}