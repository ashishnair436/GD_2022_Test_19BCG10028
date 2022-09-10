using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int speedofplayer ;

    void Start()
    {
        speedofplayer = JsonReaderReal.instance.myPlayerdata.speed;
    }

    void Update()
    {
        DoofusMovement();
    }

    void DoofusMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0 , verticalInput);

        transform.Translate(direction * speedofplayer * Time.deltaTime);
    }
}
