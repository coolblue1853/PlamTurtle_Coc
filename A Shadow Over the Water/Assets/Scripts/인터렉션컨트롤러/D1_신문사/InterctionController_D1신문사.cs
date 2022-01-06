using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1신문사 : MonoBehaviour
{


    //멜리사 대사

    public GameObject 스탠리_1일차_최초대사;
    public GameObject 스탠리_1일차_이름얻기전반복1;
    public GameObject 스탠리_1일차_이름얻기전반복2;
    public GameObject 스탠리_1일차_기능판정언변술;
    public GameObject 스탠리_1일차_에이든키워드;
    public GameObject 스탠리_1일차_엘라키워드;
    public GameObject 스탠리_1일차_악몽키워드;
    public GameObject 스탠리_1일차_행성대직렬키워드;
    public GameObject 스탠리_1일차_심리학기능;
    public GameObject 스탠리_1일차_이름얻고반복1;
    public GameObject 스탠리_1일차_이름얻고반복2;

    public GameObject 스탠리_1일차_언변술실패;
    public GameObject 스탠리_1일차_심리학실패;

    public DialogManager_D1신문사 theDM;
    public DialogManager_D1신문사 기능판정DM;


    // Update is called once per frame

    void Start()
    {

    }
    void Update()
    {

    }
    public void 스탠리_1일차_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_이름얻기전반복대화1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_이름얻기전반복1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_이름얻기전반복대화2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_이름얻기전반복2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_기능판정언변술대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_기능판정언변술.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_에이든키워드대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_에이든키워드.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_엘라키워드대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_엘라키워드.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_악몽키워드대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_악몽키워드.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_행성대직렬키워드대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_행성대직렬키워드.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_심리학기능대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_심리학기능.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_이름얻고반복1대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_이름얻고반복1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_이름얻고반복2대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_이름얻고반복2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }


    public void 스탠리_1일차_언변술실패대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_언변술실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 스탠리_1일차_심리학실패대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(스탠리_1일차_심리학실패.transform.GetComponent<interactionEvent>().GetDialogs());

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
