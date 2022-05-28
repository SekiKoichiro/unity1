using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaidodasu : MonoBehaviour
{
    // Start is called before the first frame update

    public float AA, X1, X2,X3,Z1,Z2,Z3;
    public GameObject Gaido;
    

     void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.tag == "Hantei1")
        {          
                X1 = other.gameObject.transform.position.x;
                Z1 = other.gameObject.transform.position.z;
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
                Instantiate(Gaido, new Vector3(X1 + 3f, 0, Z1), Quaternion.Euler(0, 90, 0));  ///横
        }

        if (other.gameObject.tag == "Hantei2")
        {
            X1 = other.gameObject.transform.position.x;
            Z1 = other.gameObject.transform.position.z;
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            Instantiate(Gaido, new Vector3(X1 -3f, 0, Z1), Quaternion.Euler(0, 90, 0));  ///横
        }

        if (other.gameObject.tag == "Hantei3")
        {
            X1 = other.gameObject.transform.position.x;
            Z1 = other.gameObject.transform.position.z;
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            Instantiate(Gaido, new Vector3(X1, 0, Z1 + 3f), Quaternion.Euler(0, 0, 0));  //縦
        }

        if (other.gameObject.tag == "Hantei4")
        {
            X1 = other.gameObject.transform.position.x;
            Z1 = other.gameObject.transform.position.z;
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            Instantiate(Gaido, new Vector3(X1, 0, Z1 - 3f), Quaternion.Euler(0, 0, 0));  //
        }


    }















    /////////last/////////
}


