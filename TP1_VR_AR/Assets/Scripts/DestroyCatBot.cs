using UnityEngine;
public class DestroyCatBot : MonoBehaviour
{    
    AudioSource collisionSound;
    public GameObject fx;
    public GameObject worldObject;


    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>() ;
    }

    void Update() 
    {

    }


    void OnTriggerEnter(Collider other) {  
        if (other.tag == "Player") {
            Instantiate(fx, this.transform.position, Quaternion.identity);
            collisionSound.Play();
            worldObject.SendMessage("AddHit");
            Destroy(this.gameObject);
        }
    }
}