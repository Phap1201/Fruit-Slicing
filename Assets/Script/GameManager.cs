using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    protected Blade blade;
    public bool isPauseGame;
    public bool isEndGame;

    [SerializeField]

    private void Awake()
    {
        if(Instance == null)
            Instance = this;

    }
    void Start()
    {
        blade = FindObjectOfType<Blade>();
       
        
    }

    // Update is called once per frame
   
    public void Expod()
    {
        blade.enabled = false;
        SpawManager.instance.enabled = false;
    }    
    public void AddScore()
    {
        DataManager.instance.AddScores();
        int PlayerScore = DataManager.instance.GetScore();
        UiManager.Instance.UpdateScore(PlayerScore);

    }
    public void EndGame()
    {
       DataManager.instance.SetBestScore();
    }    
    public int GetScores()
    {

       int PlayerScore=DataManager.instance.GetScore();
       return PlayerScore;
    }
    public void PauseGame()
    {
        if (isPauseGame == false)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    void Pause()
    {
        isPauseGame = true;
        Time.timeScale = 0;
    }
    void Resume()
    {
        isPauseGame = false;
        Time.timeScale = 1;
    }

}
