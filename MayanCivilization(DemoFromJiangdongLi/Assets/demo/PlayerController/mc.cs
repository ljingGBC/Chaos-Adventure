using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mc : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed = 5f;

    public int maxHealth = 100;

    public int currentHealth;

    public bool haveSword = false;

    public bool haveWater = false;

    public Vector2 lookDirection = new Vector2(1, 0);

    public Rigidbody2D mcBody;

    public Animator anim;

    void Start()
    {
        currentHealth = 100;
        mcBody = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");// a and d  move
        float moveY = Input.GetAxisRaw("Vertical");// w and s move

        Vector2 moveVector = new Vector2(moveX, moveY);

        if (moveVector.x != 0 || moveVector.y != 0)
        {
            lookDirection = moveVector;
        }
        anim.SetFloat("moveX", lookDirection.x);
        anim.SetFloat("moveY", lookDirection.y);

        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveY * speed * Time.deltaTime;
        mcBody.MovePosition(position);



        //talk with npc   keyboard button T



    }

    
    

    public void ChangeHealth(int amount)
    {
        
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);

        UImanager.instance.UpdateHealthBar(currentHealth, maxHealth);
        Debug.Log("health is " + currentHealth + "/" + maxHealth);
    }
}
