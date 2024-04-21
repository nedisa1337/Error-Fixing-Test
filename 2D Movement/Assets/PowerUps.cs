using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] powerups;
    void Start()
    {
        StartCoroutine(SpawnPowerup());
    }

    IEnumerator SpawnPowerup()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            int randomIndex = Random.Range(0, powerups.Length-1);
            Instantiate(powerups[randomIndex], new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
        }
    }
}
