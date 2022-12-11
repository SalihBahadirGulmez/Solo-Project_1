using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isDead;

    public int force;

    public Rigidbody rb;

    public GameManager gameManager;

    public GameObject deathScreen;


    private void Start()
    {
        Time.timeScale = 1;
    }


    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0);
            //rb.velocity = new Vector3(250 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0);
            //rb.velocity = new Vector3(-250 * Time.deltaTime, 0, 0);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ScoreArea")
        {
            gameManager.UpdateScore();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Barrier")
        {
            Time.timeScale = 0;

            deathScreen.SetActive(true);
        }
    }
}
