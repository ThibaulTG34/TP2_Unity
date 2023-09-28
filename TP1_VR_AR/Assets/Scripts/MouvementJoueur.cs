using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouvementJoueur : MonoBehaviour
{
    //declaration des variables
    public float speed = 6f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;
    public Camera cam;
    public float sensi = 30f;
    private Vector3 mouvement = Vector3.zero;
    CharacterController player;


    void Start()
    {
        //recuperation du composant CharacterController
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        //si le joueur est au sol
        if (player.isGrounded)
        {
            //recuperation des valeurs des axes horizontal et vertical 
            //et stockage dans un Vector3
            mouvement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            //tient compte de la rotation du joueur
            mouvement = transform.TransformDirection(mouvement);
            //on multiplie le vector3 par la vitesse de deplacement
            mouvement *= speed;

            //si la touche ESPACE est pressee
            if (Input.GetButton("Jump"))
            {
                //on dit que notre point sur l'axe y augmente de la valeur de jumpSpeed 
                mouvement.y = jumpSpeed;
            }
        }
        //maintenant si le joueur est en l'air
        //on le soumet a la gravite
        mouvement.y -= gravity * Time.deltaTime;
        //ici on effectue la rotation de notre joueur s'il glisse la souris a gauche ou a droite
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * speed * sensi, 0);

        //ici on effectue la rotation de notre joueur s'il glisse la souris en haut ou en bas
        Vector3 RotaCamera = new Vector3(Input.GetAxisRaw("Mouse Y"), 0, 0);
        cam.transform.Rotate(-RotaCamera);

        //chose la plus importante
        //on appel la methode Move() qui effectue le mouvement du joueur
        player.Move(mouvement * Time.deltaTime);
    }
}
