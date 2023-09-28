using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetectorScript : MonoBehaviour
{
    public Transform Spawn;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("ici");
            other.transform.position = Spawn.transform.position;
            other.transform.rotation = Spawn.transform.rotation;
        }
    }
}
