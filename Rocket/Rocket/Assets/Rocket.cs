using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float rocketTrust;
    public float rotationforce;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            rocketTrust = 10000;
            rigidBody.AddRelativeForce(new Vector3(0, rocketTrust, 0) * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            rotationforce = 1000;
            rigidBody.AddTorque(new Vector3(0, 0, rotationforce) * Time.deltaTime);
        }
    }
}
