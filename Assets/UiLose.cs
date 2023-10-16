using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiLose : MonoBehaviour
{
    public TextMeshProUGUI PlayerSocreText;
    public TextMeshProUGUI BestScoreText;

    public List<GameObject> btn = new List<GameObject>();

    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void SetPlayerScore(int score)
    {
        StartCoroutine(CountingScore(score, 2f));
    }
    IEnumerator CountingScore(int target, float duration)
    {
        PlayerSocreText.text = 0.ToString();
        yield return new WaitForSeconds(1f);
        if (target != 0)
        {
            float YieldTime = duration / target;
            for (int i = 0; i <= target; i++)
            {
                PlayerSocreText.text = i.ToString();
                yield return new WaitForSeconds(YieldTime);
            }

        }
        for (int i = 0; i < btn.Count; i++)
        {
            btn[i].SetActive(true);
        }

    }
    public void SetPlayerBestScore(int bestScore)
    {
        BestScoreText.text = bestScore.ToString();
    }
    
}
