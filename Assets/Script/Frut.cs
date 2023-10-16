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
            
            GameManager.Instance.AddScore();

            Instantiate(FruitSlicedPrefab,transform.position, Quaternion.identity);

            Destroy(gameObject);
            
        }
        if(other.gameObject.CompareTag("Dame"))
        {
            if (GameManager.Instance.isEndGame) return;
            Debug.LogError("KiemTraVacham");
            Destroy(this.gameObject);
            dameLogic.Dame();    
            GameManager.Instance.EndGame();
           
        }    

      
    }
    private void Slice(Vector3 direction , Vector3 position , float force)
    {
        
    }    
}
