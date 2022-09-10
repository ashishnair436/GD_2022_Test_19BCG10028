using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReaderReal : MonoBehaviour
{

    public static JsonReaderReal instance;

    public TextAsset jsonTextasset;


    private void Awake()
    {
        instance = this;
    }

    [System.Serializable]
    public class PlayerData
    {
        public float speed;
    }

    [System.Serializable]
    public class PulpitData
    {
        public float min_pulpit_destroy_time;
        public float max_pulpit_destroy_time;
        public float pulpit_spawn_time;
    }

    [System.Serializable]
    public class JsonFileFull
    {
        public PlayerData player_data;
        public PulpitData pulpit_data;
    }


    //public PlayerData myPlayerdata = new PlayerData();
    //public PulpitData mypulpitData = new PulpitData();

    public JsonFileFull myrootjsonobjects;

    
    void Start()
    {
        /*
        myPlayerdata = JsonUtility.FromJson<PlayerData>(jsonTextasset.text);
        mypulpitData = JsonUtility.FromJson<PulpitData>(jsonTextasset.text);
        */

        myrootjsonobjects = JsonUtility.FromJson<JsonFileFull>(jsonTextasset.text); 

    }

}
