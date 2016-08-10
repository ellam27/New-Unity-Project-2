using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {
    public bool trig;
   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Trigger")
        {
            trig = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Trigger")
        {
            trig = false;
        }
    }
}
