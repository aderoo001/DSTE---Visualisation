using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        gameObject.transform.position = new Vector3 (transform.position.x + (speed*h), transform.position.y,
            transform.position.z + (speed*v));
        gameObject.transform.eulerAngles = new Vector3 (0, gameObject.transform.eulerAngles.y, 0);
    }
}
