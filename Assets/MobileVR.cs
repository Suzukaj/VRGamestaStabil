using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileVR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit)&& hit.collider.tag=="Scroll")
        {
            Destroy(hit.collider.gameObject);
        }
    }

}
