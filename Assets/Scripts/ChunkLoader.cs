using System;
using Eflatun.SceneReference;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Serialization;

public class ChunkLoader : MonoBehaviour
{
    public Color gizmoColor = Color.white;
    [FormerlySerializedAs("chuckToLoad")] public SceneReference chunckToLoad;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(chunckToLoad.BuildIndex, LoadSceneMode.Additive);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.UnloadSceneAsync(chunckToLoad.BuildIndex);
        }
    }

    private void OnDrawGizmos()
    {
        Collider collider = GetComponent<Collider>(); 
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(collider.bounds.center, collider.bounds.size); 
    }
}