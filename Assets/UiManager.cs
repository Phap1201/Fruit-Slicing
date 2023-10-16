using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    public static UiManager Instance;

    public TextMeshProUGUI Score;

    public Image _LivesImg;

    public Sprite[] _LiveSprite;

    public UiLose LoseGamePanel;

    public TextMeshProUGUI BestScore;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
            
    }
    public void Start()
    {
        Score.text = " " + 0;
        BestScores();
    }
   
    public void UpdateScore(int score)
    {
        Score.text = score.ToString();
    }
    public void UpdateLive(int CurrentLive)
    {
        _LivesImg.sprite = _LiveSprite[CurrentLive];
    }
    public void LoseGame()
    {
        StartCoroutine(WaiforLose());
    }
    IEnumerator WaiforLose()
    {
        yield return new WaitForSeconds(0.2f);
        LoseGamePanel.Show();
        int PlayerScore=GameManager.Instance.GetScores();
        LoseGamePanel.SetPlayerScore(PlayerScore);
        LoseGamePanel.SetPlayerBestScore(playerPrefs());
    }
    public void BestScores()
    {
       
        BestScore.text = playerPrefs().ToString();
    }
    public int playerPrefs()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore");
        return bestScore;
    }    
    public void Pause()
    {
        GameManager.Instance.PauseGame();
    }
}
