using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BattleManager : MonoBehaviour
{
    public GameObject 근접공격;
    
    public battleUiManager 배틀유아이;
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
        if(SceneManager.GetActiveScene().name == "도로전투")
        {
            등장수 = 1;

        }
        else
        {
            등장수 = Random.Range(1, 4);
        }


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
        if(심해인1.체력 <= 0 )
        {
            심해인1이미지.SetActive(false);
        }
        if (심해인2.체력 <= 0)
        {
            심해인2이미지.SetActive(false);
        }
        if (심해인3.체력 <= 0)
        {
            심해인3이미지.SetActive(false);
        }





        if (현재턴수 == 5 && 등장수 == 3)
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
            턴시작시초기화();
            StartCoroutine(내턴메시지());

        }

        if (현재턴수 == 적부여턴수1 && 턴시작 == false)
        {
            if(심해인1.체력 > 0)
            {
                턴시작 = true;
                턴시작시초기화();
                StartCoroutine(적1턴메시지());
            }
            else
            {

                현재턴수 = 현재턴수 + 1;
                턴시작시초기화();

            }

        }

        if (현재턴수 == 적부여턴수2 && 턴시작 == false)
        {
            if (심해인2.체력 > 0)
            {
                턴시작 = true;
                턴시작시초기화();
                StartCoroutine(적2턴메시지());
            }
            else
            {

                현재턴수 = 현재턴수 + 1;
                턴시작시초기화();

            }


        }
        if (현재턴수 == 적부여턴수3 && 턴시작 == false)
        {
            if (심해인3.체력 > 0)
            {
                턴시작 = true;
                턴시작시초기화();
                StartCoroutine(적3턴메시지());
            }
            else
            {

                현재턴수 = 현재턴수 + 1;
                턴시작시초기화();

            }


        }

    }

    public GameObject 내턴알림;
    public GameObject 적1의턴알림;
    public GameObject 적2의턴알림;
    public GameObject 적3의턴알림;

    IEnumerator 내턴메시지()
    {
        내턴알림.SetActive(true);
        yield return new WaitForSeconds(2f);
        내턴알림.SetActive(false);


        내턴();
    }
    IEnumerator 적1턴메시지()
    {
        적1의턴알림.SetActive(true);
        yield return new WaitForSeconds(2f);
        적1의턴알림.SetActive(false);


        적1의턴();
    }
    IEnumerator 적2턴메시지()
    {
        적2의턴알림.SetActive(true);
        yield return new WaitForSeconds(2f);
        적2의턴알림.SetActive(false);


        적2의턴();
    }
    IEnumerator 적3턴메시지()
    {
        적3의턴알림.SetActive(true);
        yield return new WaitForSeconds(2f);
        적3의턴알림.SetActive(false);
    
        적3의턴();
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
    public GameObject 공격아이템칸뒤로가기;
    public GameObject 적선택가리개;

    //무기선택창
    public GameObject 도구선택창;
    public GameObject 총기류아이템창;
    public GameObject 단검류아이템창;
    public GameObject 투척류아이템창;
    public GameObject 화살표모음;
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
        대상이름.text = "";
        대상설명.text = "";
        whiteBox.SetActive(true);
        공격_도주_눈썰미_재장전.SetActive(true);
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);
        도구선택창.SetActive(false);
        총기류아이템창.SetActive(false);
        단검류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);

    }
    public void 내턴_격투뒤로가기()
    {
        대상이름.text = "";
        대상설명.text = "";
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
    public void 내턴_템선택창뒤로가기()
    {
        대상이름.text = "";
        대상설명.text = "";
        공격_도주_눈썰미_재장전.SetActive(false);
        whiteBox.SetActive(true);
        격투_투척_단검_사격.SetActive(true);
        공격뒤로가기.SetActive(true);
        대기상태로이미지교체();
        근접뒤로가기.SetActive(false);
        적선택가리개.SetActive(false);

        적화살표1.SetActive(false);
        공격아이템칸뒤로가기.SetActive(false);
        도구선택창.SetActive(false);
        총기류아이템창.SetActive(false);
        단검류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);



        rednum = 1;
    }
    public void 내턴_공격류적선뒤로가기()
    {
        대상이름.text = "";
        대상설명.text = "";
        whiteBox.SetActive(true);
        공격_도주_눈썰미_재장전.SetActive(false);
        공격적선택뒤로가기.SetActive(false);
        격투_투척_단검_사격.SetActive(true);
        공격뒤로가기.SetActive(true);

        근접뒤로가기.SetActive(false);
        적선택가리개.SetActive(false);
        화살표모음.SetActive(false);
        적화살표1.SetActive(false);

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
    public void 내턴_재장전버튼()
    {
        기술명 = "재장전";
        공격_도주_눈썰미_재장전.SetActive(false);
        공격뒤로가기.SetActive(true);
        whiteBox.SetActive(false);

        공격아이템칸뒤로가기.SetActive(false);
        도구선택창.SetActive(true);
        총기류아이템창.SetActive(true);
        rednum = 1;
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
        화살표모음.SetActive(true);
        화살표초기화();
    }
    
    
    public void 내턴_사격버튼()
    {
        기술명 = "사격술";
        공격_도주_눈썰미_재장전.SetActive(false);
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);
        whiteBox.SetActive(false);

        공격아이템칸뒤로가기.SetActive(true);
        도구선택창.SetActive(true);
        총기류아이템창.SetActive(true);
        rednum = 1;

    }
    public void 내턴_도검버튼()
    {
        기술명 = "단검술";
        공격_도주_눈썰미_재장전.SetActive(false);
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);
        whiteBox.SetActive(false);

        공격아이템칸뒤로가기.SetActive(true);
        도구선택창.SetActive(true);
        단검류아이템창.SetActive(true);
        rednum = 1;

    }

    public void 내턴_투척버튼()
    {
        기술명 = "투척술";
        공격_도주_눈썰미_재장전.SetActive(false);
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);
        whiteBox.SetActive(false);

        공격아이템칸뒤로가기.SetActive(true);
        도구선택창.SetActive(true);
        투척류아이템창.SetActive(true);
        rednum = 1;

    }
    public void 내턴_도주버튼()
    {
        기술명 = "도주";
        공격_도주_눈썰미_재장전.SetActive(false);

        whiteBox.SetActive(false);
        도주확인창.SetActive(true);
        공격아이템칸뒤로가기.SetActive(false);

        rednum = 1;
    }
    public GameObject 도주확인창;

    public void 내턴_도주확인버튼()
    {
        기술명 = "도주";
        공격_도주_눈썰미_재장전.SetActive(false);
        whiteBox.SetActive(false);
        도주확인창.SetActive(false);

        공격아이템칸뒤로가기.SetActive(false);

        rednum = 1;

        StartCoroutine(도주확인클릭시발동());


    }

    IEnumerator 도주확인클릭시발동()
    {
        대상이름.text = "";
        대상설명.text = "";
        판정창.SetActive(true);
        노아제목.text = "노아 : 도주";
        적제목.text = "??? : 붙잡기";
            
        yield return new WaitForSeconds(2f);

        노아기술.text = "민첩 : " + DataBaseManager.민첩;
        적기술.text = "민첩 : " + 심해인1.민첩;

        yield return new WaitForSeconds(2f);

        StartCoroutine(룰렛작동());
        StartCoroutine(적룰렛작동());
        yield return new WaitForSeconds(6f);






        if (출력기능값 <= DataBaseManager.민첩)
        {
            노아결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.민첩)
        {
            노아결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.민첩 / 3f) && (double)DataBaseManager.민첩 >= 3f)
        {
            노아결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            노아결과.text = "대실패";

        }
        // 전판정


        if (적출력기능값 <= 심해인1.민첩)
        {
            적기결과.text = "보통성공";

        }
        if (적출력기능값 > 심해인1.민첩)
        {
            적기결과.text = "실패";

        }
        if (적출력기능값 <= ((double)심해인1.민첩 / 3f) && (double)심해인1.민첩 >= 3f)
        {
            적기결과.text = "대성공";

        }
        if (적출력기능값 == 10)
        {
            적기결과.text = "대실패";

        }
        yield return new WaitForSeconds(2f);


        if ((노아결과.text == "대성공"))
        {
            결과.text = "노아 판정승";
        }
        else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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



        if (결과.text == "노아 판정승")
        {
            //씬 이동 여기에 넣기. 도주 성공
        }

 

        yield return new WaitForSeconds(2f);

        판정창.SetActive(false);


        턴시작 = false;
        현재턴수 = 현재턴수 + 1;
    }

    public void 내턴_도주돌아가기버튼()
    {
        도주확인창.SetActive(false);
        대상이름.text = "";
        대상설명.text = "";
        whiteBox.SetActive(true);
        공격_도주_눈썰미_재장전.SetActive(true);
        격투_투척_단검_사격.SetActive(false);
        공격뒤로가기.SetActive(false);
        도구선택창.SetActive(false);
        총기류아이템창.SetActive(false);
        단검류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);
    }






    //총기선택 버튼
    public GameObject 플레이어대기;
    public GameObject 플레이어리볼버조준;
    public GameObject 플레이어소총조준;
    public GameObject 플레이어데린저조준;
    public GameObject 플레이어샷건조준;

    void 리볼버조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어리볼버조준.SetActive(true);
        플레이어소총조준.SetActive(false);
        플레이어데린저조준.SetActive(false);
        플레이어샷건조준.SetActive(false);
    }

    void 샷건조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어리볼버조준.SetActive(false);
        플레이어소총조준.SetActive(false);
        플레이어데린저조준.SetActive(false);
        플레이어샷건조준.SetActive(true);
    }

    void 소총조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어리볼버조준.SetActive(false);
        플레이어소총조준.SetActive(true);
        플레이어데린저조준.SetActive(false);
        플레이어샷건조준.SetActive(false);
    }

    void 데맂너조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어리볼버조준.SetActive(false);
        플레이어소총조준.SetActive(false);
        플레이어데린저조준.SetActive(true);
        플레이어샷건조준.SetActive(false);
    }

    void 대기상태로이미지교체()
    {
        플레이어대기.SetActive(true);
        플레이어리볼버조준.SetActive(false);
        플레이어소총조준.SetActive(false);
        플레이어데린저조준.SetActive(false);
        플레이어샷건조준.SetActive(false);

        플레이어몽둥이조준.SetActive(false);
        플레이어단검조준.SetActive(false);
        플레이어도끼조준.SetActive(false);

        플레이어돌조준이미지.SetActive(false);
        플레이어화염병조준이미지.SetActive(false);
    }


    public void 매그넘선택()
    {

        if (기술명 != "재장전")
        {
            if (DataBaseManager.리볼버장탄수 != 0)
            {
                화살표모음.SetActive(true);
                단검류아이템창.SetActive(false);
                총기류아이템창.SetActive(false);
                투척류아이템창.SetActive(false);
                도구선택창.SetActive(false);
                선택된무기 = "리볼버";
                적선택차례 = true;

                리볼버조준이미지교체();

                적선택가리개.SetActive(true);
                근접뒤로가기.SetActive(true);
                공격적선택뒤로가기.SetActive(true);
                화살표초기화();

            }
            else
            {
                장탄수부족on();
            }
        }



        else
        {
            if (DataBaseManager.리볼버장탄수 == 6)
            {
                이미탄꽉참부족();

            }

            else if (DataBaseManager.보유리볼버탄약 != 0)
            {

                if (DataBaseManager.보유리볼버탄약 >= 6)
                {
                    DataBaseManager.보유리볼버탄약 -= 6;
                    DataBaseManager.리볼버장탄수 += 6;
                    StartCoroutine(리볼버장전코루틴());

                }

                else
                {
                    DataBaseManager.리볼버장탄수 = DataBaseManager.보유리볼버탄약;
                    DataBaseManager.보유리볼버탄약 = 0;
                    StartCoroutine(리볼버장전코루틴());

                }

            }
            else
            {

                보유탄수부족부족();


            }
        }


    }
    public void 소형권총선택()
    {


        if (기술명 != "재장전")
        {

            if (DataBaseManager.소형권총장탄수 != 0)
            {
                데맂너조준이미지교체();
                화살표모음.SetActive(true);
                단검류아이템창.SetActive(false);
                총기류아이템창.SetActive(false);
                투척류아이템창.SetActive(false);
                도구선택창.SetActive(false);
                선택된무기 = "소형권총";
                적선택차례 = true;
                적선택가리개.SetActive(true);
                근접뒤로가기.SetActive(true);
                공격적선택뒤로가기.SetActive(true);
                화살표초기화();

            }
            else
            {
                장탄수부족on();
            }
        }

        else
        {
            if (DataBaseManager.소형권총장탄수 == 1)
            {

                이미탄꽉참부족();
            }

            else if (DataBaseManager.보유권총탄약 != 0 && DataBaseManager.소형권총장탄수 != 1)
            {

 
                    DataBaseManager.보유권총탄약 -= 1;
                    DataBaseManager.소형권총장탄수 += 1;
                StartCoroutine(데린저장전코루틴());





            }
            else
            {


                보유탄수부족부족();


            }

        }



    }
    public void 샷건선택()
    {

        if (기술명 != "재장전")
        {
            if (DataBaseManager.샷건장탄수 != 0)
            {
                샷건조준이미지교체();
                화살표모음.SetActive(true);
                단검류아이템창.SetActive(false);
                총기류아이템창.SetActive(false);
                투척류아이템창.SetActive(false);
                도구선택창.SetActive(false);
                선택된무기 = "샷건";
                적선택차례 = true;
                적선택가리개.SetActive(true);
                근접뒤로가기.SetActive(true);
                공격적선택뒤로가기.SetActive(true);
                화살표초기화();

            }
            else
            {
                장탄수부족on();
            }
        }
        else
        {
            if (DataBaseManager.샷건장탄수 == 2)
            {

                이미탄꽉참부족();
            }

            else if (DataBaseManager.보유샷건탄약 != 0)
            {

                if (DataBaseManager.보유샷건탄약 >= 2 )
                {
                    DataBaseManager.보유샷건탄약 -= 2;
                    DataBaseManager.샷건장탄수 += 2;

                    StartCoroutine(샷건장전코루틴());
                }

                else
                {
                    DataBaseManager.샷건장탄수 = DataBaseManager.보유샷건탄약;
                    DataBaseManager.보유샷건탄약 = 0;
                    StartCoroutine(샷건장전코루틴());

                }

            }
            else
            {


                보유탄수부족부족();



            }
        }





    }
    public void 소총선택()
    {

        if (기술명 != "재장전")
        {
            if (DataBaseManager.소총장탄수 != 0)
            {
                소총조준이미지교체();
                화살표모음.SetActive(true);
                단검류아이템창.SetActive(false);
                총기류아이템창.SetActive(false);
                투척류아이템창.SetActive(false);
                도구선택창.SetActive(false);
                선택된무기 = "소총";
                적선택차례 = true;
                적선택가리개.SetActive(true);
                근접뒤로가기.SetActive(true);
                공격적선택뒤로가기.SetActive(true);
                화살표초기화();

            }
            else
            {
                장탄수부족on();
            }
        }

        else
        {

            if(DataBaseManager.소총장탄수 == 1)
            {


                이미탄꽉참부족(); ;
            }

            else if (DataBaseManager.보유소총탄약 != 0)
            {


                DataBaseManager.보유소총탄약 -= 1;
                DataBaseManager.소총장탄수 += 1;
                StartCoroutine(소총장전코루틴());


            }
            else
            {



                보유탄수부족부족();



            }

        }

    }

    public GameObject 소총장전이미지;
    public GameObject 샷건장전이미지;
    public GameObject 데린저장전이미지;
    public GameObject 리볼버장전이미지;

    IEnumerator 소총장전코루틴()
    {
        플레이어대기.SetActive(false);
        소총장전이미지.SetActive(true);
        yield return new WaitForSeconds(2f);
        플레이어대기.SetActive(true);
        소총장전이미지.SetActive(false);
        턴시작 = false;
        현재턴수 = 현재턴수 + 1;
    }

    IEnumerator 샷건장전코루틴()
    {
        플레이어대기.SetActive(false);
        샷건장전이미지.SetActive(true);
        yield return new WaitForSeconds(2f);
        플레이어대기.SetActive(true);
        샷건장전이미지.SetActive(false);
        턴시작 = false;
        현재턴수 = 현재턴수 + 1;
    }
    IEnumerator 데린저장전코루틴()
    {
        플레이어대기.SetActive(false);
        데린저장전이미지.SetActive(true);
        yield return new WaitForSeconds(2f);
        플레이어대기.SetActive(true);
        데린저장전이미지.SetActive(false);
        턴시작 = false;
        현재턴수 = 현재턴수 + 1;
    }
    IEnumerator 리볼버장전코루틴()
    {
        플레이어대기.SetActive(false);
        리볼버장전이미지.SetActive(true);
        yield return new WaitForSeconds(2f);
        플레이어대기.SetActive(true);
        리볼버장전이미지.SetActive(false);
        턴시작 = false;
        현재턴수 = 현재턴수 + 1;
    }
    public GameObject 플레이어몽둥이조준;
    public GameObject 플레이어단검조준;
    public GameObject 플레이어도끼조준;
    
    void 몽둥이조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어몽둥이조준.SetActive(true);
        플레이어단검조준.SetActive(false);
        플레이어도끼조준.SetActive(false);

    }


    void 단검조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어몽둥이조준.SetActive(false);
        플레이어단검조준.SetActive(true);
        플레이어도끼조준.SetActive(false);

    }

    void 도끼조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어몽둥이조준.SetActive(false);
        플레이어단검조준.SetActive(false);
        플레이어도끼조준.SetActive(true);

    }




    public void 단검선택()
    {
        단검조준이미지교체();
        화살표모음.SetActive(true);
        도구선택창.SetActive(false);
        단검류아이템창.SetActive(false);
        총기류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);
        선택된무기 = "단검";
        적선택차례 = true;
        적선택가리개.SetActive(true);
        근접뒤로가기.SetActive(true);
        공격적선택뒤로가기.SetActive(true);
        화살표초기화();


    }

    public void 손도끼선택()
    {
        도끼조준이미지교체();
        화살표모음.SetActive(true);
        도구선택창.SetActive(false);
        단검류아이템창.SetActive(false);   
        총기류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);
        선택된무기 = "손도끼";
        적선택차례 = true;
        적선택가리개.SetActive(true);
        근접뒤로가기.SetActive(true);
        공격적선택뒤로가기.SetActive(true);
        화살표초기화();


    }

    public void 몽둥이선택()
    {
        몽둥이조준이미지교체();
        화살표모음.SetActive(true);
        도구선택창.SetActive(false);
        단검류아이템창.SetActive(false);
        총기류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);
        선택된무기 = "몽둥이";
        적선택차례 = true;
        적선택가리개.SetActive(true);
        근접뒤로가기.SetActive(true);
        공격적선택뒤로가기.SetActive(true);
        화살표초기화();


    }

    public GameObject 플레이어돌조준이미지;
    public GameObject 플레이어화염병조준이미지;
    void 돌조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어돌조준이미지.SetActive(true);
        플레이어화염병조준이미지.SetActive(false);


    }
    void 화염병조준이미지교체()
    {
        플레이어대기.SetActive(false);
        플레이어돌조준이미지.SetActive(false);
        플레이어화염병조준이미지.SetActive(true);


    }
    public void 돌선택()
    {
        돌조준이미지교체();
        화살표모음.SetActive(true);
        도구선택창.SetActive(false);
        단검류아이템창.SetActive(false);
        총기류아이템창.SetActive(false);
        투척류아이템창.SetActive(false);
        선택된무기 = "돌";
        적선택차례 = true;
        적선택가리개.SetActive(true);
        근접뒤로가기.SetActive(true);
        공격적선택뒤로가기.SetActive(true);
        화살표초기화();


    }


    public void 화염병선택()
    {
        if (DataBaseManager.화염병보유수 != 0)
        {
            화염병조준이미지교체();
            화살표모음.SetActive(true);
            도구선택창.SetActive(false);
            단검류아이템창.SetActive(false);
            총기류아이템창.SetActive(false);
            투척류아이템창.SetActive(false);
            선택된무기 = "화염병";
            적선택차례 = true;
            적선택가리개.SetActive(true);
            근접뒤로가기.SetActive(true);
            공격적선택뒤로가기.SetActive(true);
            화살표초기화();
        }
        else
        {
            보유수부족부족on();
        }



    }

    public GameObject 장탄수부족메시지;
    public GameObject 보유탄수부족메시지;
    public GameObject 이미탄약꽉참메시지;
    public GameObject 꺼지는버튼;
    public void 장탄수부족on()
    {
        꺼지는버튼.SetActive(true);
        장탄수부족메시지.SetActive(true);

    }
    public void 알림창off()
    {
        꺼지는버튼.SetActive(false);
        보유수부족메시지.SetActive(false);
        장탄수부족메시지.SetActive(false);
        보유탄수부족메시지.SetActive(false);
        이미탄약꽉참메시지.SetActive(false);
    }
    public void 보유탄수부족부족()
    {
        꺼지는버튼.SetActive(true);
        보유탄수부족메시지.SetActive(true);

    }
    public void 이미탄꽉참부족()
    {
        꺼지는버튼.SetActive(true);
        이미탄약꽉참메시지.SetActive(true);

    }
    public void 시작시총알미리장전()
    {
        if (DataBaseManager.리볼버장탄수 < 6)
        {
            while (DataBaseManager.리볼버장탄수 < 6)
            {
               if(DataBaseManager.보유리볼버탄약 == 0)
                {
                    break;
                }

                DataBaseManager.리볼버장탄수 += 1;
                DataBaseManager.보유리볼버탄약 -= 1;

            }
        }

        if (DataBaseManager.소형권총장탄수 < 1 && DataBaseManager.보유권총탄약 >=1)
        {


            DataBaseManager.소형권총장탄수 += 1;
            DataBaseManager.보유권총탄약 -= 1;

        }

        if (DataBaseManager.소총장탄수 < 1 && DataBaseManager.보유소총탄약 >= 1)
        {

            DataBaseManager.소총장탄수 += 1;
            DataBaseManager.보유소총탄약 -= 1;


        }

        if (DataBaseManager.샷건장탄수 < 2)
        {
            while (DataBaseManager.샷건장탄수 < 2)
            {
                if (DataBaseManager.보유샷건탄약 == 0)
                {
                    break;
                }

                DataBaseManager.샷건장탄수 += 1;
                DataBaseManager.보유샷건탄약 -= 1;

            }
        }

    }   

    public void 보유수부족부족on()
    {
        꺼지는버튼.SetActive(true);
        보유수부족메시지.SetActive(true);

    }

    public GameObject 보유수부족메시지;
    int rednum = 1;
    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    public GameObject r4;
    public GameObject r5;
    public GameObject r6;
    public GameObject r7;
    public GameObject r8;
    // //////////////////////////////////아이템창 관리
    void 메뉴창업데이터()
    {

        if (rednum == 1)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r1.SetActive(true);
        }

        else if (rednum == 2)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r2.SetActive(true);
        }

        else if (rednum == 3)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r3.SetActive(true);
        }

        else if (rednum == 4)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r4.SetActive(true);
        }

        else if (rednum == 5)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r5.SetActive(true);
        }
        else if (rednum == 6)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r6.SetActive(true);
        }
        else if (rednum == 7)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r7.SetActive(true);
        }

        else if (rednum == 8)
        {
            r1.SetActive(false);
            r2.SetActive(false);
            r3.SetActive(false);
            r4.SetActive(false);
            r5.SetActive(false);
            r6.SetActive(false);
            r7.SetActive(false);
            r8.SetActive(false);

            r8.SetActive(true);
        }


    }
    void 총기류메뉴창()
    {



        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (rednum == 8)
            {
                rednum = 1;
            }

            else
            {
                rednum = rednum + 1;
            }


        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (rednum == 1)
            {
                rednum = 5;
            }
            else if (rednum == 2)
            {
                rednum = 6;
            }
            else if (rednum == 3)
            {
                rednum = 7;
            }
            else if (rednum == 4)
            {
                rednum = 8;
            }
            else if (rednum == 5)
            {
                rednum = 1;
            }
            else if (rednum == 6)
            {
                rednum = 2;
            }
            else if (rednum == 7)
            {
                rednum = 3;
            }
            else if (rednum == 8)
            {
                rednum = 4;
            }


        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (rednum == 1)
            {
                rednum = 5;
            }
            else if (rednum == 2)
            {
                rednum = 6;
            }
            else if (rednum == 3)
            {
                rednum = 7;
            }
            else if (rednum == 4)
            {
                rednum = 8;
            }
            else if (rednum == 5)
            {
                rednum = 1;
            }
            else if (rednum == 6)
            {
                rednum = 2;
            }
            else if (rednum == 7)
            {
                rednum = 3;
            }
            else if (rednum == 8)
            {
                rednum = 4;
            }




        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (rednum == 1)
            {
                rednum = 8;
            }

            else
            {
                rednum = rednum - 1;
            }
        }

    }


    // 무기 마우스 정보창
    public void 리볼버정보창엔터()
    {
        대상이름.text = "리볼버";
        대상설명.text = "최대장탄수 6발" + "\n" + " 대미지 1~8" + "\n"+ " 현재 장탄수 " + DataBaseManager.리볼버장탄수;

    }
    public void 리볼버정보창아웃()
    {
        대상이름.text = "";
        대상설명.text = "";

    }

    public void 소형권총정보창엔터()
    {
        대상이름.text = "소형 권총";
        대상설명.text = "최대장탄수 1발" + "\n" + " 대미지 1~6 " + "\n" + "현재 장탄수 " + DataBaseManager.소형권총장탄수;

    }

    public void 샷건권총정보창엔터()
    {
        대상이름.text = "16게이지 산탄총";
        대상설명.text = "최대장탄수 2발" + "\n" + " 대미지 2~10 " + "\n" + " 현재 장탄수 " + DataBaseManager.샷건장탄수;

    }
    public void 소총권총정보창엔터()
    {
        대상이름.text = "30구경 소총";
        대상설명.text = "최대장탄수 1발" + "\n" + " 대미지 2~12" + "\n" + " 현재 장탄수 " + DataBaseManager.소총장탄수;

    }

    public void 단검정보창엔터()
    {
        대상이름.text = "단검";
        대상설명.text = " 대미지 2~4 ";

    }
    public void 손도끼정보창엔터()
    {
        대상이름.text = "손도끼";
        대상설명.text = " 대미지 2~5 ";

    }
    public void 몽둥이정보창엔터()
    {
        대상이름.text = "몽둥이";
        대상설명.text = " 대미지 2~3 ";

    }
    public void 돌정보창엔터()
    {
        대상이름.text = "돌";
        대상설명.text = " 대미지 2~3 ";

    }
    public void 화염병정보창엔터()
    {
        대상이름.text = "소형 권총";
        대상설명.text = " 대미지 5~10 " +"\n"+"화염병 보유수 : " + DataBaseManager.화염병보유수;

    }

    public void 턴시작시초기화()
    {
        십의자리.text = "0";
        일의자리.text = "0";
        적십의자리.text = "0";
        적일의자리.text = "0";
        장탄수부족메시지.SetActive(false);
        리볼버정보창아웃();
        공격_도주_눈썰미_재장전.SetActive(false);
        공격적선택뒤로가기.SetActive(false);
        근접뒤로가기.SetActive(false);
        공격뒤로가기.SetActive(false);
        도구선택창.SetActive(false);

        적선택가리개.SetActive(false);
        적화살표1.SetActive(false);
        적화살표2.SetActive(false);
        적화살표3.SetActive(false);


        기술명 = "";
        공격아이템칸뒤로가기.SetActive(false);
        노아제목.text = "------";
        적제목.text = "------";
        노아기술.text = "------";
        적기술.text = "------";
        노아결과.text = "------";
        적기결과.text = "------";
        결과.text = "------";
        whiteNum = 1;
        내턴인가 = false;
        내턴기본 = false;
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
            if(심해인1.체력 > 0)
            {
                적화살표1.SetActive(true);
                적화살표2.SetActive(false);
                적화살표3.SetActive(false);

            }
            else if (심해인1.체력 <= 0 && 심해인2.체력>0)
            {
                적화살표1.SetActive(false);
                적화살표2.SetActive(true);
                적화살표3.SetActive(false);

            }
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
            if (심해인1.체력 > 0)
            {
                적화살표1.SetActive(true);
                적화살표2.SetActive(false);
                적화살표3.SetActive(false);

            }
            else if (심해인1.체력 <= 0 && 심해인2.체력 > 0)
            {
                적화살표1.SetActive(false);
                적화살표2.SetActive(true);
                적화살표3.SetActive(false);

            }
            else
            {
                적화살표1.SetActive(false);
                적화살표2.SetActive(false);
                적화살표3.SetActive(true);
            }
        }

    }

    public void 화살표초기화()
    {
        if (심해인1.체력 > 0)
        {
            적화살표1.SetActive(true);
            적화살표2.SetActive(false);
            적화살표3.SetActive(false);

        }
        else if (심해인1.체력 <= 0 && 심해인2.체력 > 0)
        {
            적화살표1.SetActive(false);
            적화살표2.SetActive(true);
            적화살표3.SetActive(false);

        }
        else
        {
            적화살표1.SetActive(false);
            적화살표2.SetActive(false);
            적화살표3.SetActive(true);
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
            화살표모음.SetActive(false);
            적화살표1.SetActive(false);
            적화살표2.SetActive(false);
            적화살표3.SetActive(false);
            StartCoroutine(적클릭1());
        }

    }

    public void 적클릭버튼_2()
    {
        if (적선택차례 == true)
        {
            화살표모음.SetActive(false);
            적화살표1.SetActive(false);
            적화살표2.SetActive(false);
            적화살표3.SetActive(false);
            StartCoroutine(적클릭2());
        }

    }
    public void 적클릭버튼_3()
    {
        if (적선택차례 == true)
        {
            화살표모음.SetActive(false);
            적화살표1.SetActive(false);
            적화살표2.SetActive(false);
            적화살표3.SetActive(false);
            StartCoroutine(적클릭3());
        }

    }
    //데미지 와 장탄수
    public int 근력대미지;

    public int 리볼버대미지;
    public int 소총대미지;
    public int 소형권총대미지;
    public int 샷건대미지;


    public int 단검대미지;
    public int 손도끼대미지;
    public int 몽둥이대미지;

    public int 돌대미지;
    public int 화염병대미지;


    public string 선택된무기;



    public GameObject 노아피격이미지;
    public GameObject 노아소총공격이미지;
    public GameObject 노아리볼버공격이미지;
    public GameObject 노아데린저공격이미지;
    public GameObject 노아샷건공격이미지;
    public GameObject 우측플로팅텍스트;


    public GameObject 노아단검공격이미지;
    public GameObject 노아도끼공격이미지;
    public GameObject 노아몽둥이공격이미지;

    public GameObject 노아투척후이미지;

    public GameObject 적대기이미지;
    public GameObject 적피격이미지;
    public GameObject 적공격이미지;
    //무기선택버튼 관련
 



    public IEnumerator 적클릭1()
    {
        대상이름.text = "";
        대상설명.text = "";

        근력대미지 = Random.Range(1, 4);

        리볼버대미지 = Random.Range(1, 9);
        샷건대미지 = Random.Range(2, 11);
        소형권총대미지 = Random.Range(1, 7);
        소총대미지 = Random.Range(2, 13);

        단검대미지 = Random.Range(2, 5);
        손도끼대미지 = Random.Range(2, 6);
        몽둥이대미지 = Random.Range(2, 4);

        돌대미지 = Random.Range(2, 4);
        화염병대미지 = Random.Range(5, 11);


        판정창.SetActive(true);

        



        //근접전투 관련 공격
        if (기술명 == "근접격투" && 심해인1.체력 > ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






             if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
             if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
             if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인맨손격투 / 3f) && (double)심해인1.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

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

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);





            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인1.체력);
                Debug.Log(근력대미지);
                심해인1.체력 = 심해인1.체력 - 근력대미지;
                Debug.Log(심해인1.체력);
               
                
                
                var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                clone.GetComponent<플로팅택스트>().Text.text = 근력대미지.ToString();
                clone.transform.SetParent(ui창.transform);

                DataBaseManager.카메라워킹온오프 = true;

                플레이어대기.SetActive(false);
                근접공격.SetActive(true);

                적대기이미지.SetActive(false);
                적피격이미지.SetActive(true);

                yield return new WaitForSeconds(3f);

                플레이어대기.SetActive(true);
                근접공격.SetActive(false);

                적대기이미지.SetActive(true);
                적피격이미지.SetActive(false);

            }

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 1.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 2.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 3.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);
                }
            }




            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        else if (기술명 == "근접격투" && 심해인1.체력 <= ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "회피 : " + 심해인1.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인회피 / 3f) && (double)심해인1.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }
      

            else if ( (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ( (노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }
     

            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인1.체력);
                Debug.Log(근력대미지);
                심해인1.체력 = 심해인1.체력 - 근력대미지;
                Debug.Log(심해인1.체력);

                var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                clone.GetComponent<플로팅택스트>().Text.text = 근력대미지.ToString();
                clone.transform.SetParent(ui창.transform);

                DataBaseManager.카메라워킹온오프 = true;

                플레이어대기.SetActive(false);
                근접공격.SetActive(true);

                적대기이미지.SetActive(false);
                적피격이미지.SetActive(true);

                yield return new WaitForSeconds(3f);

                플레이어대기.SetActive(true);
                근접공격.SetActive(false);

                적대기이미지.SetActive(true);
                적피격이미지.SetActive(false);
            }



            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        if (기술명 == "사격술" && 심해인1.체력 > ((double)심해인1.전체체력 / 2f))
        {
            
            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.사격술;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.사격술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.사격술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.사격술 / 3f) && (double)DataBaseManager.사격술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인맨손격투 / 3f) && (double)심해인1.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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


            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);




            if (선택된무기 == "리볼버")
            {
                DataBaseManager.리볼버장탄수 = DataBaseManager.리볼버장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(리볼버대미지);
                    심해인1.체력 = 심해인1.체력 - 리볼버대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 리볼버대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어리볼버조준.SetActive(false);
                    노아리볼버공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아리볼버공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }

            else if (선택된무기 == "소형권총")
            {
                DataBaseManager.소형권총장탄수 = DataBaseManager.소형권총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(소형권총대미지);
                    심해인1.체력 = 심해인1.체력 - 소형권총대미지;
                    Debug.Log(심해인1.체력);


                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 소형권총대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어데린저조준.SetActive(false);
                    노아데린저공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아데린저공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }
            else if(선택된무기 == "소총")
            {
                DataBaseManager.소총장탄수 = DataBaseManager.소총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(소총대미지);
                    심해인1.체력 = 심해인1.체력 - 소총대미지;
                    Debug.Log(심해인1.체력);



                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 소총대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어소총조준.SetActive(false);
                    노아소총공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아소총공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }
            else if(선택된무기 == "샷건")
            {
                DataBaseManager.샷건장탄수 = DataBaseManager.샷건장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(샷건대미지);
                    심해인1.체력 = 심해인1.체력 - 샷건대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 샷건대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어샷건조준.SetActive(false);
                    노아샷건공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아샷건공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }
            플레이어리볼버조준.SetActive(false);
            플레이어데린저조준.SetActive(false);
            플레이어소총조준.SetActive(false);
            플레이어샷건조준.SetActive(false);
            플레이어대기.SetActive(true);



            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "사격술" && 심해인1.체력 <= ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.사격술;
            적기술.text = "회피 : " + 심해인1.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.사격술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.사격술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.사격술 / 3f) && (double)DataBaseManager.사격술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인회피 / 3f) && (double)심해인1.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }


            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);





            if (선택된무기 == "리볼버")
            {
                DataBaseManager.리볼버장탄수 = DataBaseManager.리볼버장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(리볼버대미지);
                    심해인1.체력 = 심해인1.체력 - 리볼버대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 리볼버대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어리볼버조준.SetActive(false);
                    노아리볼버공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아리볼버공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }

            else if (선택된무기 == "소형권총")
            {
                DataBaseManager.소형권총장탄수 = DataBaseManager.소형권총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(소형권총대미지);
                    심해인1.체력 = 심해인1.체력 - 소형권총대미지;
                    Debug.Log(심해인1.체력);


                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 소형권총대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어데린저조준.SetActive(false);
                    노아데린저공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아데린저공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }
            else if (선택된무기 == "소총")
            {
                DataBaseManager.소총장탄수 = DataBaseManager.소총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(소총대미지);
                    심해인1.체력 = 심해인1.체력 - 소총대미지;
                    Debug.Log(심해인1.체력);



                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 소총대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어소총조준.SetActive(false);
                    노아소총공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아소총공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }
            else if (선택된무기 == "샷건")
            {
                DataBaseManager.샷건장탄수 = DataBaseManager.샷건장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(샷건대미지);
                    심해인1.체력 = 심해인1.체력 - 샷건대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 샷건대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어샷건조준.SetActive(false);
                    노아샷건공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아샷건공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }


            플레이어리볼버조준.SetActive(false);
            플레이어데린저조준.SetActive(false);
            플레이어소총조준.SetActive(false);
            플레이어샷건조준.SetActive(false);
            플레이어대기.SetActive(true);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        if (기술명 == "단검술" && 심해인1.체력 > ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "단검술 : " + DataBaseManager.검술;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.검술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.검술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.검술 / 3f) && (double)DataBaseManager.검술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인맨손격투 / 3f) && (double)심해인1.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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


            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            if (결과.text == "노아 판정승")
            {
                if (선택된무기 == "단검")
                {

                    Debug.Log(심해인1.체력);
                    Debug.Log(단검대미지);
                    심해인1.체력 = 심해인1.체력 - 단검대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 단검대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어단검조준.SetActive(false);
                    노아단검공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아단검공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

                else if (선택된무기 == "손도끼")
                {

                    Debug.Log(심해인1.체력);
                    Debug.Log(손도끼대미지);
                    심해인1.체력 = 심해인1.체력 - 손도끼대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 손도끼대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어도끼조준.SetActive(false);
                    노아도끼공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아도끼공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);

                }
                else if (선택된무기 == "몽둥이")
                {

                    Debug.Log(심해인1.체력);
                    Debug.Log(몽둥이대미지);
                    심해인1.체력 = 심해인1.체력 - 몽둥이대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 몽둥이대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어몽둥이조준.SetActive(false);
                    노아몽둥이공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아몽둥이공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }
            }

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 1.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 2.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 3.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);
                }
            }


            플레이어도끼조준.SetActive(false);
            플레이어단검조준.SetActive(false);
            플레이어몽둥이조준.SetActive(false);

            플레이어대기.SetActive(true);



            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "단검술" && 심해인1.체력 <= ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.검술;
            적기술.text = "회피 : " + 심해인1.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.검술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.검술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.검술 / 3f) && (double)DataBaseManager.검술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인회피 / 3f) && (double)심해인1.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }


            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);



            if (결과.text == "노아 판정승")
            {
                if (선택된무기 == "단검")
                {

                    Debug.Log(심해인1.체력);
                    Debug.Log(단검대미지);
                    심해인1.체력 = 심해인1.체력 - 단검대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 단검대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어단검조준.SetActive(false);
                    노아단검공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아단검공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

                else if (선택된무기 == "손도끼")
                {

                    Debug.Log(심해인1.체력);
                    Debug.Log(손도끼대미지);
                    심해인1.체력 = 심해인1.체력 - 손도끼대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 손도끼대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어도끼조준.SetActive(false);
                    노아도끼공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아도끼공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);

                }
                else if (선택된무기 == "몽둥이")
                {

                    Debug.Log(심해인1.체력);
                    Debug.Log(몽둥이대미지);
                    심해인1.체력 = 심해인1.체력 - 몽둥이대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 몽둥이대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어몽둥이조준.SetActive(false);
                    노아몽둥이공격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아몽둥이공격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }
            }


            플레이어도끼조준.SetActive(false);
            플레이어단검조준.SetActive(false);
            플레이어몽둥이조준.SetActive(false);

            플레이어대기.SetActive(true);

            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        if (기술명 == "투척술" && 심해인1.체력 > ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "던지기 : " + DataBaseManager.던지기;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.던지기)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.던지기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.던지기 / 3f) && (double)DataBaseManager.던지기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인맨손격투 / 3f) && (double)심해인1.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);




            if (선택된무기 == "돌")
            {

                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(돌대미지);
                    심해인1.체력 = 심해인1.체력 - 돌대미지;
                    Debug.Log(심해인1.체력);


                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 돌대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어돌조준이미지.SetActive(false);
                    노아투척후이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아투척후이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }

            else if (선택된무기 == "화염병")
            {
                DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(화염병대미지);
                    심해인1.체력 = 심해인1.체력 - 화염병대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 화염병대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어화염병조준이미지.SetActive(false);
                    노아투척후이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아투척후이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }



            플레이어돌조준이미지.SetActive(false);
            플레이어화염병조준이미지.SetActive(false);


            플레이어대기.SetActive(true);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "투척술" && 심해인1.체력 <= ((double)심해인1.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "던지기 : " + DataBaseManager.던지기;
            적기술.text = "회피 : " + 심해인1.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.던지기)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.던지기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.던지기 / 3f) && (double)DataBaseManager.던지기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인1.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인1.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인회피 / 3f) && (double)심해인1.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);

            if (선택된무기 == "돌")
            {

                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(돌대미지);
                    심해인1.체력 = 심해인1.체력 - 돌대미지;
                    Debug.Log(심해인1.체력);


                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 돌대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어돌조준이미지.SetActive(false);
                    노아투척후이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아투척후이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }

            else if (선택된무기 == "화염병")
            {
                DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인1.체력);
                    Debug.Log(화염병대미지);
                    심해인1.체력 = 심해인1.체력 - 화염병대미지;
                    Debug.Log(심해인1.체력);

                    var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅택스트>().Text.text = 화염병대미지.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라워킹온오프 = true;

                    플레이어화염병조준이미지.SetActive(false);
                    노아투척후이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적피격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아투척후이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적피격이미지.SetActive(false);
                }

            }

            플레이어돌조준이미지.SetActive(false);
            플레이어화염병조준이미지.SetActive(false);


            플레이어대기.SetActive(true);

            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

    }

    public IEnumerator 적클릭2()
    {
        대상이름.text = "";
        대상설명.text = "";

        근력대미지 = Random.Range(1, 4);

        리볼버대미지 = Random.Range(1, 9);
        샷건대미지 = Random.Range(2, 11);
        소형권총대미지 = Random.Range(1, 7);
        소총대미지 = Random.Range(2, 13);

        단검대미지 = Random.Range(2, 5);
        손도끼대미지 = Random.Range(2, 6);
        몽둥이대미지 = Random.Range(2, 4);

        돌대미지 = Random.Range(2, 4);
        화염병대미지 = Random.Range(5, 11);


        판정창.SetActive(true);





        //근접전투 관련 공격
        if (기술명 == "근접격투" && 심해인2.체력 > ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "근접격투 : " + 심해인2.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인맨손격투 / 3f) && (double)심해인2.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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



            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인2.체력);
                Debug.Log(근력대미지);
                심해인2.체력 = 심해인2.체력 - 근력대미지;
                Debug.Log(심해인2.체력);
            }

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        else if (기술명 == "근접격투" && 심해인2.체력 <= ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "회피 : " + 심해인2.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인회피 / 3f) && (double)심해인2.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }




            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인2.체력);
                Debug.Log(근력대미지);
                심해인2.체력 = 심해인2.체력 - 근력대미지;
                Debug.Log(심해인2.체력);
            }
            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        if (기술명 == "사격술" && 심해인2.체력 > ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.사격술;
            적기술.text = "근접격투 : " + 심해인2.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.사격술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.사격술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.사격술 / 3f) && (double)DataBaseManager.사격술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인맨손격투 / 3f) && (double)심해인2.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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

            if (선택된무기 == "리볼버")
            {
                DataBaseManager.리볼버장탄수 = DataBaseManager.리볼버장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(리볼버대미지);
                    심해인2.체력 = 심해인2.체력 - 리볼버대미지;
                    Debug.Log(심해인2.체력);
                }

            }

            else if (선택된무기 == "소형권총")
            {
                DataBaseManager.소형권총장탄수 = DataBaseManager.소형권총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(소형권총대미지);
                    심해인2.체력 = 심해인2.체력 - 소형권총대미지;
                    Debug.Log(심해인2.체력);
                }

            }
            if (선택된무기 == "소총")
            {
                DataBaseManager.소총장탄수 = DataBaseManager.소총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(소총대미지);
                    심해인2.체력 = 심해인2.체력 - 소총대미지;
                    Debug.Log(심해인2.체력);
                }

            }
            if (선택된무기 == "샷건")
            {
                DataBaseManager.샷건장탄수 = DataBaseManager.샷건장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(샷건대미지);
                    심해인2.체력 = 심해인2.체력 - 샷건대미지;
                    Debug.Log(심해인2.체력);
                }

            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "사격술" && 심해인2.체력 <= ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.사격술;
            적기술.text = "회피 : " + 심해인2.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.사격술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.사격술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.사격술 / 3f) && (double)DataBaseManager.사격술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인회피 / 3f) && (double)심해인2.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }


            if (선택된무기 == "리볼버")
            {
                DataBaseManager.리볼버장탄수 = DataBaseManager.리볼버장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(리볼버대미지);
                    심해인2.체력 = 심해인2.체력 - 리볼버대미지;
                    Debug.Log(심해인2.체력);
                }
            }


            else if (선택된무기 == "소형권총")
            {
                DataBaseManager.소형권총장탄수 = DataBaseManager.소형권총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(소형권총대미지);
                    심해인2.체력 = 심해인2.체력 - 소형권총대미지;
                    Debug.Log(심해인2.체력);
                }

            }
            if (선택된무기 == "소총")
            {
                DataBaseManager.소총장탄수 = DataBaseManager.소총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(소총대미지);
                    심해인2.체력 = 심해인2.체력 - 소총대미지;
                    Debug.Log(심해인2.체력);
                }

            }
            if (선택된무기 == "샷건")
            {
                DataBaseManager.샷건장탄수 = DataBaseManager.샷건장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(샷건대미지);
                    심해인2.체력 = 심해인2.체력 - 샷건대미지;
                    Debug.Log(심해인2.체력);
                }

            }
            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        if (기술명 == "단검술" && 심해인2.체력 > ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "단검술 : " + DataBaseManager.검술;
            적기술.text = "근접격투 : " + 심해인2.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.검술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.검술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.검술 / 3f) && (double)DataBaseManager.검술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인맨손격투 / 3f) && (double)심해인2.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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
            if (결과.text == "노아 판정승")
            {
                if (선택된무기 == "단검")
                {

                    Debug.Log(심해인2.체력);
                    Debug.Log(단검대미지);
                    심해인2.체력 = 심해인2.체력 - 단검대미지;
                    Debug.Log(심해인2.체력);


                }

                else if (선택된무기 == "손도끼")
                {

                    Debug.Log(심해인2.체력);
                    Debug.Log(손도끼대미지);
                    심해인2.체력 = 심해인2.체력 - 손도끼대미지;
                    Debug.Log(심해인2.체력);


                }
                else if (선택된무기 == "몽둥이")
                {

                    Debug.Log(심해인2.체력);
                    Debug.Log(몽둥이대미지);
                    심해인2.체력 = 심해인2.체력 - 몽둥이대미지;
                    Debug.Log(심해인2.체력);


                }
            }

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
            }



            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "단검술" && 심해인2.체력 <= ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.검술;
            적기술.text = "회피 : " + 심해인2.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.검술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.검술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.검술 / 3f) && (double)DataBaseManager.검술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인회피 / 3f) && (double)심해인2.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }
            if (결과.text == "노아 판정승")
            {

                if (선택된무기 == "단검")
                {

                    Debug.Log(심해인2.체력);
                    Debug.Log(단검대미지);
                    심해인2.체력 = 심해인2.체력 - 단검대미지;
                    Debug.Log(심해인2.체력);


                }

                else if (선택된무기 == "손도끼")
                {

                    Debug.Log(심해인2.체력);
                    Debug.Log(손도끼대미지);
                    심해인2.체력 = 심해인2.체력 - 손도끼대미지;
                    Debug.Log(심해인2.체력);


                }
                else if (선택된무기 == "몽둥이")
                {

                    Debug.Log(심해인2.체력);
                    Debug.Log(몽둥이대미지);
                    심해인2.체력 = 심해인2.체력 - 몽둥이대미지;
                    Debug.Log(심해인2.체력);


                }
            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }
        if (기술명 == "투척술" && 심해인2.체력 > ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "던지기 : " + DataBaseManager.던지기;
            적기술.text = "근접격투 : " + 심해인2.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.던지기)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.던지기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.던지기 / 3f) && (double)DataBaseManager.던지기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인맨손격투 / 3f) && (double)심해인2.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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

            if (선택된무기 == "돌")
            {

                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(돌대미지);
                    심해인2.체력 = 심해인2.체력 - 돌대미지;
                    Debug.Log(심해인2.체력);
                }

            }

            else if (선택된무기 == "화염병")
            {
                DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(화염병대미지);
                    심해인2.체력 = 심해인2.체력 - 화염병대미지;
                    Debug.Log(심해인2.체력);
                }

            }


            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "투척술" && 심해인2.체력 <= ((double)심해인2.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "던지기 : " + DataBaseManager.던지기;
            적기술.text = "회피 : " + 심해인2.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.던지기)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.던지기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.던지기 / 3f) && (double)DataBaseManager.던지기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인2.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인2.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인2.심해인회피 / 3f) && (double)심해인2.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }


            if (선택된무기 == "돌")
            {

                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(돌대미지);
                    심해인2.체력 = 심해인2.체력 - 돌대미지;
                    Debug.Log(심해인2.체력);
                }
            }


            else if (선택된무기 == "화염병")
            {
                DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인2.체력);
                    Debug.Log(화염병대미지);
                    심해인2.체력 = 심해인2.체력 - 화염병대미지;
                    Debug.Log(심해인2.체력);
                }

            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

    }


    public IEnumerator 적클릭3()
    {
        대상이름.text = "";
        대상설명.text = "";

        근력대미지 = Random.Range(1, 4);

        리볼버대미지 = Random.Range(1, 9);
        샷건대미지 = Random.Range(2, 11);
        소형권총대미지 = Random.Range(1, 7);
        소총대미지 = Random.Range(2, 13);

        단검대미지 = Random.Range(2, 5);
        손도끼대미지 = Random.Range(2, 6);
        몽둥이대미지 = Random.Range(2, 4);

        돌대미지 = Random.Range(2, 4);
        화염병대미지 = Random.Range(5, 11);


        판정창.SetActive(true);





        //근접전투 관련 공격
        if (기술명 == "근접격투" && 심해인3.체력 > ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "근접격투 : " + 심해인3.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인맨손격투 / 3f) && (double)심해인3.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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



            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인3.체력);
                Debug.Log(근력대미지);
                심해인3.체력 = 심해인3.체력 - 근력대미지;
                Debug.Log(심해인3.체력);
            }

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        else if (기술명 == "근접격투" && 심해인3.체력 <= ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "회피 : " + 심해인3.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인회피 / 3f) && (double)심해인3.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }




            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인3.체력);
                Debug.Log(근력대미지);
                심해인3.체력 = 심해인3.체력 - 근력대미지;
                Debug.Log(심해인3.체력);
            }
            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

        if (기술명 == "사격술" && 심해인3.체력 > ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.사격술;
            적기술.text = "근접격투 : " + 심해인3.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.사격술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.사격술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.사격술 / 3f) && (double)DataBaseManager.사격술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인맨손격투 / 3f) && (double)심해인3.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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

            if (선택된무기 == "리볼버")
            {
                DataBaseManager.리볼버장탄수 = DataBaseManager.리볼버장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(리볼버대미지);
                    심해인3.체력 = 심해인3.체력 - 리볼버대미지;
                    Debug.Log(심해인3.체력);
                }

            }

            else if (선택된무기 == "소형권총")
            {
                DataBaseManager.소형권총장탄수 = DataBaseManager.소형권총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(소형권총대미지);
                    심해인3.체력 = 심해인3.체력 - 소형권총대미지;
                    Debug.Log(심해인3.체력);
                }

            }
            if (선택된무기 == "소총")
            {
                DataBaseManager.소총장탄수 = DataBaseManager.소총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(소총대미지);
                    심해인3.체력 = 심해인3.체력 - 소총대미지;
                    Debug.Log(심해인3.체력);
                }

            }
            if (선택된무기 == "샷건")
            {
                DataBaseManager.샷건장탄수 = DataBaseManager.샷건장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(샷건대미지);
                    심해인3.체력 = 심해인3.체력 - 샷건대미지;
                    Debug.Log(심해인3.체력);
                }

            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "사격술" && 심해인3.체력 <= ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.사격술;
            적기술.text = "회피 : " + 심해인3.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.사격술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.사격술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.사격술 / 3f) && (double)DataBaseManager.사격술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인회피 / 3f) && (double)심해인3.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }


            if (선택된무기 == "리볼버")
            {
                DataBaseManager.리볼버장탄수 = DataBaseManager.리볼버장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(리볼버대미지);
                    심해인3.체력 = 심해인3.체력 - 리볼버대미지;
                    Debug.Log(심해인3.체력);
                }
            }


            else if (선택된무기 == "소형권총")
            {
                DataBaseManager.소형권총장탄수 = DataBaseManager.소형권총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(소형권총대미지);
                    심해인3.체력 = 심해인3.체력 - 소형권총대미지;
                    Debug.Log(심해인3.체력);
                }

            }
            if (선택된무기 == "소총")
            {
                DataBaseManager.소총장탄수 = DataBaseManager.소총장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(소총대미지);
                    심해인3.체력 = 심해인3.체력 - 소총대미지;
                    Debug.Log(심해인3.체력);
                }

            }
            if (선택된무기 == "샷건")
            {
                DataBaseManager.샷건장탄수 = DataBaseManager.샷건장탄수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(샷건대미지);
                    심해인3.체력 = 심해인3.체력 - 샷건대미지;
                    Debug.Log(심해인3.체력);
                }

            }
            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        if (기술명 == "단검술" && 심해인3.체력 > ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "단검술 : " + DataBaseManager.검술;
            적기술.text = "근접격투 : " + 심해인3.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.검술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.검술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.검술 / 3f) && (double)DataBaseManager.검술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인맨손격투 / 3f) && (double)심해인3.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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
            if (결과.text == "노아 판정승")
            {
                if (선택된무기 == "단검")
                {

                    Debug.Log(심해인3.체력);
                    Debug.Log(단검대미지);
                    심해인3.체력 = 심해인3.체력 - 단검대미지;
                    Debug.Log(심해인3.체력);


                }

                else if (선택된무기 == "손도끼")
                {

                    Debug.Log(심해인3.체력);
                    Debug.Log(손도끼대미지);
                    심해인3.체력 = 심해인3.체력 - 손도끼대미지;
                    Debug.Log(심해인3.체력);


                }
                else if (선택된무기 == "몽둥이")
                {

                    Debug.Log(심해인3.체력);
                    Debug.Log(몽둥이대미지);
                    심해인3.체력 = 심해인3.체력 - 몽둥이대미지;
                    Debug.Log(심해인3.체력);


                }
            }

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                }
            }



            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "단검술" && 심해인3.체력 <= ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "사격술 : " + DataBaseManager.검술;
            적기술.text = "회피 : " + 심해인3.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.검술)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.검술)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.검술 / 3f) && (double)DataBaseManager.검술 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인회피 / 3f) && (double)심해인3.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }
            if (결과.text == "노아 판정승")
            {

                if (선택된무기 == "단검")
                {

                    Debug.Log(심해인3.체력);
                    Debug.Log(단검대미지);
                    심해인3.체력 = 심해인3.체력 - 단검대미지;
                    Debug.Log(심해인3.체력);


                }

                else if (선택된무기 == "손도끼")
                {

                    Debug.Log(심해인3.체력);
                    Debug.Log(손도끼대미지);
                    심해인3.체력 = 심해인3.체력 - 손도끼대미지;
                    Debug.Log(심해인3.체력);


                }
                else if (선택된무기 == "몽둥이")
                {

                    Debug.Log(심해인3.체력);
                    Debug.Log(몽둥이대미지);
                    심해인3.체력 = 심해인3.체력 - 몽둥이대미지;
                    Debug.Log(심해인3.체력);


                }
            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }
        if (기술명 == "투척술" && 심해인3.체력 > ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 반격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "던지기 : " + DataBaseManager.던지기;
            적기술.text = "근접격투 : " + 심해인3.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.던지기)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.던지기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.던지기 / 3f) && (double)DataBaseManager.던지기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인맨손격투 / 3f) && (double)심해인3.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);


            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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

            if (선택된무기 == "돌")
            {

                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(돌대미지);
                    심해인3.체력 = 심해인3.체력 - 돌대미지;
                    Debug.Log(심해인3.체력);
                }

            }

            else if (선택된무기 == "화염병")
            {
                DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(화염병대미지);
                    심해인3.체력 = 심해인3.체력 - 화염병대미지;
                    Debug.Log(심해인3.체력);
                }

            }


            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }


        else if (기술명 == "투척술" && 심해인3.체력 <= ((double)심해인3.전체체력 / 2f))
        {

            노아제목.text = "노아 : 공격";
            적제목.text = "??? : 회피";

            yield return new WaitForSeconds(2f);

            노아기술.text = "던지기 : " + DataBaseManager.던지기;
            적기술.text = "회피 : " + 심해인3.심해인회피;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






            if (출력기능값 <= DataBaseManager.던지기)
            {
                노아결과.text = "보통성공";

            }
            if (출력기능값 > DataBaseManager.던지기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.던지기 / 3f) && (double)DataBaseManager.던지기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 전판정


            if (적출력기능값 <= 심해인3.심해인회피)
            {
                적기결과.text = "보통성공";

            }
            if (적출력기능값 > 심해인3.심해인회피)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인3.심해인회피 / 3f) && (double)심해인3.심해인회피 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 불리판정
            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }


            if (선택된무기 == "돌")
            {

                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(돌대미지);
                    심해인3.체력 = 심해인3.체력 - 돌대미지;
                    Debug.Log(심해인3.체력);
                }
            }


            else if (선택된무기 == "화염병")
            {
                DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 - 1;
                if (결과.text == "노아 판정승")
                {
                    Debug.Log(심해인3.체력);
                    Debug.Log(화염병대미지);
                    심해인3.체력 = 심해인3.체력 - 화염병대미지;
                    Debug.Log(심해인3.체력);
                }

            }

            yield return new WaitForSeconds(2f);

            판정창.SetActive(false);


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }

    }








    public GameObject 회피반격버튼;


    public void 적공격반응시버튼등장()
    {
        회피반격버튼.SetActive(true);

    }
    public void 적공격반응_회피()
    {
        회피반격버튼.SetActive(false);
        노아제목.text = "노아 : 회피";
        StartCoroutine(적공격());
    }

    public void 적공격반응_반격()
    {
        회피반격버튼.SetActive(false);
        노아제목.text = "노아 : 반격";
        StartCoroutine(적공격());
    }




    public IEnumerator 적공격()
    {
        근력대미지 = Random.Range(1, 4);



        판정창.SetActive(true);
        if (노아제목.text == "노아 : 회피")
        {


            적제목.text = "??? : 공격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "구르기 : " + DataBaseManager.구르기;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






             if (출력기능값 <= DataBaseManager.구르기)
            {
                노아결과.text = "보통성공";

            }
             if (출력기능값 > DataBaseManager.구르기)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.구르기 / 3f) && (double)DataBaseManager.구르기 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 적판정

 
             if (적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
             if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인맨손격투 / 3f) && (double)심해인1.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            //노아 유리판정
            if ((노아결과.text == "대성공"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
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
            yield return new WaitForSeconds(2f);
            판정창.SetActive(false);

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 1.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 2.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 3.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);
                }
            }





            턴시작 = false;
            현재턴수 = 현재턴수 + 1;

        }


         else if ( 노아제목.text == "노아 : 반격")
        {


            적제목.text = "??? : 공격";

            yield return new WaitForSeconds(2f);

            노아기술.text = "근접격투 : " + DataBaseManager.맨손격투;
            적기술.text = "근접격투 : " + 심해인1.심해인맨손격투;

            yield return new WaitForSeconds(2f);

            StartCoroutine(룰렛작동());
            StartCoroutine(적룰렛작동());
            yield return new WaitForSeconds(6f);






             if (출력기능값 <= DataBaseManager.맨손격투)
            {
                노아결과.text = "보통성공";

            }
             if (출력기능값 > DataBaseManager.맨손격투)
            {
                노아결과.text = "실패";

            }
            if (출력기능값 <= ((double)DataBaseManager.맨손격투 / 3f) && (double)DataBaseManager.맨손격투 >= 3f)
            {
                노아결과.text = "대성공";

            }
            if (출력기능값 == 10)
            {
                노아결과.text = "대실패";

            }
            // 적판정

 
             if (적출력기능값 <= 심해인1.심해인맨손격투)
            {
                적기결과.text = "보통성공";

            }
             if (적출력기능값 > 심해인1.심해인맨손격투)
            {
                적기결과.text = "실패";

            }
            if (적출력기능값 <= ((double)심해인1.심해인맨손격투 / 3f) && (double)심해인1.심해인맨손격투 >= 3f)
            {
                적기결과.text = "대성공";

            }
            if (적출력기능값 == 10)
            {
                적기결과.text = "대실패";

            }
            yield return new WaitForSeconds(2f);

            if ((노아결과.text == "대성공") && (적기결과.text == "보통성공" || (노아결과.text == "대성공") && (적기결과.text == "실패") || (노아결과.text == "대성공") && (적기결과.text == "대실패")))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "대성공") && (적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "보통성공" && 적기결과.text == "실패") || (노아결과.text == "보통성공" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "보통성공" && 적기결과.text == "보통성공") || (노아결과.text == "보통성공" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }

            else if ((노아결과.text == "실패" && 적기결과.text == "대실패"))
            {
                결과.text = "노아 판정승";
            }
            else if ((노아결과.text == "실패" && 적기결과.text == "실패") || (노아결과.text == "실패" && 적기결과.text == "보통성공") || (노아결과.text == "실패" && 적기결과.text == "대성공"))
            {
                결과.text = "적 판정승";
            }


            else if ((노아결과.text == "대실패"))
            {
                결과.text = "적 판정승";
            }

            yield return new WaitForSeconds(2f);
            판정창.SetActive(false);

            if (결과.text == "적 판정승")
            {
                if (근력대미지 == 1)
                {
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 1.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }

                else if (근력대미지 == 2)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 2.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);

                }
                else if (근력대미지 == 3)
                {
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    BattleUiManager.체력감소();
                    var clone = Instantiate(우측플로팅텍스트, 내플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                    clone.GetComponent<플로팅텍스트좌측>().Text.text = 3.ToString();
                    clone.transform.SetParent(ui창.transform);

                    DataBaseManager.카메라왼쪽워킹온오프 = true;

                    플레이어대기.SetActive(false);
                    노아피격이미지.SetActive(true);

                    적대기이미지.SetActive(false);
                    적공격이미지.SetActive(true);

                    yield return new WaitForSeconds(3f);

                    플레이어대기.SetActive(true);
                    노아피격이미지.SetActive(false);

                    적대기이미지.SetActive(true);
                    적공격이미지.SetActive(false);
                }
            }
            if (결과.text == "노아 판정승")
            {
                Debug.Log(심해인1.체력);
                Debug.Log(근력대미지);
                심해인1.체력 = 심해인1.체력 - 근력대미지;
                Debug.Log(심해인1.체력);



                var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
                clone.GetComponent<플로팅택스트>().Text.text = 근력대미지.ToString();
                clone.transform.SetParent(ui창.transform);

                DataBaseManager.카메라워킹온오프 = true;

                플레이어대기.SetActive(false);
                근접공격.SetActive(true);

                적대기이미지.SetActive(false);
                적피격이미지.SetActive(true);

                yield return new WaitForSeconds(3f);

                플레이어대기.SetActive(true);
                근접공격.SetActive(false);

                적대기이미지.SetActive(true);
                적피격이미지.SetActive(false);

            }


            턴시작 = false;
            현재턴수 = 현재턴수 + 1;

        }

        

    }


    


    public void 적1의턴()
    {
        내턴인가 = false;
        내턴기본 = false;
        whiteBox.SetActive(false);
        공격_도주_눈썰미_재장전.SetActive(false);
        적공격반응시버튼등장();
    }
    public void 적2의턴()
    {
        내턴인가 = false;
        내턴기본 = false;
        whiteBox.SetActive(false);
        공격_도주_눈썰미_재장전.SetActive(false);
        적공격반응시버튼등장();
    }
    public void 적3의턴()
    {
        내턴인가 = false;
        내턴기본 = false;
        whiteBox.SetActive(false);
        공격_도주_눈썰미_재장전.SetActive(false);
        적공격반응시버튼등장();
    }




    // Start is called before the first frame update
    void Start()
    {

        시작시총알미리장전();


        심해인전투시작();
        현재턴수 = 현재턴수 + 1;


    }
    public Text 누적데미지_심해인1;
    public Text 누적데미지_심해인2;
    public Text 누적데미지_심해인3;
    // Update is called once per frame
    public GameObject ui창;
    public GameObject 플로팅텍스트오브젝트;
    public GameObject 적플로팅위치;
    public GameObject 내플로팅위치;

    void Update()
    {


        누적데미지_심해인1.text = "누적 : " + (심해인1.전체체력 - 심해인1.체력);
        누적데미지_심해인2.text = "누적 : " + (심해인2.전체체력 - 심해인2.체력);
        누적데미지_심해인3.text = "누적 : " + (심해인3.전체체력 - 심해인3.체력);
        총기류메뉴창();
        메뉴창업데이터();


        내턴기본white관리();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DataBaseManager.던지기 = DataBaseManager.던지기 + 1;
            DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 + 1;
        }



        현재가누구턴인지확인();
    }


    public IEnumerator 룰렉동작시키기()
    {

        룰렛머신온오프.SetActive(true);
        yield return StartCoroutine(룰렛작동());
        룰렛머신온오프.SetActive(false);
    }




    // 설명창류

    public Text 대상이름;
    public Text 대상설명;













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
    public static float 출력기능값;
    public static float 적출력기능값;






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
        for (int i = 0; i < 20; i++)
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
        for (int i = 0; i < 40; i++)
        {
            랜덤십의자리 = Random.Range(0, 10);
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
        for (int i = 0; i < 20; i++)
        {

            적랜덤일의자리 = Random.Range(0, 10);


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
        for (int i = 0; i < 40; i++)
        {
            랜덤십의자리 = Random.Range(0, 10);
            적랜덤일의자리 = Random.Range(0, 10);
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
