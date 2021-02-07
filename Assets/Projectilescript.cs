using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilescript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward*2000);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Scroll")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
