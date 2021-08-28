using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1사무소 : MonoBehaviour
{
    //public GameObject 선1예;
    //public GameObject 선1아니오;
    public GameObject 엘라;
    public GameObject 독백;
    public GameObject 의뢰자등장후;
    public GameObject 의뢰자앉은후;
    public GameObject 의뢰자나간후;

    public GameObject 신문살펴보기;


    public GameObject 선택지1성공;
    public GameObject 선택지1실패;

    public GameObject 선택1커피줘;
    public GameObject 선택1직접타기;
    public GameObject 선택1가만히있기;


    public GameObject 선택2_1오브젝트;
    public GameObject 선택2_2오브젝트;
    public GameObject 선택2_3오브젝트;

    public GameObject 선택3_거절_심리X;
    public GameObject 선택3_거절_심리O;
    public GameObject 선택3_거절_선택1에1선택;
    public GameObject 선택3_수락;
    public GameObject 선택3_수락_선택1에1선택;


    public GameObject 선1이후;




    //1 심리학판정 성공
    public GameObject 엘라심리학성공;
    public GameObject 엘라심리학실패;
    // Start is called before the first frame update

    public DialogManager_D1사무소 theDM;
    public DialogManager_D1사무소 기능판정DM;


    // Update is called once per frame

    void Start()
    {
        StartCoroutine(startNaertion());
    }
    void Update()
    {

    }



    public void 의뢰자등장후대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(의뢰자등장후.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 의뢰자앉은후대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(의뢰자앉은후.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 의뢰자나간후대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(의뢰자나간후.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 신문살펴보기대화()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(신문살펴보기.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    // ////////////////////////////////////////////////









    public void 선1커피타줘()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
 
            theDM.ShowDialog(선택1커피줘.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 선1커피직접타기()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(선택1직접타기.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 선1가만히있기()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(선택1가만히있기.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 선1이후연결()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(선1이후.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }




    // 2번째 선택지
    public void 선2_1()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(선택2_1오브젝트.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 선2_2()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(선택2_2오브젝트.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }

    public void 선2_3()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;

            theDM.ShowDialog(선택2_3오브젝트.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }



    //의뢰 수락 OR 거절


    public void 선3_의뢰거절()
    {
        if (DataBaseManager.선택1_3가만히있기를했는가 == true)
        {
            if (theDM.isDialogON == false)
            {
                theDM.isDialogON = true;

                theDM.ShowDialog(선택3_거절_선택1에1선택.transform.GetComponent<interactionEvent>().GetDialogs());

            }
        }
        else if (DataBaseManager._1일차오전심리학판정성공여부 == true)
        {
            if (theDM.isDialogON == false)
            {
                theDM.isDialogON = true;

                theDM.ShowDialog(선택3_거절_심리O.transform.GetComponent<interactionEvent>().GetDialogs());

            }
        }
        else
        {
            if (theDM.isDialogON == false)
            {
                theDM.isDialogON = true;

                theDM.ShowDialog(선택3_거절_심리X.transform.GetComponent<interactionEvent>().GetDialogs());

            }
        }



    }

    public void 선3_의뢰수락()
    {
        if (DataBaseManager.선택1_3가만히있기를했는가 == true)
        {
            if (theDM.isDialogON == false)
            {
                theDM.isDialogON = true;

                theDM.ShowDialog(선택3_수락_선택1에1선택.transform.GetComponent<interactionEvent>().GetDialogs());

            }
        }
        else
        {
            if (theDM.isDialogON == false)
            {
                theDM.isDialogON = true;

                theDM.ShowDialog(선택3_수락.transform.GetComponent<interactionEvent>().GetDialogs());

            }
        }


    }













    //참고이후 삭제


    public void 선1예선택()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.isDialogON = true;
           // theDM.ShowDialog(선1예.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 선1아니오선택()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.isDialogON = true;
           // theDM.ShowDialog(선1아니오.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    IEnumerator startNaertion()
    {
        yield return new WaitForSeconds(1f);

        theDM.ShowDialog(독백.transform.GetComponent<interactionEvent>().GetDialogs());
    }

    public void checkObject()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(엘라.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }


    public void 선택지1성공출력대사()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(선택지1성공.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 선택지1실패출력대사()
    {

        if (theDM.isDialogON == false)
        {
            theDM.isDialogON = true;
            theDM.ShowDialog(선택지1실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }





    //이하 기능판정, 중간삽입물.


    public void 엘라심리학성공출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(엘라심리학성공.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 엘라심리학실패출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(엘라심리학실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }


}
