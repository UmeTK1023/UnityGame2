using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//花火エフェクトスクリプト
public class Burst : MonoBehaviour
{

    public AudioClip sound;

    private const float DESTORY = 1.0f;//n秒でオブジェクトを削除(全体の軽量化)

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        Invoke("DestoryBurst", DESTORY);
    }

    // Update is called once per frame
    void Update()
    {
   
       
    }
    private void DestoryBurst()
    {
        Destroy(this.gameObject);
    }
}
