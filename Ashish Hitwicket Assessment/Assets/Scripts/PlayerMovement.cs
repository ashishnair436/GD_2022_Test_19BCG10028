using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 8.0f;

    void Start()
    {
        
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

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
