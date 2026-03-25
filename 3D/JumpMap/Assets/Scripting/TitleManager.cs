using UnityEngine;

public class TitleManager : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject helpPanel; 
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlayScene_Door1");
    }
   public void HelpOpen()
    {
        helpPanel.SetActive(true);
    }

    public void HelpClose()
    {
        helpPanel.SetActive(false);
    }

    public void Title()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScene");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
