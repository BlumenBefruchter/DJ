using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class OneWayColl : MonoBehaviour
{
    [SerializeField] private Vector3 entryDriection = Vector3.up;
    [SerializeField] private bool localDirection = false;
    private new BoxCollider collider = null;



    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        collider.isTrigger = false;

        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Vector3 direction;
        if (localDirection)
        {
            direction = transform.TransformDirection(entryDriection.normalized);
        }
        else
        {
            direction = entryDriection;
        }
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, entryDriection);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -entryDriection);
    }
}
