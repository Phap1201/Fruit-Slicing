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
        if(_lives ==0)
        {
            UiManager.Instance.LoseGame();
            GameManager.Instance.Expod();
        }
        UiManager.Instance.UpdateLive(_lives);

    }
   

}
