using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    private GameObject head;

    void Start()
    {
        head = GameObject.FindGameObjectWithTag("head");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ThrowObject(float force){
        rb.AddForce(head.transform.forward * force, ForceMode.Impulse);
    }
}
