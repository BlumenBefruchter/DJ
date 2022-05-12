using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    float movement = 0f;
    Rigidbody2D rb;

    public Transform hole;
    public GameObject EiPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //if (Input.GetButtonDown("Fire1"))
        //{
          //  Shoot();
        //}
    }
    //void Shoot()
    //{
      //  Instantiate(EiPrefab, hole.position, hole.rotation);
    //}

    private void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = movement;
        
        rb.velocity = velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            SceneManager.LoadScene("GO");
            Destroy(gameObject);
            
        }
        else if (collision.gameObject.CompareTag("KillZone"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GO");
        }
    }

}
