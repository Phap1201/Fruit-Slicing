using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Button UiSetting;
    public GameObject UiPause;



    public void Awake()
    {
        UiSetting.onClick.AddListener(OnpenPause);
    }
    public void OnpenPause()
    {
        UiPause.SetActive(true);
        
          UiManager.Instance.Pause();
        
    }
}
