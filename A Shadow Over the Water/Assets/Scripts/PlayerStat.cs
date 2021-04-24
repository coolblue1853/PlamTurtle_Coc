using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStat : MonoBehaviour
{



    // Start is called before the first frame update

    public Text 힘텍스트;
    public Text 지능텍스트;
    public Text 민첩텍스트;
    public Text 행운텍스트;

    public Text 활력텍스트;
    public Text 마력텍스트;
    public Text 의지력텍스트;

    public Text 체력텍스트;
    public Text 정신력텍스트;
    public Text 최대스트레스텍스트;
    /*

    public GameObject SevTPer;
    public GameObject sixTPer;
    public GameObject fifTper1;
    public GameObject fifTper2;
    public GameObject forTper1;
    public GameObject forTper2;
    public GameObject forTper3;
    */

    public GameObject 게이지오브젝트;
    public GameObject 힘게이지;
    public GameObject 지능게이지;
    public GameObject 민첩이지;
    public GameObject 행운이지;
    public GameObject 활력게이지;
    public GameObject 의지력게이지;
    public GameObject 마력게이지;
    public GameObject 체력게이지;
    public GameObject 정신력게이지;
    public GameObject 스트레스내성게이지;

    int 힘스킬배분숫자;
    int 지능스킬배분숫자;
    int 민첩스킬배분숫자;

    public GameObject 다음페이지_스킬버튼;
    
    public void OnclickSetStat()// 스탯 생성 버튼
    {
        다음페이지_스킬버튼.SetActive(true);

        Transform[] 힘차일드 =힘게이지.GetComponentsInChildren<Transform>(true);
        if (힘차일드 != null)
        {
            for (int i = 1; i < 힘차일드.Length; i++)
            {
                if (힘차일드[i] != transform)
                    Destroy(힘차일드[i].gameObject);
            }
        }
        Transform[] 지능차일드 = 지능게이지.GetComponentsInChildren<Transform>(true);
        if (힘차일드 != null)
        {
            for (int i = 1; i < 지능차일드.Length; i++)
            {
                if (지능차일드[i] != transform)
                    Destroy(지능차일드[i].gameObject);
            }
        }
        Transform[] 민첩차일드 = 민첩이지.GetComponentsInChildren<Transform>(true);
        if (힘차일드 != null)
        {
            for (int i = 1; i < 민첩차일드.Length; i++)
            {
                if (민첩차일드[i] != transform)
                    Destroy(민첩차일드[i].gameObject);
            }
        }
        Transform[] 행운차일드 = 행운이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 행운차일드.Length; i++)
            {
                if (행운차일드[i] != transform)
                    Destroy(행운차일드[i].gameObject);
            }
        }
        Transform[] 활력차일드 = 활력게이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 활력차일드.Length; i++)
            {
                if (활력차일드[i] != transform)
                    Destroy(활력차일드[i].gameObject);
            }
        }
        Transform[] 의지력차일드 = 의지력게이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 의지력차일드.Length; i++)
            {
                if (의지력차일드[i] != transform)
                    Destroy(의지력차일드[i].gameObject);
            }
        }
        Transform[] 마력차일드 = 마력게이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 마력차일드.Length; i++)
            {
                if (마력차일드[i] != transform)
                    Destroy(마력차일드[i].gameObject);
            }
        }
        Transform[] 체력차일드 = 체력게이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 체력차일드.Length; i++)
            {
                if (체력차일드[i] != transform)
                    Destroy(체력차일드[i].gameObject);
            }
        }
        Transform[] 정신력차일드 = 정신력게이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 정신력차일드.Length; i++)
            {
                if (정신력차일드[i] != transform)
                    Destroy(정신력차일드[i].gameObject);
            }
        }
        Transform[] 스트레스차일드 = 스트레스내성게이지.GetComponentsInChildren<Transform>(true);
        if (행운차일드 != null)
        {
            for (int i = 1; i < 스트레스차일드.Length; i++)
            {
                if (스트레스차일드[i] != transform)
                    Destroy(스트레스차일드[i].gameObject);
            }
        }

        DataBaseManager.힘 = Random.Range(1, 10);
        DataBaseManager.지능 = Random.Range(1, 10);
        DataBaseManager.민첩 = Random.Range(1, 10);
        DataBaseManager.행운 = Random.Range(1, 10);
        
        DataBaseManager.활력 = Random.Range(1, 10);
        DataBaseManager.마력 = Random.Range(1, 10);
        DataBaseManager.의지력 = Random.Range(1, 10);

        DataBaseManager.체력 = DataBaseManager.활력 + DataBaseManager.의지력;
        DataBaseManager.정신력 = DataBaseManager.마력 + DataBaseManager.의지력;

        DataBaseManager.스트레스게이지 = DataBaseManager.의지력;




        

        /*
        if (skillSlotScripts.칠십퍼배정 == 24)
        {
            SevTPer.SetActive(true);
        }

        if (skillSlotScripts.육십퍼배정 == 24)
        {
            sixTPer.SetActive(true);
        }

        if (skillSlotScripts.오십퍼배정이 == 24)
        {
            fifTper2.SetActive(true);
        }

        if (skillSlotScripts.오십퍼배정일 == 24)
        {
            fifTper1.SetActive(true);
        }

        if (skillSlotScripts.사십퍼배정삼 == 24)
        {
            forTper3.SetActive(true);
        }

        if (skillSlotScripts.사십퍼배정이 == 24)
        {
            forTper2.SetActive(true);
        }

        if (skillSlotScripts.사십퍼배정일 == 24)
        {
            forTper1.SetActive(true);
        }
        */
        힘텍스트.text = "힘 : " + DataBaseManager.힘.ToString();//근력표기
        지능텍스트.text = "지능 : " + DataBaseManager.지능.ToString();//근력표기
        민첩텍스트.text = "민첩 : " + DataBaseManager.민첩.ToString();//
        행운텍스트.text = "행운 : " + DataBaseManager.행운.ToString();//

        활력텍스트.text = "활력 : " + DataBaseManager.활력.ToString();//
        마력텍스트.text = "마력 : " + DataBaseManager.마력.ToString();//
        의지력텍스트.text = "의지력 : " + DataBaseManager.의지력.ToString();//
        체력텍스트.text = "체력 : " + DataBaseManager.체력.ToString();//
        정신력텍스트.text = "정신력 : " + DataBaseManager.정신력.ToString();//

        최대스트레스텍스트.text = "스트레스 내성 : " + DataBaseManager.스트레스게이지.ToString();//

        for(int i=0;i< DataBaseManager.힘; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 힘게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.지능; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 지능게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.민첩; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 민첩이지.transform;
        }
        for (int i = 0; i < DataBaseManager.행운; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 행운이지.transform;
        }
        for (int i = 0; i < DataBaseManager.체력/2; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 체력게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.마력; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 마력게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.정신력/2; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 정신력게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.의지력; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 의지력게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.활력; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 활력게이지.transform;
        }
        for (int i = 0; i < DataBaseManager.스트레스게이지; i++)
        {
            GameObject.Instantiate(게이지오브젝트).transform.parent = 스트레스내성게이지.transform;
        }

        맨손격투reset();
        사격술reset();
        검술reset();
        고문술reset();
        눈썰미reset();
        언변술협박reset();
        던지기reset();
        잠수reset();

        의학지식reset();
        정보조사reset();
        심리판단reset();
        오컬트지식reset();
        정신감정reset();
        언변술설득reset();
        붕대감기reset();
        법의학reset();

        구르기reset();
        변장술reset();
        언변술거짓말reset();
        자물쇠따기reset();
        손재주reset();
        은신reset();
        연기술reset();
        운동신경reset();


        힘스킬배분숫자 = DataBaseManager.힘 * 2;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        지능스킬배분숫자 = DataBaseManager.지능 * 2;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        민첩스킬배분숫자 = DataBaseManager.민첩 * 2;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();





    }

    public Text 힘스킬배분치txt;

    public Text 지능스킬배분치txt;

    public Text 민첩스킬배분치txt;


    public GameObject 맨손격투게이지;
    public Text 맨손격투게이지txt;
    public GameObject 사격술게이지;
    public Text 사격술게이지txt;
    public GameObject 단검술게이지;
    public Text 단검술게이지txt;
    public GameObject 고문술게이지;
    public Text 고문술게이지txt;
    public GameObject 눈썰미게이지;
    public Text 눈썰미게이지txt;
    public GameObject 언변술협박게이지;
    public Text 언변술협박게이지txt;
    public GameObject 던지기게이지;
    public Text 던지기게이지txt;
    public GameObject 잠수게이지;
    public Text 잠수게이지txt;

    

    public void 힘기술랜덤배분()
    {
        
        int 뭘배분 = 0;
        while(0< 힘스킬배분숫자)
        {
            뭘배분 = Random.Range(1, 9);
            switch (뭘배분)
            {
                case 1:
                    맨손격투up();
                    break;
                case 2:
                    사격술up();
                    break;
                case 3:
                    단검술up();
                    break;
                case 4:
                    고문술up();
                    break;
                case 5:
                    눈썰미up();
                    break;
                case 6:
                    언변술협박up();
                    break;
                case 7:
                    던지기up();
                    break;
                case 8:
                    잠수up();
                    break;
            }
                
           

        }
    }

    public void 힘기술전체초기화()
    {
        맨손격투reset();
        사격술reset();
        검술reset();
        고문술reset();
        눈썰미reset();
        언변술협박reset();
        던지기reset();
        잠수reset();
    }



    public void 지능기술랜덤배분()
    {

        int 뭘배분 = 0;
        while (0 < 지능스킬배분숫자)
        {
            뭘배분 = Random.Range(1, 9);
            switch (뭘배분)
            {
                case 1:
                    의학지식up();
                    break;
                case 2:
                    정보조사up();
                    break;
                case 3:
                    심리판단up();
                    break;
                case 4:
                    오컬트지식up();
                    break;
                case 5:
                    정신감정up();
                    break;
                case 6:
                    언변술설득up();
                    break;
                case 7:
                    붕대감기up();
                    break;
                case 8:
                    법의학up();
                    break;
            }



        }
    }

    public void 지능기술전체초기화()
    {
        의학지식reset();
        정보조사reset();
        심리판단reset();
        오컬트지식reset();
        정신감정reset();
        언변술설득reset();
        붕대감기reset();
        법의학reset();
    }



    public void 민첩기술랜덤배분()
    {

        int 뭘배분 = 0;
        while (0 < 민첩스킬배분숫자)
        {
            뭘배분 = Random.Range(1, 9);
            switch (뭘배분)
            {
                case 1:
                    구르기up();
                    break;
                case 2:
                    변장술up();
                    break;
                case 3:
                    언변술거짓말up();
                    break;
                case 4:
                    자물쇠따기up();
                    break;
                case 5:
                    손재주up();
                    break;
                case 6:
                    은신up();
                    break;
                case 7:
                    연기술up();
                    break;
                case 8:
                    운동신경up();
                    break;
            }



        }
    }

    public void 민첩기술전체초기화()
    {
        구르기reset();
        변장술reset();
        언변술거짓말reset();
        자물쇠따기reset();
        손재주reset();
        은신reset();
        연기술reset();
        운동신경reset();
    }
    //힘기반 기술
    public void 맨손격투up()
    {
        if(DataBaseManager.맨손격투 < 9)
        {
            if(힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.맨손격투 = DataBaseManager.맨손격투 + 1;
                맨손격투게이지txt.text = "맨손격투 : " + DataBaseManager.맨손격투.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 맨손격투게이지.transform;
            }


        }

    }
    public void 맨손격투down()
    {
        if (DataBaseManager.맨손격투 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.맨손격투 = DataBaseManager.맨손격투 - 1;
            맨손격투게이지txt.text = "맨손격투 : " + DataBaseManager.맨손격투.ToString();
            Transform[] 맨손격투차일드 = 맨손격투게이지.GetComponentsInChildren<Transform>(true);
            if (맨손격투차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (맨손격투차일드[i] != transform)
                        Destroy(맨손격투차일드[i].gameObject);
                }
            }

        }
    }

    public void 맨손격투reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.맨손격투;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.맨손격투 = 0;




        맨손격투게이지txt.text = "맨손격투 : " + DataBaseManager.맨손격투.ToString();
            Transform[] 맨손격투차일드 = 맨손격투게이지.GetComponentsInChildren<Transform>(true);
            if (맨손격투차일드 != null)
            {
                for (int i = 1; i < 맨손격투차일드.Length; i++)
                {
                    if (맨손격투차일드[i] != transform)
                        Destroy(맨손격투차일드[i].gameObject);
                }
            }


    }


    public void 사격술up()
    {
        if (DataBaseManager.사격술 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.사격술 = DataBaseManager.사격술 + 1;
                사격술게이지txt.text = "사격술 : " + DataBaseManager.사격술.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 사격술게이지.transform;
            }


        }

    }
    public void 사격술down()
    {
        if (DataBaseManager.사격술 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.사격술 = DataBaseManager.사격술 - 1;
            사격술게이지txt.text = "사격술 : " + DataBaseManager.사격술.ToString();
            Transform[] 사격술차일드 = 사격술게이지.GetComponentsInChildren<Transform>(true);
            if (사격술차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (사격술차일드[i] != transform)
                        Destroy(사격술차일드[i].gameObject);
                }
            }

        }
    }

    public void 사격술reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.사격술;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.사격술 = 0;
        사격술게이지txt.text = "사격술 : " + DataBaseManager.사격술.ToString();
        Transform[] 사격술차일드 = 사격술게이지.GetComponentsInChildren<Transform>(true);
        if (사격술차일드 != null)
        {
            for (int i = 1; i < 사격술차일드.Length; i++)
            {
                if (사격술차일드[i] != transform)
                    Destroy(사격술차일드[i].gameObject);
            }
        }


    }


    public void 단검술up()
    {
        if (DataBaseManager.검술 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.검술 = DataBaseManager.검술 + 1;
                단검술게이지txt.text = "단검술 : " + DataBaseManager.검술.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 단검술게이지.transform;
            }


        }

    }
    public void 검술down()
    {
        if (DataBaseManager.검술 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.검술 = DataBaseManager.검술 - 1;
            단검술게이지txt.text = "단검술 : " + DataBaseManager.검술.ToString();
            Transform[] 단검술차일드 = 단검술게이지.GetComponentsInChildren<Transform>(true);
            if (단검술차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (단검술차일드[i] != transform)
                        Destroy(단검술차일드[i].gameObject);
                }
            }

        }
    }

    public void 검술reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.검술;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.검술 = 0;
        단검술게이지txt.text = "단검술 : " + DataBaseManager.검술.ToString();
        Transform[] 단검술차일드 = 단검술게이지.GetComponentsInChildren<Transform>(true);
        if (단검술차일드 != null)
        {
            for (int i = 1; i < 단검술차일드.Length; i++)
            {
                if (단검술차일드[i] != transform)
                    Destroy(단검술차일드[i].gameObject);
            }
        }


    }


    public void 고문술up()
    {
        if (DataBaseManager.고문술 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.고문술 = DataBaseManager.고문술 + 1;
                고문술게이지txt.text = "고문술 : " + DataBaseManager.고문술.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 고문술게이지.transform;
            }


        }

    }
    public void 고문술down()
    {
        if (DataBaseManager.고문술 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.고문술 = DataBaseManager.고문술 - 1;
            고문술게이지txt.text = "고문술 : " + DataBaseManager.고문술.ToString();
            Transform[] 고문술차일드 = 고문술게이지.GetComponentsInChildren<Transform>(true);
            if (고문술차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (고문술차일드[i] != transform)
                        Destroy(고문술차일드[i].gameObject);
                }
            }

        }
    }

    public void 고문술reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.고문술;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.고문술 = 0;
        고문술게이지txt.text = "고문술 : " + DataBaseManager.고문술.ToString();
        Transform[] 고문술차일드 = 고문술게이지.GetComponentsInChildren<Transform>(true);
        if (고문술차일드 != null)
        {
            for (int i = 1; i < 고문술차일드.Length; i++)
            {
                if (고문술차일드[i] != transform)
                    Destroy(고문술차일드[i].gameObject);
            }
        }


    }
    public void 눈썰미up()
    {
        if (DataBaseManager.눈썰미 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.눈썰미 = DataBaseManager.눈썰미 + 1;
                눈썰미게이지txt.text = "눈썰미 : " + DataBaseManager.눈썰미.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 눈썰미게이지.transform;
            }


        }

    }
    public void 눈썰미down()
    {
        if (DataBaseManager.눈썰미 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.눈썰미 = DataBaseManager.눈썰미 - 1;
            눈썰미게이지txt.text = "눈썰미 : " + DataBaseManager.눈썰미.ToString();
            Transform[] 눈썰미차일드 = 눈썰미게이지.GetComponentsInChildren<Transform>(true);
            if (눈썰미차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (눈썰미차일드[i] != transform)
                        Destroy(눈썰미차일드[i].gameObject);
                }
            }

        }
    }

    public void 눈썰미reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.눈썰미;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.눈썰미 = 0;
        눈썰미게이지txt.text = "눈썰미 : " + DataBaseManager.눈썰미.ToString();
        Transform[] 눈썰미차일드 = 눈썰미게이지.GetComponentsInChildren<Transform>(true);
        if (눈썰미차일드 != null)
        {
            for (int i = 1; i < 눈썰미차일드.Length; i++)
            {
                if (눈썰미차일드[i] != transform)
                    Destroy(눈썰미차일드[i].gameObject);
            }
        }


    }
    public void 언변술협박up()
    {
        if (DataBaseManager.언변술_협박 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.언변술_협박 = DataBaseManager.언변술_협박 + 1;
                언변술협박게이지txt.text = "언변술(협박) : " + DataBaseManager.언변술_협박.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 언변술협박게이지.transform;
            }


        }

    }
    public void 언변술협박down()
    {
        if (DataBaseManager.언변술_협박 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.언변술_협박 = DataBaseManager.언변술_협박 - 1;
            언변술협박게이지txt.text = "언변술(협박) : " + DataBaseManager.언변술_협박.ToString();
            Transform[] 언변술협박차일드 = 언변술협박게이지.GetComponentsInChildren<Transform>(true);
            if (언변술협박차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (언변술협박차일드[i] != transform)
                        Destroy(언변술협박차일드[i].gameObject);
                }
            }

        }
    }

    public void 언변술협박reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.언변술_협박;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.언변술_협박 = 0;
        언변술협박게이지txt.text = "언변술(협박) : " + DataBaseManager.언변술_협박.ToString();
        Transform[] 언변술협박차일드 = 언변술협박게이지.GetComponentsInChildren<Transform>(true);
        if (언변술협박차일드 != null)
        {
            for (int i = 1; i < 언변술협박차일드.Length; i++)
            {
                if (언변술협박차일드[i] != transform)
                    Destroy(언변술협박차일드[i].gameObject);
            }
        }


    }
    public void 던지기up()
    {
        if (DataBaseManager.던지기 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.던지기 = DataBaseManager.던지기 + 1;
                던지기게이지txt.text = "던지기 : " + DataBaseManager.던지기.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 던지기게이지.transform;
            }


        }

    }
    public void 던지기down()
    {
        if (DataBaseManager.던지기 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.던지기 = DataBaseManager.던지기 - 1;
            던지기게이지txt.text = "던지기 : " + DataBaseManager.던지기.ToString();
            Transform[] 던지기차일드 = 던지기게이지.GetComponentsInChildren<Transform>(true);
            if (던지기차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (던지기차일드[i] != transform)
                        Destroy(던지기차일드[i].gameObject);
                }
            }

        }
    }

    public void 던지기reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.던지기;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.던지기 = 0;
        던지기게이지txt.text = "던지기 : " + DataBaseManager.던지기.ToString();
        Transform[] 던지기차일드 = 던지기게이지.GetComponentsInChildren<Transform>(true);
        if (던지기차일드 != null)
        {
            for (int i = 1; i < 던지기차일드.Length; i++)
            {
                if (던지기차일드[i] != transform)
                    Destroy(던지기차일드[i].gameObject);
            }
        }


    }
    public void 잠수up()
    {
        if (DataBaseManager.잠수 < 9)
        {
            if (힘스킬배분숫자 > 0)
            {
                힘스킬배분숫자 = 힘스킬배분숫자 - 1;
                힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
                DataBaseManager.잠수 = DataBaseManager.잠수 + 1;
                잠수게이지txt.text = "잠수 : " + DataBaseManager.잠수.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 잠수게이지.transform;
            }


        }

    }
    public void 잠수down()
    {
        if (DataBaseManager.잠수 > 0)
        {
            힘스킬배분숫자 = 힘스킬배분숫자 + 1;
            힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
            DataBaseManager.잠수 = DataBaseManager.잠수 - 1;
            잠수게이지txt.text = "잠수 : " + DataBaseManager.잠수.ToString();
            Transform[] 잠수차일드 = 잠수게이지.GetComponentsInChildren<Transform>(true);
            if (잠수차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (잠수차일드[i] != transform)
                        Destroy(잠수차일드[i].gameObject);
                }
            }

        }
    }

    public void 잠수reset()
    {
        힘스킬배분숫자 = 힘스킬배분숫자 + DataBaseManager.잠수;
        힘스킬배분치txt.text = 힘스킬배분숫자.ToString();
        DataBaseManager.잠수 = 0;
        잠수게이지txt.text = "잠수 : " + DataBaseManager.잠수.ToString();
        Transform[] 잠수차일드 = 잠수게이지.GetComponentsInChildren<Transform>(true);
        if (잠수차일드 != null)
        {
            for (int i = 1; i < 잠수차일드.Length; i++)
            {
                if (잠수차일드[i] != transform)
                    Destroy(잠수차일드[i].gameObject);
            }
        }


    }

    public GameObject 의학지식게이지;
    public Text 의학지식게이지txt;
    public GameObject 정보조사게이지;
    public Text 정보조사게이지txt;
    public GameObject 심리판단게이지;
    public Text 심리판단게이지txt;
    public GameObject 오컬트지식게이지;
    public Text 오컬트지식게이지txt;
    public GameObject 정신감정게이지;
    public Text 정신감정게이지txt;
    public GameObject 언변술설득게이지;
    public Text 언변술설득게이지txt;
    public GameObject 붕대감기게이지;
    public Text 붕대감기게이지txt;
    public GameObject 법의학게이지;
    public Text 법의학게이지txt;

    public void 의학지식up()
    {
        if (DataBaseManager.의학지식 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.의학지식 = DataBaseManager.의학지식 + 1;
                의학지식게이지txt.text = "의학지식 : " + DataBaseManager.의학지식.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 의학지식게이지.transform;
            }


        }

    }
    public void 의학지식down()
    {
        if (DataBaseManager.의학지식 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.의학지식 = DataBaseManager.의학지식 - 1;
            의학지식게이지txt.text = "의학지식 : " + DataBaseManager.의학지식.ToString();
            Transform[] 의학지식차일드 = 의학지식게이지.GetComponentsInChildren<Transform>(true);
            if (의학지식차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (의학지식차일드[i] != transform)
                        Destroy(의학지식차일드[i].gameObject);
                }
            }

        }
    }

    public void 의학지식reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.의학지식;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.의학지식 = 0;


        의학지식게이지txt.text = "의학지식 : " + DataBaseManager.의학지식.ToString();
        Transform[] 의학지식차일드 = 의학지식게이지.GetComponentsInChildren<Transform>(true);
        if (의학지식차일드 != null)
        {
            for (int i = 1; i < 의학지식차일드.Length; i++)
            {
                if (의학지식차일드[i] != transform)
                    Destroy(의학지식차일드[i].gameObject);
            }
        }


    }


    public void 정보조사up()
    {
        if (DataBaseManager.정보조사 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.정보조사 = DataBaseManager.정보조사 + 1;
                정보조사게이지txt.text = "정보조사 : " + DataBaseManager.정보조사.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 정보조사게이지.transform;
            }


        }

    }
    public void 정보조사down()
    {
        if (DataBaseManager.정보조사 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.정보조사 = DataBaseManager.정보조사 - 1;
            정보조사게이지txt.text = "정보조사 : " + DataBaseManager.정보조사.ToString();
            Transform[] 정보조사차일드 = 정보조사게이지.GetComponentsInChildren<Transform>(true);
            if (정보조사차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (정보조사차일드[i] != transform)
                        Destroy(정보조사차일드[i].gameObject);
                }
            }

        }
    }

    public void 정보조사reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.정보조사;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.정보조사 = 0;
        정보조사게이지txt.text = "정보조사 : " + DataBaseManager.정보조사.ToString();
        Transform[] 정보조사차일드 = 정보조사게이지.GetComponentsInChildren<Transform>(true);
        if (정보조사차일드 != null)
        {
            for (int i = 1; i < 정보조사차일드.Length; i++)
            {
                if (정보조사차일드[i] != transform)
                    Destroy(정보조사차일드[i].gameObject);
            }
        }


    }


    public void 심리판단up()
    {
        if (DataBaseManager.심리판단 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.심리판단 = DataBaseManager.심리판단 + 1;
                심리판단게이지txt.text = "심리판단 : " + DataBaseManager.심리판단.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 심리판단게이지.transform;
            }


        }

    }
    public void 심리판단down()
    {
        if (DataBaseManager.심리판단 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.심리판단 = DataBaseManager.심리판단 - 1;
            심리판단게이지txt.text = "심리판단 : " + DataBaseManager.심리판단.ToString();
            Transform[] 심리판단차일드 = 심리판단게이지.GetComponentsInChildren<Transform>(true);
            if (심리판단차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (심리판단차일드[i] != transform)
                        Destroy(심리판단차일드[i].gameObject);
                }
            }

        }
    }

    public void 심리판단reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.심리판단;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.심리판단 = 0;
        심리판단게이지txt.text = "심리판단 : " + DataBaseManager.심리판단.ToString();
        Transform[] 심리판단차일드 = 심리판단게이지.GetComponentsInChildren<Transform>(true);
        if (심리판단차일드 != null)
        {
            for (int i = 1; i < 심리판단차일드.Length; i++)
            {
                if (심리판단차일드[i] != transform)
                    Destroy(심리판단차일드[i].gameObject);
            }
        }


    }


    public void 오컬트지식up()
    {
        if (DataBaseManager.오컬트지식 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.오컬트지식 = DataBaseManager.오컬트지식 + 1;
                오컬트지식게이지txt.text = "오컬트지식 : " + DataBaseManager.오컬트지식.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 오컬트지식게이지.transform;
            }


        }

    }
    public void 오컬트지식down()
    {
        if (DataBaseManager.오컬트지식 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.오컬트지식 = DataBaseManager.오컬트지식 - 1;
            오컬트지식게이지txt.text = "오컬트지식 : " + DataBaseManager.오컬트지식.ToString();
            Transform[] 오컬트지식차일드 = 오컬트지식게이지.GetComponentsInChildren<Transform>(true);
            if (오컬트지식차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (오컬트지식차일드[i] != transform)
                        Destroy(오컬트지식차일드[i].gameObject);
                }
            }

        }
    }

    public void 오컬트지식reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.오컬트지식;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.오컬트지식 = 0;
        오컬트지식게이지txt.text = "오컬트지식 : " + DataBaseManager.오컬트지식.ToString();
        Transform[] 오컬트지식차일드 = 오컬트지식게이지.GetComponentsInChildren<Transform>(true);
        if (오컬트지식차일드 != null)
        {
            for (int i = 1; i < 오컬트지식차일드.Length; i++)
            {
                if (오컬트지식차일드[i] != transform)
                    Destroy(오컬트지식차일드[i].gameObject);
            }
        }


    }
    public void 정신감정up()
    {
        if (DataBaseManager.정신감정 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.정신감정 = DataBaseManager.정신감정 + 1;
                정신감정게이지txt.text = "정신감정 : " + DataBaseManager.정신감정.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 정신감정게이지.transform;
            }


        }

    }
    public void 정신감정down()
    {
        if (DataBaseManager.정신감정 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.정신감정 = DataBaseManager.정신감정 - 1;
            정신감정게이지txt.text = "정신감정 : " + DataBaseManager.정신감정.ToString();
            Transform[] 정신감정차일드 = 정신감정게이지.GetComponentsInChildren<Transform>(true);
            if (정신감정차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (정신감정차일드[i] != transform)
                        Destroy(정신감정차일드[i].gameObject);
                }
            }

        }
    }

    public void 정신감정reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.정신감정;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.정신감정 = 0;
        정신감정게이지txt.text = "정신감정 : " + DataBaseManager.정신감정.ToString();
        Transform[] 정신감정차일드 = 정신감정게이지.GetComponentsInChildren<Transform>(true);
        if (정신감정차일드 != null)
        {
            for (int i = 1; i < 정신감정차일드.Length; i++)
            {
                if (정신감정차일드[i] != transform)
                    Destroy(정신감정차일드[i].gameObject);
            }
        }


    }
    public void 언변술설득up()
    {
        if (DataBaseManager.언변술_설득 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.언변술_설득 = DataBaseManager.언변술_설득 + 1;
                언변술설득게이지txt.text = "언변술(설득) : " + DataBaseManager.언변술_설득.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 언변술설득게이지.transform;
            }


        }

    }
    public void 언변술설득down()
    {
        if (DataBaseManager.언변술_설득 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.언변술_설득 = DataBaseManager.언변술_설득 - 1;
            언변술설득게이지txt.text = "언변술(설득) : " + DataBaseManager.언변술_설득.ToString();
            Transform[] 언변술설득차일드 = 언변술설득게이지.GetComponentsInChildren<Transform>(true);
            if (언변술설득차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (언변술설득차일드[i] != transform)
                        Destroy(언변술설득차일드[i].gameObject);
                }
            }

        }
    }

    public void 언변술설득reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.언변술_설득;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.언변술_설득 = 0;
        언변술설득게이지txt.text = "언변술(설득) : " + DataBaseManager.언변술_설득.ToString();
        Transform[] 언변술설득차일드 = 언변술설득게이지.GetComponentsInChildren<Transform>(true);
        if (언변술설득차일드 != null)
        {
            for (int i = 1; i < 언변술설득차일드.Length; i++)
            {
                if (언변술설득차일드[i] != transform)
                    Destroy(언변술설득차일드[i].gameObject);
            }
        }


    }
    public void 붕대감기up()
    {
        if (DataBaseManager.붕대감기 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.붕대감기 = DataBaseManager.붕대감기 + 1;
                붕대감기게이지txt.text = "붕대감기 : " + DataBaseManager.붕대감기.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 붕대감기게이지.transform;
            }


        }

    }
    public void 붕대감기down()
    {
        if (DataBaseManager.붕대감기 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.붕대감기 = DataBaseManager.붕대감기 - 1;
            붕대감기게이지txt.text = "붕대감기 : " + DataBaseManager.붕대감기.ToString();
            Transform[] 붕대감기차일드 = 붕대감기게이지.GetComponentsInChildren<Transform>(true);
            if (붕대감기차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (붕대감기차일드[i] != transform)
                        Destroy(붕대감기차일드[i].gameObject);
                }
            }

        }
    }

    public void 붕대감기reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.붕대감기;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.붕대감기 = 0;
        붕대감기게이지txt.text = "붕대감기 : " + DataBaseManager.붕대감기.ToString();
        Transform[] 붕대감기차일드 = 붕대감기게이지.GetComponentsInChildren<Transform>(true);
        if (붕대감기차일드 != null)
        {
            for (int i = 1; i < 붕대감기차일드.Length; i++)
            {
                if (붕대감기차일드[i] != transform)
                    Destroy(붕대감기차일드[i].gameObject);
            }
        }


    }
    public void 법의학up()
    {
        if (DataBaseManager.법의학 < 9)
        {
            if (지능스킬배분숫자 > 0)
            {
                지능스킬배분숫자 = 지능스킬배분숫자 - 1;
                지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
                DataBaseManager.법의학 = DataBaseManager.법의학 + 1;
                법의학게이지txt.text = "법의학 : " + DataBaseManager.법의학.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 법의학게이지.transform;
            }


        }

    }
    public void 법의학down()
    {
        if (DataBaseManager.법의학 > 0)
        {
            지능스킬배분숫자 = 지능스킬배분숫자 + 1;
            지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
            DataBaseManager.법의학 = DataBaseManager.법의학 - 1;
            법의학게이지txt.text = "법의학 : " + DataBaseManager.법의학.ToString();
            Transform[] 법의학차일드 = 법의학게이지.GetComponentsInChildren<Transform>(true);
            if (법의학차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (법의학차일드[i] != transform)
                        Destroy(법의학차일드[i].gameObject);
                }
            }

        }
    }

    public void 법의학reset()
    {
        지능스킬배분숫자 = 지능스킬배분숫자 + DataBaseManager.법의학;
        지능스킬배분치txt.text = 지능스킬배분숫자.ToString();
        DataBaseManager.법의학 = 0;
        법의학게이지txt.text = "법의학 : " + DataBaseManager.법의학.ToString();
        Transform[] 법의학차일드 = 법의학게이지.GetComponentsInChildren<Transform>(true);
        if (법의학차일드 != null)
        {
            for (int i = 1; i < 법의학차일드.Length; i++)
            {
                if (법의학차일드[i] != transform)
                    Destroy(법의학차일드[i].gameObject);
            }
        }


    }



    public GameObject 구르기게이지;
    public Text 구르기게이지txt;
    public GameObject 변장술게이지;
    public Text 변장술게이지txt;
    public GameObject 언변술거짓말게이지;
    public Text 언변술거짓말게이지txt;
    public GameObject 자물쇠따기게이지;
    public Text 자물쇠따기게이지txt;
    public GameObject 손재주게이지;
    public Text 손재주게이지txt;
    public GameObject 은신게이지;
    public Text 은신게이지txt;
    public GameObject 연기술게이지;
    public Text 연기술게이지txt;
    public GameObject 운동신경게이지;
    public Text 운동신경게이지txt;


    public void 구르기up()
    {
        if (DataBaseManager.구르기 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.구르기 = DataBaseManager.구르기 + 1;
                구르기게이지txt.text = "구르기 : " + DataBaseManager.구르기.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 구르기게이지.transform;
            }


        }

    }
    public void 구르기down()
    {
        if (DataBaseManager.구르기 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.구르기 = DataBaseManager.구르기 - 1;
            구르기게이지txt.text = "구르기 : " + DataBaseManager.구르기.ToString();
            Transform[] 구르기차일드 = 구르기게이지.GetComponentsInChildren<Transform>(true);
            if (구르기차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (구르기차일드[i] != transform)
                        Destroy(구르기차일드[i].gameObject);
                }
            }

        }
    }

    public void 구르기reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.구르기;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.구르기 = 0;
        구르기게이지txt.text = "구르기 : " + DataBaseManager.구르기.ToString();
        Transform[] 구르기차일드 = 구르기게이지.GetComponentsInChildren<Transform>(true);
        if (구르기차일드 != null)
        {
            for (int i = 1; i < 구르기차일드.Length; i++)
            {
                if (구르기차일드[i] != transform)
                    Destroy(구르기차일드[i].gameObject);
            }
        }


    }

    public void 언변술거짓말up()
    {
        if (DataBaseManager.언변술_거짓말 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.언변술_거짓말 = DataBaseManager.언변술_거짓말 + 1;
                언변술거짓말게이지txt.text = "언변술(거짓말) : " + DataBaseManager.언변술_거짓말.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 언변술거짓말게이지.transform;
            }


        }

    }
    public void 언변술거짓말down()
    {
        if (DataBaseManager.언변술_거짓말 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.언변술_거짓말 = DataBaseManager.언변술_거짓말 - 1;
            언변술거짓말게이지txt.text = "언변술(거짓말) : " + DataBaseManager.언변술_거짓말.ToString();
            Transform[] 언변술거짓말차일드 = 언변술거짓말게이지.GetComponentsInChildren<Transform>(true);
            if (언변술거짓말차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (언변술거짓말차일드[i] != transform)
                        Destroy(언변술거짓말차일드[i].gameObject);
                }
            }

        }
    }

    public void 언변술거짓말reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.언변술_거짓말;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.언변술_거짓말 = 0;
        언변술거짓말게이지txt.text = "언변술(거짓말) : " + DataBaseManager.언변술_거짓말.ToString();
        Transform[] 언변술거짓말차일드 = 언변술거짓말게이지.GetComponentsInChildren<Transform>(true);
        if (언변술거짓말차일드 != null)
        {
            for (int i = 1; i < 언변술거짓말차일드.Length; i++)
            {
                if (언변술거짓말차일드[i] != transform)
                    Destroy(언변술거짓말차일드[i].gameObject);
            }
        }


    }


    public void 변장술up()
    {
        if (DataBaseManager.변장술 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.변장술 = DataBaseManager.변장술 + 1;
                변장술게이지txt.text = "변장술 : " + DataBaseManager.변장술.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 변장술게이지.transform;
            }


        }

    }
    public void 변장술down()
    {
        if (DataBaseManager.변장술 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.변장술 = DataBaseManager.변장술 - 1;
            변장술게이지txt.text = "변장술 : " + DataBaseManager.변장술.ToString();
            Transform[] 변장술차일드 = 변장술게이지.GetComponentsInChildren<Transform>(true);
            if (변장술차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (변장술차일드[i] != transform)
                        Destroy(변장술차일드[i].gameObject);
                }
            }

        }
    }

    public void 변장술reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.변장술;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.변장술 = 0;
        변장술게이지txt.text = "변장술 : " + DataBaseManager.변장술.ToString();
        Transform[] 변장술차일드 = 변장술게이지.GetComponentsInChildren<Transform>(true);
        if (변장술차일드 != null)
        {
            for (int i = 1; i < 변장술차일드.Length; i++)
            {
                if (변장술차일드[i] != transform)
                    Destroy(변장술차일드[i].gameObject);
            }
        }


    }
    public void 자물쇠따기up()
    {
        if (DataBaseManager.자물쇠따기 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.자물쇠따기 = DataBaseManager.자물쇠따기 + 1;
                자물쇠따기게이지txt.text = "자물쇠따기 : " + DataBaseManager.자물쇠따기.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 자물쇠따기게이지.transform;
            }


        }

    }
    public void 자물쇠따기down()
    {
        if (DataBaseManager.자물쇠따기 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.자물쇠따기 = DataBaseManager.자물쇠따기 - 1;
            자물쇠따기게이지txt.text = "자물쇠따기 : " + DataBaseManager.자물쇠따기.ToString();
            Transform[] 자물쇠따기차일드 = 자물쇠따기게이지.GetComponentsInChildren<Transform>(true);
            if (자물쇠따기차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (자물쇠따기차일드[i] != transform)
                        Destroy(자물쇠따기차일드[i].gameObject);
                }
            }

        }
    }

    public void 자물쇠따기reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.자물쇠따기;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.자물쇠따기 = 0;
        자물쇠따기게이지txt.text = "자물쇠따기 : " + DataBaseManager.자물쇠따기.ToString();
        Transform[] 자물쇠따기차일드 = 자물쇠따기게이지.GetComponentsInChildren<Transform>(true);
        if (자물쇠따기차일드 != null)
        {
            for (int i = 1; i < 자물쇠따기차일드.Length; i++)
            {
                if (자물쇠따기차일드[i] != transform)
                    Destroy(자물쇠따기차일드[i].gameObject);
            }
        }


    }
    public void 손재주up()
    {
        if (DataBaseManager.손재주 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.손재주 = DataBaseManager.손재주 + 1;
                손재주게이지txt.text = "손재주 : " + DataBaseManager.손재주.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 손재주게이지.transform;
            }


        }

    }
    public void 손재주down()
    {
        if (DataBaseManager.손재주 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.손재주 = DataBaseManager.손재주 - 1;
            손재주게이지txt.text = "손재주 : " + DataBaseManager.손재주.ToString();
            Transform[] 손재주차일드 = 손재주게이지.GetComponentsInChildren<Transform>(true);
            if (손재주차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (손재주차일드[i] != transform)
                        Destroy(손재주차일드[i].gameObject);
                }
            }

        }
    }

    public void 손재주reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.손재주;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.손재주 = 0;
        손재주게이지txt.text = "손재주 : " + DataBaseManager.손재주.ToString();
        Transform[] 손재주차일드 = 손재주게이지.GetComponentsInChildren<Transform>(true);
        if (손재주차일드 != null)
        {
            for (int i = 1; i < 손재주차일드.Length; i++)
            {
                if (손재주차일드[i] != transform)
                    Destroy(손재주차일드[i].gameObject);
            }
        }


    }
    public void 은신up()
    {
        if (DataBaseManager.은신 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.은신 = DataBaseManager.은신 + 1;
                은신게이지txt.text = "은신 : " + DataBaseManager.은신.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 은신게이지.transform;
            }


        }

    }
    public void 은신down()
    {
        if (DataBaseManager.은신 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.은신 = DataBaseManager.은신 - 1;
            은신게이지txt.text = "은신 : " + DataBaseManager.은신.ToString();
            Transform[] 은신차일드 = 은신게이지.GetComponentsInChildren<Transform>(true);
            if (은신차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (은신차일드[i] != transform)
                        Destroy(은신차일드[i].gameObject);
                }
            }

        }
    }

    public void 은신reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.은신;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.은신 = 0;
        은신게이지txt.text = "은신 : " + DataBaseManager.은신.ToString();
        Transform[] 은신차일드 = 은신게이지.GetComponentsInChildren<Transform>(true);
        if (은신차일드 != null)
        {
            for (int i = 1; i < 은신차일드.Length; i++)
            {
                if (은신차일드[i] != transform)
                    Destroy(은신차일드[i].gameObject);
            }
        }


    }
    public void 연기술up()
    {
        if (DataBaseManager.연기술 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.연기술 = DataBaseManager.연기술 + 1;
                연기술게이지txt.text = "연기술 : " + DataBaseManager.연기술.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 연기술게이지.transform;
            }


        }

    }
    public void 연기술down()
    {
        if (DataBaseManager.연기술 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.연기술 = DataBaseManager.연기술 - 1;
            연기술게이지txt.text = "연기술 : " + DataBaseManager.연기술.ToString();
            Transform[] 연기술차일드 = 연기술게이지.GetComponentsInChildren<Transform>(true);
            if (연기술차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (연기술차일드[i] != transform)
                        Destroy(연기술차일드[i].gameObject);
                }
            }

        }
    }

    public void 연기술reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.연기술;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.연기술 = 0;
        연기술게이지txt.text = "연기술 : " + DataBaseManager.연기술.ToString();
        Transform[] 연기술차일드 = 연기술게이지.GetComponentsInChildren<Transform>(true);
        if (연기술차일드 != null)
        {
            for (int i = 1; i < 연기술차일드.Length; i++)
            {
                if (연기술차일드[i] != transform)
                    Destroy(연기술차일드[i].gameObject);
            }
        }


    }
    public void 운동신경up()
    {
        if (DataBaseManager.운동신경 < 9)
        {
            if (민첩스킬배분숫자 > 0)
            {
                민첩스킬배분숫자 = 민첩스킬배분숫자 - 1;
                민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
                DataBaseManager.운동신경 = DataBaseManager.운동신경 + 1;
                운동신경게이지txt.text = "운동신경 : " + DataBaseManager.운동신경.ToString();
                GameObject.Instantiate(게이지오브젝트).transform.parent = 운동신경게이지.transform;
            }


        }

    }
    public void 운동신경down()
    {
        if (DataBaseManager.운동신경 > 0)
        {
            민첩스킬배분숫자 = 민첩스킬배분숫자 + 1;
            민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
            DataBaseManager.운동신경 = DataBaseManager.운동신경 - 1;
            운동신경게이지txt.text = "운동신경 : " + DataBaseManager.운동신경.ToString();
            Transform[] 운동신경차일드 = 운동신경게이지.GetComponentsInChildren<Transform>(true);
            if (운동신경차일드 != null)
            {
                for (int i = 1; i < 2; i++)
                {
                    if (운동신경차일드[i] != transform)
                        Destroy(운동신경차일드[i].gameObject);
                }
            }

        }
    }

    public void 운동신경reset()
    {
        민첩스킬배분숫자 = 민첩스킬배분숫자 + DataBaseManager.운동신경;
        민첩스킬배분치txt.text = 민첩스킬배분숫자.ToString();
        DataBaseManager.운동신경 = 0;
        운동신경게이지txt.text = "운동신경 : " + DataBaseManager.운동신경.ToString();
        Transform[] 운동신경차일드 = 운동신경게이지.GetComponentsInChildren<Transform>(true);
        if (운동신경차일드 != null)
        {
            for (int i = 1; i < 운동신경차일드.Length; i++)
            {
                if (운동신경차일드[i] != transform)
                    Destroy(운동신경차일드[i].gameObject);
            }
        }


    }
    








    public void goNext()// 스탯 생성 버튼
    {
        SceneManager.LoadScene("START_OPEN");
        Time.timeScale = 1.0f;
    }
    public void goMenu()// 스탯 생성 버튼
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1.0f;
    }

    void Start()
    {

        맨손격투게이지txt.text = "맨손격투 : " + DataBaseManager.맨손격투.ToString();
        사격술게이지txt.text = "사격술 : " + DataBaseManager.사격술.ToString();
        단검술게이지txt.text = "단검술 : " + DataBaseManager.검술.ToString();
        고문술게이지txt.text = "고문술 : " + DataBaseManager.고문술.ToString();
        눈썰미게이지txt.text = "눈썰미 : " + DataBaseManager.눈썰미.ToString();
        언변술협박게이지txt.text = "언변술(협박) : " + DataBaseManager.언변술_협박.ToString();
        던지기게이지txt.text = "던지기 : " + DataBaseManager.던지기.ToString();
        잠수게이지txt.text = "잠수 : " + DataBaseManager.잠수.ToString();

        의학지식게이지txt.text = "의학지식 : " + DataBaseManager.의학지식.ToString();
        정보조사게이지txt.text = "정보조사 : " + DataBaseManager.정보조사.ToString();
        심리판단게이지txt.text = "심리판단 : " + DataBaseManager.심리판단.ToString();
        오컬트지식게이지txt.text = "오컬트지식 : " + DataBaseManager.오컬트지식.ToString();
        정신감정게이지txt.text = "정신감정 : " + DataBaseManager.정신감정.ToString();
        언변술설득게이지txt.text = "언변술(설득) : " + DataBaseManager.언변술_설득.ToString();
        붕대감기게이지txt.text = "붕대감기 : " + DataBaseManager.붕대감기.ToString();
        법의학게이지txt.text = "법의학 : " + DataBaseManager.법의학.ToString();

        구르기게이지txt.text = "구르기 : " + DataBaseManager.구르기.ToString();
        변장술게이지txt.text = "변장술 : " + DataBaseManager.변장술.ToString();
        언변술거짓말게이지txt.text = "언변술(거짓말) : " + DataBaseManager.언변술_거짓말.ToString();
        자물쇠따기게이지txt.text = "오컬트지식 : " + DataBaseManager.자물쇠따기.ToString();
        손재주게이지txt.text = "손재주 : " + DataBaseManager.손재주.ToString();
        은신게이지txt.text = "은신 : " + DataBaseManager.은신.ToString();
        연기술게이지txt.text = "연기술 : " + DataBaseManager.연기술.ToString();
        운동신경게이지txt.text = "운동신경 : " + DataBaseManager.운동신경.ToString();
    }


    public GameObject 게임시작버튼;
    public GameObject 힘배분치남음알람;
    public GameObject 지능배분치남음알람;
    public GameObject 민첩배분치남음알람;
    // Update is called once per frame
    void Update()
    {
        if(힘스킬배분숫자 ==0 && 지능스킬배분숫자 ==0 && 민첩스킬배분숫자 == 0)
        {
            게임시작버튼.SetActive(true);
        }
        else
        {
            게임시작버튼.SetActive(false);
        }

        if (힘스킬배분숫자 == 0)
        {
            힘배분치남음알람.SetActive(false);
        }
        else
        {
            힘배분치남음알람.SetActive(true);
        }

        if (지능스킬배분숫자 == 0)
        {
            지능배분치남음알람.SetActive(false);
        }
        else
        {
            지능배분치남음알람.SetActive(true);
        }

        if (민첩스킬배분숫자 == 0)
        {
            민첩배분치남음알람.SetActive(false);
        }
        else
        {
            민첩배분치남음알람.SetActive(true);
        }

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


    public GameObject 일페이지;
    public GameObject 이페이지;
    public GameObject 삼페이지;

    // Update is called once per frame

    public int 화살표넘버 = 1;

    public void 힘페이지켜기()
    {
        화살표넘버 = 1;

    }

    public void 지능페이지켜기()
    {
        화살표넘버 = 2;

    }
    public void 민첩페이지켜기()
    {
        화살표넘버 = 3;

    }


}





