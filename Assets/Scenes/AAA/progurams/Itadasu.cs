using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itadasu : MonoBehaviour
{
    public float AA, BB, CC, DD,FF, X1, Z1;
    public GameObject Ki;


    // Start is called before the first frame update
    void Start()
    {
        BB = 1;

    }

    // Update is called once per frame
    void Update()
    {
        DD = Gaidoirokaeru1.AA;

    }

    void OnTriggerStay(Collider other)
    {

        if (BB == 1)
        {

            if (other.gameObject.tag == "Hantei1")
            {
                X1 = other.gameObject.transform.position.x;
                Z1 = other.gameObject.transform.position.z;

                //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓

                if (DD != 1)///////ガイドが青色なら
                {
                    if (Input.GetMouseButton(0))//////ボタン押したら板出す
                    {
                        Instantiate(Ki, new Vector3(X1 + 3f, 0, Z1), Quaternion.Euler(0, 90, 0));  ///横
                        CC = 2;
                    }
                }
            }

            if (other.gameObject.tag == "Hantei2")
            {
                X1 = other.gameObject.transform.position.x;
                Z1 = other.gameObject.transform.position.z;

                //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
                if (DD != 1)///////ガイドが青色なら
                {
                    if (Input.GetMouseButton(0))
                    {
                        Instantiate(Ki, new Vector3(X1 - 3f, 0, Z1), Quaternion.Euler(0, 90, 0));  ///横
                    }
                }


            }

            if (other.gameObject.tag == "Hantei3")
            {
                X1 = other.gameObject.transform.position.x;
                Z1 = other.gameObject.transform.position.z;

                if (DD != 1)///////ガイドが青色なら
                {
                    //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
                    if (Input.GetMouseButton(0))
                    {
                        Instantiate(Ki, new Vector3(X1, 0, Z1 + 3f), Quaternion.Euler(0, 0, 0));  ///縦
                    }
                }
            }

            if (other.gameObject.tag == "Hantei4")
            {
                X1 = other.gameObject.transform.position.x;
                Z1 = other.gameObject.transform.position.z;
                //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓

                if (DD != 1)///////ガイドが青色なら
                {
                    if (Input.GetMouseButton(0))
                    {
                        Instantiate(Ki, new Vector3(X1, 0, Z1 - 3f), Quaternion.Euler(0, 0, 0));  ///縦
                    }
                }
            }

        }
    }




}

