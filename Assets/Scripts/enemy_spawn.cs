using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour
{
    public GameObject chad;
    public GameObject eBoy;

    [SerializeField] private Rigidbody2D daf;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;

    int chadCount = 0, eBoyCount = 0;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn && chadCount < 5){
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(daf.position.x + 10, daf.position.x + 20);
            whereToSpawn = new Vector2 (randX, transform.position.y);
            Instantiate (chad, whereToSpawn, Quaternion.identity);
            chadCount++;
        }
        else if(Time.time > nextSpawn && chadCount >= 5){
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(daf.position.x + 10, daf.position.x + 20);
            whereToSpawn = new Vector2 (randX, transform.position.y);
            Instantiate (eBoy, whereToSpawn, Quaternion.identity);
            Instantiate (chad, whereToSpawn, Quaternion.identity);
            eBoyCount++;
            chadCount++;
        }
    }
}
