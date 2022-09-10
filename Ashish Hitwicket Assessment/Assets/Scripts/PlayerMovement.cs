using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int speedofplayer ;

    private Camera cam;

    public Transform playertransform;
    public Vector3 offset;

    void Start()
    {
        cam = Camera.main;
        speedofplayer = JsonReaderReal.instance.myPlayerdata.speed;
    }

    void Update()
    {
        speedofplayer = JsonReaderReal.instance.myPlayerdata.speed;
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
}
