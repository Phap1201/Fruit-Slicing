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


    public void Awake()
    {
        if (Instance == null)
            Instance = this;
            
    }
    public void Start()
    {
        Score.text = " " + 0; 
    }
    public void UpdateScore(int score)
    {
        Score.text = score.ToString();
    }
    public void UpdateLive(int CurrentLive)
    {
        _LivesImg.sprite = _LiveSprite[CurrentLive];
    }
}
