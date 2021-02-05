using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//花火エフェクトを生成させるスクリプト
public class Seisei : MonoBehaviour
{
    public GameObject target;
    private const float START_SOUND = 0.0f;//SE起動時間
    private const float INTERVA_SOUND = 0.5f;//n秒ごとにSE再生
   

    // Use this for initialization     
    void Start ()     {

        InvokeRepeating("burst", START_SOUND, INTERVA_SOUND);

    }
    // Update is called once per frame    
    void Update ()     {
    }

    private void burst()
    {
        Instantiate(target, new Vector3(Random.Range(-40.0f, 40.0f),Random.Range(20.0f, 45.0f), 5.5f), Quaternion.identity);
    }
  
}
