using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//text出力スクリプト
public class ObjectActiveView : MonoBehaviour
{
    private GameObject OAM;

    private ObjectActiveFlag objAct;

    public Text[] targetObj=new Text[ObjectActiveFlag.Num];

    // Start is called before the first frame update
    void Start()
    {
        OAM = GameObject.Find("ObjectActiveManager");
        objAct = OAM.GetComponent<ObjectActiveFlag>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void CheackObj()
    {
         for (int i=0;i<ObjectActiveFlag.Num;i++) {
            if (objAct.objFlag[i])
            {
                targetObj[i].text = objAct.pubobj[i].name + " : " + objAct.objFlag[i];
            }
            if (!objAct.objFlag[i])
            {
                targetObj[i].text = "";
            }
            
        }
    }

}
