using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    private GameObject mainCamera;      //メインカメラ格納用

    public Transform verRot;
    public Transform horRot;
    //呼び出し時に実行される関数
    void Start()
    {
        //メインカメラとサブカメラをそれぞれ取得
        mainCamera = GameObject.Find("MainCamera");


        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }


    //単位時間ごとに実行される関数
    void Update()
    {

        rotateCamera();
    }
    //カメラを回転させる関数
    private void rotateCamera()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation*5, 0);
        horRot.transform.Rotate(-Y_Rotation*5, 0, 0);
    }
}
