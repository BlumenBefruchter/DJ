using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ei : MonoBehaviour
{
    public GameObject ei;
    public Transform hole;
    public float eiSpeed = 20;

    Vector2 lookDirection;
    float lookAngle;
    private void Update()
    {
        lookDirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        hole.rotation = Quaternion.Euler(0, 0, lookAngle);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject eiClone = Instantiate(ei);
            eiClone.transform.position = hole.position;
            eiClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            eiClone.GetComponent<Rigidbody2D>().velocity = hole.right * eiSpeed;
        }
    }
}


    
