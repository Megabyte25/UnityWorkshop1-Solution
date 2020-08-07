using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    public GameObject shieldPrefab;
    private int shieldsRemaining;
    void Start()
    {
        GameObject settingsObj = GameObject.FindWithTag("GameSettings");
        if (settingsObj)
        {
            GameSettings settings = settingsObj.GetComponent<GameSettings>();
            shieldsRemaining = settings.ShieldsAvailable;
        }
    }

    public void SpawnShield()
    {
        if (shieldsRemaining > 0)
        {
            shieldsRemaining -= 1;
            Instantiate(shieldPrefab, transform.position, transform.rotation);
        }
    }
}
