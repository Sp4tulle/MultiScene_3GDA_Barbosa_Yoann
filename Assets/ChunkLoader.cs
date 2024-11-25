using Eflatun.SceneReference;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChunkLoader : MonoBehaviour
{
    public Color gizmoColor = Color.white;
    public SceneReference chuckToLoad;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(chuckToLoad.BuildIndex, LoadSceneMode.Additive);
    }

    private void OnTriggerExit(Collider other)
    {
        SceneManager.UnloadSceneAsync(chuckToLoad.BuildIndex);
    }

    private void OnDrawGizmos()
    {
        Collider collider = GetComponent<Collider>(); 
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireCube(collider.bounds.center, collider.bounds.size); 
    }
}