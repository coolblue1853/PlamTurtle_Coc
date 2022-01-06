using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1의뢰자의집 : MonoBehaviour
{


    //멜리사 대사

    public GameObject 엘라_1일차낮_연출대사;

    public GameObject 엘라_1일차낮_반복대사1;
    public GameObject 엘라_1일차낮_반복대사2;
    public GameObject 엘라_1일차낮_에이든1키워드;
    public GameObject 엘라_1일차낮_모르는키워드;

    public GameObject 에이든_1일차낮_최초대사;
    public GameObject 에이든_1일차낮_반복대사1;
    public GameObject 에이든_1일차낮_반복대사2;
    public GameObject 에이든_1일차낮_키워드악몽1;
    public GameObject 에이든_1일차낮_의학기능;
    public GameObject 에이든_1일차낮_의학기능실패;
    public GameObject 에이든_1일차낮_정신분석기능;
    public GameObject 에이든_1일차낮_정신분석기능실패;
    public GameObject 에이든최초대화후독백;
    public GameObject 에이든최초대화후엘라대화;



    //1 심리학판정 성공
    public GameObject 알버트심리학성공;
    public GameObject 알버트심리학실패;
    public GameObject 알버트심리학대성공;
    public GameObject 알버트심리학대실패;

    public GameObject 알버트_1일차낮_불면증1;


    // Start is called before the first frame update

    public DialogManager_D1의뢰자의집 theDM;
    public DialogManager_D1의뢰자의집 기능판정DM;


    // Update is called once per frame

    void Start()
    {

    }
    void Update()
    {

    }
    public void 엘라_1일차낮_연출대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(엘라_1일차낮_연출대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 엘라_1일차낮_반복대화1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(엘라_1일차낮_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 엘라_1일차낮_반복대화2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(엘라_1일차낮_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 엘라_1일차낮_에이든1키워드대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(엘라_1일차낮_에이든1키워드.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 엘라_1일차낮_모르는키워드대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(엘라_1일차낮_모르는키워드.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 에이든_1일차낮_최초대화()
    {
        DataBaseManager.에이든1일차최초대화완료여부 = true;
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든_1일차낮_반복대화1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든_1일차낮_반복대화2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 에이든_1일차낮_키워드악몽대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_키워드악몽1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든_1일차낮_의학기능대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_의학기능.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든_1일차낮_의학기능실패대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_의학기능실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든_1일차낮_정신분석대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_정신분석기능.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든_1일차낮_정신분석실패대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든_1일차낮_정신분석기능실패  .transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 노아독백()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든최초대화후독백.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 에이든대화후엘라최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(에이든최초대화후엘라대화.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    /*
    public void 경찰관1_1일차낮_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관1_1일차낮_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 경찰관1_1일차낮_반복대화1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관1_1일차낮_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 경찰관1_1일차낮_반복대화2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관1_1일차낮_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 경찰관1_1일차낮_반복대화3()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관1_1일차낮_반복대사3.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    //경찰관B
    public void 경찰관2_1일차낮_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관2_1일차낮_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 경찰관2_1일차낮_반복대화1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관2_1일차낮_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 경찰관2_1일차낮_반복대화2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관2_1일차낮_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 경찰관2_1일차낮_반복대화3()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(경찰관2_1일차낮_반복대사3.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }


    //알버트 대사들
    public void 알버트_1일차낮_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(알버트_1일차낮_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 알버트_1일차낮_반복대화1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(알버트_1일차낮_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 알버트_1일차낮_반복대화2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(알버트_1일차낮_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    //이하 기능판정, 중간삽입물.


    public void 알버트심리학성공출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(알버트심리학성공.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 알버트심리학실패출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(알버트심리학실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 알버트심리학대실패출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(알버트심리학대실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 알버트심리학대성공출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(알버트심리학대성공.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }


    // 알버트 키워드

    public void 알버트_행성대직렬_키워드()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.isDialogON = true;
            theDM.ShowDialog(알버트_1일차낮_행성대직렬1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 알버트_불면증_키워드()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.isDialogON = true;
            theDM.ShowDialog(알버트_1일차낮_불면증1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 알버트_실종사건_키워드()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.isDialogON = true;
            theDM.ShowDialog(알버트_1일차낮_실종사건1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 잘모르는키워드()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.isDialogON = true;
            theDM.ShowDialog(알버트_1일차낮_잘모름.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    */



}
