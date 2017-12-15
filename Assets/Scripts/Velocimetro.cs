using UnityEngine;
using UnityEngine.UI;

public class Velocimetro : MonoBehaviour {

    public GameObject carro;
    public Text texto;
    
    private void Start()
    {
    }



    // Update is called once per frame
    void Update () {
        var vel = carro.GetComponent<Velocidade>();
        float speed = vel.velocidade;
        if (speed <= 5)
            texto.color = Color.black;
        else if (speed <= 40)
            texto.color = Color.green;
        else if (speed <= 60)
            texto.color = Color.yellow;
        else
            texto.color = Color.red;
        texto.text = vel.velocidade.ToString("0");
	}
}
