using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject gm = GameManagerFSM.Instance.gameObject;
            GameManagerFSM.Instance.ChangeState(gm.GetComponent<GameOverGameState>());
        }
    }
}