using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarMain : MonoBehaviour {

    public void voltarMain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void tentarNovamente()
    {
        SceneManager.LoadScene("bla");
    }
}
