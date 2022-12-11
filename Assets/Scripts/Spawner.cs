using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Player player;

    public GameObject barriers;

    public int barrierRange;

    public float spawnTime = 1.25f;

    private void Start()
    {
        StartCoroutine(SpawnObject(spawnTime));
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!player.isDead)
        {

            Instantiate(barriers, new Vector3(Random.Range(-barrierRange, barrierRange), 0, 40), Quaternion.identity);



            yield return new WaitForSeconds(time);

        }
    }

}
