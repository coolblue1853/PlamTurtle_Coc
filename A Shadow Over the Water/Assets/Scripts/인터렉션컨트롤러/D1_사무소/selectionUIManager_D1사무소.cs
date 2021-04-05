using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selectionUIManager_D1사무소 : MonoBehaviour
{
    public DialogManager_D1사무소 theDM;

    public DialogManager_D1사무소 dialogManager;
    public GameObject 첫번째_선택지_커피타줘버튼;
    public GameObject 첫번째_선택지_직접타기버튼;
    public GameObject 첫번째_선택지_가만히버튼;





    public GameObject 엘라심리학선택지버튼;
    public Text 엘라심리학선택지텍스트;

    public InterctionController_D1사무소 interctionController;
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


    bool 기능사용안하고넘기기 = false;
    int 출력기능수치;

    public void 선택지출력1(string oneTxt, string twoTxt)
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
        interctionController.선1커피타줘();;

    }
    public void 선1직접타기()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        첫번째_선택지_커피타줘버튼.SetActive(false);
        첫번째_선택지_직접타기버튼.SetActive(false);
        첫번째_선택지_가만히버튼.SetActive(false);
        dialogManager.onButtonSetterF();
        interctionController.선1커피직접타기();
    }

    public void 선1가만히있기누름()
    {
        dialogManager.선택지선택시외부에서페이지넘기기();
        첫번째_선택지_커피타줘버튼.SetActive(false);
        첫번째_선택지_직접타기버튼.SetActive(false);
        첫번째_선택지_가만히버튼.SetActive(false);
        dialogManager.onButtonSetterF();
        interctionController.선1가만히있기();
    }



    public void 엘라심리학선택지출력()
    {
        엘라심리학선택지버튼.SetActive(true);

    }
    public void 엘라심리학선택지클릭()
    {
        기능사용안하고넘기기 = true;
        StartCoroutine(심리학기능사용선택지());

        theDM.isSelectButton = true;
    }


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
            interctionController.선택지1성공출력대사();
            //첫번째_선택지_버튼.SetActive(false);
            dialogManager.onButtonSetterF();

        }

        if (DataBaseManager.힘 < 출력기능값)
        {
            Debug.Log("성공");
            dialogManager.선택지선택시외부에서페이지넘기기();
            interctionController.선택지1실패출력대사();
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
        for (int i = 0; i < 10; i++)
        {
            랜덤십의자리 = Random.Range(0, 10);
            랜덤일의자리 = Random.Range(0, 10);


            십의자리.text = 랜덤십의자리.ToString();
            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.1f);

        }
        for (int i = 0; i < 30; i++)
        {
            랜덤십의자리 = Random.Range(1, 10);
            랜덤일의자리 = Random.Range(1, 10);


            랜덤십의몸통위치 = Random.Range(1, 10);


            if (랜덤십의몸통위치 == 1)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1f, 십의자리몸통.transform.position.y - 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1f, 십의자리몸통.transform.position.y + 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 0.5f, 일의자리몸통.transform.position.y - 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 0.5f, 일의자리몸통.transform.position.y + 0.5f);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 0.5f, 일의자리몸통.transform.position.y + 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 0.5f, 일의자리몸통.transform.position.y - 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y - 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y + 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 5)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y + 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y + 0.5f);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y - 0.5f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y - 0.5f);
            }
            if (랜덤십의몸통위치 == 6)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y - 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y + 0.5f);
            }
            if (랜덤십의몸통위치 == 7)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 0.5f, 십의자리몸통.transform.position.y + 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 0.5f, 십의자리몸통.transform.position.y - 0.5f);
            }
            if (랜덤십의몸통위치 == 8)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 0.5f, 십의자리몸통.transform.position.y - 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 0.5f, 십의자리몸통.transform.position.y + 0.5f);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1f, 십의자리몸통.transform.position.y - 0.5f);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1f, 십의자리몸통.transform.position.y + 0.5f);
            }









            십의자리.text = 랜덤십의자리.ToString();
            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.025f);

        }
        for (int i = 0; i < 80; i++)
        {
            랜덤십의자리 = Random.Range(1, 10);
            랜덤일의자리 = Random.Range(1, 10);
            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2f, 십의자리몸통.transform.position.y - 1f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2f, 십의자리몸통.transform.position.y + 1f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1f, 일의자리몸통.transform.position.y - 1f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1f);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y - 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 2);
            }
            if (랜덤십의몸통위치 == 5)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 6)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 7)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 8)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y + 1);
            }



            십의자리.text = 랜덤십의자리.ToString();
            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);

        }

        출력기능값 = (10 * 랜덤십의자리) + (랜덤일의자리);
        if (출력기능값 == 0)
        {
            출력기능값 = 100;
        }

        yield return new WaitForSeconds(2f);



    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(기능사용안하고넘기기 = true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                기능사용안하고넘기기 = false;
                엘라심리학선택지버튼.SetActive(false);
            }
        }

    }
}
