using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bスクリプト
public class B : MonoBehaviour
{
    [SerializeField] private GameObject target;//player
  

    public GameObject wallC;//オブジェクトの箱
   
    public bool CWallFlag;//オブジェクト存在フラグ
 private GameObject P2;
    [SerializeField]
    private string Tags;//Tagの箱

    // Start is called before the first frame update
    void Start()
    {
        CWallFlag = false;
     
    }

    // Update is called once per frame
    void Update()
    {
           P2 = GameObject.Find("PPos2");
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            wallC = GameObject.FindGameObjectWithTag(Tags);
            if (wallC)
            {

                // 座標を取得
               Vector3 pos = P2.transform.position;
                Vector3 rot = P2.transform.eulerAngles;

            
                Destroy(other.gameObject);
                Instantiate(target, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(0.0f, rot.y, 0.0f));
            }
          
           
        }

    }
   
}
