using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonsBehavior : MonoBehaviour
{
    public void OnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void OnExitClick()
    {
        
    }
}
