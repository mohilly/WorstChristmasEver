using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
 /// <summary>
 /// The class definition for a projectile's trigger
 /// </summary>
 /// <remarks>
 /// Attach this script as a component to any object capable of triggering projectiles
 /// The spawn transform should represent the position where the projectile is to appear, i.e. gun barrel end
 /// </remarks>
 public class PlayerAttack : MonoBehaviour
 {
     /// <summary>
     /// Public fields
     /// </summary>
     public GameObject m_Projectile;    // this is a reference to your projectile prefab
     public Transform m_SpawnTransform; // this is a reference to the transform where the prefab will spawn
     public Rigidbody rb;   

     /// <summary>
     /// Message that is called once per frame
     /// </summary>

     private void Start(){

     }

     private void Update()
     {
         if (Input.GetKeyDown(KeyCode.Return))
         {
             GameObject fireball = Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation) as GameObject;
//             rb = fireball.GetComponent<Rigidbody>;
//             rb.velocity = Transform.forward * 20f;

         }
     }
 }
