using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReaderReal : MonoBehaviour
{
    // Start is called before the first frame update

    public TextAsset jsonTextasset;

    public static JsonReaderReal instance;

    private void Awake()
    {
        instance = this;
    }

    public class player_data
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

    public player_data myPlayerdata = new player_data();
    public PulpitData mypulpitData = new PulpitData();

    void Start()
    {
        myPlayerdata = JsonUtility.FromJson<player_data>(jsonTextasset.text);
        mypulpitData = JsonUtility.FromJson<PulpitData>(jsonTextasset.text);


    }

}
