using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//goalオブジェクトに触れたときにクリア画面に遷移するスクリプト
public class GameClear : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage1")
        {
           
            Destroy(other.gameObject);
            SceneManager.LoadScene("Stage2");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage2")
        {
      
            Destroy(other.gameObject);
            SceneManager.LoadScene("Stage3");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage3")
        {
        
            Destroy(other.gameObject);
            SceneManager.LoadScene("Title");

        }
    }
    
    
}
