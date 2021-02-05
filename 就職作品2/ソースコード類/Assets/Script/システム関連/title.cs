using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//タイトル画面スクリプト　ステージ選択画面に遷移
public class title : MonoBehaviour
{

	public void OnClickStartButton()
	{
		SceneManager.LoadScene("Stage1");
	}
    public void OnClickSelectStageButton()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void OnClickEndButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#else
		Application.Quit();
#endif
    }
}
