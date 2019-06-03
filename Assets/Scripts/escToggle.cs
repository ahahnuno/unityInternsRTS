using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escToggle : MonoBehaviour
{
    RectTransform rt;
    Vector3 og;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
        og = rt.localScale;
    }

    bool hidden = false;
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (!hidden)
            {
                rt.localScale = new Vector3(0f, 0f, 0f);
                hidden = true;
            }
            else
            {
                rt.localScale = og;
                hidden = false;
            }
        }
    }
}
