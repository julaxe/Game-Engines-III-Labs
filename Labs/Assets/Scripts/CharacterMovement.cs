using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float Fspeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * Fspeed; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * Fspeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * Fspeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * Fspeed;
        }
    }
}
