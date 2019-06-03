using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
	
	void Update ()
    {
        transform.Translate(transform.right * Input.GetAxis("Horizontal"));

        transform.Translate(transform.up * Input.GetAxis("Vertical"));
    }
}
