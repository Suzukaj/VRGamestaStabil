using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGunScript : MonoBehaviour
{
    public Transform GunTip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("LeftHandTrigger")!=0 || Input.GetAxis("RightHandTrigger")!=0){

        }
        Instantiate(Resources.Load("projectile"), GunTip.position, GunTip.rotation);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            transform.parent = other.transform;
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
        }
    }
}
