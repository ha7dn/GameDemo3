using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    bool CanSpawn = true;
    float minSpawnTime = 1.5f;
    float maxSpawnTime = 6f;
    [SerializeField] Attacker attacker;



    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (CanSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Debug.Log("new enemy!");
        Instantiate(attacker, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
