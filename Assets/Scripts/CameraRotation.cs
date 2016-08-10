using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Move left");
            transform.RotateAround(transform.position, transform.up, 2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Move right");
            transform.RotateAround(transform.position, transform.up, -2);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Move up");
            transform.RotateAround(transform.position, transform.right, 2);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Move down");
            transform.RotateAround(transform.position, transform.right, -2);
        }

    }

}
