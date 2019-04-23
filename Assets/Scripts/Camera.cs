using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject Jogador;
    Vector3 calcula_distancia;
	// Use this for initialization
	void Start () {
        //a varaivel calcula distancia onde a camerda vai focar entre o jogador e o ponto
        // em que ele se encontra. Sem essa diferena a camera estaria no pé do jogador

        calcula_distancia = transform.position - Jogador.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Jogador.transform.position + calcula_distancia;

    }


   
        
}
