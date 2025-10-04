using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawner : MonoBehaviour
{
    public static Vector3 LoadPositionAfterSceneLoad = Vector3.zero;

    void Start()
    {
        if (LoadPositionAfterSceneLoad != Vector3.zero)
        {
            transform.position = LoadPositionAfterSceneLoad;
            LoadPositionAfterSceneLoad = Vector3.zero; // Reset so it doesn't affect new games
        }
    }
}
