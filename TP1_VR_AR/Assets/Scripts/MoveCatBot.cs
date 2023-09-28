using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCatBot : MonoBehaviour
{
    public GameObject arrD;
    public GameObject arrG;
    public GameObject avnG;
    public GameObject avnD;
    //declaration des variables
    public float speed = 6f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;
    public Camera cam;
    public float sensi = 30f;
    private Vector3 mouvement = Vector3.zero;
    private float angle = 25.0f;


    void Start()
    {

    }

    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * speed * sensi);

        arrD.transform.Rotate(angle, 0, 0, Space.Self);
        arrG.transform.Rotate(angle, 0, 0, Space.Self);
        avnG.transform.Rotate(angle, 0, 0, Space.Self);
        avnD.transform.Rotate(angle, 0, 0, Space.Self);
    }
}
