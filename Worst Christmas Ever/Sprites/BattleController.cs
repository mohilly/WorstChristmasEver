using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{

    public int Health;
    
    void OnCollisionEnter(Collision collision)
    {
     if (!collision.gameObject.CompareTag("Interactable")) return;
     Health -= 10; // Dmg
     if (Health <= 0)
     {
         Health = 0;
         
     }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
