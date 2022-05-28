using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaidoirokaeru1 : MonoBehaviour
{
    public float  BB, CC;
    public static int AA;


    // Start is called before the first frame update
    void Start()
    {
        AA = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Ki")
        {
            AA = 1;
            GetComponent<Renderer>().material.color = Color.red;
        }

    }
    

}
