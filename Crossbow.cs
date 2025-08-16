using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public GameObject arrow;
    public float shootInterval = 0.75f;
    public float shootTimer = 0;
    // Update is called once per frame
    void Update()
    {
        Vector2 mouseScreenPos = Input.mousePosition;
        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

        Vector2 bowPos = transform.position;
        Vector2 wantedDir =  mouseScenePos - bowPos;
        Vector2 defaultDir = Vector2.up;        
       float angle = Vector2.SignedAngle(defaultDir, wantedDir );

        Vector3 newEuler = new Vector3(0, 0, angle);
        transform.localEulerAngles = newEuler;

        if(shootTimer >0) shootTimer -= Time.deltaTime;

        if(Input.GetMouseButtonDown(0) && shootTimer <= 0) Shot();
    }
    void Shot()
    {
        Instantiate(arrow,transform.position,transform.rotation);
        shootTimer = shootInterval;
    }
}
