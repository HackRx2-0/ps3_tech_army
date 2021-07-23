using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatCamera : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
        //transform.LookAt(this.transform.position - Camera.main.transform.position);
        //transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
    }
}
