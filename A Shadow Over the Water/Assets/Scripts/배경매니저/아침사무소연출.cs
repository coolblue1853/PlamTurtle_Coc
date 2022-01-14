using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 아침사무소연출 : MonoBehaviour
{    //연출시 못움직이게하는
    //public 마이름튜토리얼매니저 튜토리얼매니저;
    public GameObject 대화창;
    public Mins 주인공;
    public GameObject 주인공캐릭터오브젝트;
    public SpriteRenderer 주인공캐릭터스프라이트랜더러;
    public Color 투명;
    public Color 원래컬러;
    public GameObject 텍스트박스;

    public SoundManager 사운드매니저;

    public bool 첫번째의뢰인들어오는연출 = true;

    public GameObject 주인공의자신문유;
    public GameObject 주인공의자신문무;
    public GameObject 신문콜라이더없음;
    public GameObject 신문콜라이더있음;
    public GameObject 의뢰인서있음;
    public GameObject 의뢰인앉음;

    public InterctionController_D1사무소 인터렉션컨트롤러;

    public void 노크소리온()
    {
        사운드매니저.노크효과음효과음함수();
    }
    public void 의뢰인들어옴()
    {
        if (첫번째의뢰인들어오는연출 == false)
        {

            첫번째의뢰인들어오는연출 = true;
            주인공의자신문유.SetActive(false);
            주인공의자신문무.SetActive(true);

            신문콜라이더없음.SetActive(true);
            StartCoroutine(n초뒤페이드아웃(1.5f));
        }

    }


    IEnumerator n초뒤페이드아웃(float n)
    {
        yield return new WaitForSeconds(n);
        사운드매니저.문열고닫기함수();
        StartCoroutine(페이드아웃코루틴());
        StartCoroutine(n초뒤페이드인(4.5f));
    }
    IEnumerator n초뒤페이드인(float n)
    {
        yield return new WaitForSeconds(n);
        의뢰인서있음.SetActive(true);
        StartCoroutine(페이드인코루틴());
        StartCoroutine(n초뒤두번째대화실행(2));
    }
    IEnumerator n초뒤두번째대화실행(float n)
    {
        yield return new WaitForSeconds(n);
        인터렉션컨트롤러.의뢰자등장후대화();
    }


    public bool 의뢰인앉는연출 = true;
    public void 의뢰인자리에앉음()
    {
        if (의뢰인앉는연출 == false)
        {

            의뢰인앉는연출 = true;
            의뢰인서있음.SetActive(false);
            의뢰인앉음.SetActive(true);

            StartCoroutine(의뢰자앉고n초뒤대화실행(2));
        }

    }
    IEnumerator 의뢰자앉고n초뒤대화실행(float n)
    {
        yield return new WaitForSeconds(n);
        인터렉션컨트롤러.의뢰자앉은후대화();
    }

    public bool 의뢰인나감연출 = true;
    public void 의뢰인나감()
    {
        if (의뢰인나감연출 == false)
        {

            의뢰인나감연출 = true;


            StartCoroutine(n초뒤페이드아웃투(2));
        }

    }


    IEnumerator n초뒤페이드아웃투(float n)
    {
        yield return new WaitForSeconds(n);

        사운드매니저.문열고닫기함수();
        StartCoroutine(페이드아웃코루틴());
        StartCoroutine(n초뒤페이드인투(4));
    }
    IEnumerator n초뒤페이드인투(float n)
    {

        yield return new WaitForSeconds(n);
        의뢰인앉음.SetActive(false);

        StartCoroutine(페이드인코루틴());
        StartCoroutine(n초뒤세번째대화실행(2));
        DataBaseManager.연출중움직임제한 = false;

    }
    bool 연출마무리 = false;
    public void 연출끝()
    {
        주인공의자신문무.SetActive(false);
        주인공캐릭터스프라이트랜더러.color = 원래컬러;

        신문콜라이더없음.SetActive(false);
        신문콜라이더있음.SetActive(true);

        DataBaseManager.연출중움직임제한 = false;
        연출마무리 = true;
        DataBaseManager.연출진행중 = false;
    }




    IEnumerator n초뒤세번째대화실행(float n)
    {
        yield return new WaitForSeconds(n);
        인터렉션컨트롤러.의뢰자나간후대화();
    }



    // Start is called before the first frame update
    void Start()
    {
        if(DataBaseManager.시간대 == 1)
        {
            DataBaseManager.연출진행중 = true;
            투명.a = 0;
            원래컬러 = 주인공캐릭터스프라이트랜더러.color;
            주인공캐릭터스프라이트랜더러.color = 투명;
            DataBaseManager.연출중움직임제한 = true;
        }

        else
        {
            주인공의자신문유.SetActive(false);
        }

    }
    void Update()
    {
        if (텍스트박스.activeSelf == false)
        {
            의뢰인들어옴();
            의뢰인자리에앉음();
            의뢰인나감();
        }

        if(연출마무리 == true && 대화창.activeSelf == false)
        {
            //튜토리얼매니저.이번버튼();
        }


    }
    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;

    IEnumerator 페이드인코루틴()
    {
        float 페이드카운트 = 1;
        페이드이미지오브젝트.SetActive(true);

        while (페이드카운트 > 0)
        {
            페이드카운트 -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);
        }
        페이드이미지오브젝트.SetActive(false);


    }
    IEnumerator 페이드아웃코루틴()
    {
        페이드이미지.color = new Color(0, 0, 0, 0);
        float 페이드카운트 = 0;
        페이드이미지오브젝트.SetActive(true);

        while (페이드카운트 < 1)
        {
            페이드카운트 += 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);
        }


    }
    // Update is called once per frame

}
