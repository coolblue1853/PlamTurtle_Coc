using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCharNext : MonoBehaviour
{
    public GameObject 능력치;
    public GameObject 스킬;
    public GameObject 최초설명;

    public GameObject 힘설명;
    public GameObject 지능설명;
    public GameObject 민첩설명;
    public GameObject 행운설명;

    public GameObject 활력설명;
    public GameObject 의지력설명;
    public GameObject 마력설명;
    public GameObject 체력설명;
    public GameObject 정신력설명;
    public GameObject 스트레스내성설명;

    public GameObject 맨손격투;
    public GameObject 사격술;
    public GameObject 단검술;
    public GameObject 고문술;
    public GameObject 눈썰미;
    public GameObject 언변술협박;
    public GameObject 던지기;
    public GameObject 잠수;

    public GameObject 의학지식;
    public GameObject 정보조사;
    public GameObject 심리판단;
    public GameObject 오컬트지식;
    public GameObject 정신감정;
    public GameObject 언변술설득;
    public GameObject 붕대감기;
    public GameObject 법의학;

    public GameObject 구르기;
    public GameObject 변장술;
    public GameObject 자물쇠따기;
    public GameObject 손재주;
    public GameObject 은신;
    public GameObject 언변술거짓말;
    public GameObject 연기술;
    public GameObject 운동신경;

    public bool 설명isOn = false;


    public void 운동신경설명등장()
    {
        설명isOn = true;
        운동신경.SetActive(true);


    }
    public void 운동신경설명가림()
    {
        설명isOn = false;
        운동신경.SetActive(false);
    }
    public void 연기술설명등장()
    {
        설명isOn = true;
        연기술.SetActive(true);


    }
    public void 연기술설명가림()
    {
        설명isOn = false;
        연기술.SetActive(false);
    }
    public void 언변술거짓말설명등장()
    {
        설명isOn = true;
        언변술거짓말.SetActive(true);


    }
    public void 언변술거짓말설명가림()
    {
        설명isOn = false;
        언변술거짓말.SetActive(false);
    }
    public void 은신설명등장()
    {
        설명isOn = true;
        은신.SetActive(true);


    }
    public void 은신설명가림()
    {
        설명isOn = false;
        은신.SetActive(false);
    }
    public void 손재주설명등장()
    {
        설명isOn = true;
        손재주.SetActive(true);


    }
    public void 손재주설명가림()
    {
        설명isOn = false;
        손재주.SetActive(false);
    }
    public void 자물쇠따기설명등장()
    {
        설명isOn = true;
        자물쇠따기.SetActive(true);


    }
    public void 자물쇠따기설명가림()
    {
        설명isOn = false;
        자물쇠따기.SetActive(false);
    }
    public void 변장술설명등장()
    {
        설명isOn = true;
        변장술.SetActive(true);


    }
    public void 변장술설명가림()
    {
        설명isOn = false;
        변장술.SetActive(false);
    }
    public void 구르기설명등장()
    {
        설명isOn = true;
        구르기.SetActive(true);


    }
    public void 구르기설명가림()
    {
        설명isOn = false;
        구르기.SetActive(false);
    }
    public void 법의학설명등장()
    {
        설명isOn = true;
        법의학.SetActive(true);


    }
    public void 법의학설명가림()
    {
        설명isOn = false;
        법의학.SetActive(false);
    }
    public void 붕대감기설명등장()
    {
        설명isOn = true;
        붕대감기.SetActive(true);


    }
    public void 붕대감기설명가림()
    {
        설명isOn = false;
        붕대감기.SetActive(false);
    }
    public void 언변술설득설명등장()
    {
        설명isOn = true;
        언변술설득.SetActive(true);


    }
    public void 언변술설득설명가림()
    {
        설명isOn = false;
        언변술설득.SetActive(false);
    }
    public void 정신감정설명등장()
    {
        설명isOn = true;
        정신감정.SetActive(true);


    }
    public void 정신감정설명가림()
    {
        설명isOn = false;
        정신감정.SetActive(false);
    }
    public void 오컬트지식설명등장()
    {
        설명isOn = true;
        오컬트지식.SetActive(true);


    }
    public void 오컬트지식설명가림()
    {
        설명isOn = false;
        오컬트지식.SetActive(false);
    }
    public void 심리판단설명등장()
    {
        설명isOn = true;
        심리판단.SetActive(true);


    }
    public void 심리판단설명가림()
    {
        설명isOn = false;
        심리판단.SetActive(false);
    }
    public void 정보조사설명등장()
    {
        설명isOn = true;
        정보조사.SetActive(true);


    }
    public void 정보조사설명가림()
    {
        설명isOn = false;
        정보조사.SetActive(false);
    }
    public void 의학지식설명등장()
    {
        설명isOn = true;
        의학지식.SetActive(true);


    }
    public void 의학지식설명가림()
    {
        설명isOn = false;
        의학지식.SetActive(false);
    }







    public void 잠수설명등장()
    {
        설명isOn = true;
        잠수.SetActive(true);


    }
    public void 잠수설명가림()
    {
        설명isOn = false;
        잠수.SetActive(false);
    }
    public void 던지기설명등장()
    {
        설명isOn = true;
        던지기.SetActive(true);


    }
    public void 던지기설명가림()
    {
        설명isOn = false;
        던지기.SetActive(false);
    }
    public void 언변술협박설명등장()
    {
        설명isOn = true;
        언변술협박.SetActive(true);


    }
    public void 언변술협박설명가림()
    {
        설명isOn = false;
        언변술협박.SetActive(false);
    }
    public void 눈썰미설명등장()
    {
        설명isOn = true;
        눈썰미.SetActive(true);


    }
    public void 눈썰미설명가림()
    {
        설명isOn = false;
        눈썰미.SetActive(false);
    }
    public void 고문술설명등장()
    {
        설명isOn = true;
        고문술.SetActive(true);


    }
    public void 고문술설명가림()
    {
        설명isOn = false;
        고문술.SetActive(false);
    }
    public void 단검술설명등장()
    {
        설명isOn = true;
        단검술.SetActive(true);


    }
    public void 단검술설명가림()
    {
        설명isOn = false;
        단검술.SetActive(false);
    }
    public void 사격술설명등장()
    {
        설명isOn = true;
        사격술.SetActive(true);


    }
    public void 사격술설명가림()
    {
        설명isOn = false;
        사격술.SetActive(false);
    }
    public void 맨손격투설명등장()
    {
        설명isOn = true;
        맨손격투.SetActive(true);


    }
    public void 맨손격투설명가림()
    {
        설명isOn = false;
        맨손격투.SetActive(false);
    }






    // Start is called before the first frame update
    public void 힘설명등장()
    {
        설명isOn = true;
        힘설명.SetActive(true);


    }
    public void 힘설명가림()
    {
        설명isOn = false;
        힘설명.SetActive(false);
    }

    public void 지능설명가림()
    {
        설명isOn = false;
        지능설명.SetActive(false);
    }

    public void 지능설명등장()
    {
        설명isOn = true;
        지능설명.SetActive(true);


    }

    public void 민첩설명가림()
    {
        설명isOn = false;
        민첩설명.SetActive(false);
    }

    public void 민첩설명등장()
    {
        설명isOn = true;
        민첩설명.SetActive(true);


    }
    public void 행운설명가림()
    {
        설명isOn = false;
        행운설명.SetActive(false);
    }

    public void 행운설명등장()
    {
        설명isOn = true;
        행운설명.SetActive(true);
    }


    public void 활력설명가림()
    {
        설명isOn = false;
        활력설명.SetActive(false);
    }

    public void 활력설명등장()
    {
        설명isOn = true;
        활력설명.SetActive(true);
    }

    public void 의지력설명가림()
    {
        설명isOn = false;
        의지력설명.SetActive(false);
    }

    public void 의지력설명등장()
    {
        설명isOn = true;
        의지력설명.SetActive(true);
    }
    public void 마력설명가림()
    {
        설명isOn = false;
        마력설명.SetActive(false);
    }

    public void 마력설명등장()
    {
        설명isOn = true;
        마력설명.SetActive(true);
    }
    public void 체력설명가림()
    {
        설명isOn = false;
        체력설명.SetActive(false);
    }

    public void 체력설명등장()
    {
        설명isOn = true;
        체력설명.SetActive(true);
    }
    public void 정신력설명가림()
    {
        설명isOn = false;
        정신력설명.SetActive(false);
    }

    public void 정신력설명등장()
    {
        설명isOn = true;
        정신력설명.SetActive(true);
    }
    public void 스트레스내성설명가림()
    {
        설명isOn = false;
        스트레스내성설명.SetActive(false);
    }

    public void 스트레스내성설명등장()
    {
        설명isOn = true;
        스트레스내성설명.SetActive(true);
    }








    public setChar튜토리얼매니저 튜토리얼매니저;


    public void 능력치이후로()
    {
        능력치.SetActive(false);
        스킬.SetActive(true);
        튜토리얼매니저.스킬설정설정();
    }

    public void 스킬이전으로()
    {
        스킬.SetActive(false);
        능력치.SetActive(true);
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (설명isOn == false)
            최초설명.SetActive(true);
        else
            최초설명.SetActive(false);
    }
}
