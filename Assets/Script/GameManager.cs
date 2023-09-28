using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score;
    protected Blade blade;
  

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
    void Update()
    {
        
    }
    public void Expod()
    {
        blade.enabled = false;
        SpawManager.instance.enabled = false;
    }    
    public void AddScore(int Point)
    {
        Score += Point;
        UiManager.Instance.UpdateScore(Score);

    }

}
