using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaidokie2Hanteri : MonoBehaviour
{
    public float AA, BB, CC;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
        //離れたオブジェクトのタグが"Cylinder"のとき
        if (other.CompareTag("Cylinder"))
        {
            AA = 1;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(AA == 1)
        {
            if (other.CompareTag("Gaido"))
            {
                Destroy(other.gameObject);
                AA = 0;
            }
        }

    }
}
