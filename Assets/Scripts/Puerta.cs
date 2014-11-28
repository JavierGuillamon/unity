using UnityEngine;
using System.Collections;

public class Puerta : MonoBehaviour {
	private GameObject Player;
	private Inventario inventario;
	[SerializeField]
	private GameObject puerta;
	private Animation animacionPuerta;


	// Use this for initialization
	void Start () {
		animacionPuerta = puerta.GetComponent<Animation> ();
		Player = GameObject.Find ("Player") as GameObject;

	}
	
	void OnTriggerEnter(Collider otro)
	{
		if (otro.name == "Player" && Player.GetComponent<Inventario>().getLlave()) {
			animacionPuerta.Play("AbrirPuerta");

		}
	}
	void OnTriggerExit(Collider otro )
	{
		if (otro.name == "Player" && Player.GetComponent<Inventario>().getLlave()) {
			animacionPuerta.Play("cerrarPuerta");
		
		}
	}
}
