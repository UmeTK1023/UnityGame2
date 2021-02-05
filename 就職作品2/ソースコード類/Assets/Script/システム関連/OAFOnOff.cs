using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OAFOnOff : MonoBehaviour
{
    public GameObject OAFCANVAS;

    // Start is called before the first frame update
    void Start()
    {
      OAFCANVAS.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightShift) && OAFCANVAS.activeSelf)
        {
            OAFCANVAS.SetActive(false);
        }
        if(Input.GetKey(KeyCode.Tab) && !OAFCANVAS.activeSelf)
        {
            OAFCANVAS.SetActive(true);
        }
    }
  
}
