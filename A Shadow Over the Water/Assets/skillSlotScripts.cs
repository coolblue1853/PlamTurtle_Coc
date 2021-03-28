using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skillSlotScripts : MonoBehaviour
{
    public GameObject SevTPer;
    public GameObject sixTPer;
    public GameObject fifTper1;
    public GameObject fifTper2;
    public GameObject forTper1;
    public GameObject forTper2;
    public GameObject forTper3;
    public GameObject PercenSet;

    public Text 감정txt;
    public Text 격투txt;
    public Text 관찰력txt;
    public Text 도약txt;
    public Text 도검류txt;
    public Text 듣기txt;
    public Text 말재주txt;
    public Text 법률txt;

    public Text 변장txt;
    public Text 사격txt;
    public Text 생물학txt;
    public Text 설득txt;
    public Text 손놀림txt;
    public Text 심리학txt;
    public Text 열쇠공txt;
    public Text 오르기txt;

    public Text 오컬트txt;
    public Text 위협txt;
    public Text 은밀행동txt;
    public Text 응급처치txt;
    public Text 의료txt;
    public Text 자료조사txt;
    public Text 정신분석txt;
    public Text 회피txt;



    public static int 칠십퍼배정 = 0;
    public static int 육십퍼배정 = 0;
    public static int 오십퍼배정일 = 0;
    public static int 오십퍼배정이 = 0;
    public static int 사십퍼배정일 = 0;
    public static int 사십퍼배정이 = 0;
    public static int 사십퍼배정삼 = 0;
    public static int skillNum = 0;

    /*
        1감정 = 5;
        2격투 = 25;
        3관찰력 = 25;
        4도약 = 20;
        5도검류 = 20
        6듣기 = 20;
        7말재주 = 5;
        8법률 = 5;

        9변장 = 5;
        10사격 = 20;
        11생물학 = 1;
        12설득 = 10;
        13손놀림 = 10;
        14심리학 = 10;
        15열쇠공 = 1;
        16오르기 = 20;

        17오컬트 = 5;
        18위협 = 15;
        19은밀행동 = 20;
        20응급처치 = 30;
        21의료 = 1;
        22자료조사 = 20;
        23정신분석 = 1;
        24회피 = 0;
    */
    
    public void 모두초기화()
    {      
        
      SevTPer.SetActive(true);
      sixTPer.SetActive(true);
        fifTper1.SetActive(true);
        fifTper2.SetActive(true);
        forTper1.SetActive(true);
        forTper2.SetActive(true);
        forTper3.SetActive(true);

        DataBaseManager.감정 = 5;
        DataBaseManager.격투 = 25;
        DataBaseManager.관찰력 = 25;
        DataBaseManager.사격 = 20;
        DataBaseManager.도약 = 20;
        DataBaseManager.도검류 = 20;
        DataBaseManager.듣기 = 20;
        DataBaseManager.말재주 = 5;

        DataBaseManager.법률 = 5;
        DataBaseManager.변장 = 5;
        DataBaseManager.생물학 = 1;
        DataBaseManager.설득 = 10;
        DataBaseManager.손놀림 = 10;
        DataBaseManager.심리학 = 10;
        DataBaseManager.열쇠공 = 1;
        DataBaseManager.오르기 = 20;

        DataBaseManager.오컬트 = 5;
        DataBaseManager.위협 = 15;
        DataBaseManager.은밀행동 = 20;
        DataBaseManager.응급처치 = 30;
        DataBaseManager.의료 = 1;
        DataBaseManager.자료조사 = 20;
        DataBaseManager.정신분석 = 1;
        DataBaseManager.회피 = DataBaseManager.민첩성 / 2;

        감정txt.text = DataBaseManager.감정.ToString();//근력표기
        격투txt.text = DataBaseManager.격투.ToString();//근력표기
        관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
        사격txt.text = DataBaseManager.사격.ToString();//근력표기
        도약txt.text = DataBaseManager.도약.ToString();//근력표기
        도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
        듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
        말재주txt.text = DataBaseManager.말재주.ToString();//근력표기

        법률txt.text = DataBaseManager.법률.ToString();//근력표기
        변장txt.text = DataBaseManager.변장.ToString();//근력표기
        생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
        설득txt.text = DataBaseManager.설득.ToString();//근력표기
        손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
        심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
        열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
        오르기txt.text = DataBaseManager.오르기.ToString();//근력표기

        오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
        위협txt.text = DataBaseManager.위협.ToString();//근력표기
        은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
        의료txt.text = DataBaseManager.의료.ToString();//근력표기
        자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
        정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
        응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
        회피txt.text = DataBaseManager.회피.ToString();//근력표기
    }

    public void 감정설정창열기()
    {
        
           skillNum = 1;
        PercenSet.SetActive(true);
        
    }
    public void 감정초기화()
    {
        if(칠십퍼배정 == 1)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 1)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 1)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 1)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 1)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 1)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 1)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.감정 = 5;
        감정txt.text = DataBaseManager.감정.ToString();//근력표기

    }

    public void 격투설정창열기()
    {
        skillNum = 2;
        PercenSet.SetActive(true);

    }
    public void 격투초기화()
    {
        if (칠십퍼배정 == 2)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 2)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 2)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 2)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 2)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 2)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 2)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.격투 = 25;
        격투txt.text = DataBaseManager.격투.ToString();//근력표기

    }

    public void 관찰력설정창열기()
    {
        skillNum = 3;
        PercenSet.SetActive(true);

    }
    public void 관찰력초기화()
    {
        if (칠십퍼배정 == 3)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 3)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 3)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 3)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 3)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 3)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 3)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.관찰력 = 25;
        관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기

    }

    public void 도약설정창열기()
    {
        skillNum = 4;
        PercenSet.SetActive(true);

    }
    public void 도약초기화()
    {
        if (칠십퍼배정 == 4)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 4)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 4)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 4)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 4)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 4)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 4)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.도약 = 25;
        도약txt.text = DataBaseManager.도약.ToString();//근력표기

    }

    public void 도검류설정창열기()
    {
        skillNum = 5;
        PercenSet.SetActive(true);

    }
    public void 도검류초기화()
    {
        if (칠십퍼배정 == 5)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 5)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 5)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 5)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 5)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 5)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 5)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.도검류 = 20;
        도검류txt.text = DataBaseManager.도검류.ToString();//근력표기

    }

    public void 듣기설정창열기()
    {
        skillNum = 6;
        PercenSet.SetActive(true);

    }
    public void 듣기초기화()
    {
        if (칠십퍼배정 == 6)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 6)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 6)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 6)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 6)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 6)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 6)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.듣기 = 20;
        듣기txt.text = DataBaseManager.듣기.ToString();//근력표기

    }

    public void 말재주설정창열기()
    {
        skillNum = 7;
        PercenSet.SetActive(true);

    }
    public void 말재주초기화()
    {
        if (칠십퍼배정 == 7)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 7)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 7)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 7)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 7)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 7)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 7)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.말재주 = 5;
        말재주txt.text = DataBaseManager.말재주.ToString();//근력표기

    }

        public void 법률설정창열기()
    {
        skillNum = 8;
        PercenSet.SetActive(true);

    }
    public void 법률초기화()
    {
        if (칠십퍼배정 == 8)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 8)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 8)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 8)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 8)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 8)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 8)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.법률 = 5;
        법률txt.text = DataBaseManager.법률.ToString();//근력표기

    }




    //2번째 페이지



        
    public void 변장설정창열기()
    {
        skillNum = 9;
        PercenSet.SetActive(true);

    }
    public void 변장초기화()
    {
        if (칠십퍼배정 == 9)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 9)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 9)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 9)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 9)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 9)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 9)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.변장 = 5;
        변장txt.text = DataBaseManager.변장.ToString();//근력표기

    }

    public void 사격설정창열기()
    {
        skillNum = 10;
        PercenSet.SetActive(true);

    }
    public void 사격초기화()
    {
        if (칠십퍼배정 == 10)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 10)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 10)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 10)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 10)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 10)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 10)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.사격 = 20;
        사격txt.text = DataBaseManager.사격.ToString();//근력표기

    }

    public void 생물학설정창열기()
    {
        skillNum = 11;
        PercenSet.SetActive(true);

    }
    public void 생물학초기화()
    {
        if (칠십퍼배정 == 11)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 11)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 11)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 11)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 11)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 11)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 11)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.생물학 = 1;
        생물학txt.text = DataBaseManager.생물학.ToString();//근력표기

    }

    public void 설득설정창열기()
    {
        skillNum = 12;
        PercenSet.SetActive(true);

    }
        public void 설득초기화()
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            DataBaseManager.설득 = 10;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기

        }
    public void 손놀림설정창열기()
    {
        skillNum = 13;
        PercenSet.SetActive(true);

    }
    public void 손놀림초기화()
    {
        if (칠십퍼배정 == 13)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 13)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 13)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 13)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 13)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 13)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 13)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.손놀림 = 10;
        손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기

    }

    public void 심리학설정창열기()
    {
        skillNum = 14;
        PercenSet.SetActive(true);

    }
    public void 심리학초기화()
    {
        if (칠십퍼배정 == 14)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 14)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 14)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 14)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 14)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 14)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 14)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.심리학 = 10;
        심리학txt.text = DataBaseManager.심리학.ToString();//근력표기

    }

    public void 열쇠공설정창열기()
    {
        skillNum = 15;
        PercenSet.SetActive(true);

    }
    public void 열쇠공초기화()
    {
        if (칠십퍼배정 == 15)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 15)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 15)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 15)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 15)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 15)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 15)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.열쇠공 = 1;
        열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기

    }
    public void 오르기설정창열기()
    {
        skillNum = 16;
        PercenSet.SetActive(true);

    }
    public void 오르기초기화()
    {
        if (칠십퍼배정 == 16)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 16)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 16)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 16)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 16)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 16)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 16)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.오르기 = 20;
        오르기txt.text = DataBaseManager.오르기.ToString();//근력표기

    }


    // 3페이지
    public void 오컬트설정창열기()
    {
        skillNum = 17;
        PercenSet.SetActive(true);

    }
    public void 오컬트초기화()
    {
        if (칠십퍼배정 == 17)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 17)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 17)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 17)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 17)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 17)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 17)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.오컬트 = 5;
        오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기

    }
    public void 위협설정창열기()
    {
        skillNum = 18;
        PercenSet.SetActive(true);

    }
    public void 위협초기화()
    {
        if (칠십퍼배정 == 18)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 18)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 18)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 18)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 18)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 18)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 18)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.위협 = 5;
        위협txt.text = DataBaseManager.위협.ToString();//근력표기

    }
    public void 은밀행동설정창열기()
    {
        skillNum = 19;
        PercenSet.SetActive(true);

    }
    public void 은밀행동초기화()
    {
        if (칠십퍼배정 == 19)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 19)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 19)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 19)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 19)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 19)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 19)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.은밀행동 = 20;
        은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기

    }
    public void 응급처치설정창열기()
    {
        skillNum = 20;
        PercenSet.SetActive(true);

    }
    public void 응급처치초기화()
    {
        if (칠십퍼배정 == 20)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 20)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 20)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 20)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 20)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 20)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 20)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.응급처치 = 30;
        응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기

    }

    public void 의료설정창열기()
    {
        skillNum = 21;
        PercenSet.SetActive(true);

    }
    public void 의료초기화()
    {
        if (칠십퍼배정 == 21)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 21)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 21)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 21)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 21)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 21)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 21)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.의료 = 1;
        의료txt.text = DataBaseManager.의료.ToString();//근력표기

    }
    public void 자료조사설정창열기()
    {
        skillNum = 22;
        PercenSet.SetActive(true);

    }
    public void 자료조사초기화()
    {
        if (칠십퍼배정 == 22)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 22)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 22)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 22)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 22)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 22)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 22)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.자료조사 = 20;
        자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기

    }
    public void 정신분석설정창열기()
    {
        skillNum = 23;
        PercenSet.SetActive(true);

    }
    public void 정신분석초기화()
    {
        if (칠십퍼배정 == 23)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 23)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 23)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 23)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 23)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 23)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 23)
        {
            forTper3.SetActive(true);
        }
        DataBaseManager.정신분석 = 1;
        정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기

    }
    public void 회피설정창열기()
    {
        skillNum = 24;
        PercenSet.SetActive(true);

    }
    public void 회피초기화()
    {
        if (칠십퍼배정 == 24)
        {
            SevTPer.SetActive(true);
        }
        if (육십퍼배정 == 24)
        {
            sixTPer.SetActive(true);
        }
        if (오십퍼배정일 == 24)
        {
            fifTper1.SetActive(true);
        }
        if (오십퍼배정이 == 24)
        {
            fifTper2.SetActive(true);
        }
        if (사십퍼배정일 == 24)
        {
            forTper1.SetActive(true);
        }
        if (사십퍼배정이 == 24)
        {
            forTper2.SetActive(true);
        }
        if (사십퍼배정삼 == 24)
        {
            forTper3.SetActive(true);
        }


        DataBaseManager.회피 = DataBaseManager.민첩성 / 2;
        회피txt.text = DataBaseManager.회피.ToString();//근력표기

    }






    public void 퍼샌트설정창닫기()
    {
        PercenSet.SetActive(false);
    }







    public void 칠십퍼센트설정()
    {

        if (skillNum == 1)
        {
            if(육십퍼배정 == 1)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 1)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 1)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 1)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 1)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 1)
            {
                forTper3.SetActive(true);
            }

            칠십퍼배정 = 1;
            DataBaseManager.감정 = 70;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (육십퍼배정 == 2)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 2)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 2)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 2)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 2)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 2)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 2;
            DataBaseManager.격투 = 70;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (육십퍼배정 == 3)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 3)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 3)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 3)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 3)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 3)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 3;
            DataBaseManager.관찰력 = 70;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (육십퍼배정 == 4)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 4)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 4)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 4)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 4)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 4)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 4;
            DataBaseManager.도약 = 70;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (육십퍼배정 == 5)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 5)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 5)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 5)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 5)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 5)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 5;
            DataBaseManager.도검류 = 70;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (육십퍼배정 == 6)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 6)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 6)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 6)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 6)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 6)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 6;
            DataBaseManager.듣기 = 70;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (육십퍼배정 == 7)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 7)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 7)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 7)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 7)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 7)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 7;
            DataBaseManager.말재주 = 70;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (육십퍼배정 == 8)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 8)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 8)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 8)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 8)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 8)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 8;
            DataBaseManager.법률 = 70;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        //2페이지

        else if (skillNum == 9)
        {
            if (육십퍼배정 == 9)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 9)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 9)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 9)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 9)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 9)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 9;
            DataBaseManager.변장 = 70;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (육십퍼배정 == 10)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 10)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 10)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 10)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 10)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 10)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 10;
            DataBaseManager.사격 = 70;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (육십퍼배정 == 11)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 11)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 11)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 11)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 11)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 11)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 11;
            DataBaseManager.생물학 = 70;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 12;
            DataBaseManager.설득 = 70;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (육십퍼배정 == 13)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 13)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 13)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 13)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 13)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 13)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 13;
            DataBaseManager.손놀림 = 70;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (육십퍼배정 == 14)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 14)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 14)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 14)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 14)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 14)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 14;
            DataBaseManager.심리학 = 70;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (육십퍼배정 == 15)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 15)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 15)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 15)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 15)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 15)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 15;
            DataBaseManager.열쇠공 = 70;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (육십퍼배정 == 16)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 16)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 16)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 16)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 16)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 16)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 16;
            DataBaseManager.오르기 = 70;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (육십퍼배정 == 17)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 17)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 17)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 17)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 17)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 17)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 17;
            DataBaseManager.오컬트 = 70;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (육십퍼배정 == 18)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 18)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 18)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 18)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 18)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 18)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 18;
            DataBaseManager.위협 = 70;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (육십퍼배정 == 19)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 19)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 19)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 19)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 19)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 19)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 19;
            DataBaseManager.은밀행동 = 70;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (육십퍼배정 == 20)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 20)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 20)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 20)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 20)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 20)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 20;
            DataBaseManager.응급처치 = 70;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (육십퍼배정 == 21)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 21)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 21)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 21)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 21)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 21)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 21;
            DataBaseManager.의료 = 70;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (육십퍼배정 == 22)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 22)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 22)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 22)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 22)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 22)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 22;
            DataBaseManager.자료조사 = 70;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (육십퍼배정 == 23)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 23)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 23)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 23)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 23)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 23)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 23;
            DataBaseManager.정신분석 = 70;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (육십퍼배정 == 24)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 24)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 24)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 24)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 24)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 24)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 24;
            DataBaseManager.회피 = 70;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }

        SevTPer.SetActive(false);

    }

    public void 육십퍼센트설정()
    {

        if (skillNum == 1)
        {
            if (칠십퍼배정 == 1)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 1)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 1)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 1)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 1)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 1)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 1;
            DataBaseManager.감정 = 60;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (칠십퍼배정 == 2)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 2)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 2)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 2)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 2)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 2)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 2;
            DataBaseManager.격투 = 60;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (칠십퍼배정 == 3)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 3)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 3)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 3)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 3)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 3)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 3;
            DataBaseManager.관찰력 = 60;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (칠십퍼배정 == 4)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 4)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 4)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 4)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 4)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 4)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 4;
            DataBaseManager.도약 = 60;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (칠십퍼배정 == 5)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 5)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 5)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 5)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 5)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 5)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 5;
            DataBaseManager.도검류 = 60;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (칠십퍼배정 == 6)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 6)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 6)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 6)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 6)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 6)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 6;
            DataBaseManager.듣기 = 60;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (칠십퍼배정 == 7)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 7)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 7)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 7)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 7)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 7)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 7;
            DataBaseManager.말재주 = 60;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (칠십퍼배정 == 8)
            {
                SevTPer.SetActive(true);
            }
             if (오십퍼배정일 == 8)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 8)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 8)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 8)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 8)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 8;
            DataBaseManager.법률 = 60;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }

        else if (skillNum == 9)
        {
            if (칠십퍼배정 == 9)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 9)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 9)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 9)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 9)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 9)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 9;
            DataBaseManager.변장 = 60;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (칠십퍼배정 == 10)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 10)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 10)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 10)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 10)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 10)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 10;
            DataBaseManager.사격 = 60;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (칠십퍼배정 == 11)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 11)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 11)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 11)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 11)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 11)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 11;
            DataBaseManager.생물학 = 60;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 12;
            DataBaseManager.설득 = 60;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (칠십퍼배정 == 13)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 13)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 13)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 13)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 13)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 13)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 13;
            DataBaseManager.손놀림 = 60;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (칠십퍼배정 == 14)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 14)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 14)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 14)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 14)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 14)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 14;
            DataBaseManager.심리학 = 60;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (칠십퍼배정 == 15)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 15)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 15)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 15)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 15)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 15)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 15;
            DataBaseManager.열쇠공 = 60;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (칠십퍼배정 == 16)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 16)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 16)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 16)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 16)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 16)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 16;
            DataBaseManager.오르기 = 60;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (칠십퍼배정 == 17)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 17)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 17)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 17)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 17)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 17)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 17;
            DataBaseManager.오컬트 = 60;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (칠십퍼배정 == 18)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 18)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 18)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 18)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 18)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 18)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 18;
            DataBaseManager.위협 = 60;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (칠십퍼배정 == 19)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 19)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 19)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 19)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 19)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 19)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 19;
            DataBaseManager.은밀행동 = 60;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (칠십퍼배정 == 20)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 20)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 20)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 20)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 20)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 20)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 20;
            DataBaseManager.응급처치 = 60;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (칠십퍼배정 == 21)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 21)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 21)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 21)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 21)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 21)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 21;
            DataBaseManager.의료 = 60;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (칠십퍼배정 == 22)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 22)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 22)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 22)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 22)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 22)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 22;
            DataBaseManager.자료조사 = 60;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (칠십퍼배정 == 23)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 23)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 23)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 23)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 23)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 23)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 23;
            DataBaseManager.정신분석 = 60;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (칠십퍼배정 == 24)
            {
                SevTPer.SetActive(true);
            }
            if (오십퍼배정일 == 24)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 24)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 24)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 24)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 24)
            {
                forTper3.SetActive(true);
            }
            육십퍼배정 = 24;
            DataBaseManager.회피 = 60;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }


        sixTPer.SetActive(false);

    }

    public void 오십퍼센트설정일()
    {

        if (skillNum == 1)
        {
            if (칠십퍼배정 == 1)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 1)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 == 1)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 1)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 1)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 1)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 1;
            DataBaseManager.감정 = 50;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (칠십퍼배정 ==2 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==2 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 ==2 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==2 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 2)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 2)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 2;
            DataBaseManager.격투 = 50;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (칠십퍼배정 ==3 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 3)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 == 3)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 3)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 3)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 3)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 3;
            DataBaseManager.관찰력 = 50;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (칠십퍼배정 ==4 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 4)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 == 4)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 4)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 4)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 4)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 4;
            DataBaseManager.도약 = 50;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (칠십퍼배정 ==5 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==5 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 == 5)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 5)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 5)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 5)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 5;
            DataBaseManager.도검류 = 50;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (칠십퍼배정 == 6)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 6)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 ==6 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 6)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==6 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 6)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 6;
            DataBaseManager.듣기 = 50;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (칠십퍼배정 == 7)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==7 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 ==7 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 7)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 7)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 7)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 7;
            DataBaseManager.말재주 = 50;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (칠십퍼배정 ==8 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 8)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정이 == 8)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 8)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 8)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 8)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 8;
            DataBaseManager.법률 = 50;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }


        else if (skillNum == 9)
        {
            if (칠십퍼배정 == 9)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 9)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 9)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 9)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 9)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 9)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 9;
            DataBaseManager.변장 = 50;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (칠십퍼배정 == 10)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 10)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 10)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 10)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 10)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 10)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 10;
            DataBaseManager.사격 = 50;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (칠십퍼배정 == 11)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 11)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 11)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 11)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 11)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 11)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 11;
            DataBaseManager.생물학 = 50;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 12;
            DataBaseManager.설득 = 50;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (칠십퍼배정 == 13)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 13)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 13)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 13)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 13)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 13)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 13;
            DataBaseManager.손놀림 = 50;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (칠십퍼배정 == 14)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 14)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 14)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 14)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 14)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 14)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 14;
            DataBaseManager.심리학 = 50;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (칠십퍼배정 == 15)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 15)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 15)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 15)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 15)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 15)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 15;
            DataBaseManager.열쇠공 = 50;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (칠십퍼배정 == 16)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 16)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 16)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 16)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 16)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 16)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 16;
            DataBaseManager.오르기 = 50;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (칠십퍼배정 == 17)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 17)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 17)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 17)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 17)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 17)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 17;
            DataBaseManager.오컬트 = 50;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (칠십퍼배정 == 18)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 18)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 18)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 18)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 18)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 18)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 18;
            DataBaseManager.위협 = 50;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (칠십퍼배정 == 19)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 19)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 19)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 19)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 19)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 19)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 19;
            DataBaseManager.은밀행동 = 50;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (칠십퍼배정 == 20)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 20)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 20)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 20)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 20)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 20)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 20;
            DataBaseManager.응급처치 = 50;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (칠십퍼배정 == 21)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 21)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 21)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 21)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 21)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 21)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 21;
            DataBaseManager.의료 = 50;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (칠십퍼배정 == 22)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 22)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 22)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 22)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 22)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 22)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 22;
            DataBaseManager.자료조사 = 50;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (칠십퍼배정 == 23)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 23)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 23)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 23)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 23)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 23)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 23;
            DataBaseManager.정신분석 = 50;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (칠십퍼배정 == 24)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 24)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정이 == 24)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 24)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 24)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 24)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정일 = 24;
            DataBaseManager.회피 = 50;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        fifTper1.SetActive(false);

    }

    public void 오십퍼센트설정이()
    {

        if (skillNum == 1)
        {
            if (칠십퍼배정 ==1 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 1)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==1 )
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 1)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 1)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 1)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 1;
            DataBaseManager.감정 = 50;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (칠십퍼배정 ==2 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==2 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 2)
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 2)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==2 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 2)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 2;
            DataBaseManager.격투 = 50;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (칠십퍼배정 == 3)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 3)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==3 )
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 3)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 3)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==3 )
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 3;
            DataBaseManager.관찰력 = 50;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (칠십퍼배정 == 4)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 4)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==4 )
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 ==4 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==4 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 4)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 4;
            DataBaseManager.도약 = 50;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (칠십퍼배정 == 5)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==5 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==5 )
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 5)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 5)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==5 )
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 5;
            DataBaseManager.도검류 = 50;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (칠십퍼배정 ==6 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 6)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 6)
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 6)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 6)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 6)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 6;
            DataBaseManager.듣기 = 50;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (칠십퍼배정 ==7 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==7 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==7 )
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 7)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 7)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 7)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 7;
            DataBaseManager.말재주 = 50;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (칠십퍼배정 ==8 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==8 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 8)
            {
                fifTper1.SetActive(true);
            }
             if (사십퍼배정일 == 8)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 8)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==8 )
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 8;
            DataBaseManager.법률 = 50;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }





        else if (skillNum == 9)
        {
            if (칠십퍼배정 == 9)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 9)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 9)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 9)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 9)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 9)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 9;
            DataBaseManager.변장 = 50;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (칠십퍼배정 == 10)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 10)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 10)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 10)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 10)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 10)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 10;
            DataBaseManager.사격 = 50;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (칠십퍼배정 == 11)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 11)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 11)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 11)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 11)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 11)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 11;
            DataBaseManager.생물학 = 50;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 12;
            DataBaseManager.설득 = 50;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (칠십퍼배정 == 13)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 13)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 13)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 13)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 13)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 13)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 13;
            DataBaseManager.손놀림 = 50;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (칠십퍼배정 == 14)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 14)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 14)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 14)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 14)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 14)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 14;
            DataBaseManager.심리학 = 50;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (칠십퍼배정 == 15)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 15)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 15)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 15)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 15)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 15)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 15;
            DataBaseManager.열쇠공 = 50;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (칠십퍼배정 == 16)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 16)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 16)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 16)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 16)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 16)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 16;
            DataBaseManager.오르기 = 50;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (칠십퍼배정 == 17)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 17)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 17)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 17)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 17)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 17)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 17;
            DataBaseManager.오컬트 = 50;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (칠십퍼배정 == 18)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 18)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 18)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 18)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 18)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 18)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 18;
            DataBaseManager.위협 = 50;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (칠십퍼배정 == 19)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 19)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 19)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 19)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 19)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 19)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 19;
            DataBaseManager.은밀행동 = 50;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (칠십퍼배정 == 20)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 20)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 20)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 20)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 20)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 20)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 20;
            DataBaseManager.응급처치 = 50;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (칠십퍼배정 == 21)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 21)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 21)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 21)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 21)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 21)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 21;
            DataBaseManager.의료 = 50;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (칠십퍼배정 == 22)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 22)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 22)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 22)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 22)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 22)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 22;
            DataBaseManager.자료조사 = 50;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (칠십퍼배정 == 23)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 23)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 23)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 23)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 23)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 23)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 23;
            DataBaseManager.정신분석 = 50;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (칠십퍼배정 == 24)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 24)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 24)
            {
                fifTper1.SetActive(true);
            }
            if (사십퍼배정일 == 24)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 24)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 24)
            {
                forTper3.SetActive(true);
            }
            오십퍼배정이 = 24;
            DataBaseManager.회피 = 50;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        fifTper2.SetActive(false);

    }

    public void 사십퍼센트설정일()
    {

        if (skillNum == 1)
        {
            if (칠십퍼배정 == 1)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 1)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 1)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 1)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 ==1 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==1 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 1;
            DataBaseManager.감정 = 40;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (칠십퍼배정 == 2)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 2)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 2)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==2 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 ==2 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 2)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 2;
            DataBaseManager.격투 = 40;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (칠십퍼배정 == 3)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 3)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 3)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 3)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 ==3 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==3 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 3;
            DataBaseManager.관찰력 = 40;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (칠십퍼배정 ==4 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 4)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==4 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 4)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 ==4 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 4)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 4;
            DataBaseManager.도약 = 40;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (칠십퍼배정 == 5)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==5 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==5 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==5 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 ==5 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==5 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 5;
            DataBaseManager.도검류 = 40;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (칠십퍼배정 == 6)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 6)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==6 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 6)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 ==6 )
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 ==6 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 6;
            DataBaseManager.듣기 = 40;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (칠십퍼배정 == 7)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 7)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==7 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==7 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 == 7)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 7)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 7;
            DataBaseManager.말재주 = 40;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (칠십퍼배정 ==8 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==8 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==8 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 8)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정이 == 8)
            {
                forTper2.SetActive(true);
            }
             if (사십퍼배정삼 == 8)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 8;
            DataBaseManager.법률 = 40;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }


        else if (skillNum == 9)
        {
            if (칠십퍼배정 == 9)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 9)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 9)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 9)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 9)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 9)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 9;
            DataBaseManager.변장 = 40;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (칠십퍼배정 == 10)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 10)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 10)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 10)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 10)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 10)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 10;
            DataBaseManager.사격 = 40;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (칠십퍼배정 == 11)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 11)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 11)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 11)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 11)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 11)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 11;
            DataBaseManager.생물학 = 40;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 12;
            DataBaseManager.설득 = 40;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (칠십퍼배정 == 13)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 13)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 13)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 13)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 13)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 13)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 13;
            DataBaseManager.손놀림 = 40;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (칠십퍼배정 == 14)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 14)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 14)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 14)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 14)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 14)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 14;
            DataBaseManager.심리학 = 40;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (칠십퍼배정 == 15)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 15)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 15)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 15)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 15)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 15)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 15;
            DataBaseManager.열쇠공 = 40;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (칠십퍼배정 == 16)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 16)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 16)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 16)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 16)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 16)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 16;
            DataBaseManager.오르기 = 40;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (칠십퍼배정 == 17)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 17)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 17)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 17)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 17)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 17)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 17;
            DataBaseManager.오컬트 = 40;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (칠십퍼배정 == 18)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 18)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 18)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 18)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 18)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 18)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 18;
            DataBaseManager.위협 = 40;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (칠십퍼배정 == 19)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 19)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 19)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 19)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 19)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 19)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 19;
            DataBaseManager.은밀행동 = 40;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (칠십퍼배정 == 20)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 20)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 20)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 20)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 20)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 20)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 20;
            DataBaseManager.응급처치 = 40;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (칠십퍼배정 == 21)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 21)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 21)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 21)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 21)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 21)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 21;
            DataBaseManager.의료 = 40;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (칠십퍼배정 == 22)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 22)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 22)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 22)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 22)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 22)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 22;
            DataBaseManager.자료조사 = 40;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (칠십퍼배정 == 23)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 23)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 23)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 23)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 23)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 23)
            {
                forTper3.SetActive(true);
            }
            칠십퍼배정 = 23;
            DataBaseManager.정신분석 = 40;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (칠십퍼배정 == 24)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 24)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 24)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 24)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정이 == 24)
            {
                forTper2.SetActive(true);
            }
            if (사십퍼배정삼 == 24)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정일 = 24;
            DataBaseManager.회피 = 40;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        forTper1.SetActive(false);

    }

    public void 사십퍼센트설정이()
    {

        if (skillNum == 1)
        {
            if (칠십퍼배정 ==1 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==1)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 1)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 1)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 1)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 ==1 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 1;
            DataBaseManager.감정 = 40;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (칠십퍼배정 ==2 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 2)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==2 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==2 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==2 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 ==2 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 2;
            DataBaseManager.격투 = 40;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (칠십퍼배정 == 3)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 3)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 3)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 3)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==3 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 == 3)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 3;
            DataBaseManager.관찰력 = 40;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (칠십퍼배정 == 4)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==4 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==4 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==4 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==4 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 == 4)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 4;
            DataBaseManager.도약 = 40;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (칠십퍼배정 ==5 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 5)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 5)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 5)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==5 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 ==5 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 5;
            DataBaseManager.도검류 = 40;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (칠십퍼배정 == 6)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 6)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 6)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 6)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==6 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 ==6 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 6;
            DataBaseManager.듣기 = 40;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (칠십퍼배정 == 7)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 7)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 7)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==7 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 7)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 == 7)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 7;
            DataBaseManager.말재주 = 40;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (칠십퍼배정 ==8 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==8 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==8 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 8)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 8)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정삼 ==8 )
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 8;
            DataBaseManager.법률 = 40;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }


        else if (skillNum == 9)
        {
            if (칠십퍼배정 == 9)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 9)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 9)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 9)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 9)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 9)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 9;
            DataBaseManager.변장 = 40;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (칠십퍼배정 == 10)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 10)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 10)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 10)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 10)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 10)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 10;
            DataBaseManager.사격 = 40;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (칠십퍼배정 == 11)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 11)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 11)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 11)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 11)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 11)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 11;
            DataBaseManager.생물학 = 40;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 12)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 12;
            DataBaseManager.설득 = 40;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (칠십퍼배정 == 13)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 13)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 13)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 13)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 13)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 13)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 13;
            DataBaseManager.손놀림 = 40;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (칠십퍼배정 == 14)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 14)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 14)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 14)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 14)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 14)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 14;
            DataBaseManager.심리학 = 40;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (칠십퍼배정 == 15)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 15)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 15)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 15)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 15)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 15)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 15;
            DataBaseManager.열쇠공 = 40;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (칠십퍼배정 == 16)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 16)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 16)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 16)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 16)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 16)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 16;
            DataBaseManager.오르기 = 40;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (칠십퍼배정 == 17)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 17)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 17)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 17)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 17)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 17)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 17;
            DataBaseManager.오컬트 = 40;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (칠십퍼배정 == 18)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 18)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 18)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 18)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 18)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 18)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 18;
            DataBaseManager.위협 = 40;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (칠십퍼배정 == 19)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 19)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 19)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 19)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 19)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 19)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 19;
            DataBaseManager.은밀행동 = 40;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (칠십퍼배정 == 20)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 20)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 20)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 20)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 20)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 20)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 20;
            DataBaseManager.응급처치 = 40;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (칠십퍼배정 == 21)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 21)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 21)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 21)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 21)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 21)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 21;
            DataBaseManager.의료 = 40;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (칠십퍼배정 == 22)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 22)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 22)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 22)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 22)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 22)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 22;
            DataBaseManager.자료조사 = 40;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (칠십퍼배정 == 23)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 23)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 23)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 23)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 23)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 23)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 23;
            DataBaseManager.정신분석 = 40;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (칠십퍼배정 == 24)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 24)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 24)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 24)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 24)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정삼 == 24)
            {
                forTper3.SetActive(true);
            }
            사십퍼배정이 = 24;
            DataBaseManager.회피 = 40;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        forTper2.SetActive(false);

    }

    public void 사십퍼센트설정일삼()
    {

        if (skillNum == 1)
        {
            if (칠십퍼배정 ==1 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==1 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==1 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 1)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==1 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 1)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 1;
            DataBaseManager.감정 = 40;
            감정txt.text = DataBaseManager.감정.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 2)
        {
            if (칠십퍼배정 ==2 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==2 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 2)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==2 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==2 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 2)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 2;
            DataBaseManager.격투 = 40;
            격투txt.text = DataBaseManager.격투.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 3)
        {
            if (칠십퍼배정 == 3)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==3 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==3 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 3)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 3)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==3 )
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 3;
            DataBaseManager.관찰력 = 40;
            관찰력txt.text = DataBaseManager.관찰력.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 4)
        {
            if (칠십퍼배정 == 4)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 4)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==4 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==4 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 4)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 4)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 4;
            DataBaseManager.도약 = 40;
            도약txt.text = DataBaseManager.도약.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 5)
        {
            if (칠십퍼배정 ==5 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 ==5 )
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==5 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 5)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 5)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==5 )
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 5;
            DataBaseManager.도검류 = 40;
            도검류txt.text = DataBaseManager.도검류.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 6)
        {
            if (칠십퍼배정 ==6 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 6)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==6 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==6 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==6 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 == 6)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 6;
            DataBaseManager.듣기 = 40;
            듣기txt.text = DataBaseManager.듣기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 7)
        {
            if (칠십퍼배정 == 7)
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 7)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 ==7 )
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 ==7 )
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 ==7 )
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==7 )
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 7;
            DataBaseManager.말재주 = 40;
            말재주txt.text = DataBaseManager.말재주.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 8)
        {
            if (칠십퍼배정 ==8 )
            {
                SevTPer.SetActive(true);
            }
             if (육십퍼배정 == 8)
            {
                sixTPer.SetActive(true);
            }
             if (오십퍼배정일 == 8)
            {
                fifTper1.SetActive(true);
            }
             if (오십퍼배정이 == 8)
            {
                fifTper2.SetActive(true);
            }
             if (사십퍼배정일 == 8)
            {
                forTper1.SetActive(true);
            }
             if (사십퍼배정이 ==8 )
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 8;
            DataBaseManager.법률 = 40;
            법률txt.text = DataBaseManager.법률.ToString();//근력표기
            PercenSet.SetActive(false);
        }

        else if (skillNum == 9)
        {
            if (칠십퍼배정 == 9)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 9)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 9)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 9)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 9)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 9)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 9;
            DataBaseManager.변장 = 40;
            변장txt.text = DataBaseManager.변장.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 10)
        {
            if (칠십퍼배정 == 10)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 10)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 10)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 10)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 10)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 10)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 10;
            DataBaseManager.사격 = 40;
            사격txt.text = DataBaseManager.사격.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 11)
        {
            if (칠십퍼배정 == 11)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 11)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 11)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 11)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 11)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 11)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 11;
            DataBaseManager.생물학 = 40;
            생물학txt.text = DataBaseManager.생물학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 12)
        {
            if (칠십퍼배정 == 12)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 12)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 12)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 12)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 12)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 12)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 12;
            DataBaseManager.설득 = 40;
            설득txt.text = DataBaseManager.설득.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 13)
        {
            if (칠십퍼배정 == 13)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 13)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 13)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 13)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 13)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 13)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 13;
            DataBaseManager.손놀림 = 40;
            손놀림txt.text = DataBaseManager.손놀림.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 14)
        {
            if (칠십퍼배정 == 14)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 14)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 14)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 14)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 14)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 14)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 14;
            DataBaseManager.심리학 = 40;
            심리학txt.text = DataBaseManager.심리학.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 15)
        {
            if (칠십퍼배정 == 15)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 15)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 15)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 15)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 15)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 15)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 15;
            DataBaseManager.열쇠공 = 40;
            열쇠공txt.text = DataBaseManager.열쇠공.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 16)
        {
            if (칠십퍼배정 == 16)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 16)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 16)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 16)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 16)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 16)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 16;
            DataBaseManager.오르기 = 40;
            오르기txt.text = DataBaseManager.오르기.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 17)
        {
            if (칠십퍼배정 == 17)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 17)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 17)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 17)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 17)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 17)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 17;
            DataBaseManager.오컬트 = 40;
            오컬트txt.text = DataBaseManager.오컬트.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 18)
        {
            if (칠십퍼배정 == 18)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 18)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 18)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 18)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 18)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 18)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 18;
            DataBaseManager.위협 = 40;
            위협txt.text = DataBaseManager.위협.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 19)
        {
            if (칠십퍼배정 == 19)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 19)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 19)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 19)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 19)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 19)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 19;
            DataBaseManager.은밀행동 = 40;
            은밀행동txt.text = DataBaseManager.은밀행동.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 20)
        {
            if (칠십퍼배정 == 20)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 20)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 20)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 20)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 20)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 20)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 20;
            DataBaseManager.응급처치 = 40;
            응급처치txt.text = DataBaseManager.응급처치.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 21)
        {
            if (칠십퍼배정 == 21)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 21)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 21)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 21)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 21)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 21)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 21;
            DataBaseManager.의료 = 40;
            의료txt.text = DataBaseManager.의료.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 22)
        {
            if (칠십퍼배정 == 22)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 22)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 22)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 22)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 22)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 22)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 22;
            DataBaseManager.자료조사 = 40;
            자료조사txt.text = DataBaseManager.자료조사.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 23)
        {
            if (칠십퍼배정 == 23)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 23)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 23)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 23)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 23)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 23)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 23;
            DataBaseManager.정신분석 = 40;
            정신분석txt.text = DataBaseManager.정신분석.ToString();//근력표기
            PercenSet.SetActive(false);
        }
        else if (skillNum == 24)
        {
            if (칠십퍼배정 == 24)
            {
                SevTPer.SetActive(true);
            }
            if (육십퍼배정 == 24)
            {
                sixTPer.SetActive(true);
            }
            if (오십퍼배정일 == 24)
            {
                fifTper1.SetActive(true);
            }
            if (오십퍼배정이 == 24)
            {
                fifTper2.SetActive(true);
            }
            if (사십퍼배정일 == 24)
            {
                forTper1.SetActive(true);
            }
            if (사십퍼배정이 == 24)
            {
                forTper2.SetActive(true);
            }
            사십퍼배정삼 = 24;
            DataBaseManager.회피 = 40;
            회피txt.text = DataBaseManager.회피.ToString();//근력표기
            PercenSet.SetActive(false);
        }


            
        forTper3.SetActive(false);

    }




    public GameObject 일페이지;
    public GameObject 이페이지;
    public GameObject 삼페이지;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (화살표넘버 == 1)
        {
            일페이지.SetActive(true);
            이페이지.SetActive(false);
            삼페이지.SetActive(false);
        }
        else if (화살표넘버 == 2)
        {
            일페이지.SetActive(false);
            이페이지.SetActive(true);
            삼페이지.SetActive(false);
        }
        else if (화살표넘버 == 3)
        {
            일페이지.SetActive(false);
            이페이지.SetActive(false);
            삼페이지.SetActive(true);
        }
    }

    public int  화살표넘버 = 1;

    public void 오른쪽넘기기()
    {
        if(화살표넘버 <= 2)
        {
            화살표넘버 = 화살표넘버 + 1;
        }



    }
    public void 왼쪽넘기기()
    {
        if (화살표넘버 >= 2)
        {
            화살표넘버 = 화살표넘버 - 1;
        }
    }

}
