using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
  public static DataManager instance;
  public int CurrentScore = 0 ;



    private void Awake()
    {
        instance = this;
        if (!PlayerPrefs.HasKey("FirstPlay")) 
        {
            CurrentScore = 0 ;
            PlayerPrefs.SetInt("BestScore", 0);
            PlayerPrefs.SetInt("FirstPlay",0);
        }
    }
    public void AddScores()
    {
        CurrentScore++;

    }    
    public int GetScore()
    {
        return CurrentScore;
    }    
    public void SetBestScore()
    {
        int LastBestScore = PlayerPrefs.GetInt("BestScore");
        if (CurrentScore > LastBestScore)
        {
            PlayerPrefs.SetInt("BestScore", CurrentScore);
        }
            
        
    }    
}
