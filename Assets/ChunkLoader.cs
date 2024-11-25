using Eflatun.SceneReference;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Serialization;

public class ChunkLoader : MonoBehaviour
{
    public Color gizmoColor = Color.white;
    [FormerlySerializedAs("chuckToLoad")] public SceneReference chunckToLoad;
    // public SceneReference chunkLoaded;
    // public GameObject chunkPrefab;

    private void OnTriggerEnter(Collider other)
    {
        // chunkPrefab = this.gameObject;
        // chunkLoaded = chunckToLoad;
        // Debug.Log(chunkLoaded.Name);
        SceneManager.LoadSceneAsync(chunckToLoad.BuildIndex, LoadSceneMode.Additive);
    }

    private void OnTriggerExit(Collider other)
    {
        // chunkPrefab = null;
        // chunkLoaded = null;
        SceneManager.UnloadSceneAsync(chunckToLoad.BuildIndex);
    }

    private void OnDrawGizmos()
    {
        Collider collider = GetComponent<Collider>(); 
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(collider.bounds.center, collider.bounds.size); 
    }
}