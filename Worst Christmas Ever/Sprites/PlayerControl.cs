using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

	bool isOnGround;
    public Vector3 initialPosition;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update ()

    {

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
            jump();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && !isOnGround) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-200.0f));
        }
    }

void OnCollisionEnter2D(Collision2D coll){

    if (coll.collider.tag == "ground"){

    isOnGround = true;

    }

    else{

    isOnGround = false;
    }
}


void jump()

{

GetComponent<Rigidbody2D>().AddForce(new Vector2 (0, 400.0f));

isOnGround = false;

}

}

