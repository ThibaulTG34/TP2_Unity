using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkOnDragon : MonoBehaviour
{

    public Transform player;
    public Transform playerCamera;
    public Transform dragonCamera;
    private bool near = false;
    public Canvas erreur;

    void Start()
    {
        dragonCamera.gameObject.SetActive(false);
        erreur.gameObject.SetActive(false);
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        if (dist <= 1.9f)
        {
            near = true;
        }
        else
        {
            near = false;
        }

        if (near && Input.GetKey(KeyCode.F))
        {
            if(GameVariables.nbCats >= 3)
            {
                playerCamera.gameObject.SetActive(false);
                dragonCamera.gameObject.SetActive(true);
                player.gameObject.SetActive(false);
                StartCoroutine(ChangeScene());
            }
            else{
                erreur.gameObject.SetActive(true);
                StartCoroutine(Wait());
            }

        }
    }

    IEnumerator Wait() 
    {
        yield return new WaitForSeconds(2);
        erreur.gameObject.SetActive(false);

    }

    IEnumerator ChangeScene() 
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2); 
    }
}
