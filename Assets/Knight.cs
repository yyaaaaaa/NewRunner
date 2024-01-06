using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Rigidbody rigidbody;
    Transform aim;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Enable(Transform player)
    {
        aim = player;
    }

    private void Update()
    {
        if(aim != null)
        {
            var direction = aim.position - transform.position;
            rigidbody.velocity = direction * 2f; 
        }
    }
}
