using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    private Transform playerTsfm;

    private void Start()
    {
        GameObject GetPlayer = GameObject.FindGameObjectWithTag("Player");
        playerTsfm = GetPlayer.transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject gm = GameManagerFSM.Instance.gameObject;
            GameManagerFSM.Instance.ChangeState(gm.GetComponent<GameOverGameState>()); 
            Destroy(gameObject);
        }
    }
}
