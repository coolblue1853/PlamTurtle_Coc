using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1바 : MonoBehaviour
{


    //멜리사 대사

    public GameObject 노동자a_1일차밤_최초대사;
    public GameObject 노동자a_1일차밤_반복대사;

    public GameObject 노동자b_1일차밤_최초대사;
    public GameObject 노동자b_1일차밤_반복대사;

    public GameObject 맥캔리_1일차밤_최초대사;
    public GameObject 맥캔리_1일차밤_반복대사1;
    public GameObject 맥캔리_1일차밤_반복대사2;
    public GameObject 맥캔리_1일차밤_에이든;
    public GameObject 맥캔리_1일차밤_비릿한냄새;
    public GameObject 맥캔리_1일차밤_부당해고;
    public GameObject 맥캔리_1일차밤_실종;
    public GameObject 맥캔리_1일차밤_그외키워드;
    //1 심리학판정 성공
    public GameObject 알버트심리학성공;
    public GameObject 알버트심리학실패;
    public GameObject 알버트심리학대성공;
    public GameObject 알버트심리학대실패;

    public GameObject 알버트_1일차낮_불면증1;


    // Start is called before the first frame update

    public DialogManager_D1바 theDM;
    public DialogManager_D1바 기능판정DM;


    // Update is called once per frame

    void Start()
    {

    }
    void Update()
    {

    }
    public void 노동자a_1일차밤_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(노동자a_1일차밤_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 노동자a_1일차밤_반복대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(노동자a_1일차밤_반복대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 노동자b_1일차밤_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(노동자b_1일차밤_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 노동자b_1일차밤_반복대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(노동자b_1일차밤_반복대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 맥캔리_1일차밤_최초대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 맥캔리_1일차밤_반복1대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 맥캔리_1일차밤_반복2대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 맥캔리_1일차밤_부당해고대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_부당해고.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 맥캔리_1일차밤_에이든대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_에이든.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 맥캔리_1일차밤_실종대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_실종.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 맥캔리_1일차밤_비릿한냄새대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_비릿한냄새.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 맥캔리_1일차밤_그외대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(맥캔리_1일차밤_그외키워드.transform.GetComponent<interactionEvent>().GetDialogs());

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
