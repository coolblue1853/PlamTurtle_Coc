using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1병원 : MonoBehaviour
{

    /*
    //

    public GameObject 경찰관1_1일차낮_최초대사;
    public GameObject 경찰관1_1일차낮_반복대사1;
    public GameObject 경찰관1_1일차낮_반복대사2;
    public GameObject 경찰관1_1일차낮_반복대사3;

    public GameObject 경찰관2_1일차낮_최초대사;
    public GameObject 경찰관2_1일차낮_반복대사1;
    public GameObject 경찰관2_1일차낮_반복대사2;
    public GameObject 경찰관2_1일차낮_반복대사3;

    public GameObject 알버트_1일차낮_최초대사;
    public GameObject 알버트_1일차낮_반복대사1;
    public GameObject 알버트_1일차낮_반복대사2;

    //1 심리학판정 성공
    public GameObject 알버트심리학성공;
    public GameObject 알버트심리학실패;
    public GameObject 알버트심리학대성공;
    public GameObject 알버트심리학대실패;

    public GameObject 알버트_1일차낮_불면증1;
    public GameObject 알버트_1일차낮_행성대직렬1;
    public GameObject 알버트_1일차낮_실종사건1;
    public GameObject 알버트_1일차낮_잘모름;
    */
    // Start is called before the first frame update
    public GameObject 환자1_1일차낮_최초대사;
    public GameObject 환자1_1일차낮_반복대사1;
    public GameObject 환자1_1일차낮_반복대사2;

    public GameObject 환자1_1일차낮_악몽1;
    public GameObject 환자1_1일차낮_불면증1;
    public GameObject 환자1_1일차낮_병원1;
    public GameObject 환자1_1일차낮_잘모름;

    public GameObject 의사1_1일차낮_최초;
    public GameObject 의사1_1일차낮_반복;


    public GameObject 의사1_1일차저녁_최초;
    public GameObject 의사1_1일차저녁_반복;
    public GameObject 의사1_1일차저녁_반복2;
    public GameObject 의사1_1일차저녁_편집증키워드;
    public GameObject 의사1_1일차저녁_불면증키워드;
    public GameObject 의사1_1일차저녁_비릿한냄새키워드;
    public GameObject 의사1_1일차저녁_그외키워드;

    public GameObject 간호사1_1일차저녁_최초;
    public GameObject 간호사1_1일차저녁_반복;
    public GameObject 간호사1_1일차저녁_반복2;
    public GameObject 간호사1_1일차저녁_편집증키워드;
    public GameObject 간호사1_1일차저녁_불면증키워드;
    public GameObject 간호사1_1일차저녁_비릿한냄새키워드;
    public GameObject 간호사1_1일차저녁_그외키워드;

    public GameObject 간호사1_1일차낮_최초;
    public GameObject 간호사1_1일차낮_반복1;
    public GameObject 간호사1_1일차낮_반복2;

    public DialogManager_D1병원 theDM;
    public DialogManager_D1병원 기능판정DM;


    // Update is called once per frame

    void Start()
    {

    }
    void Update()
    {

    }
    public void 환자1_1일차낮_최초대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_최초대사.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }

    public void 환자1_1일차낮_반복대화1()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_반복대사1.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 환자1_1일차낮_반복대화2()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_반복대사2.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }

    public void 환자1_1일차낮_악몽1대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_악몽1.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 환자1_1일차낮_불면증1대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_불면증1.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 환자1_1일차낮_병원1대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_병원1.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 환자1_1일차낮_잘모름대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(환자1_1일차낮_잘모름.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차낮_최초대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차낮_최초.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차낮_반복대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차낮_반복.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }


    //의사 저녁
    public void 의사1_1일차저녁_최초대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_최초.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차저녁_반복대화1()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_반복.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차저녁_반복대화2()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_반복2.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차저녁_편집증키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_편집증키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차저녁_불면증키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_불면증키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차저녁_비릿한냄새키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_비릿한냄새키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 의사1_1일차저녁_그외키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(의사1_1일차저녁_그외키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }





    //간호사

    public void 간호사1_1일차낮_최초대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차낮_최초.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }

    public void 간호사1_1일차낮_반복대화1()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차낮_반복1.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차낮_반복대화2()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차낮_반복2.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }

    //간호사 저녁
    public void 간호사1_1일차저녁_최초대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_최초.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차저녁_반복대화1()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_반복.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차저녁_반복대화2()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_반복2.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차저녁_편집증키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_편집증키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차저녁_불면증키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_불면증키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차저녁_비릿한냄새키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_비릿한냄새키워드.transform.GetComponent<interactionEvent>().GetDialogs());
        }
    }
    public void 간호사1_1일차저녁_그외키워드대화()
    {
        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(간호사1_1일차저녁_그외키워드.transform.GetComponent<interactionEvent>().GetDialogs());
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
