using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frut : MonoBehaviour
{
    public GameObject FruitSlicedPrefab;
    public DameLogic dameLogic;



    public void Start()
    {
        dameLogic = FindObjectOfType<DameLogic>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Blade"))
        {
            GameManager.Instance.AddScore(1);
            Instantiate(FruitSlicedPrefab,transform.position, Quaternion.identity);
           
            Destroy(gameObject);
        }
        if(other.gameObject.CompareTag("Dame"))
        {
            Debug.LogError("KiemTraVacham");
            Destroy(this.gameObject);
            dameLogic.Dame();
            GameManager.Instance.Expod();
        }    
    }
}
