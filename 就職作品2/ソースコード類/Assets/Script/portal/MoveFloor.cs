using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private Rigidbody rigid;
    private int count;
    private int z;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        count = 0;
        z = 3;

    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
       
        rigid.velocity = (new Vector3(0, 0, z));
        if (count >= 1000 && this.transform.position.z >= 6.0f)
        {
            count = 0;
            z *= -1;
        }
        else if (count >= 1000 && this.transform.position.z < -9.0f)
        {
            count = 0;
            z *= -1;
        }
    }
}
