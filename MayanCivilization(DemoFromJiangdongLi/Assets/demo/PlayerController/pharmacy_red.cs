using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pharmacy_red : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        mc pc = other.GetComponent<mc>();
        if(pc != null)
        {
            if(pc.currentHealth < pc.maxHealth)
            {
                pc.ChangeHealth(20);
                Destroy(this.gameObject);
                
            }
        }
    }
}
