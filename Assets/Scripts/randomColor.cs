using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    private void Start()
    {
        Spin();
    }

    public void Spin()
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0.25f, 0.75f), Random.Range(0.25f, 0.75f), Random.Range(0.25f, 0.75f));
    }
}
