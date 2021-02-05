using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage1Button()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2Button()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Stage3Button()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void ReturnButton()
    {
        SceneManager.LoadScene("Title");
    }
}
