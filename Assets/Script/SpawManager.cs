using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public static SpawManager instance;
    private Collider spawnArea;

    public GameObject[] FruitPrefab;

    public GameObject BombPrefab;

    [Range(0f, 1f)]
    public float BombChance = 0.05f;

    public float minSpawnDelay = .25f;
    public float maxSpawnDelay = 1.0f;

    
    public float minAngle = -10f;
    public float maxAngle = 10f;

    public float minForce = 7f;
    public float maxForce = 10f;

    public float maxLifetime = 5f;
    private void Awake()
    {
        if(instance == null)
            instance = this;
        spawnArea = GetComponent<Collider>();
    }
    private void OnEnable()
    {
        StartCoroutine(spawn());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    private IEnumerator spawn()
    {
        yield return new WaitForSeconds(2f);

        while (enabled)
        {
            GameObject prefab = FruitPrefab[ Random.Range(0, FruitPrefab.Length) ];

            if(Random.value < BombChance )
            {
                prefab = BombPrefab;
            }    
            Vector3 position = new Vector3();
            position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
            position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
            position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

            Quaternion rotation = Quaternion.Euler(0f,0f,Random.Range(minAngle,maxAngle));

            GameObject fruit = Instantiate(prefab, position, rotation);
            Destroy(fruit,maxLifetime);

            float force = Random.Range(minForce,maxForce);
            fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);
            yield return new WaitForSeconds (Random.Range (minSpawnDelay, maxSpawnDelay));
        }
    }


}
