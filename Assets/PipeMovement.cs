using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int score;
    BirdMovement birdMovement;

    void Start()
    {
        birdMovement = GameObject.Find("Player").GetComponent<BirdMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (birdMovement.isGameOver == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            if (transform.position.x <= -4f)
            {
                Destroy(gameObject);

            }
        }
    }
       
    
}
