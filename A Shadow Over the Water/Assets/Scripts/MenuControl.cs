using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class MenuControl : MonoBehaviour//메인 메뉴 
{
    public GameObject optionObject;

    public void OnclickStart()//게임 스타트 버튼 
    {
        SceneManager.LoadScene("SelectMode");
        Time.timeScale = 1.0f;
       
    }

    public void OnclickStartGameMenu()//최초 게임 메뉴로 돌아가기.
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1.0f;

    }
    public void QuitOption()//최초 게임 메뉴로 돌아가기.
    {
        optionObject.SetActive(false);

    }
    public void goYseTuto()//
    {
        SceneManager.LoadScene("SetCharacter");
        Time.timeScale = 1.0f;

    }
    public void goNoTuto()//
    {
        SceneManager.LoadScene("SetCharacter");
        Time.timeScale = 1.0f;

    }
    public void OnclickStartOption()// 옵션창(소리 조절 등)
    {
        optionObject.SetActive(true);

    }
    public void OnclickStartCollection()// 옵션창(소리 조절 등)
    {
        SceneManager.LoadScene("Collection");
        Time.timeScale = 1.0f;
    }


    public void OnclickQuitBtn()//게임종료 버튼을 누르면 게임 종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
