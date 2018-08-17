using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bird : MonoBehaviour {

	public float speed=1.5f;
	public int forward=5;
 bool dead=false;
	Animator animator;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (dead)
			return;
		transform.Translate (Vector3.right * forward * Time.deltaTime);
		if (Input.GetKey (KeyCode.Space)||Input.GetKey(KeyCode.Mouse0)) {
				transform.Translate(Vector3.up*speed*Time.deltaTime);

			}
	}
	void OnCollisionEnter2D(Collision2D collision){
		animator = GetComponent<Animator>();
		animator.SetTrigger("die");
		dead = true;
		 	
	}
	private int score1=0;
	public Text settext;
	void Start(){
		settext.text = "Score :" + score1.ToString ();
	}
	
	void OnTriggerEnter2D(Collider2D collide){
		if (collide.tag=="high") {
			score1=score1+1;
			settext.text = "Score : " + score1.ToString();
			
			Debug.Log ("Triggered: " + collide.name);
			Vector3 pos=collide.transform.position;
			pos.x+=7f;
			collide.transform.position=pos;
		}
		
		
	}
}
