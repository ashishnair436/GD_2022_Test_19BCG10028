using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReaderReal : MonoBehaviour
{


    public TextAsset jsonTextasset;

    public static JsonReaderReal instance;

    private void Awake()
    {
        instance = this;
    }

    [System.Serializable]
    public class PlayerData
    {
        public int speed;
    }

    [System.Serializable]
    public class PulpitData
    {
        public int min_pulpit_destroy_time;
        public int max_pulpit_destroy_time;
        public float pulpit_spawn_time;
    }

    public PlayerData myPlayerdata = new PlayerData();
    public PulpitData mypulpitData = new PulpitData();

    void Start()
    {
        myPlayerdata = JsonUtility.FromJson<PlayerData>(jsonTextasset.text);
        mypulpitData = JsonUtility.FromJson<PulpitData>(jsonTextasset.text);


    }

}
