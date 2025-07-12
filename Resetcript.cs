using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetcript : MonoBehaviour
{
    Vector3 resetPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        resetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = resetPosition;
            transform.rotation = Quaternion.identity;
        }
    }
}
