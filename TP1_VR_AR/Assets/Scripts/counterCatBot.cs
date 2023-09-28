using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class counterCatBot : MonoBehaviour
{
    TMP_Text headText;
    public TMP_Text timerText; 

    void Start() {
        StartCoroutine(TimerTick());
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
    }

    void Update() {

    }
    public void AddHit() {
        GameVariables.nbCats++;
        headText.text = "CatBots touchés : " + GameVariables.nbCats;
    }

    IEnumerator TimerTick() {
        while (GameVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time : " + GameVariables.currentTime.ToString();
        }
    }

}
