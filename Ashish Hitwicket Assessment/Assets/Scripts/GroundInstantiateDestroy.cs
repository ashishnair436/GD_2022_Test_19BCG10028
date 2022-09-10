using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInstantiateDestroy : MonoBehaviour
{

    [SerializeField]
    private GameObject groundPlane;

    public Vector3[] positionArray = new[] { new Vector3(9f, -1f, 0f), new Vector3(-9f, -1f, 0f), new Vector3(0f, -1f, 9f), new Vector3(0f, -1f, -9f) };

    //public Transform positionofplane;
    void Start()
    {
        Vector3 spawnpoint = GetSpawnPoint();
        Instantiate(groundPlane, spawnpoint, Quaternion.identity);
    }

    void Update()
    {

        
    }

    IEnumerator SpawnTime()
    {
        yield return new WaitForSeconds(4f);
    }

    public Vector3 GetSpawnPoint()
    {
        return positionArray[Random.Range(0, positionArray.Length)];
    }
}
