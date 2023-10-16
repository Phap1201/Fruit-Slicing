using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private CameraShake cameraShake;
    GameManager gameManager;
    Rigidbody rb;
    public void Start()
    {
        cameraShake = FindObjectOfType<CameraShake>();
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Blade"))
        {
            StartCoroutine(cameraShake.Shake(.15f, .4f));
            Debug.LogError("Bomb");
            rb.isKinematic = true;
            gameManager.Expod();
             GameManager.Instance.EndGame();
             UiManager.Instance.LoseGame();
            GameManager.Instance.isEndGame = true;

           
            
        }
    }
}
