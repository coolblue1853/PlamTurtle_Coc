using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setChar튜토리얼매니저 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject 스탯생성_1;
    public GameObject 스탯생성_2;
    public GameObject 스탯생성_3;
    public GameObject 스탯생성_4;
    public GameObject 스탯생성_5;
    public GameObject 스탯생성_6;
    void Start()
    {
        StartCoroutine(스탯생성코루틴());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator 스탯생성코루틴()
    {
        yield return new WaitForSecondsRealtime(1f);
        스탯생성_1.SetActive(true);
    }

    bool 생성_2여부 = false;

    public void 재생성_스킬설정()
    {
        if(생성_2여부 == false)
        {
            생성_2여부 = true;
            StartCoroutine(재생성_스킬설정코루틴());
        }

    }
     IEnumerator 재생성_스킬설정코루틴()
    {
        스탯생성_1.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        스탯생성_2.SetActive(true);
    }
    bool 생성_3여부 = false;

    public void 스킬설정설정()
    {
        if (생성_3여부 == false)
        {
            생성_3여부 = true;
            StartCoroutine(스킬설정으로코루틴());
        }

    }
    IEnumerator 스킬설정으로코루틴()
    {
        스탯생성_2.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        스탯생성_3.SetActive(true);
    }

    IEnumerator 사번코루틴()
    {
        스탯생성_3.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        스탯생성_4.SetActive(true);
    }

    IEnumerator 오번코루틴()
    {
        스탯생성_4.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        스탯생성_5.SetActive(true);
    }

    bool 생성_6여부 = false;

    public void 마지막코루틴설정()
    {
        if (생성_6여부 == false && 생성_3여부 == true)
        {
            생성_6여부 = true;
            StartCoroutine(마지막코루틴());
        }

    }
    IEnumerator 마지막코루틴()
    {

        yield return new WaitForSecondsRealtime(2f);
        스탯생성_6.SetActive(true);
    }



    public void 스탯생성_1튜토리얼창끄기()
    {
        스탯생성_1.SetActive(false);
    }

    public void 스탯생성_2튜토리얼창끄기()
    {
        스탯생성_2.SetActive(false);
    }

    public void 스탯생성_3튜토리얼창끄기()
    {
        스탯생성_3.SetActive(false);
        StartCoroutine(사번코루틴());
    }

    public void 스탯생성_4튜토리얼창끄기()
    {
        스탯생성_4.SetActive(false);
        StartCoroutine(오번코루틴());
    }

    public void 스탯생성_5튜토리얼창끄기()
    {
        스탯생성_5.SetActive(false);
    }
    public void 스탯생성_6튜토리얼창끄기()
    {
        스탯생성_6.SetActive(false);
    }
}
