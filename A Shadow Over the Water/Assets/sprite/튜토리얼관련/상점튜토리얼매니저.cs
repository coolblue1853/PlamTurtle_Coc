using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 상점튜토리얼매니저 : MonoBehaviour
{
    public GameObject 마이룸_1;
    public GameObject 마이룸_2;
    public GameObject 마이룸_3;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(일번코루틴());
    }

    // Update is called once per frame
    void Update()
    {
        if(상점창.activeSelf == true)
        {
            StartCoroutine(이번코루틴());
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

    public GameObject 상점창;


    public void 이번버튼()
    {
        StartCoroutine(이번코루틴());
    }

    bool 이번코루틴여부 = false;
    IEnumerator 이번코루틴()
    {
        if (이번코루틴여부 == false)
        {

            이번코루틴여부 = true;
            yield return new WaitForSecondsRealtime(1f);
            마이룸_2.SetActive(true);
        }

    }
    bool 삼번코루틴여부 = false;
    IEnumerator 삼번코루틴()
    {
        if (삼번코루틴여부 == false)
        {

            삼번코루틴여부 = true;
            yield return new WaitForSecondsRealtime(2f);
            마이룸_3.SetActive(true);
        }

    }



    public void 삼번버튼()
    {
        StartCoroutine(삼번코루틴());
    }


    public void 마이룸_1튜토리얼창끄기()
    {
        마이룸_1.SetActive(false);

    }


    public void 마이룸_2튜토리얼창끄기()
    {
        마이룸_2.SetActive(false);

    }

    public void 마이룸_3튜토리얼창끄기()
    {
        마이룸_3.SetActive(false);

    }


}
