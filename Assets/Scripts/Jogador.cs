using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {
    public float velocidadejogador = 10;
	
	void Update () {
       float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao*velocidadejogador*Time.deltaTime);
   
	}
}
