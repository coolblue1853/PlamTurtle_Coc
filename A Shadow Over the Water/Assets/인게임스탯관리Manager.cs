using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 인게임스탯관리Manager : MonoBehaviour
{



    // Start is called before the first frame update

    public Text 힘텍스트;
    public Text 지능텍스트;
    public Text 민첩텍스트;
    public Text 행운텍스트;

    public Text 활력텍스트;
    public Text 마력텍스트;
    public Text 의지력텍스트;

    public Text 체력텍스트;
    public Text 정신력텍스트;
    public Text 최대스트레스텍스트;
    public Text 현재체력텍스트;
    public Text 현재정신력텍스트;





    public Text 힘스킬배분치txt;
    public Text 지능스킬배분치txt;
    public Text 민첩스킬배분치txt;



    public Text 맨손격투게이지txt;
    public Text 사격술게이지txt;
    public Text 단검술게이지txt;
    public Text 고문술게이지txt;
    public Text 눈썰미게이지txt;

    public Text 언변술협박게이지txt;

    public Text 던지기게이지txt;

    public Text 잠수게이지txt;



    public Text 의학지식게이지txt;

    public Text 정보조사게이지txt;

    public Text 심리판단게이지txt;

    public Text 오컬트지식게이지txt;

    public Text 정신감정게이지txt;

    public Text 언변술설득게이지txt;

    public Text 붕대감기게이지txt;

    public Text 법의학게이지txt;


    public Text 구르기게이지txt;

    public Text 변장술게이지txt;

    public Text 언변술거짓말게이지txt;

    public Text 자물쇠따기게이지txt;

    public Text 손재주게이지txt;

    public Text 은신게이지txt;

    public Text 연기술게이지txt;
 
    public Text 운동신경게이지txt;


    private void Update()
    {
        힘텍스트.text = "힘 : " + DataBaseManager.힘.ToString();//근력표기
        지능텍스트.text = "지능 : " + DataBaseManager.지능.ToString();//근력표기
        민첩텍스트.text = "민첩 : " + DataBaseManager.민첩.ToString();//
        행운텍스트.text = "행운 : " + DataBaseManager.행운.ToString();//

        활력텍스트.text = "활력 : " + DataBaseManager.활력.ToString();//
        마력텍스트.text = "마력 : " + DataBaseManager.마력.ToString();//
        의지력텍스트.text = "의지력 : " + DataBaseManager.의지력.ToString();//
        체력텍스트.text = "체력 : " + DataBaseManager.체력.ToString();//
        정신력텍스트.text = "정신력 : " + DataBaseManager.정신력.ToString();//

        현재체력텍스트.text = "현재 체력 : " + DataBaseManager.현재체력.ToString();//
        현재정신력텍스트.text = "현재 정신력 : " + DataBaseManager.현재정신력.ToString();//

    }



    


}





