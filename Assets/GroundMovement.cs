using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);
        if(transform.position.x < -5.8f)
        {
            transform.position =new Vector2(11.0f,transform.position.y);
        }
        
    }
}
