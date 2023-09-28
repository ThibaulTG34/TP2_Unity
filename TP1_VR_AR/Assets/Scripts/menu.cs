using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Button jouer;
    public Button quitter;

    void Start()
    {
        jouer.onClick.AddListener(ClickPlay);
        quitter.onClick.AddListener(ClickQuit);
    }


    void ClickPlay()
    {
        SceneManager.LoadScene(1);
    }

    void ClickQuit()
    {
        Application.Quit();
    }
}
