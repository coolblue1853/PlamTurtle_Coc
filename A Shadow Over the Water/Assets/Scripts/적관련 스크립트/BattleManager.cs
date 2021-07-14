using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public GameObject 공격_도주_눈썰미_재장전;

    public void 심해인등장()
    {

        int 등장수 = Random.Range(1, 3);

        Debug.Log(등장수);
        if (등장수 == 1)
        {

            심해인1.심해인스탯생성();

        }

        if (등장수 == 2)
        {

            심해인1.심해인스탯생성();
            심해인2.심해인스탯생성();
        }
        if (등장수 == 3)
        {

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

        if(현재턴수 == 5)
        {
            현재턴수 = 1;
        }

        if(현재턴수 == 내부여턴수 && 턴시작 == false)
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


    public void 내턴()
    {
        공격_도주_눈썰미_재장전.SetActive(true);


    }


    public void 적1의턴()
    {
        공격_도주_눈썰미_재장전.SetActive(false);
    }
    public void 적2의턴()
    {
        공격_도주_눈썰미_재장전.SetActive(false);
    }
    public void 적3의턴()
    {
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


        if (Input.GetKeyDown(KeyCode.Space))
        {
            턴시작 = false;
            현재턴수 = 현재턴수 + 1;
        }
        현재가누구턴인지확인();
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
