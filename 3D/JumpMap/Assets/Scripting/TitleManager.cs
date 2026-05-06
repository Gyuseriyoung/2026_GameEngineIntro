using TMPro;
using UnityEngine;

public class TitleManager : MonoBehaviour
{

    public TextMeshProUGUI stage1;
    public TextMeshProUGUI stage2;
    public TextMeshProUGUI stage3;

    
    void Start()
    {
        stage1.text = "Stage 1 : " + HighScore.Load(1).ToString();
        stage2.text = "Stage 2 : " + HighScore.Load(2).ToString();
        stage3.text = "Stage 3 : " + HighScore.Load(3).ToString(); 
    }

    public GameObject helpPanel;
    public GameObject HighScorePanel;
    public GameObject RankPanel;
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

    public void HighScoreOpen()
    {
        HighScorePanel.SetActive(true);
    }

    public void HighScoreClose()
    {
        HighScorePanel.SetActive(false);
    }

    public void RankOpen()
    {
        RankPanel.SetActive(true);
    }
    
    public void RankClose()
    {
        RankPanel.SetActive(false);
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
