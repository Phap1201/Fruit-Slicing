using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frut : MonoBehaviour
{
    public GameObject FruitSlicedPrefab;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Blade"))
        {
            Instantiate(FruitSlicedPrefab,transform.position, Quaternion.identity);
            Debug.LogError("KiemTraVacham");
            Destroy(gameObject);
        }
    }
}
