using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public float horizontalSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float h = horizontalSpeed * Input.GetAxis("Mouse X");

        gameObject.transform.Rotate(0, h, 0);
    }
}
