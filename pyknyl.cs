using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyknyl : MonoBehaviour
{
    public static pyknyl singleton;
    public int health = 100;
    // Start is called before the first frame update
    void Awake()
    {
        singleton = this;      
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

}
