using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1경찰서 : MonoBehaviour
{


    //멜리사 대사

    public GameObject 경찰관1_1일차낮_최초대사;
    public GameObject 경찰관1_1일차낮_반복대사1;
    public GameObject 경찰관1_1일차낮_반복대사2;
    public GameObject 경찰관1_1일차낮_반복대사3;
  



    //1 심리학판정 성공
    public GameObject 엘라심리학성공;
    public GameObject 엘라심리학실패;
    // Start is called before the first frame update

    public DialogManager_D1경찰서 theDM;
    public DialogManager_D1경찰서 기능판정DM;


    // Update is called once per frame

    void Start()
    {

    }
    void Update()
    {

    }

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
