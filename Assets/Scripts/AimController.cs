using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AimController : MonoBehaviour
{
    private float rotationY;
    public float sensivity = .5f;
    public float shootPower = 50f;

    private Touch touch;
    public Rigidbody rb;
    public Vector3 velocity;
    public float xVelocity, zVelocity;

    public LineRenderer line;
    public GameObject dragText;

    private void Update()
    {
        transform.position = rb.position;
        
        velocity = rb.velocity;
        xVelocity = velocity.x;
        zVelocity = velocity.z;
        
        if (xVelocity == 0f && zVelocity == 0f)
        {
            dragText.gameObject.SetActive(true);
            SetAim();
        }
        else
        {
            dragText.gameObject.SetActive(false);
        }
        
    }

    void SetAim()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved)
            {
                line.gameObject.SetActive(true);
                line.SetPosition(0,transform.position);
                line.SetPosition(1,transform.position + transform.forward * 10f);
                rotationY += touch.deltaPosition.x * sensivity;
                transform.rotation = Quaternion.Euler(0f,rotationY,0f);
            }
            if (touch.phase == TouchPhase.Ended)
            {
                line.gameObject.SetActive(false);
                rb.velocity = transform.forward * shootPower;
            }
        }
    }
}
