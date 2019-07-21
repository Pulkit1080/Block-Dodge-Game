using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Debug.ClearDeveloperConsole();  
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        //before 1 sec
        yield return new WaitForSeconds(1f/ slowness);
        //after 1 sec

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
