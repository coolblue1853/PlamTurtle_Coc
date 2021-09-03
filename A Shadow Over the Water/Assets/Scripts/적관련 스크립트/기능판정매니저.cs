using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 기능판정매니저 : MonoBehaviour
{

    public SoundManager 배틀사운드매니저;
    public InterctionController_D1사무소 인터렉션컨트롤러;


    public GameObject 기능판청안내창;

    public GameObject 판정창;
    public Text 사용기능;
    public Text 결과;


    public void 신문기능판정()
    {


        기능판청안내창.SetActive(false);
        StartCoroutine(정보조사기능판정코루틴());

    }
    public void 신문기능판정창끄기()
    {
        기능판청안내창.SetActive(false);
        DataBaseManager.연출중움직임제한 = false;
        DataBaseManager.판정창여부 = false;
    }
    public IEnumerator 정보조사기능판정코루틴()
    {


        DataBaseManager.신문기능판정여부 = true;

        판정창.SetActive(true);


        사용기능.text = "정보조사" + DataBaseManager.정보조사 ;
        배틀사운드매니저.찰칵효과음함수();

        yield return new WaitForSeconds(2f);

        StartCoroutine(룰렛작동());

        yield return new WaitForSeconds(6f);
        배틀사운드매니저.찰칵효과음함수();





        if (출력기능값 <= DataBaseManager.정보조사)
        {
            결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.정보조사)
        {
            결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.정보조사 / 3f) && (double)DataBaseManager.정보조사 >= 3f)
        {
            결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            결과.text = "대실패";

        }
       
       
        yield return new WaitForSeconds(2f);

        판정창.SetActive(false);





        if (결과.text == "대성공")
        {

            인터렉션컨트롤러.신문정보조사대성공();
        }

        if (결과.text == "보통성공")
        {

            인터렉션컨트롤러.신문정보조사성공();

        }
        if (결과.text == "실패")
        {

            인터렉션컨트롤러.신문정보조사실패();

        }
        if (결과.text == "대실패")
        {

            인터렉션컨트롤러.신문정보조사대실패();

        }



    }








    


    public IEnumerator 룰렉동작시키기()
    {

        룰렛머신온오프.SetActive(true);
        yield return StartCoroutine(룰렛작동());
        룰렛머신온오프.SetActive(false);
    }















    // 기능관련 룰렛
    public rollet 룰렛머신;

   // public Text 십의자리;
    public Text 일의자리;

    //public GameObject 십의자리몸통;
    public GameObject 일의자리몸통;
    public GameObject 룰렛머신온오프;






    //int 랜덤십의자리;
    int 랜덤일의자리;


    int 랜덤십의몸통위치;

    public static float 출력기능값;







    public IEnumerator 룰렛끄기()
    {
        yield return new WaitForSeconds(2f);
        룰렛머신온오프.SetActive(false);
    }

    public IEnumerator 룰렛작동()
    {

        배틀사운드매니저.기계돌아가는효과음함수();
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
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1f, 십의자리몸통.transform.position.y - 0.5f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1f, 십의자리몸통.transform.position.y + 0.5f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 0.5f, 일의자리몸통.transform.position.y - 0.5f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
               //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 0.5f, 일의자리몸통.transform.position.y + 0.5f);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 0.5f, 일의자리몸통.transform.position.y + 0.5f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 0.5f, 일의자리몸통.transform.position.y - 0.5f);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y - 0.5f);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y + 0.5f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 5)
            {//
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y + 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y + 0.5f);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y - 0.5f);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y - 0.5f);
            }
            if (랜덤십의몸통위치 == 6)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y - 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y + 0.5f);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 0.5f, 십의자리몸통.transform.position.y + 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 0.5f, 십의자리몸통.transform.position.y - 0.5f);
            }
            if (랜덤십의몸통위치 == 8)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 0.5f, 십의자리몸통.transform.position.y - 0.5f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y);
             //   십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 0.5f, 십의자리몸통.transform.position.y + 0.5f);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1f, 십의자리몸통.transform.position.y - 0.5f);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1f, 십의자리몸통.transform.position.y + 0.5f);
            }








           // 십의자리.text = 랜덤십의자리.ToString();
            일의자리.text = 랜덤일의자리.ToString();






            yield return new WaitForSeconds(0.025f);

        }
        for (int i = 0; i < 40; i++)
        {
            //랜덤십의자리 = Random.Range(0, 10);
            랜덤일의자리 = Random.Range(0, 10);
            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2f, 십의자리몸통.transform.position.y - 1f);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2f, 십의자리몸통.transform.position.y + 1f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1f, 일의자리몸통.transform.position.y - 1f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1f);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y - 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 2);
            }
            if (랜덤십의몸통위치 == 5)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 6)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 8)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y + 1);
            }



            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);

        }





        배틀사운드매니저.찰칵효과음함수();
        출력기능값 = (랜덤일의자리);
        if (출력기능값 == 0)
        {
            출력기능값 = 10;
        }

        //연출흔들기
        for (int i = 0; i < 10; i++)
        {

            float 큰흔들기값= 4f;
            float 작은흔들기값=2f;

            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
               //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
              //  십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값   );
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
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
               // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }






            yield return new WaitForSeconds(0.025f);

        }

        yield return new WaitForSeconds(2f);
    }





}
