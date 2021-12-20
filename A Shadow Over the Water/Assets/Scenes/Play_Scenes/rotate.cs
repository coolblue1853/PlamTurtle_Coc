using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class rotate : MonoBehaviour
{

    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;
    public Image 페이드이미지2;
    IEnumerator 페이드아웃코루틴()
    {
        float 페이드카운트 = 1;
        yield return new WaitForSecondsRealtime(2f);
        페이드이미지오브젝트.SetActive(true);

        while (페이드카운트 > 0)
        {
            페이드카운트 -= 0.01f;
            yield return new WaitForSecondsRealtime(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);
        }
    }

    bool 체커 = false;
    IEnumerator 시간끝이동()
    {
        if(체커 == false)
        {
            체커 = true;

            yield return new WaitForSecondsRealtime(3f);
            아침글자.SetActive(false);
            점심글자.SetActive(true);
            yield return new WaitForSecondsRealtime(4f);
            StartCoroutine(장면전환());

        }
        else
        {

        }
    }


    IEnumerator 장면전환()
    {



        float 페이드카운트 = 0;
        while (페이드카운트 < 1.0f)
        {
            페이드카운트 += 0.01f;
            yield return new WaitForSecondsRealtime(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }
        if (DataBaseManager.이동지 == "빈민가")
        {
            SceneManager.LoadScene("1st_Mor_Slum");
        }
        else if (DataBaseManager.이동지 == "대학")
        {
            SceneManager.LoadScene("1st_Mor_Uni");
        }
        else if (DataBaseManager.이동지 == "총포상")
        {
            SceneManager.LoadScene("1st_Mor_GUNSHOP");
        }

        else if (DataBaseManager.이동지 == "경찰서")
        {
            SceneManager.LoadScene("1st_Mor_Police");
        }

        else if (DataBaseManager.이동지 == "강가")
        {
            SceneManager.LoadScene("1st_Mor_river");
        }

        else if (DataBaseManager.이동지 == "의뢰자의집")
        {
            SceneManager.LoadScene("1st_Mor_questHouse");
        }

        else if (DataBaseManager.이동지 == "신문사")
        {
            SceneManager.LoadScene("1st_Mor_NewsPaper");
        }

        else if (DataBaseManager.이동지 == "술집")
        {
            SceneManager.LoadScene("1st_Mor_Bar");
        }
        else if (DataBaseManager.이동지 == "병원")
        {
            SceneManager.LoadScene("1st_Mor_Hospital");
        }

    }









    public GameObject 아침글자;
    public GameObject 점심글자;



    float timer;
    int waitingTime;
    int updownder;
    int 넘 =  0;
    public Animator UD;
    public Animator Ten;
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject ring4;
    bool 촉수체커 = false;
    public bool isRing1End= false;
    public bool isRing2End = false;
    public bool isRing3End = false;
    public bool isRing4End = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(페이드아웃코루틴());
        timer = 0.0f;
        waitingTime = 7;
        넘 = 0;
        촉수체커 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {if(collision.tag == "ring1")
        {
            isRing1End = true;
        }

        if (collision.tag == "ring2")
        {
            isRing2End = true;
        }
        if (collision.tag == "ring3" )
        {

            updownder = 2;
            isRing3End = true;

            if(촉수체커 == true)
            {
                넘 = 3;
                Ten.SetInteger("Ten", 넘);
            }
        }
        if (collision.tag == "ring4")
        {
            isRing4End = true;
        }

    }


    public float turnSpeed1 = 30;
    public float turnSpeed2 = 40;
    public float turnSpeed3 = 20;
    public float turnSpeed4 = 30;

    public Text 날짜텍스트;

    bool isover = false;
    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > waitingTime && isover == false)
        {

            isover = true;
            updownder = 1;
            isRing1End = false;
            isRing2End = false;
            isRing3End = false;
            isRing4End = false;
            촉수체커 = true;


        }


        if (updownder == 0)
        {

            UD.SetInteger("upDowner", 0);
        }

        else if (updownder == 1)
        {

            UD.SetInteger("upDowner", 1);
        }

        else if (updownder == 2)
        {


            UD.SetInteger("upDowner", 2);
        }

        if(isRing1End == false)
        {
            ring1.transform.Rotate(Vector3.forward, turnSpeed1 * Time.deltaTime);
        }
        if (isRing2End == false)
        {

            StartCoroutine(시간끝이동());
            ring2.transform.Rotate(Vector3.forward, turnSpeed2 * Time.deltaTime);
        }
        if (isRing3End == false)
        {
            ring3.transform.Rotate(Vector3.forward, turnSpeed3 * Time.deltaTime);
        }
        if (isRing4End == false)
        {
            ring4.transform.Rotate(Vector3.forward, turnSpeed4 * Time.deltaTime);
        }
    }
}
