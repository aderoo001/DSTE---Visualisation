using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale_camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus)) {
            if (transform.position.y > 26 )
                gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y - 25, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.KeypadMinus)) {
            if (transform.position.y < 100 )
                gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y + 25, transform.position.z);
        }
    }
}
