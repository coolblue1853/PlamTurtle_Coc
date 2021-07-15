using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleManager : MonoBehaviour
{

    public int 현재턴수 = 0;
    public int 내부여턴수 = 0;
    public int 적부여턴수1 = 0;
    public int 적부여턴수2 = 0;
    public int 적부여턴수3 = 0;

    bool 턴시작 = false;

    public battleUiManager BattleUiManager;
    public Enemy enemy;
    Enemy.DeepOne 심해인1 = new Enemy.DeepOne();
    Enemy.DeepOne 심해인2 = new Enemy.DeepOne();
    Enemy.DeepOne 심해인3 = new Enemy.DeepOne();

    public GameObject 심해인1이미지;
    public GameObject 심해인2이미지;
    public GameObject 심해인3이미지;
    int 등장수 = 0;

    public GameObject 공격_도주_눈썰미_재장전;
    public GameObject 격투_투척_단검_사격;
    public void 심해인등장()
    {

        등장수 = Random.Range(1, 3);

        Debug.Log(등장수);
        if (등장수 == 1)
        {
            심해인1이미지.SetActive(true);
            심해인1.심해인스탯생성();

        }

        if (등장수 == 2)
        {
            심해인1이미지.SetActive(true);
            심해인2이미지.SetActive(true);
            심해인1.심해인스탯생성();
            심해인2.심해인스탯생성();
        }
        if (등장수 == 3)
        {
            심해인1이미지.SetActive(true);
            심해인2이미지.SetActive(true);
            심해인3이미지.SetActive(true);

            심해인1.심해인스탯생성();
            심해인2.심해인스탯생성();
            심해인3.심해인스탯생성();
        }





    }
    public void 심해인전투시작()
    {
        확인용스탯생성();

        심해인등장();

        //턴순서 정하기
       if(DataBaseManager.민첩 >= 심해인1.민첩 && DataBaseManager.민첩 >= 심해인2.민첩 && DataBaseManager.민첩 >= 심해인3.민첩)
        {
            내부여턴수 = 1;

            if(심해인1.민첩 >= 심해인2.민첩 && 심해인1.민첩 >= 심해인3.민첩)
            {
                적부여턴수1 = 2;

                if(심해인2.민첩 >= 심해인3.민첩)
                {
                    적부여턴수2 = 3;
                    적부여턴수3 = 4;
                }
                else if (심해인3.민첩 > 심해인2.민첩)
                {
                    적부여턴수2 = 4;
                    적부여턴수3 = 3;
                }

            }
            else if (심해인2.민첩 >= 심해인1.민첩 && 심해인2.민첩 >= 심해인3.민첩)
            {
                적부여턴수2 = 2;

                if (심해인1.민첩 >= 심해인3.민첩)
                {
                    적부여턴수1 = 3;
                    적부여턴수3 = 4;
                }
                else if (심해인3.민첩 > 심해인1.민첩)
                {
                    적부여턴수1 = 4;
                    적부여턴수3 = 3;
                }

            }
            else if (심해인3.민첩 >= 심해인1.민첩 && 심해인3.민첩 >= 심해인2.민첩)
            {
                적부여턴수3 = 2;

                if (심해인1.민첩 >= 심해인2.민첩)
                {
                    적부여턴수1 = 3;
                    적부여턴수2 = 4;
                }
                else if (심해인2.민첩 > 심해인1.민첩)
                {
                    적부여턴수1 = 4;
                    적부여턴수2 = 3;
                }

            }
        }
        else if (심해인1.민첩 > DataBaseManager.민첩 && 심해인1.민첩 >= 심해인2.민첩 && 심해인1.민첩 >= 심해인3.민첩)
        {
            적부여턴수1 = 1;
            if (DataBaseManager.민첩 >= 심해인2.민첩 && DataBaseManager.민첩 >= 심해인3.민첩)
            {
                내부여턴수 = 2;

                if (심해인2.민첩 >= 심해인3.민첩)
                {
                    적부여턴수2 = 3;
                    적부여턴수3 = 4;
                }
                else if (심해인3.민첩 > 심해인2.민첩)
                {
                    적부여턴수2 = 4;
                    적부여턴수3 = 3;
                }

            }
            else if (심해인2.민첩 > DataBaseManager.민첩 && 심해인2.민첩 >= 심해인3.민첩)
            {
                적부여턴수2 = 2;

                if (DataBaseManager.민첩 >= 심해인3.민첩)
                {
                    내부여턴수 = 3;
                    적부여턴수3 = 4;
                }
                else if (심해인3.민첩 > DataBaseManager.민첩)
                {
                    내부여턴수 = 4;
                    적부여턴수3 = 3;
                }

            }
            else if (심해인3.민첩 > DataBaseManager.민첩 && 심해인3.민첩 >= 심해인2.민첩)
            {
                적부여턴수3 = 2;

                if (DataBaseManager.민첩 >= 심해인2.민첩)
                {
                    내부여턴수 = 3;
                    적부여턴수2 = 4;
                }
                else if (심해인2.민첩 > DataBaseManager.민첩)
                {
                    내부여턴수 = 4;
                    적부여턴수2 = 3;
                }

            }



        }
        else if (심해인2.민첩 > DataBaseManager.민첩 && 심해인2.민첩 > 심해인1.민첩 && 심해인2.민첩 >= 심해인3.민첩)
        {
            적부여턴수2 = 1;
            if (DataBaseManager.민첩 >= 심해인1.민첩 && DataBaseManager.민첩 >= 심해인3.민첩)
            {
                내부여턴수 = 2;

                if (심해인1.민첩 >= 심해인3.민첩)
                {
                    적부여턴수1 = 3;
                    적부여턴수3 = 4;
                }
                else if (심해인3.민첩 > 심해인1.민첩)
                {
                    적부여턴수1 = 4;
                    적부여턴수3 = 3;
                }

            }
            else if (심해인1.민첩 > DataBaseManager.민첩 && 심해인1.민첩 >= 심해인3.민첩)
            {
                적부여턴수1 = 2;

                if (DataBaseManager.민첩 >= 심해인3.민첩)
                {
                    내부여턴수 = 3;
                    적부여턴수3 = 4;
                }
                else if (심해인3.민첩 > DataBaseManager.민첩)
                {
                    내부여턴수 = 4;
                    적부여턴수3 = 3;
                }

            }
            else if (심해인3.민첩 > DataBaseManager.민첩 && 심해인3.민첩 >= 심해인1.민첩)
            {
                적부여턴수3 = 2;

                if (DataBaseManager.민첩 >= 심해인1.민첩)
                {
                    내부여턴수 = 3;
                    적부여턴수1 = 4;
                }
                else if (심해인1.민첩 > DataBaseManager.민첩)
                {
                    내부여턴수 = 4;
                    적부여턴수1 = 3;
                }

            }


        }
        else if (심해인3.민첩 > DataBaseManager.민첩 && 심해인3.민첩 > 심해인1.민첩 && 심해인3.민첩 > 심해인2.민첩)
        {
            적부여턴수3 = 1;

            if (DataBaseManager.민첩 >= 심해인1.민첩 && DataBaseManager.민첩 >= 심해인2.민첩)
            {
                내부여턴수 = 2;

                if (심해인1.민첩 >= 심해인2.민첩)
                {
                    적부여턴수1 = 3;
                    적부여턴수2 = 4;
                }
                else if (심해인2.민첩 > 심해인1.민첩)
                {
                    적부여턴수1 = 4;
                    적부여턴수2 = 3;
                }

            }
            else if (심해인1.민첩 > DataBaseManager.민첩 && 심해인1.민첩 >= 심해인2.민첩)
            {
                적부여턴수1 = 2;

                if (DataBaseManager.민첩 >= 심해인2.민첩)
                {
                    내부여턴수 = 3;
                    적부여턴수2 = 4;
                }
                else if (심해인2.민첩 > DataBaseManager.민첩)
                {
                    내부여턴수 = 4;
                    적부여턴수2 = 3;
                }

            }
            else if (심해인2.민첩 > DataBaseManager.민첩 && 심해인2.민첩 >= 심해인1.민첩)
            {
                적부여턴수2 = 2;

                if (DataBaseManager.민첩 >= 심해인1.민첩)
                {
                    내부여턴수 = 3;
                    적부여턴수1 = 4;
                }
                else if (심해인1.민첩 > DataBaseManager.민첩)
                {
                    내부여턴수 = 4;
                    적부여턴수1 = 3;
                }

            }
        }






    }


    public void 현재가누구턴인지확인()
    {

        if(현재턴수 == 5 && 등장수 == 3)
        {
            현재턴수 = 1;
        }

        else if (현재턴수 == 4 && 등장수 ==2)
        {
            현재턴수 = 1;
        }

        else if (현재턴수 == 3 && 등장수 == 1)
        {
            현재턴수 = 1;
        }
        if (현재턴수 == 내부여턴수 && 턴시작 == false)
        {
            턴시작 = true;

            내턴();
        }

        if (현재턴수 == 적부여턴수1 && 턴시작 == false)
        {
            턴시작 = true;
            적1의턴();
        }

        if (현재턴수 == 적부여턴수2 && 턴시작 == false)
        {
            턴시작 = true;
            적2의턴();
        }
        if (현재턴수 == 적부여턴수3 && 턴시작 == false)
        {
            턴시작 = true;
            적3의턴();
        }

    }


    public bool 내턴인가 = false;
    public bool 내턴기본 = false;

    int whiteNum = 1;
    public GameObject whiteBox;
    public GameObject white1;
    public GameObject white2;
    public GameObject white3;
    public GameObject white4;
    public GameObject 공격뒤로가기;
    public GameObject 근접뒤로가기;
    public GameObject 공격적선택뒤로가기;
    public GameObject 적선택가리개;
    public void 내턴()
    {
        whiteBox.SetActive(true);
        공격_도주_눈썰미_재장전.SetActive(true);
        내턴인가 = true;
        내턴기본 = true;
    }
    public void 내턴기본white관리()
    {
        if(내턴기본 == true)
        {
            if (whiteNum == 1)
            {
                white1.SetActive(true);
                white2.SetActive(false);
                white3.SetActive(false);
                white4.SetActive(false);

            }
            else if (whiteNum == 2)
            {
                white1.SetActive(false);
                white2.SetActive(true);
                white3.SetActive(false);
                white4.SetActive(false);
            }
            else if (whiteNum == 3)
            {
                white1.SetActive(false);
                white2.SetActive(false);
                white3.SetActive(true);
                white4.SetActive(false);
            }
            else if (whiteNum == 4)
            {
                white1.SetActive(false);
                white2.SetActive(false);
                white3.SetActive(false);
                white4.SetActive(true);
            }
        }

        if(내턴인가 == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if(whiteNum == 1)
                {
                    whiteNum = 3;  
                }
                else if (whiteNum == 2)
                {
                    whiteNum = 4;
                }
                else if (whiteNum == 3)
                {
                    whiteNum = 1;
                }
                else if (whiteNum == 4)
                {
                    whiteNum = 2;
                }
            }

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (whiteNum == 3)
                {
                    whiteNum = 1;
                }
                else if (whiteNum == 4)
                {
                    whiteNum = 2;
                }
                else if (whiteNum == 1)
                {
                    whiteNum = 3;
                }
                else if (whiteNum == 2)
                {
                    whiteNum = 4;
                }
            }


            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (whiteNum == 1)
                {
                    whiteNum = 2;
                }
                else if (whiteNum == 2)
                {
                    whiteNum = 1;
                }
                else if (whiteNum == 3)
                {
                    whiteNum = 4;
                }
                else if (whiteNum == 4)
                {
                    whiteNum = 3;
                }
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (whiteNum == 2)
                {
                    whiteNum = 1;
                }
                else if (whiteNum == 1)
                {
                    whiteNum = 2;
                }
                else if (whiteNum == 4)
                {
                    whiteNum = 3;
                }
                else if (whiteNum == 3)
                {
                    whiteNum = 4;
                }
            }


        }
   

    }

    public void 내턴_공격뒤로가기()
    {
        공격_도주_눈썰미_재장전.SetActive(true);
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);

    }

    public void 내턴_공격버튼()
    {
        공격_도주_눈썰미_재장전.SetActive(false);

        격투_투척_단검_사격.SetActive(true);
        공격뒤로가기.SetActive(true);

        근접뒤로가기.SetActive(false);
        적선택가리개.SetActive(false);

        적화살표1.SetActive(false);
    }

    public void 내턴_격투버튼()
    {
        기술명 = "근접격투";
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);
        whiteBox.SetActive(false);
        
        적선택차례 = true;
        적선택가리개.SetActive(true);
        근접뒤로가기.SetActive(true);
        공격적선택뒤로가기.SetActive(true);
        적화살표1.SetActive(true);
    }

    public void 내턴_격투뒤로가기()
    {
        기술명 = null;
        공격_도주_눈썰미_재장전.SetActive(false);
        whiteBox.SetActive(true);


        격투_투척_단검_사격.SetActive(true);
        공격뒤로가기.SetActive(true);

        적화살표1.SetActive(false);
        적선택차례 = false;
        근접뒤로가기.SetActive(false);
        적선택가리개.SetActive(false);

    }

    public void 내턴_공격류적선뒤로가기()
    {
        whiteBox.SetActive(true);
        공격_도주_눈썰미_재장전.SetActive(false);
        공격적선택뒤로가기.SetActive(false);
        격투_투척_단검_사격.SetActive(true);
        공격뒤로가기.SetActive(true);

        근접뒤로가기.SetActive(false);
        적선택가리개.SetActive(false);

        적화살표1.SetActive(false);

    }
















    public bool 적선택차례 = false;
    public GameObject 적화살표1;
    public GameObject 적화살표2;
    public GameObject 적화살표3;

    public void 적선택_2_마우스엔터()
    {
        if(적선택차례 == true)
        {
            적화살표1.SetActive(false);
            적화살표2.SetActive(true);
            적화살표3.SetActive(false);
        }

    }
    public void 적선택_2_마우스아웃()
    {
        if (적선택차례 == true)
        {
            적화살표1.SetActive(true);
            적화살표2.SetActive(false);
            적화살표3.SetActive(false);
        }

    }
    public void 적선택_3_마우스엔터()
    {
        if (적선택차례 == true)
        {
            적화살표1.SetActive(false);
            적화살표2.SetActive(false);
            적화살표3.SetActive(true);
        }

    }
    public void 적선택_3_마우스아웃()
    {
        if (적선택차례 == true)
        {
            적화살표1.SetActive(true);
            적화살표2.SetActive(false);
            적화살표3.SetActive(false);
        }

    }


    // 적 1 클릭시__ 모든 공격 포함  

    public GameObject 판정창;

    public string 기술명 = null;
    public Text 노아제목;
    public Text 적제목;

    public Text 노아기술;
    public Text 적기술;
    public Text 노아결과;
    public Text 적기결과;



    public Text 결과;

    public void 적클릭버튼_1()
    {
        if(적선택차례 == true)
        {
            StartCoroutine(적클릭1());
        }

    }

    public int 대미지;
    public IEnumerator 적클릭1()
    {
        판정창.SetActive(true);
        if (기술명 == "근접격투")
        {
            대미지 = Random.Range(1, 4);
            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);




            if (출력기능값 <= DataBaseManager.맨손격투/3 || DataBaseManager.맨손격투 == 1)
            {
                노아결과.text = "대성공";

            }
            else if (DataBaseManager.맨손격투 == 10)
            {
                노아결과.text = "대실패";

            }

            else if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
            else if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }

            // 전판정

            if (출력기능값 <= 심해인1.심해인맨손격투 / 3 || 심해인1.심해인맨손격투 == 1)
            {
                적기결과.text = "대성공";

            }
            else if (심해인1.심해인맨손격투 == 10)
            {
                적기결과.text = "대실패";

            }
            else if(적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            else if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }

            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공" ))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패" )|| (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대실패" && 적기결과.text == "보통성공") || (노아결과.text == "대실패" && 적기결과.text == "실패") || (노아결과.text == "대실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }



            if(결과.text == "노아 판정승")
            {
                Debug.Log(심해인1.체력);
                Debug.Log(대미지);
                심해인1.체력 = 심해인1.체력 - 대미지;
                Debug.Log(심해인1.체력);
            } 
        }






    }







    public void 적1의턴()
    {
        whiteBox.SetActive(false);
        공격_도주_눈썰미_재장전.SetActive(false);
    }
    public void 적2의턴()
    {
        whiteBox.SetActive(false);
        공격_도주_눈썰미_재장전.SetActive(false);
    }
    public void 적3의턴()
    {
        whiteBox.SetActive(false);
        공격_도주_눈썰미_재장전.SetActive(false);
    }




    // Start is called before the first frame update
    void Start()
    {

        심해인전투시작();
        현재턴수 = 현재턴수 + 1;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
        }

        내턴기본white관리();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        현재가누구턴인지확인();
    }


    public IEnumerator 룰렉동작시키기()
    {


        룰렛머신온오프.SetActive(true);
        yield return StartCoroutine(룰렛작동());
        룰렛머신온오프.SetActive(false);
    }










    // 기능관련 룰렛
    public rollet 룰렛머신;

    public Text 십의자리;
    public Text 일의자리;

    public GameObject 십의자리몸통;
    public GameObject 일의자리몸통;
    public GameObject 룰렛머신온오프;


    public Text 적십의자리;
    public Text 적일의자리;

    public GameObject 적십의자리몸통;
    public GameObject 적일의자리몸통;
    public GameObject 적룰렛머신온오프;





    int 랜덤십의자리;
    int 랜덤일의자리;
    int 적랜덤일의자리;

    int 랜덤십의몸통위치;
    int 적랜덤십의몸통위치;
    public static int 출력기능값;
    public static int 적출력기능값;






    public IEnumerator 룰렛끄기()
    {
        yield return new WaitForSeconds(2f);
        룰렛머신온오프.SetActive(false);
    }

    public IEnumerator 룰렛작동()
    {
        for (int i = 0; i < 10; i++)
        {

            랜덤일의자리 = Random.Range(0, 10);

            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.1f);

        }
        for (int i = 0; i < 30; i++)
        {

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



            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);

        }

        출력기능값 = (랜덤일의자리);
        if (출력기능값 == 0)
        {
            출력기능값 = 10;
        }

        yield return new WaitForSeconds(2f);
    }




    public IEnumerator 적룰렛작동()
    {
        for (int i = 0; i < 10; i++)
        {

            적랜덤일의자리 = Random.Range(0, 10);

            적일의자리.text = 적랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.1f);

        }
        for (int i = 0; i < 30; i++)
        {

            적랜덤일의자리 = Random.Range(1, 10);


            적랜덤십의몸통위치 = Random.Range(1, 10);


            if (적랜덤십의몸통위치 == 1)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1f, 적십의자리몸통.transform.position.y - 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1, 적십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1f, 적십의자리몸통.transform.position.y + 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1, 적십의자리몸통.transform.position.y);
            }
            if (적랜덤십의몸통위치 == 2)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 0.5f, 적일의자리몸통.transform.position.y - 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1, 적십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1, 적십의자리몸통.transform.position.y);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 0.5f, 적일의자리몸통.transform.position.y + 0.5f);

            }
            if (적랜덤십의몸통위치 == 3)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 0.5f, 적일의자리몸통.transform.position.y + 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 0.5f, 적일의자리몸통.transform.position.y - 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y + 1);
            }
            if (적랜덤십의몸통위치 == 4)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 1, 적일의자리몸통.transform.position.y - 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 1, 적일의자리몸통.transform.position.y + 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y - 1);
            }
            if (적랜덤십의몸통위치 == 5)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1, 적십의자리몸통.transform.position.y + 0.5f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 1, 적일의자리몸통.transform.position.y + 0.5f);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 1, 적일의자리몸통.transform.position.y - 0.5f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1, 적십의자리몸통.transform.position.y - 0.5f);
            }
            if (적랜덤십의몸통위치 == 6)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1, 적십의자리몸통.transform.position.y - 0.5f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y - 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1, 적십의자리몸통.transform.position.y + 0.5f);
            }
            if (적랜덤십의몸통위치 == 7)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 0.5f, 적십의자리몸통.transform.position.y + 0.5f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y + 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 0.5f, 적십의자리몸통.transform.position.y - 0.5f);
            }
            if (적랜덤십의몸통위치 == 8)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 0.5f, 적십의자리몸통.transform.position.y - 0.5f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 1, 적일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 1, 적일의자리몸통.transform.position.y);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 0.5f, 적십의자리몸통.transform.position.y + 0.5f);
            }
            if (적랜덤십의몸통위치 == 9)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 1, 적일의자리몸통.transform.position.y);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1f, 적십의자리몸통.transform.position.y - 0.5f);
                yield return new WaitForSeconds(0.025f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 1, 적일의자리몸통.transform.position.y);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1f, 적십의자리몸통.transform.position.y + 0.5f);
            }









            적십의자리.text = 랜덤십의자리.ToString();
            적일의자리.text = 적랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.025f);

        }
        for (int i = 0; i < 80; i++)
        {
            랜덤십의자리 = Random.Range(1, 10);
            적랜덤일의자리 = Random.Range(1, 10);
            적랜덤십의몸통위치 = Random.Range(1, 10);

            if (적랜덤십의몸통위치 == 1)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 2f, 적십의자리몸통.transform.position.y - 1f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 2, 적십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 2f, 적십의자리몸통.transform.position.y + 1f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 2, 적십의자리몸통.transform.position.y);
            }
            if (적랜덤십의몸통위치 == 2)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 1f, 적일의자리몸통.transform.position.y - 1f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 2, 적십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 2, 적십의자리몸통.transform.position.y);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 1f, 적일의자리몸통.transform.position.y + 1f);

            }
            if (적랜덤십의몸통위치 == 3)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 1f, 적일의자리몸통.transform.position.y + 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 1, 적일의자리몸통.transform.position.y - 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y + 1);
            }
            if (적랜덤십의몸통위치 == 4)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 2, 적일의자리몸통.transform.position.y - 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 2, 적일의자리몸통.transform.position.y + 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x, 적십의자리몸통.transform.position.y - 2);
            }
            if (적랜덤십의몸통위치 == 5)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 2, 적십의자리몸통.transform.position.y + 1);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 2, 적일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 2, 적일의자리몸통.transform.position.y - 1);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 2, 적십의자리몸통.transform.position.y - 1);
            }
            if (적랜덤십의몸통위치 == 6)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 2, 적십의자리몸통.transform.position.y - 1);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y - 2);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 2, 적십의자리몸통.transform.position.y + 1);
            }
            if (적랜덤십의몸통위치 == 7)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1, 적십의자리몸통.transform.position.y + 1);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y - 2);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x, 적일의자리몸통.transform.position.y + 2);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1, 적십의자리몸통.transform.position.y - 1);
            }
            if (적랜덤십의몸통위치 == 8)
            {
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 1, 적십의자리몸통.transform.position.y - 1);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 2, 적일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 2, 적일의자리몸통.transform.position.y);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 1, 적십의자리몸통.transform.position.y + 1);
            }
            if (적랜덤십의몸통위치 == 9)
            {
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x + 2, 적일의자리몸통.transform.position.y);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x + 2, 적십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                적일의자리몸통.transform.position = new Vector2(적일의자리몸통.transform.position.x - 2, 적일의자리몸통.transform.position.y);
                적십의자리몸통.transform.position = new Vector2(적십의자리몸통.transform.position.x - 2, 적십의자리몸통.transform.position.y + 1);
            }



            적일의자리.text = 적랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);

        }

        적출력기능값 = (적랜덤일의자리);
        if (적출력기능값 == 0)
        {
            적출력기능값 = 10;
        }

        yield return new WaitForSeconds(2f);
    }

    public void 확인용스탯생성()
    {



        int 힘스킬배분숫자;
        int 지능스킬배분숫자;
        int 민첩스킬배분숫자;
        DataBaseManager.힘 = Random.Range(1, 10);
        DataBaseManager.지능 = Random.Range(1, 10);
        DataBaseManager.민첩 = Random.Range(1, 10);
        DataBaseManager.행운 = Random.Range(1, 10);

        DataBaseManager.활력 = Random.Range(1, 10);
        DataBaseManager.마력 = Random.Range(1, 10);
        DataBaseManager.의지력 = Random.Range(1, 10);

        DataBaseManager.체력 = DataBaseManager.활력 + DataBaseManager.의지력;
        DataBaseManager.정신력 = DataBaseManager.마력 + DataBaseManager.의지력;

        DataBaseManager.현재체력 = DataBaseManager.체력;
        DataBaseManager.현재정신력 = DataBaseManager.정신력;

        DataBaseManager.스트레스게이지 = DataBaseManager.의지력;

        힘스킬배분숫자 = DataBaseManager.힘;
        지능스킬배분숫자 = DataBaseManager.지능;
        민첩스킬배분숫자 = DataBaseManager.민첩;

        int 뭘배분 = 0;
        while (0 < 힘스킬배분숫자)
        {
            뭘배분 = Random.Range(1, 7);

            switch (뭘배분)
            {
                case 1:
                    DataBaseManager.맨손격투 += 1;
                    break;
                case 2:
                    DataBaseManager.사격술 += 1;
                    break;
                case 3:
                    DataBaseManager.검술 += 1;
                    break;

                case 4:
                    DataBaseManager.눈썰미 += 1;
                    break;

                case 5:
                    DataBaseManager.던지기 += 1;
                    break;
                case 6:
                    DataBaseManager.잠수 += 1;
                    break;
            }

            힘스킬배분숫자 = 힘스킬배분숫자 - 1;

        }


        int 뭘배분1 = 0;
        while (0 < 지능스킬배분숫자)
        {
            뭘배분1 = Random.Range(1, 7);
            switch (뭘배분1)
            {
                case 1:
                    DataBaseManager.의학지식 += 1;
                    break;
                case 2:
                    DataBaseManager.정보조사 += 1;
                    break;
                case 3:
                    DataBaseManager.심리판단 += 1;
                    break;
                case 4:
                    DataBaseManager.오컬트지식 += 1;
                    break;
                case 5:
                    DataBaseManager.정신감정 += 1;
                    break;
                case 6:
                    DataBaseManager.붕대감기 += 1;
                    break;

            }

            지능스킬배분숫자 = 지능스킬배분숫자 - 1;

        }
        int 뭘배분2 = 0;
        while (0 < 민첩스킬배분숫자)
        {
            뭘배분2 = Random.Range(1, 7);
            switch (뭘배분2)
            {
                case 1:
                    DataBaseManager.구르기 += 1;
                    break;
                case 2:
                    DataBaseManager.변장술 += 1;
                    break;
                case 3:
                    DataBaseManager.언변술 += 1;
                    break;
                case 4:
                    DataBaseManager.자물쇠따기 += 1;
                    break;
                case 5:
                    DataBaseManager.손재주 += 1;
                    break;
                case 6:
                    DataBaseManager.은신 += 1;
                    break;

            }
            민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
        }



    }
}
