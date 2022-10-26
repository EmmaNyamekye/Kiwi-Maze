using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody ourRigidbody;  
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
        ourRigidbody.AddForce(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            ourRigidbody.AddForce(Vector3.back);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidbody.AddForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ourRigidbody.AddForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ourRigidbody.AddForce(Vector3.right);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(1000,transform.position+ Vector3.down+ Vector3.back,2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }

}
