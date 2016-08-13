using UnityEngine;
using System.Collections;

public class CambioSprite : MonoBehaviour {

	public GameObject premio1, premio2, premio3;
	public GameObject prefab;
	public Sprite sprite1, sprite2, sprite3;

	public float myNumeroAleatorio=-1.0F;
	public bool fin=false;

	public GameObject[] mispremios;

	public Sprite[] Faces;


	// Use this for initialization
	void Start () {
		//premio1 = GameObject.Find ("Premios").GetComponent<Transform>().FindChild("bomb");
		premio1 = GameObject.Find("bomb");
		premio2 = GameObject.Find("clover");
		premio3 = GameObject.Find("bronze_coin");




		mispremios = GameObject.FindGameObjectsWithTag("TagPremios");

		for(int i = 0; i < mispremios.Length; i++)
		{
			Debug.Log("Premio Number "+i+" is named "+mispremios[i].name);
		}



	}

	// Update is called once per frame
	void Update () {
		EmitirPremio ();
		//GameObject premio1Copy = Instantiate (premio1);

		if (Input.GetKeyDown (KeyCode.Space)) {
			ChangeTheDamnSprite ();
		}
	}

	void ChangeTheDamnSprite(){

		/*
		if (GetComponent<SpriteRenderer> ().sprite == sprite1) {
			GetComponent<SpriteRenderer> ().sprite = sprite2;
		} else {
			GetComponent<SpriteRenderer> ().sprite = sprite1;
		}
		*/
		int index = Random.Range (0, Faces.Length - 1);
		this.GetComponent<SpriteRenderer> ().sprite = Faces [index];

	}

	void EmitirPremio(){
		/* esta funciona correctamente
		if (Random.value < 1f /(60f * 3f)){
			GameObject goldCopy = Instantiate (goldPrototype);
			GameObject rubyCopy = Instantiate (rubyPrototype);
			GameObject diamondCopy = Instantiate (diamondPrototype);
			goldCopy.transform.position = new Vector3(-0.33f,0.99f,0f);
		}
		*/
		myNumeroAleatorio = Random.Range(0F, 1000F);

		//switch (myNumeroAleatorio){
		if (myNumeroAleatorio>=0 && myNumeroAleatorio<1 && fin==false){
			//GameObject premio1Copy = Instantiate (premio1);
			//premio1Copy.GetComponent<SpriteRenderer> ().enabled = true;
			//GameObject goldCopy = Instantiate (goldProototype);
			//goldCopy.transform.position = new Vector3(-0.33f,3.83f,0f);
		}
		if (myNumeroAleatorio>=30 && myNumeroAleatorio<31 && fin==false){
			//GameObject premio2Copy = Instantiate (premio2);
			//premio2Copy.GetComponent<SpriteRenderer> ().enabled = true;
			//GameObject rubyCopy = Instantiate (rubyPrototype);
			//rubyCopy.transform.position = new Vector3(-0.33f,3.83f,0f);
		}
		if (myNumeroAleatorio>=60 && myNumeroAleatorio<=61 && fin==false){
			//GameObject premio3Copy = Instantiate (premio3);
			//premio3Copy.GetComponent<SpriteRenderer> ().enabled = true;
			//GameObject diamondCopy = Instantiate (diamondPrototype);
			//diamondCopy.transform.position = new Vector3(-0.33f,3.83f,0f);
		}

	}
}
