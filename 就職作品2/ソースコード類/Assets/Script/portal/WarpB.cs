using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WarpB
public class WarpB : MonoBehaviour
{

    [SerializeField] private GameObject Btarget;//青ワープブロック

    [SerializeField] private GameObject Wtarget;//白ブロック
    private GameObject C;//Cのブロックがあるか確認

    // Start is called before the first frame update
    void Start()
    {
        C = GameObject.Find("C(Clone)");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "aWall")
        {
            if (C) {
                Vector3 Cpos = C.transform.position;

                Vector3 Crot = C.transform.eulerAngles;
                Destroy(C);
                Instantiate(Wtarget, new Vector3(Cpos.x, Cpos.y, Cpos.z), Quaternion.Euler(Crot.x, Crot.y, Crot.z));
            }
            // 座標を取得
            Vector3 pos = other.transform.position;

            Vector3 rot = other.transform.eulerAngles;

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Btarget, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(rot.x, rot.y, rot.z));

        }
        if (other.gameObject.tag == "bWall")
        {
            if (C)
            {
                Vector3 Cpos = C.transform.position;

                Vector3 Crot = C.transform.eulerAngles;
                Destroy(C);
                Instantiate(Wtarget, new Vector3(Cpos.x, Cpos.y, Cpos.z), Quaternion.Euler(Crot.x, Crot.y, Crot.z));
            }
            // 座標を取得
            Vector3 pos = other.transform.position;

            Vector3 rot = other.transform.eulerAngles;

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Btarget, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(rot.x, rot.y, rot.z));
        
        }

    }
    }
