using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {
    public BulletScript bullet;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        BulletScript newBullet = (BulletScript)Instantiate(bullet, transform.position + transform.forward, Quaternion.identity);

        newBullet.direction = transform.forward;
    }
}
