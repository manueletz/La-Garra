using UnityEngine;
using System.Collections;

public class controlPremios : MonoBehaviour {

	AudioSource aSource;
	public AudioClip ganarPremioSound;
	GameObject premio=null;

	Rigidbody2D rgb;
	SpriteRenderer sr;
	public float maxVel = 10f;

	public int girarx = 0;
	public int girary = 0;
	public int girarz = -5;

	bool ActivarRotacion = false;

	// Use this for initialization
	void Start () {
		premio = GameObject.Find ("cake_source_53");
		rgb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		aSource = GetComponent<AudioSource> ();

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//Se genera fuerza sobre la bala, lanzándola en dirección del eje z de la bola (el frente de la bola)
			//rigidbodyObjeto.AddForce (transform.forward * fuerza);
			float fuerza = 2700f;
			rgb.AddForce (transform.up * fuerza);
		}

		if (ActivarRotacion==true) {
//			premio.GetComponent<Transform> ().Rotate (girarx, girary, girarz);
		}
	}


	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log(sr.sprite.name.Equals
		//if (other.gameObject.name.Equals ("cake_source_53") && (sr.sprite.name.Equals("resortes_4") || (sr.sprite.name.Equals("resortes_3") ))) {
		//if (other.gameObject.name.Equals ("cake_source_53")	&& (sr.sprite.name.Contains("resortes"))) {
		//if ( (other.gameObject.name.Equals ("cake_source_53") || other.gameObject.name.Contains ("bomb") || other.gameObject.name.Contains ("clover") || other.gameObject.name.Contains ("bronze_coin")	)&& (sr.sprite.name.Contains("resortes"))) {
		if ( (other.gameObject.name.Contains ("FrutasPrototype") || other.gameObject.name.Contains ("bomb") || other.gameObject.name.Contains ("clover") || other.gameObject.name.Contains ("bronze_coin")	)&& (sr.sprite.name.Contains("resortes"))) {
			Debug.Log ("Toque la fruta");
			aSource.PlayOneShot (ganarPremioSound);
			//premio.GetComponent<Salto>().activo=false;
			//other.gameObject.GetComponent<Salto>().activo=false;

			Destroy (other.gameObject);

			//float v = Input.GetAxis ("Vertical");
			//Vector2 vel = new Vector2 (rgb.velocity.x, 0);
			//v *= maxVel;
			//vel.y = v;
			//float power = 10000f;
			//premio.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up*power);
			//float speed = 10000f;
			//premio.GetComponent<Rigidbody2D>().AddForce(transform.up*Time.deltaTime*speed);
			float fuerza = 2700f;
//			premio.GetComponent<Rigidbody2D> ().AddForce (transform.up * fuerza);
			ActivarRotacion = true;
			//Destroy (premio);
		}

	}

	void FixedUpdate () {
		// Cambio de los metodos para verificar el input
		VerificarInputParaCaminar();
	}

	private void VerificarInputParaCaminar() {
		float v = Input.GetAxis ("Horizontal");
		Vector2 vel = new Vector2 (0, rgb.velocity.y);
		v *= maxVel;
		vel.x = v;
		rgb.velocity = vel;
	}
}
