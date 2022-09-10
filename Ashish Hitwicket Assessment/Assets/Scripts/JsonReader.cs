using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class JsonReader : MonoBehaviour
{

    public TextAsset textJson;

    [System.Serializable]
    public class Player
    {
        public string name;
        public int health;
        public int mana;

    }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] player;
    }

    public PlayerList myPlayerList = new PlayerList();

    private void Start()
    {

        myPlayerList = JsonUtility.FromJson<PlayerList>(textJson.text);
    }
}
