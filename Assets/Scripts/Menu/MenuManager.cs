using UnityEngine.SceneManagement;  
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public void PlayNew()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
