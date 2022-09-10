using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehaviors : MonoBehaviour
{

    //JsonReaderReal jsonmanager;

    public float timermin = 5f;
    public float timermax = 7f;
    public float timer = 5f;
    //public bool scored = false;


    void Start()
    {
        //GameObject jsonmanagerObject = GameObject.Find("JsonReaderlol");
        //jsonmanager = jsonmanagerObject.GetComponent<JsonReaderReal>();
        timermin = JsonReaderReal.instance.myrootjsonobjects.pulpit_data.min_pulpit_destroy_time;
        timermax = JsonReaderReal.instance.myrootjsonobjects.pulpit_data.max_pulpit_destroy_time;

        timer = Random.Range(timermin, timermax);

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
