using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 인물정보창manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Debug.Log(노아정보획득량);
            DataBaseManager.노아정보1 = true;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            DataBaseManager.노아정보2 = true;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            DataBaseManager.노아정보3 = true;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            DataBaseManager.노아정보4 = true;
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            DataBaseManager.노아정보5 = true;
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            DataBaseManager.노아정보6 = true;
        }
    }
    public GameObject 정보프리팹;

    bool 노아정보1획득 = false;
    bool 노아정보2획득 = false;
    bool 노아정보3획득 = false;
    bool 노아정보4획득 = false;
    bool 노아정보5획득 = false;
    bool 노아정보6획득 = false;


    //정보컨텐츠


    public GameObject 노아정보컨텐츠;

    int 노아정보획득량;
    int 노아현재페이지=1;
    string 선택정보이름;

    public void 노아정보창켜기()
    {

        선택정보이름 = "노아";


        노아정보컨텐츠.SetActive(true);

        if (DataBaseManager.노아정보1 == true && 노아정보1획득 == false)
        {
            노아정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보1>";
            clone.transform.SetParent(노아정보컨텐츠.transform);


        }


        if (DataBaseManager.노아정보2 == true && 노아정보2획득 == false)
        {
            노아정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보2>";
            clone.transform.SetParent(노아정보컨텐츠.transform);

        }

        if (DataBaseManager.노아정보3 == true && 노아정보3획득 == false)
        {
            노아정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보3>";
            clone.transform.SetParent(노아정보컨텐츠.transform);

        }



        if (DataBaseManager.노아정보4 == true && 노아정보4획득 == false)
        {
            노아정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보4>";
            clone.transform.SetParent(노아정보컨텐츠.transform);



        }
        if (DataBaseManager.노아정보5 == true && 노아정보5획득 == false)
        {
            노아정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보5>";
            clone.transform.SetParent(노아정보컨텐츠.transform);



        }
        if (DataBaseManager.노아정보6 == true && 노아정보6획득 == false)
        {
            노아정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보6>";
            clone.transform.SetParent(노아정보컨텐츠.transform);



        }
        노아정보획득량 = 노아정보컨텐츠.transform.childCount;

        if (노아정보획득량 > 2)
        {
            노아페이지넘기기버튼.SetActive(true);
        }



    }


    public GameObject 노아페이지넘기기버튼;

    public void 페이지넘기기()
    {
        if (선택정보이름=="노아") 
        {

            페이지넘기기함수(노아정보획득량, 노아현재페이지, 노아정보컨텐츠);
        }

    }
    public void 페이지되돌리기()
    {
        if (선택정보이름 == "노아")
        {

            페이지되돌리기함수(노아정보획득량, 노아현재페이지, 노아정보컨텐츠);
        }

    }

    public void 페이지넘기기함수(int 대상정보획득량,int 대상페이지 ,GameObject 정보컨텐츠 )
    {


        if (대상정보획득량 <= 4)
        {
            노아페이지넘기기버튼.SetActive(false);
        }




        if (대상페이지 == 1)
        {

            되돌리기버튼.SetActive(true);
            Transform trChild0 = 정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(false);


            Transform trChild1 = 정보컨텐츠.transform.GetChild(1);
            trChild1.gameObject.SetActive(false);





            Transform trChild2 = 정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (대상정보획득량 >= 4)
            {
                Transform trChild3 = 정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }



            if(선택정보이름 == "노아")
            {
                노아현재페이지 = 2;
            }


        }


        else if (대상페이지 == 2)
        {

            Transform trChild2 = 정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(false);


            Transform trChild3 = 정보컨텐츠.transform.GetChild(3);
            trChild3.gameObject.SetActive(false);





            Transform trChild4 = 정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (대상정보획득량 >= 6)
            {
                Transform trChild5 = 정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }



            if (대상정보획득량 <= 6)
            {
                노아페이지넘기기버튼.SetActive(false);
            }

            if (선택정보이름 == "노아")
            {
                노아현재페이지 = 3;
            }



        }
    }

    public GameObject 되돌리기버튼;

    public void 페이지되돌리기함수(int 대상정보획득량, int 대상페이지, GameObject 정보컨텐츠)
    {





        if (대상페이지 == 2)
        {
            되돌리기버튼.SetActive(false);
            노아페이지넘기기버튼.SetActive(true);


            Transform trChild0 = 정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            Transform trChild1 = 정보컨텐츠.transform.GetChild(1);
            trChild1.gameObject.SetActive(true);






            if (선택정보이름 == "노아")
            {
                노아현재페이지 = 1;
            }


        }


        else if (대상페이지 == 3)
        {
            노아페이지넘기기버튼.SetActive(true);
            Transform trChild2 = 정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);


            Transform trChild3 = 정보컨텐츠.transform.GetChild(3);
            trChild3.gameObject.SetActive(true);






            if (선택정보이름 == "노아")
            {
                노아현재페이지 = 2;
            }



        }
    }
}
