using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    public Vector3 direction;
    public float speed;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 5.0f);
    }	
	// Update is called once per frame
	void Update () {

        transform.position += direction * Time.deltaTime * speed;
	
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Bullet Hit");

        if(col.collider.tag == "Enemy")
        {
            col.collider.gameObject.SetActive(false);

            Destroy(col.gameObject);
        }
    }
}
