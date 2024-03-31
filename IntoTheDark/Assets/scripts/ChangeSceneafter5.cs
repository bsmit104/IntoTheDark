using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneafter5 : MonoBehaviour
{
    void Start()
    {
        // Start a coroutine to change scene after 5 seconds
        StartCoroutine(ChangeSceneAfterDelay(7f));
    }

    IEnumerator ChangeSceneAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Change scene
        SceneManager.LoadScene("level");
    }
}