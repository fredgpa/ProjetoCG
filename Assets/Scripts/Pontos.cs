using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

    int pontosMax = 3;
    int pontos;
    public Image certo1;
    public Image certo2;
    public Image certo3;
    public Image errado1;
    public Image errado2;
    public Image errado3;
    public GameObject mensagem;
    public GameObject ingame;
    public bool esperar;

	// Use this for initialization
	void Start () {
        pontos = pontosMax;
	}

    void FimDeJogo()
    {
        mensagem.SetActive(true);
        ingame.SetActive(false);
    }

    public void houveColisao()
    {
        pontos--;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Backspace))
            pontos--;
        switch (pontos)
        {
            case 3:
                certo1.color = new Color(certo1.color.r, certo1.color.g, certo1.color.b, 1);
                certo2.color = new Color(certo2.color.r, certo2.color.g, certo2.color.b, 1);
                certo3.color = new Color(certo3.color.r, certo3.color.g, certo3.color.b, 1);
                errado1.color = new Color(errado1.color.r, errado1.color.g, errado1.color.b, 0);
                errado2.color = new Color(errado2.color.r, errado2.color.g, errado2.color.b, 0);
                errado3.color = new Color(errado3.color.r, errado3.color.g, errado3.color.b, 0);
                break;
            case 2:
                certo3.color = new Color(certo3.color.r, certo3.color.g, certo3.color.b, 0);
                errado3.color = new Color(errado3.color.r, errado3.color.g, errado3.color.b, 1);
                break;
            case 1:
                certo2.color = new Color(certo2.color.r, certo2.color.g, certo2.color.b, 0);
                errado2.color = new Color(errado2.color.r, errado2.color.g, errado2.color.b, 1);
                break;
            case 0:
                certo1.color = new Color(certo1.color.r, certo1.color.g, certo1.color.b, 0);
                errado1.color = new Color(errado1.color.r, errado1.color.g, errado1.color.b, 1);
                FimDeJogo();
                break;
        }
    }
}
