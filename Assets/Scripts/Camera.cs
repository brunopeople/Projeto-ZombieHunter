using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject Jogador;
    Vector3 calcula_distancia;
	// Use this for initialization
	void Start () {
        calcula_distancia = transform.position - Jogador.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        calcula_distancia = transform.position + Jogador.transform.position;
    }
}
