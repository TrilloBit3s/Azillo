using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SustoFantasma : MonoBehaviour {
	private BoxCollider[] collisores;
	public AudioClip sustoFantasma;//som para o susto do fantasma 
	private float cronometro;//cronometro de visibilidade do fantasma na cena 
	public float tempoDaImagem;//quanto tempo a imagem do fantasma fica visivel
	private bool contar;//ativar cronometro
	private int randomSusto;//sorteio dar o susto ou não 
	public bool temSom; //verifica sim ou nao esta variavel deve ser publica para decidir 

	void Start () {
		randomSusto = Random.Range (1, 1);
		if (randomSusto != 1) {
			Destroy (gameObject);
		}
		GetComponent<Renderer>().enabled = false;//para começar invisivel
		collisores = gameObject.GetComponents<BoxCollider> ();//adicionar colisores da imagem
		GetComponent<AudioSource>().clip = sustoFantasma;
	}

	void Update () {
		if (contar == true) {
			cronometro += Time.deltaTime;
		}
		if (cronometro >= tempoDaImagem) {
			contar = false;
			GetComponent<Renderer>().enabled = false;
		}
	}

	void OnTriggerEnter (){
		contar = true;
		GetComponent<Renderer>().enabled = true;
		if (temSom == true) {
              GetComponent<AudioSource>().PlayOneShot(sustoFantasma);
			//GetComponent<AudioSource>().PlayOneShot (GetComponent<AudioSource>().clip);
		}
		Destroy (gameObject, GetComponent<AudioSource>().clip.length);//destruir depois que tocar
	}
}