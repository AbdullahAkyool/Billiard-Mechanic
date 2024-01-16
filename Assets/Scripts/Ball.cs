using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isDuplicate = false;
    private AimController _aimController;

    void Start()
    {
        _aimController = FindObjectOfType<AimController>();
    }
    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Ball"))
    //     {
    //         if (isDuplicate) return;
    //         for (int i = 1; i <= 5; i++)
    //         {
    //             Instantiate(collision.gameObject, transform.position, transform.rotation);
    //             Debug.Log("dadasdasdsa");
    //         }
    //         isDuplicate = true;    
    //     }
    // }
}
