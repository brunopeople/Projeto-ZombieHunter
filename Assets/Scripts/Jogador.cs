using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {
    public float velocidadejogador = 50;
    Vector3 direcao;
	
	void Update () {
       float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao * velocidadejogador * Time.deltaTime);

        if (direcao != Vector3.zero) {
            GetComponent<Animator>().SetBool("Movendo", true);
        }

        else
        {
            GetComponent<Animator>().SetBool("Movendo", false);
        }
   
	}

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (direcao * velocidadejogador * Time.deltaTime));
    }
}
