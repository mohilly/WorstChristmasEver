using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGenereator : MonoBehaviour
{
    public GameObject obstacle;

    float timer;

    void manageTimer() {

    timer += Time.deltaTime;

    if (timer >= 2){

        addObstacle ();
        timer = 0;
        }

    }

    void addObstacle(){

    Vector3 positionOfPlayer = GameObject.Find ("Player").GetComponent<PlayerControl>().initialPosition;

    GameObject t1;

    t1 = (GameObject)(GameObject.Instantiate (obstacle, positionOfPlayer + Vector3.right * 20, Quaternion.identity));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manageTimer ();
        transform.Translate(Vector2.left * 4*Time.deltaTime);

        if (transform.position.y < -5) Destroy(gameObject);
    }
}
