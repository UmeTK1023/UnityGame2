using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cスクリプト
public class C : MonoBehaviour
{
    [SerializeField] private GameObject target;//player


    public GameObject wallB;//オブジェクトの箱
     private GameObject P1;//playerをわかせる場所
    public bool BWallFlag;//オブジェクト存在フラグ
    [SerializeField]
    private string Tags;//Tagの箱

    // Start is called before the first frame update
    void Start()
    {
        BWallFlag = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        P1 = GameObject.Find("PPos1");

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            wallB = GameObject.FindGameObjectWithTag(Tags);
            if (wallB)
            {
             

                // 座標を取得
                Vector3 pos = P1.transform.position;
                Vector3 rot = P1.transform.eulerAngles;

                
              
                Destroy(other.gameObject);
                Instantiate(target, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(0.0f, rot.y, 0.0f));
            }


        }
    }
   
}   
