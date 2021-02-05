using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    [SerializeField] private GameObject target;//player
    private GameObject StartPoint;

    // Start is called before the first frame update
    void Start()
    {
        StartPoint = GameObject.Find("StartPoint");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {


            // 座標を取得
            Vector3 pos = StartPoint.transform.position;
            Vector3 rot = StartPoint.transform.eulerAngles;


            Destroy(other.gameObject);
                Instantiate(target, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(0.0f, rot.y, 0.0f));
       


        }

    }
}
