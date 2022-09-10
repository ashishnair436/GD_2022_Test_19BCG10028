using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInstantiateDestroy : MonoBehaviour
{
    /*
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

    public Vector3 GetSpawnPoint()
    {
        return positionArray[Random.Range(0, positionArray.Length)];
    }
    */

    public static GroundInstantiateDestroy instance;

    [SerializeField]
    private GameObject groundPlane;

    [SerializeField]
    private float x = 4f;

    
    GroundBehaviors currentgroundplane;

    private void Awake()
    {

        instance = this;
    }

    private void Start()
    {
        x = JsonReaderReal.instance.myrootjsonobjects.pulpit_data.pulpit_spawn_time - 1;
        GameObject firstGround = Instantiate(groundPlane, new Vector3(0, 0, 0), Quaternion.identity);
        currentgroundplane = firstGround.GetComponent<GroundBehaviors>();

    }

    private void Update()
    {
        if(currentgroundplane.timer <= x)
        {
            GameObject newGroundPlane;
            Vector3 newGroundPosition = new Vector3();

            int position = Random.Range(0, 3);

            switch (position)
            {
                case 0:
                    newGroundPosition = new Vector3(currentgroundplane.transform.position.x + 9f, currentgroundplane.transform.position.y, currentgroundplane.transform.position.z);
                    break;

                case 1:
                    newGroundPosition = new Vector3(currentgroundplane.transform.position.x - 9f, currentgroundplane.transform.position.y, currentgroundplane.transform.position.z);
                    break;

                case 2:
                    newGroundPosition = new Vector3(currentgroundplane.transform.position.x , currentgroundplane.transform.position.y, currentgroundplane.transform.position.z + 9f);
                    break;

                case 3:
                    newGroundPosition = new Vector3(currentgroundplane.transform.position.x, currentgroundplane.transform.position.y, currentgroundplane.transform.position.z - 9f);
                    break;
            }


            newGroundPlane = Instantiate(groundPlane, newGroundPosition, Quaternion.identity);
            currentgroundplane = newGroundPlane.GetComponent<GroundBehaviors>();
        }
    }

}
