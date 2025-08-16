using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shulkerdupe : MonoBehaviour
{
    public Enemy enemyPrefab;
    public Transform topbardr;
    public Transform nijnebarjer;
    public float spawnintmin = 0.01f;
    public float spawnintma = 2;
    public float spawntimer = 1;
    public int spawnCount = 10;
    // Start is called before the first frame update
    void Spawn()
    {
        spawnCount--;
        spawntimer = Random.Range(spawnintmin, spawnintma);
        Vector2 randPos = new Vector2(transform.position.x, Random.Range(nijnebarjer.position.y, topbardr.position.y));
        Instantiate(enemyPrefab, randPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawntimer > 0)
        {
            spawntimer -= Time.deltaTime;
        }
        else if (spawnCount > 0) Spawn();
    }
}
