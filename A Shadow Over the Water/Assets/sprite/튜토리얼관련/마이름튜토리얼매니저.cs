using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 마이름튜토리얼매니저 : MonoBehaviour
{
    public GameObject 마이룸_1;
    public GameObject 마이룸_2;
    public GameObject 마이룸_3;
    public GameObject 마이룸_4;
    public GameObject 마이룸_5;
    public GameObject 마이룸_6;

    public GameObject 대화창;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (대화창.activeSelf == true)
        {
            StartCoroutine(일번코루틴());
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            마이룸_1.SetActive(false);
            마이룸_5.SetActive(false);
            if(육번코루틴여부 == false && 오번코루틴여부 == true)
            {
                StartCoroutine(육번코루틴());
            }
        }
        
    }
    bool 일번코루틴여부 = false;
    IEnumerator 일번코루틴()
    {
        if(일번코루틴여부 == false)
        {
            일번코루틴여부 = true;
            yield return new WaitForSecondsRealtime(1f);
            마이룸_1.SetActive(true);
        }

    }
    bool 생성_6여부 = false;


    public void 이번버튼()
    {
        StartCoroutine(이번코루틴());
    }

    bool 이번코루틴여부 = false;
    IEnumerator 이번코루틴()
    {
        if (이번코루틴여부 == false)
        {
            Time.timeScale = 0;
            이번코루틴여부 = true;
            yield return new WaitForSecondsRealtime(2f);
            마이룸_2.SetActive(true);
        }

    }
    IEnumerator 삼번코루틴()
    {


            yield return new WaitForSecondsRealtime(1f);
            마이룸_3.SetActive(true);


    }
    IEnumerator 사번코루틴()
    {

        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1f);
        마이룸_4.SetActive(true);


    }


    public void 오번버튼()
    {
        StartCoroutine(오번코루틴());
    }


    bool 오번코루틴여부 = false;
    IEnumerator 오번코루틴()
    {
        if (오번코루틴여부 == false)
        {
            Time.timeScale = 0;
            오번코루틴여부 = true;
            yield return new WaitForSecondsRealtime(0.0011f);
            마이룸_5.SetActive(true); 
        }

    }
    bool 육번코루틴여부 = false;
    IEnumerator 육번코루틴()
    {
        if (육번코루틴여부 == false)
        {
            육번코루틴여부 = true;
            yield return new WaitForSecondsRealtime(0.0011f);
            마이룸_6.SetActive(true);
        }



    }






        public void 마지막코루틴설정()
    {
        if (생성_6여부 == false)
        {
            생성_6여부 = true;

        }

    }
    IEnumerator 마지막코루틴()
    {

        yield return new WaitForSecondsRealtime(2f);
        마이룸_6.SetActive(true);
    }




    public void 마이룸_2튜토리얼창끄기()
    {
        마이룸_2.SetActive(false);
        StartCoroutine(삼번코루틴());
    }

    public void 마이룸_3튜토리얼창끄기()
    {
        마이룸_3.SetActive(false);
        StartCoroutine(사번코루틴());
    }

    public void 마이룸_4튜토리얼창끄기()
    {
        마이룸_4.SetActive(false);
        Time.timeScale = 1;
    }

    public void 마이룸_5튜토리얼창끄기()
    {
        마이룸_5.SetActive(false);
        StartCoroutine(육번코루틴());
    }
    public void 마이룸_6튜토리얼창끄기()
    {
        마이룸_6.SetActive(false);
        Time.timeScale = 1;
    }
}
