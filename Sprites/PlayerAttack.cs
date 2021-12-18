using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerAttack : MonoBehaviour
{

    public GameObject projectile;
    private Rigidbody2D rb;
    public Texture2D tex;
    private Sprite AttackSprite;
    private SpriteRenderer sr;

    Vector3 positionOfPlayer = GameObject.Find ("Player").GetComponent<PlayerControl>().initialPosition;


    void Awake() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
        sr.color = new Color(0.9f, 0.9f, 0.5f, 1.0f);
        sr.sprite = AttackSprite;
        transform.position = new Vector2(0.0f, 1.0f);

    }

    // Start is called before the first frame update
    void Start()
    {
        AttackSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, 128.0f, 128.0f), new Vector2(0.5f, 0.5f), 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            fire();
            print("FIRING!!!");
        }        
    }

    void fire() {
        Instantiate(projectile, positionOfPlayer + Vector3.right * 20, Quaternion.identity);
        rb.AddForce(transform.up * 0.5f);

    }
}
