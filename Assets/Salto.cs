using UnityEngine;
using System.Collections;

public class Salto : MonoBehaviour {

	float timeCounter=0;

	public float speed;
	public float width;
	public float height;
	float valorespares;
	float llave=0;
	public bool activo=true;
	Rigidbody2D rgb;

	public Sprite[] Faces;

	// Use this for initialization
	void Start () {
		speed  = 1.0f;
		width  = 4;
		height = 4;

		rgb = GetComponent<Rigidbody2D> ();


		int index = Random.Range (0, Faces.Length - 1);
		this.GetComponent<SpriteRenderer> ().sprite = Faces [index];
	}
	
	// Update is called once per frame
	void Update () {

		if (activo) {
			timeCounter += Time.deltaTime * speed;

			float x = Mathf.Cos (timeCounter) * width;
			float y = Mathf.Sin (timeCounter) * height;
			float z = 0;

			//Debug.Log (timeCounter);
			valorespares = Mathf.Ceil (timeCounter);

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

		} else {
			rgb.isKinematic = false;
		}
	}
}
