using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Blade"))
        {
            Debug.LogError("Bomb");
            gameManager.Expod();
        }
    }
}
