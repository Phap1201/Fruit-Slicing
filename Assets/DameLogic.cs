using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameLogic : MonoBehaviour
{
    [SerializeField]
    private int _lives = 3;

    public void Dame()
    {
        Debug.LogError("KiemTraLive");
        if (_lives > 0)
        {
            Debug.LogError("Live");
            _lives--;
        }
        UiManager.Instance.UpdateLive(_lives);
    }
   

}
