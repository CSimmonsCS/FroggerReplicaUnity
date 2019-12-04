using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 2f;
    public float maxSpeed = 8f;

    public GameObject car;

    float speed = 1f;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        //transform.right
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);

        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);//moves the car to the right


        Debug.Log(car.transform.position.x);
        if (car.transform.position.x >= 15 || car.transform.position.x <= -15)
        {
            Destroy(car);
        }
    }
}
