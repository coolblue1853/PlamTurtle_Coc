using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stressManager : MonoBehaviour
{

    public GameObject 스트레스칸;
    public GameObject 스트레스배경1;
    public GameObject 스트레스배경2;
    public GameObject 스트레스배경3;
    public GameObject 스트레스배경4;
    public GameObject 스트레스배경5;
    public GameObject 스트레스배경6;
    public GameObject 스트레스배경7;
    public GameObject 스트레스배경8;
    public GameObject 스트레스배경9;

    public SoundManager 사운드매니저;
    public GameObject 판정창;
    public Text 사용기능;
    public Text 결과;

    public BillowUIManager billowUiManager;
    // Start is called before the first frame update
    void Start()
    {

        스트레스게이지업데이터();

    }


    void 스트레스게이지업데이터()
    {
        if( DataBaseManager.스트레스게이지 == 1)
        {
            스트레스게이지딜리터();
            스트레스배경1.SetActive(true);
        }
        else if (DataBaseManager.스트레스게이지 == 2)
        {
            스트레스게이지딜리터();
            스트레스배경2.SetActive(true);
        }
        else if (DataBaseManager.스트레스게이지 == 3)
        {
            스트레스게이지딜리터();
            스트레스배경3.SetActive(true);
        }
        else if (DataBaseManager.스트레스게이지 == 4)
        {
            스트레스게이지딜리터();
            스트레스배경4.SetActive(true);
        }
        else if (DataBaseManager.스트레스게이지 == 5)
        {
            스트레스게이지딜리터();
            스트레스배경5.SetActive(true);
        }
        else if (DataBaseManager.스트레스게이지 == 6)
        {
            스트레스게이지딜리터();
            스트레스배경6.SetActive(true);
        }
        else if (DataBaseManager.스트레스게이지 == 7)
        {
            스트레스게이지딜리터();
            스트레스배경7.SetActive(true);

        }
        else if (DataBaseManager.스트레스게이지 == 8)
        {
            스트레스게이지딜리터();
            스트레스배경8.SetActive(true);

        }
        else if (DataBaseManager.스트레스게이지 == 9)
        {
            스트레스게이지딜리터();
            스트레스배경9.SetActive(true);
        }
    }

    void 스트레스게이지딜리터()
    {
        스트레스배경1.SetActive(false);
        스트레스배경2.SetActive(false);
        스트레스배경3.SetActive(false);
        스트레스배경4.SetActive(false);
        스트레스배경5.SetActive(false);
        스트레스배경6.SetActive(false);
        스트레스배경7.SetActive(false);
        스트레스배경8.SetActive(false);
        스트레스배경9.SetActive(false);

    }



    // Update is called once per frame
    void Update()
    {
        스트레스게이지업데이터();
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (판정진행 == true)
            {
                StartCoroutine(스트래스판정());
                판정진행 = false;
            }

        }


        if (룰렛활성여부 == true && Input.GetMouseButtonDown(0))
        {
            전투클릭여부 = true;
        }



        판정창끄기();

        if (판정창끌수있나 == true && Input.GetMouseButtonDown(0))
        {
            판정창끌까요 = true;

        }
    }


    public void 스트레스추가(GameObject 배경)
    {
        if (배경.transform.childCount < DataBaseManager.스트레스게이지)
        {
            GameObject myInstance = Instantiate(스트레스칸, 배경.transform);
            //billowUiManager.이성감소();  // 이성감소는 어떻게 해야할지 생각해 봐야할듯.
        }
        if(배경.transform.childCount == DataBaseManager.스트레스게이지)
        {


            StartCoroutine(스택최대발동());
            //DeleteChilds(배경); // 모든스택 제거
        }
    }


    public GameObject 지능판정안내판;
    public GameObject 이성붕괴;
    IEnumerator 스택최대발동()
    {
        지능판정안내판.SetActive(true);
        yield return new WaitForSeconds(2f);
        지능판정안내판.SetActive(false);

        StartCoroutine(지능판정());
    }


    public void DeleteChilds(GameObject 스트레스배경)
    {
        Transform[] childList = 스트레스배경.GetComponentsInChildren<Transform>(true);
        if (childList != null)
        {
            for (int i = 1; i < childList.Length; i++)
            {
                if (childList[i] != transform)
                    Destroy(childList[i].gameObject);
            }
        }

    }



    public void 스트레스추가함수()
    {

        if (DataBaseManager.스트레스게이지 == 1)
        {
            스트레스추가(스트레스배경1);
        }
        else if (DataBaseManager.스트레스게이지 == 2)
        {
            스트레스추가(스트레스배경2);
        }
        else if (DataBaseManager.스트레스게이지 == 3)
        {
            스트레스추가(스트레스배경3);
        }
        else if (DataBaseManager.스트레스게이지 == 4)
        {
            스트레스추가(스트레스배경4);
        }
        else if (DataBaseManager.스트레스게이지 == 5)
        {
            스트레스추가(스트레스배경5);
        }
        else if (DataBaseManager.스트레스게이지 == 6)
        {
            스트레스추가(스트레스배경6);
        }
        else if (DataBaseManager.스트레스게이지 == 7)
        {
            스트레스추가(스트레스배경7);

        }
        else if (DataBaseManager.스트레스게이지 == 8)
        {
            스트레스추가(스트레스배경8);

        }
        else if (DataBaseManager.스트레스게이지 == 9)
        {
            스트레스추가(스트레스배경9);
        }
}


    bool 판정창끌까요 = false;
    bool 판정창끌수있나 = false;
    float closeTime = 3f;
    float waitingTime = 3f;

    // 기능관련 룰렛
    public rollet 룰렛머신;

    public Text 십의자리;
    public Text 일의자리;

    public GameObject 십의자리몸통;
    public GameObject 일의자리몸통;
    public GameObject 룰렛머신온오프;




    int 랜덤일의자리;


    int 랜덤십의몸통위치;

    public static float 출력기능값;
    public static float 적출력기능값;




    bool 전투클릭여부;
    bool 룰렛활성여부;


    void 판정창끄기()
    {

        if (판정창끌까요 == true && 판정창끌수있나 == true)
        {
            StopAllCoroutines();
            판정창끌까요 = false;
            판정창끌수있나 = false;
            판정창.SetActive(false);


            if (사용기능.text == "의지력 판정:" + DataBaseManager.지능)
            {
                StartCoroutine(스트래스판정결과속단());
            }
            else if (사용기능.text == "지능 판정:" + DataBaseManager.지능)
            {
                StartCoroutine(지능판정결과속단());
            }
        }

    }
    IEnumerator 스트래스판정결과속단()
    {

        if (결과.text == "보통성공")
        {
            // 여기에는 경우에 따라 다름. 성공일시 이성을 안깍는 경우도 있으니

        }
        if (결과.text == "실패")
        {
            스트레스추가함수();

        }
        if (결과.text == "대성공")
        {


        }
        if (결과.text == "대실패")
        {
            스트레스추가함수();
            스트레스추가함수();
            스트레스추가함수();

        }
        return null;
    }
    bool 판정진행;
    public void 외부스트레스판정()
    {
        판정진행 = true;
        DataBaseManager.연출진행중 = true;


    }

    IEnumerator 스트래스판정()
    {
        결과.text = "------";
        판정창.SetActive(true);

        사용기능.text = "의지력 판정:" + DataBaseManager.의지력;



        yield return new WaitForSeconds(waitingTime);

        StartCoroutine(룰렛작동());




    }
    IEnumerator 스트래스판정결과()
    {


        사운드매니저.찰칵효과음함수();

        if (출력기능값 <= DataBaseManager.의지력)
        {
            결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.의지력)
        {
            결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.의지력 / 3f) && (double)DataBaseManager.의지력 >= 3f)
        {
            결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            결과.text = "대실패";

        }


        판정창끌까요 = false;
        판정창끌수있나 = true;
        yield return new WaitForSeconds(closeTime);
        판정창끌까요 = false;
        판정창끌수있나 = false;
        판정창.SetActive(false);




        if (결과.text == "보통성공")
        {
            // 여기에는 경우에 따라 다름. 성공일시 이성을 안깍는 경우도 있으니

        }
        if (결과.text == "실패")
        {
            스트레스추가함수();

        }
        if (결과.text == "대성공")
        {


        }
        if (결과.text == "대실패")
        {
            스트레스추가함수();
            스트레스추가함수();
            스트레스추가함수();

        }

        DataBaseManager.연출진행중 = false;

    }



    IEnumerator 지능판정결과속단()
    {

        if (결과.text == "보통성공")
        {
            // 여기에는 경우에 따라 다름. 성공일시 이성을 안깍는 경우도 있으니

        }
        if (결과.text == "실패")
        {
            스트레스추가함수();

        }
        if (결과.text == "대성공")
        {


        }
        if (결과.text == "대실패")
        {
            스트레스추가함수();
            스트레스추가함수();
            스트레스추가함수();

        }
        DataBaseManager.연출진행중 = false;
        return null;

    }

    IEnumerator 지능판정()
    {
        결과.text = "------";
        판정창.SetActive(true);

        사용기능.text = "지능 판정:" + DataBaseManager.지능;



        yield return new WaitForSeconds(waitingTime);

        StartCoroutine(룰렛작동());
        사운드매니저.찰칵효과음함수();

    }
    IEnumerator 지능판정결과()
    {


        사운드매니저.찰칵효과음함수();

        if (출력기능값 <= DataBaseManager.의지력)
        {
            결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.의지력)
        {
            결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.의지력 / 3f) && (double)DataBaseManager.의지력 >= 3f)
        {
            결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            결과.text = "대실패";

        }


        판정창끌까요 = false;
        판정창끌수있나 = true;
        yield return new WaitForSeconds(closeTime);
        판정창끌까요 = false;
        판정창끌수있나 = false;
        판정창.SetActive(false);




        if (결과.text == "보통성공" || 결과.text == "대성공")
        {
            // 정신붕괴 실시

        }
        if (결과.text == "실패"|| 결과.text == "대실패")
        {
           //정신분괴 x
        }




    }


    public IEnumerator 룰렛작동()
    {
        전투클릭여부 = false;
        사운드매니저.기계돌아가는효과음함수();


        while (전투클릭여부 == false)
        {
            판정창끌수있나 = false;
            룰렛활성여부 = true;


            랜덤일의자리 = Random.Range(0, 10);
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



            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);


        }




        룰렛활성여부 = false;
        사운드매니저.효과음멈춤();
        사운드매니저.찰칵효과음함수();
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
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
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
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }






            yield return new WaitForSeconds(0.025f);

        }


        yield return new WaitForSeconds(waitingTime);

        if (사용기능.text == "의지력 판정:" + DataBaseManager.의지력)
        {
            StartCoroutine(스트래스판정결과());
        }
        else if (사용기능.text == "지능 판정:" + DataBaseManager.지능)
        {
            StartCoroutine(지능판정결과());
        }

    }









}
