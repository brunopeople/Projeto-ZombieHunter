using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Zumbi : MonoBehaviour {

    public GameObject Jogador;
    public float velocidade = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {

        Vector3 direcao = Jogador.transform.position - transform.position;
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao * velocidade * Time.deltaTime);       
    }
}
