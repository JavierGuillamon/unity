using UnityEngine;
using System.Collections;

public class CogerLlave : MonoBehaviour {




	void OnTriggerEnter(Collider otro){
		if (otro.name == "Player") {
			otro.GetComponent<Inventario>().setLlave(true);
			Destroy(this.gameObject);
		}
	}
}
