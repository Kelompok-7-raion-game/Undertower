using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerbehaviour : MonoBehaviour
{
    public Vector2 arah;
    public float speed, jumpforce;
    public Rigidbody2D rb2d;
    public bool onjump;
    public SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        gameover.endgame = false;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover.endgame) {
            movement();
        }
        
    }

    void movement() { 
        arah = Vector2.zero;
        if (Input.GetKey(KeyCode.RightArrow)){
            arah = Vector2.right;
            sprite.flipX = true;
        }
        else if(Input.GetKey(KeyCode.LeftArrow ))
        {
            arah = Vector2.left;
            sprite.flipX = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && onjump ==false && rb2d.velocity.y == 0)
        {
            rb2d.AddForce(Vector2.up * jumpforce);
            onjump = true;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            arah = Vector2.down;
        }

        transform.Translate(arah * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("platform"))
        {
            onjump = false;
        }
    }
}
