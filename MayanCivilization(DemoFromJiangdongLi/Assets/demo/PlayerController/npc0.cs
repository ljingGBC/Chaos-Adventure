using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc0 : MonoBehaviour
{   

    public float speed =10;

    public float changeDirectionTime = 4f;

    public float changeTimer;

    public bool isVertical;

    public Vector2 moveDirection;

    public Rigidbody2D rbody;




    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        changeTimer = changeDirectionTime;

        moveDirection = isVertical ? Vector2.up : Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        changeTimer -= Time.deltaTime;
        if (changeTimer < 0)
        {
            moveDirection *= -1;
            changeTimer = changeDirectionTime;
        }

        Vector2 position = rbody.position;
        position.x += moveDirection.x * speed * Time.deltaTime;
        position.y += moveDirection.y * speed * Time.deltaTime;
        rbody.MovePosition(position);


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        mc pc = other.gameObject.GetComponent<mc>();
        if (pc != null)
        {
            if (pc.haveSword == true)
            {

                Destroy(this.gameObject);

            }
            else
            {
                pc.ChangeHealth(-20);
            }
        }
    }
}
