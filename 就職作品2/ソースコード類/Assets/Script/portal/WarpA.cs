using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WarpA
public class WarpA : MonoBehaviour
{
 
    [SerializeField] private GameObject Rtarget;//赤ワープブロック
    [SerializeField] private GameObject Wtarget;//白ブロック
    private GameObject B;//Bのブロックがあるか確認

    // Start is called before the first frame update
    void Start()
    {
            B = GameObject.Find("B(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.tag == "aWall")
        {
            if (B) {
                Vector3 Bpos = B.transform.position;

                Vector3 Brot = B.transform.eulerAngles;
                Destroy(B);
                Instantiate(Wtarget, new Vector3(Bpos.x, Bpos.y, Bpos.z), Quaternion.Euler(Brot.x, Brot.y, Brot.z));
            }
            // 座標を取得
            Vector3 pos = other.transform.position;

            Vector3 rot = other.transform.eulerAngles;

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Rtarget, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(rot.x, rot.y, rot.z));
           
        }
        if (other.gameObject.tag == "cWall" )
        {
            if (B) {
                Vector3 Bpos = B.transform.position;

                Vector3 Brot = B.transform.eulerAngles;
                Destroy(B);
                Instantiate(Wtarget, new Vector3(Bpos.x, Bpos.y, Bpos.z), Quaternion.Euler(Brot.x, Brot.y, Brot.z));
            }

            // 座標を取得
            Vector3 pos = other.transform.position;

            Vector3 rot = other.transform.eulerAngles;

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Rtarget, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(rot.x, rot.y, rot.z));
           
        }
    

    }

}
