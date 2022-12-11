using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarriersMovement : MonoBehaviour
{
    public float speed;

    public int destroyTime = 10;

    public GameObject left;
    public GameObject right;


    private void Start()
    {
        Destroy(gameObject, destroyTime);       
    }





    private void FixedUpdate()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;    // transform.Translate yap   
    }
}
