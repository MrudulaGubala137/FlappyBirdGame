using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public int score;
    ScoreCalculator scoreCalculator;
    void Start()
    {
        scoreCalculator=GameObject.Find("ScoreManager").GetComponent<ScoreCalculator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= -4)
        {
           Destroy(gameObject);
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreCalculator.ScoreManager(0);
            
        }
    }
}
