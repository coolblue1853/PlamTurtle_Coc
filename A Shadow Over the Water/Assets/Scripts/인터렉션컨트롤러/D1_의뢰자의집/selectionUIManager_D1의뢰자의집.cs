using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selectionUIManager_D1의뢰자의집 : MonoBehaviour
{
    public DialogManager_D1의뢰자의집 theDM;
    public SoundManager 배틀사운드매니저;
    public DialogManager_D1의뢰자의집 dialogManager;
    public GameObject 첫번째_선택지_커피타줘버튼;
    public GameObject 첫번째_선택지_직접타기버튼;
    public GameObject 첫번째_선택지_가만히버튼;

    public GameObject 두번째_선택지_1;
    public GameObject 두번째_선택지_2;
    public GameObject 두번째_선택지_3;

    public GameObject 세번째_선택지_거절;
    public GameObject 세번째_선택지_수락;



    bool 엘라심리학실시여부 = false;


    public GameObject 엘라심리학선택지버튼;
    public Text 엘라심리학선택지텍스트;
    public Text 판정결과;
    public InterctionController_D1의뢰자의집 interctionController;
    public rollet 룰렛머신;

    public Text 십의자리;
    public Text 일의자리;

    public GameObject 십의자리몸통;
    public GameObject 일의자리몸통;
    public GameObject 룰렛머신온오프;

    int 랜덤십의자리;
    int 랜덤일의자리;

    int 랜덤십의몸통위치;
    public static int 출력기능값;

    public void 대화중기능판정버튼제거()
    {
        //엘라심리학선택지버튼.SetActive(false);
    }
    bool 기능사용안하고넘기기 = false;
    int 일번선택지합쳐지는파트 = 0;
    int 출력기능수치;

    public void 일번선택지넘기기()
    {
        일번선택지합쳐지는파트 = 1;
    }

    void Update()
    {
        if (룰렛활성여부 == true && Input.GetMouseButtonDown(0))
        {
            전투클릭여부 = true;
            배틀사운드매니저.효과음멈춤();
        }


        if (일번선택지합쳐지는파트 == 1 && Input.GetKeyDown(KeyCode.Z))
        {
            일번선택지합쳐지는파트 = 2;
            dialogManager.선택지선택시외부에서페이지넘기기();
            dialogManager.onButtonSetterF();
            선1이후출력();
        }
    }


    public void 기능사용안하고넘기기외부()
    {
        기능사용안하고넘기기 = false;
        엘라심리학선택지버튼.SetActive(false);
    }


    public void 선택지출력1()
    {

        첫번째_선택지_커피타줘버튼.SetActive(true);
        첫번째_선택지_직접타기버튼.SetActive(true);
        첫번째_선택지_가만히버튼.SetActive(true);

    }


    public void 선1커피타줘누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        첫번째_선택지_커피타줘버튼.SetActive(false);
        첫번째_선택지_직접타기버튼.SetActive(false);
        첫번째_선택지_가만히버튼.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선1커피타줘();;

    }
    public void 선1직접타기()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        첫번째_선택지_커피타줘버튼.SetActive(false);
        첫번째_선택지_직접타기버튼.SetActive(false);
        첫번째_선택지_가만히버튼.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선1커피직접타기();
    }

    public void 선1가만히있기누름()
    {
        DataBaseManager.선택1_3가만히있기를했는가 = true;
        dialogManager.선택지선택시외부에서페이지넘기기();
        첫번째_선택지_커피타줘버튼.SetActive(false);
        첫번째_선택지_직접타기버튼.SetActive(false);
        첫번째_선택지_가만히버튼.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선1가만히있기();
    }

    public void 선1이후출력()
    {


        //interctionController.선1이후연결();
    }



    // 선택지 2번
    public void 선택지출력2()
    {

        두번째_선택지_1.SetActive(true);
        두번째_선택지_2.SetActive(true);

        if (DataBaseManager.선택1_3가만히있기를했는가 == true)
        {
            두번째_선택지_3.SetActive(true);
        }


    }


    public void 선2_1누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        두번째_선택지_1.SetActive(false);
        두번째_선택지_2.SetActive(false);
        두번째_선택지_3.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선2_1(); ;

    }
    public void 선2_2누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        두번째_선택지_1.SetActive(false);
        두번째_선택지_2.SetActive(false);
        두번째_선택지_3.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선2_2();
    }

    public void 선2_3누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        두번째_선택지_1.SetActive(false);
        두번째_선택지_2.SetActive(false);
        두번째_선택지_3.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선2_3();
    }


    // 선택지 3번

    public void 선택지출력3()
    {

        세번째_선택지_거절.SetActive(true);
        세번째_선택지_수락.SetActive(true);

    }


    public void 선3_거절누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        세번째_선택지_거절.SetActive(false);
        세번째_선택지_수락.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선3_의뢰거절(); ;

    }
    public void 선3_수락누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        세번째_선택지_거절.SetActive(false);
        세번째_선택지_수락.SetActive(false);
        dialogManager.onButtonSetterF();
        //interctionController.선3_의뢰수락();
    }







    //기능판단


    public void 엘라심리학선택지출력()
    {
        StartCoroutine(지연자());
        if (엘라심리학실시여부 == false)
        {
            엘라심리학선택지버튼.SetActive(true);
        }



    }
    IEnumerator 지연자()
    {
        yield return new WaitForSecondsRealtime(0.001f);
        기능사용안하고넘기기 = true;
    }
    public void 엘라심리학선택지끄기()
    {

        //엘라심리학선택지버튼.SetActive(false);

    }



    public void 엘라심리학선택지예()
    {
        DataBaseManager.대화중기능판정 = true;
        엘라심리학선택지버튼.SetActive(false);
        엘라심리학실시여부 = true;
        기능사용안하고넘기기 = true;          //요거는  단발성 메시지에서 사용하면 바로 넘겨짐
        theDM.isSelectButton = true;

        엘라기능판정창.SetActive(false);
        StartCoroutine(심리학기능판정코루틴());
    }
    public void 엘라심리학선택지아니오()
    {
        theDM.isSelectButton = false;
        DataBaseManager.판정창여부 = false;
        엘라기능판정창.SetActive(false);
    }
    public GameObject 엘라기능판정창;
    public Text 엘라기능판정텍스트;
    public void 엘라심리학기능판정창안내()
    {
        theDM.isSelectButton = true;
        DataBaseManager.판정창여부 = true;

        엘라기능판정창.SetActive(true);
        엘라기능판정텍스트.text = "알버트에 대하여 <심리판단> 기능을 사용합니다.\n 현재 해당기능 수치는 " + DataBaseManager.심리판단 + " 입니다.";
    }
    public Text 사용기능;
    public IEnumerator 심리학기능판정코루틴()
    {


        DataBaseManager.신문기능판정여부 = true;

        룰렛머신온오프.SetActive(true);


        사용기능.text = "정보조사" + DataBaseManager.정보조사;
        //배틀사운드매니저.찰칵효과음함수();

        yield return new WaitForSeconds(2f);

        StartCoroutine(룰렛작동());

        //yield return new WaitForSeconds(6f);


    }
    IEnumerator 심리판단_1일차알버트()
    {
        배틀사운드매니저.찰칵효과음함수();




        if (출력기능값 <= DataBaseManager.심리판단)
        {
            판정결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.심리판단)
        {
            판정결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.심리판단 / 3f) && (double)DataBaseManager.심리판단 >= 3f)
        {
            판정결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            판정결과.text = "대실패";

        }


        yield return new WaitForSeconds(2f);

        룰렛머신온오프.SetActive(false);





        if (판정결과.text == "대성공")
        {

            //interctionController.알버트심리학대성공출력대사();
            엘라심리학선택지버튼.SetActive(false);
            dialogManager.onButtonSetterF();
        }

        if (판정결과.text == "보통성공")
        {

            //interctionController.알버트심리학성공출력대사();
            엘라심리학선택지버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }
        if (판정결과.text == "실패")
        {

            //interctionController.알버트심리학실패출력대사();
            엘라심리학선택지버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }
        if (판정결과.text == "대실패")
        {

            //interctionController.알버트심리학대실패출력대사();
            엘라심리학선택지버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }

        DataBaseManager.대화중기능판정 = false;
    }
    /*
    public IEnumerator 심리학기능사용선택지()
    {
        기능사용안하고넘기기 = false;
        룰렛머신온오프.SetActive(true);
        yield return StartCoroutine(룰렛작동());

        //StartCoroutine(룰렛끄기());
        룰렛머신온오프.SetActive(false);
        Debug.Log("룰렛값은 : " + 출력기능값);


        if (DataBaseManager.심리판단 >= 출력기능값)
        {
            Debug.Log("실패");
           // dialogManager.선택지선택시외부에서페이지넘기기();
            interctionController.엘라심리학성공출력대사();
            엘라심리학선택지버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }

        if (DataBaseManager.심리판단 < 출력기능값)
        {
            Debug.Log("성공");

           // dialogManager.선택지선택시외부에서페이지넘기기();
            interctionController.엘라심리학실패출력대사();
            엘라심리학선택지버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }


        yield return null;
    }
    */




    public void 선택치선택출력1()
    {
        StartCoroutine(선택지선택1());


    }

    public IEnumerator 선택지선택1()
    {

        Debug.Log("현재 근력 수치 : " + DataBaseManager.힘);

        룰렛머신온오프.SetActive(true);
        yield return StartCoroutine(룰렛작동());

        //StartCoroutine(룰렛끄기());
        룰렛머신온오프.SetActive(false);
        Debug.Log("룰렛값은 : " + 출력기능값);


        if (DataBaseManager.힘 >= 출력기능값)
        {
            Debug.Log("실패");
            dialogManager.선택지선택시외부에서페이지넘기기();
            //interctionController.선택지1성공출력대사();
            //첫번째_선택지_버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }

        if (DataBaseManager.힘 < 출력기능값)
        {
            Debug.Log("성공");
            DataBaseManager._1일차오전심리학판정성공여부 = true;
            dialogManager.선택지선택시외부에서페이지넘기기();
            //interctionController.선택지1실패출력대사();
            //첫번째_선택지_버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }


        yield return null;

    }

    public IEnumerator 룰렛끄기()
    {
        yield return new WaitForSeconds(2f);
        룰렛머신온오프.SetActive(false);
    }
    public IEnumerator 룰렛작동()
    {
        배틀사운드매니저.기계돌아가는효과음함수();
        while (전투클릭여부 == false)
        {
            룰렛활성여부 = true;
            //랜덤십의자리 = Random.Range(0, 10);
            랜덤일의자리 = Random.Range(0, 10);
            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2f, 십의자리몸통.transform.position.y - 1f);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2f, 십의자리몸통.transform.position.y + 1f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1f, 일의자리몸통.transform.position.y - 1f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1f);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y - 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 2);
            }
            if (랜덤십의몸통위치 == 5)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 6)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 8)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y + 1);
            }



            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);

        }






        배틀사운드매니저.찰칵효과음함수();
        출력기능값 = (랜덤일의자리);
        if (출력기능값 == 0)
        {
            출력기능값 = 10;
        }

        //연출흔들기
        for (int i = 0; i < 10; i++)
        {

            float 큰흔들기값 = 4f;
            float 작은흔들기값 = 2f;

            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                //  십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값   );
            }




            yield return new WaitForSeconds(0.005f);

        }
        for (int i = 0; i < 5; i++)
        {

            float 큰흔들기값 = 3f;
            float 작은흔들기값 = 2f;


            랜덤십의몸통위치 = Random.Range(1, 10);


            if (랜덤십의몸통위치 == 1)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }






            yield return new WaitForSeconds(0.025f);

        }

        yield return new WaitForSeconds(2f);



        // 나중에 기능판정 늘어냐면 여기 수정해줘야됨
        StartCoroutine(심리판단_1일차알버트());
    }

    bool 전투클릭여부;
    bool 룰렛활성여부;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

}
