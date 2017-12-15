using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pisca : MonoBehaviour {

    public bool ativa = false;
    public Image seta;
    Vector3 posInicial;
    public GameObject carro;
    public KeyCode tecla;

    // Use this for initialization
    void Start () {
    }

    IEnumerator Piscada()
    {
        while (true)
        {
            switch (seta.color.a.ToString())
            {
                case "0":
                    seta.color = new Color(seta.color.r, seta.color.g, seta.color.b, 1);
                    //Play sound
                    yield return new WaitForSeconds(0.3f);
                    break;
                case "1":
                    seta.color = new Color(seta.color.r, seta.color.g, seta.color.b, 0);
                    //Play sound
                    yield return new WaitForSeconds(0.3f);
                    break;
            }
        }
    }

    void ComeçaPiscar()
    {
        StopAllCoroutines();
        StartCoroutine("Piscada");
    }

    void ParaPiscar()
    {
        StopAllCoroutines();
        seta.color = new Color(seta.color.r, seta.color.g, seta.color.b, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            if (ativa)
            {
                ParaPiscar();
                ativa = !ativa;
            }
            else
            {
                ComeçaPiscar();
                posInicial = carro.transform.forward;
                ativa = !ativa;
            }        
        }
        if (ativa)
            if (Mathf.Abs(Vector3.Angle(carro.transform.forward, posInicial)) > 40)
            {
                ParaPiscar();
                ativa = !ativa;
            }
    }

}

