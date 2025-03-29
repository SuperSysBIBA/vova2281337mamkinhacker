using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLOX : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    public Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
    }

    // Update is called once per frame
    void Update()
    {
       newPosition.x += speed * Time.deltaTime;
       transform.position = newPosition;
    }
}
