using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour
{
    public GameObject fx;
    public GameObject cube;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "bullet") {
            Instantiate(fx, cube.transform.position, Quaternion.identity);
            GameVariables.nbCibles ++;
            Destroy(this.gameObject);
        }
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     ContactPoint contact = collision.contacts[0];
    //     Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
    //     Vector3 position = contact.point;
    //     Instantiate(fx, position, rotation);
    //     Destroy(gameObject);
    // }
}
