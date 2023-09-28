using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform positionDepart;
    public float vitesse;
    public AudioSource gunFire;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            GameObject newBullet = Instantiate(bullet, positionDepart.position, Quaternion.identity) as GameObject;

            Rigidbody rBullet = newBullet.GetComponent<Rigidbody>();

            rBullet.velocity = positionDepart.TransformDirection(-Vector3.right) * vitesse;
            
            gunFire.Play();

            // Destroy(newBullet);
        }
    }
}
