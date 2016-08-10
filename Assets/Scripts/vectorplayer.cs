using UnityEngine;
using System.Collections;

public class vectorplayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Move up");
            transform.position += transform.up * Time.deltaTime;
        }
	
	}
}
