using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	private bool boolLlave;


	void Start () {
		boolLlave = false;

	}
	
	public bool getLlave(){
		return boolLlave;
	}
	public void setLlave(bool a){
		boolLlave = a;
	}


}
