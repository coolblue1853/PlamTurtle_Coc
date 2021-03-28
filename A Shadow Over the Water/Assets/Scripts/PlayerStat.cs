using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStat : MonoBehaviour
{



    // Start is called before the first frame update

    public Text 근력텍스트;
    public Text 민첩성텍스트;
    public Text 건강텍스트;
    public Text 외모텍스트;
    public Text 정신력텍스트;
    public Text 지능텍스트;
    public Text 크기텍스트;
    public Text 교육텍스트;
    public Text 회피텍스트;
    public Text 체력텍스트;
    public Text 마력텍스트;
    public Text 이성텍스트;
    public Text 행운텍스트;
    public GameObject SevTPer;
    public GameObject sixTPer;
    public GameObject fifTper1;
    public GameObject fifTper2;
    public GameObject forTper1;
    public GameObject forTper2;
    public GameObject forTper3;

    public void OnclickSetStat()// 스탯 생성 버튼
    {
        DataBaseManager.근력 = Random.Range(15, 91);
        DataBaseManager.건강 = Random.Range(15, 91);
        DataBaseManager.민첩성 = Random.Range(15, 91);
        DataBaseManager.외모 = Random.Range(15, 91);
        DataBaseManager.정신력 = Random.Range(15, 91);

        DataBaseManager.크기 = Random.Range(40, 91);
        DataBaseManager.지능 = Random.Range(40, 91);
        DataBaseManager.교육 = Random.Range(40, 91);


        DataBaseManager.체력 = (DataBaseManager.근력 + DataBaseManager.건강) / 10;
        DataBaseManager.마력 = DataBaseManager.정신력 / 5;
        DataBaseManager.이성 = DataBaseManager.정신력;
        DataBaseManager.행운 = Random.Range(40, 91);

        DataBaseManager.회피 = DataBaseManager.민첩성/2;

        if (skillSlotScripts.칠십퍼배정 == 24)
        {
            SevTPer.SetActive(true);
        }

        if (skillSlotScripts.육십퍼배정 == 24)
        {
            sixTPer.SetActive(true);
        }

        if (skillSlotScripts.오십퍼배정이 == 24)
        {
            fifTper2.SetActive(true);
        }

        if (skillSlotScripts.오십퍼배정일 == 24)
        {
            fifTper1.SetActive(true);
        }

        if (skillSlotScripts.사십퍼배정삼 == 24)
        {
            forTper3.SetActive(true);
        }

        if (skillSlotScripts.사십퍼배정이 == 24)
        {
            forTper2.SetActive(true);
        }

        if (skillSlotScripts.사십퍼배정일 == 24)
        {
            forTper1.SetActive(true);
        }

        회피텍스트.text = DataBaseManager.회피.ToString();//근력표기
        근력텍스트.text = "근력 : " + DataBaseManager.근력.ToString();//근력표기
        민첩성텍스트.text = "민첩성 : " + DataBaseManager.민첩성.ToString();//
        건강텍스트.text = "건강 : " + DataBaseManager.건강.ToString();//
        외모텍스트.text = "외모 : " + DataBaseManager.외모.ToString();//
        정신력텍스트.text = "정신력 : " + DataBaseManager.정신력.ToString();//
        지능텍스트.text = "지능 : " + DataBaseManager.지능.ToString();//
        크기텍스트.text = "크기 : " + DataBaseManager.크기.ToString();//
        교육텍스트.text = "교육 : " + DataBaseManager.교육.ToString();//

        체력텍스트.text = "체력 : " + DataBaseManager.체력.ToString();//
        마력텍스트.text = "마력 : " + DataBaseManager.마력.ToString();//
        이성텍스트.text = "이성 : " + DataBaseManager.이성.ToString();//
        행운텍스트.text = "행운 : " + DataBaseManager.행운.ToString();//

    }

    public void goNext()// 스탯 생성 버튼
    {
        SceneManager.LoadScene("START_OPEN");
        Time.timeScale = 1.0f;
    }
    public void goMenu()// 스탯 생성 버튼
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1.0f;
    }

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }



}





