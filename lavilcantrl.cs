using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavilcantrl : MonoBehaviour
{
    public shulkerdupe spawner;
    public static bool finished = false;
    private void Update()
    {
        if (finished == false)
        {
            Check();
        }
    }
    void Check()
    {
      if (spawner.spawnCount <= 0){ Enemy[] enemies = FindObjectsOfType<Enemy>();
      if (enemies.Length <= 0)
      {Victory();}
      }
      if (pyknyl.singleton.health <= 0)
      {
        defeat();
      }  
    }
    void Victory()
    {
        finished = true;
        print("salto");
    }
    void defeat()
    {
        finished = true;
        print("dayn");
    }

    // Update is called once per frame
   
}
