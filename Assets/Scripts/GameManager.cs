using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Player player;
    public Enemy enemy;

    public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {

        InvokeRepeating("SpawnEnemy", 1f, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void SpawnEnemy()
    {
        Enemy newEnemy = (Enemy)Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);

        newEnemy.target = player.transform;
        newEnemy.gameObject.SetActive(true);
    }
}
