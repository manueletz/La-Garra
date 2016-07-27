using UnityEngine;
using System.Collections;

public class Salto : MonoBehaviour {

	float timeCounter=0;

	public float speed;
	public float width;
	public float height;
	float valorespares;
	float llave=0;
	// Use this for initialization
	void Start () {
		speed =1.0f;
		width = 4;
		height = 4;
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime * speed;

		float x = Mathf.Cos (timeCounter) * width;
		float y = Mathf.Sin (timeCounter) * height;
		float z = 0;

		//Debug.Log (timeCounter);
		valorespares=Mathf.Ceil (timeCounter);

		//Debug.Log (valorespares);

		//metodo 1
		/*
		if (valorespares % 2 == 0) { 
			transform.position = new Vector3 (x, y, z);
		}
		*/

		//metodo2
		//el valor de la llave en este caso 5 denota la velocidad que se va a refrescar la pantalla.
		if (llave == 5) { 
			transform.position = new Vector3 (x, y, z);
			llave = 0;
		} else {
			llave += 1;
		}
	}
}
