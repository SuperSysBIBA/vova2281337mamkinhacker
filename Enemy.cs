using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public float speed = 1;
    float borderPosX = -0.88f;
    public float enemyPosX = 0;
    public Animator anim;
    public int damage = 1;

    public float attackTimer = 1;
    float timer = 0;

    void Start()
    {
        borderPosX = pyknyl.singleton.transform.position.x;
        anim =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyPosX = transform.position.x;
        if (health <= 0) Destroy(gameObject);
        

        if (enemyPosX > borderPosX)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
            anim.SetBool("move", true);
        }

        else
        {
         timer += Time.deltaTime;
         if(timer >= attackTimer)
        {
             Attack();
        }
            anim.SetBool("move", false);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    void Attack()
    {
        pyknyl.singleton.TakeDamage(damage);
    }
}
