using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvaFin : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        Debug.Log(GameVariables.nbCibles);
        if (GameVariables.nbCibles == 3)
        {
            canvas.gameObject.SetActive(true);
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart() {
        
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0); 

    }
}
