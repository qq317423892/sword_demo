using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
           
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other != null)
        {
            Debug.Log(">>>>>>>>>>> OnTriggerStay" + other.ToString());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            Debug.Log(">>>>>>>>>>> OnTriggerExit" + other.ToString());
        }
    }
}

