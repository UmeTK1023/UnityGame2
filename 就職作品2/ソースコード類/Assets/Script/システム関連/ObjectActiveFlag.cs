using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

//オブジェクトが存在するか確認するためのオブジェクトを入れる箱　ObjectActiveManagerにアタッチ
public class ObjectActiveFlag : MonoBehaviour
{
    public static int Num = 5;//オブジェクト数
    public int RefNum = Num;//別スクリプトでの参照用変数

    public GameObject[] pubobj = new GameObject[Num];//オブジェクトの箱
    public bool[] objFlag = new bool[Num];//オブジェクト存在フラグ
    [SerializeField]
    private string[] Tags =new string[Num];//Tagの箱

    // Start is called before the first frame update
    void Start()
    {
        
        for (int f=0;f<Num;f++)//フラグ初期化
        {
            objFlag[f] = false;
        }
    }

    // Update is called once per frame
    void Update()//Updateで回しているので重くなりそう　要改善
    {
        ObjSearch();
    }

    void ObjSearch()
    {
        for (int i = 0; i < Num; i++)
        {

            pubobj[i] = GameObject.FindGameObjectWithTag(Tags[i]);//Tagでオブジェクトを検索して場にそのオブジェクトがあるかを確認する
            if (pubobj[i])//オブジェクトが見つかったときにフラグをtrueに
            {
                objFlag[i] = true;
            }
            if (!pubobj[i])//オブジェクトが見つからないときにフラグをfalseに
            {
                objFlag[i] = false;
            }
        }
    }
}
