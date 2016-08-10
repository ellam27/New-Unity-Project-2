using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Transform target;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.LookRotation(target.position - transform.position);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;
	
	}
}
