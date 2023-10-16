using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiPause : MonoBehaviour
{
    
    public Button Close;
    public Button RePlay;
    public GameObject PauseGame;
 
    private void Awake()
    {
        RePlay.onClick.AddListener(OnHidePause);
        Close.onClick.AddListener(OnHidePause);
    }
    public void OnHidePause()
    {
        PauseGame.SetActive(false);
        UiManager.Instance.Pause();
    }
   
}
