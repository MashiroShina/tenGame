using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1f;

    public GameObject[] hexagonPrefab;

    private float nextTimeToSpawn=0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Time.time >= nextTimeToSpawn)
	    {
            Instantiate(hexagonPrefab[Random.Range(0, 1)], Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
	    }
    }
}
