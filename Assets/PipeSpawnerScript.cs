using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minY;
    public float maxY;
    public float time;
    BirdMovement birdMovement;
    // Start is called before the first frame update
    void Start()
    {
        birdMovement=GameObject.Find("Player").GetComponent<BirdMovement>();
        if (birdMovement.isGameOver == false)
        {
            InvokeRepeating("PipeSpawner", 2f, 2f);
            //PipeSpawner();
        }
    }
    private void PipeSpawner()
    {
      

            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = new Vector2(transform.position.x, UnityEngine.Random.Range(minY, maxY));


    }
    // Update is called once per frame
    void Update()
    {

    }
}
