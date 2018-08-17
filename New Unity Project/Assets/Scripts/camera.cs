using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public GameObject player;
	private float offset;
	public
	// Use this for initialization
	void Start () {
		offset = transform.position.x - player.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x = player.transform.position.x + offset;
		transform.position = pos;
	}
}
