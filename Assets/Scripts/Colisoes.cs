using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisoes : MonoBehaviour {

    public GameObject carro;
    List<GameObject> alvos = new List<GameObject>();

    void bateu()
    {
        var funcao = carro.GetComponent<Pontos>();
        funcao.houveColisao();
        StartCoroutine("Aguardando");
    }

    IEnumerator Aguardando()
    {
        yield return new WaitForSecondsRealtime(5);
        alvos.Clear();
    }


    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == 9)
        {
            if (!alvos.Contains(col.gameObject))
            {
                alvos.Add(col.gameObject);
                bateu();
            }
            
        }
            
    }

}
