using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public static PlayerMovement instance;

    [SerializeField]
    private float speedofplayer = 4f ;

    private Camera cam;

    public Transform playertransform;
    public Vector3 offset;

    [SerializeField]
    JsonReaderReal jsonmanagertrying;

    public int score;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        cam = Camera.main;
        //speedofplayer = JsonReaderReal.instance.myrootjsonobjects.player_data.speed;
        speedofplayer = jsonmanagertrying.myrootjsonobjects.player_data.speed;
    }

    void Update()
    {
        //speedofplayer = JsonReaderReal.instance.myrootjsonobjects.player_data.speed;
        speedofplayer = jsonmanagertrying.myrootjsonobjects.player_data.speed;
        DoofusMovement();
    }

    void DoofusMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0 , verticalInput);

        transform.Translate(direction * speedofplayer * Time.deltaTime);
    }

    private void LateUpdate()
    {
        cam.transform.position = playertransform.position + offset;
        cam.transform.rotation = Quaternion.Euler(45,0,0);
    }

    public void AddScore(int points)
    {
        score = score + points;
        UIManager.instance.UpdateScore(score);

        UIManager.instance.CheckForBestScore(score);

    }
}
