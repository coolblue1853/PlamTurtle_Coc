using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterctionController_D1사무소 : MonoBehaviour
{
    //public GameObject 선1예;
    //public GameObject 선1아니오;
    public GameObject 엘라;
    public GameObject 독백;
    public GameObject 선택지1성공;
    public GameObject 선택지1실패;

    public GameObject 선택1커피줘;
    public GameObject 선택1직접타기;
    public GameObject 선택1가만히있기;

    //1 심리학판정 성공
    public GameObject 일일_오전_엘라_심리학실패;
    public GameObject 일일_오전_엘라_심리학성공;
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
            기능판정DM.ShowDialog(일일_오전_엘라_심리학성공.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }
    public void 엘라심리학실패출력대사()
    {

        if (기능판정DM.isDialogON == false)
        {
            theDM.isDialogON = true;
            기능판정DM.isDialogON = true;
            기능판정DM.ShowDialog(일일_오전_엘라_심리학실패.transform.GetComponent<interactionEvent>().GetDialogs());

        }
    }


}
