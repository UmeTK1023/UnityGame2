using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject WarpABPrefab;
    [SerializeField]
    private GameObject WarpBBPrefab;
    //[SerializeField]
    //private GameObject WarpCBPrefab;
    [SerializeField]
    private Transform muzzlePoint;
    [SerializeField]
    private float shotSpeed;

    private GameObject bFlag;
    private PBulletManager bflag;

    // Start is called before the first frame update
    void Start()
    {
        bFlag = GameObject.Find("PBulletManager");
        bflag = bFlag.GetComponent<PBulletManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (bflag.WarpBulletF==0) {

                ShotA();
                bflag.WarpBulletF +=1;
            }
           else if (bflag.WarpBulletF==1)
            {

                ShotB();
                bflag.WarpBulletF = 0;
            }
            //else if (bflag.WarpBulletF == 2)
            //{

            //    ShotC();
            //    bflag.WarpBulletF = 0;
            //}

        }
    }
    public void ShotA()
    {
        GameObject bullet = GameObject.Instantiate(WarpABPrefab, muzzlePoint.position, muzzlePoint.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * shotSpeed);
    }
    public void ShotB()
    {
        GameObject bullet = GameObject.Instantiate(WarpBBPrefab, muzzlePoint.position, muzzlePoint.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * shotSpeed);
    }
    //public void ShotC()
    //{
    //    GameObject bullet = GameObject.Instantiate(WarpCBPrefab, muzzlePoint.position, muzzlePoint.rotation) as GameObject;
    //    bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * shotSpeed);
    //}
}
