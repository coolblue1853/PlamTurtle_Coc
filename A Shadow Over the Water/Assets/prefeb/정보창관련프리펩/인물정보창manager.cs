using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 인물정보창manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DataBaseManager.노아정보1 = true;
            DataBaseManager.멜리사정보1 = true;
            DataBaseManager.에이든정보1 = true;
            DataBaseManager.엘라정보1 = true;
            DataBaseManager.동료기자정보1 = true;
            DataBaseManager.노교수정보1 = true;
            DataBaseManager.경찰친구정보1 = true;
            DataBaseManager.술집친구정보1 = true;
            DataBaseManager.하수정비사무소소장정보1 = true;
 
        }
        ㅁ낭라();
        if(아래버튼누름 == false)
        {
            세부정보버튼관리();
        }



    }

    public GameObject 위버튼;
    public GameObject 아래버튼;

    public GameObject 노아버튼;
    public GameObject 멜리사버튼;
    public GameObject 엘라버튼;
    public GameObject 에이든버튼;

    public GameObject 노교수버튼;
    public GameObject 술집친구버튼;
    public GameObject 경찰친구버튼;
    public GameObject 하수정비사무소소장버튼;
    public GameObject 동료기자버튼;


    bool 노아버튼상승 = false;
    bool 멜리사버튼상승 = false;
    bool 엘라버튼상승 = false;
    bool 에이든버튼상승 = false;
    bool 노교수버튼상승 = false;
    bool 경찰친구버튼상승 = false;
    bool 술집친구버튼상승 = false;
    bool 탐정사무소소장버튼상승 = false;
    bool 동료기자버튼상승 = false;


    void ㅁ낭라()
    {
        if((DataBaseManager.노아정보1 == true || DataBaseManager.노아정보2 == true || DataBaseManager.노아정보3 == true || DataBaseManager.노아정보4 == true || DataBaseManager.노아정보5 == true || DataBaseManager.노아정보6 == true) && 노아버튼상승 == false)
        {
            노아버튼상승 = true;
            DataBaseManager.노아버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.멜리사정보1 == true || DataBaseManager.멜리사정보2 == true || DataBaseManager.멜리사정보3 == true || DataBaseManager.멜리사정보4 == true || DataBaseManager.멜리사정보5 == true || DataBaseManager.멜리사정보6== true) && 멜리사버튼상승 == false)
        {
            멜리사버튼상승 = true;
            DataBaseManager.멜리사버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.엘라정보1 == true || DataBaseManager.엘라정보2 == true || DataBaseManager.엘라정보3 == true || DataBaseManager.엘라정보4 == true || DataBaseManager.엘라정보5 == true || DataBaseManager.엘라정보6 == true) && 엘라버튼상승 == false)
        {
            엘라버튼상승 = true;
            DataBaseManager.엘라버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.에이든정보1 == true || DataBaseManager.에이든정보2 == true || DataBaseManager.에이든정보3 == true || DataBaseManager.에이든정보4 == true || DataBaseManager.에이든정보5 == true || DataBaseManager.에이든정보6 == true) && 에이든버튼상승 == false)
        {
            에이든버튼상승 = true;
            DataBaseManager.에이든버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }


        if ((DataBaseManager.노교수정보1 == true || DataBaseManager.노교수정보2 == true || DataBaseManager.노교수정보3 == true || DataBaseManager.노교수정보4 == true || DataBaseManager.노교수정보5 == true || DataBaseManager.노교수정보6 == true) && 노교수버튼상승 == false)
        {
            노교수버튼상승 = true;
            DataBaseManager.노교수버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.경찰친구정보1 == true || DataBaseManager.경찰친구정보2 == true || DataBaseManager.경찰친구정보3 == true || DataBaseManager.경찰친구정보4 == true || DataBaseManager.경찰친구정보5 == true || DataBaseManager.경찰친구정보6 == true) && 경찰친구버튼상승 == false)
        {
            경찰친구버튼상승 = true;
            DataBaseManager.경찰친구버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.술집친구정보1 == true || DataBaseManager.술집친구정보2 == true || DataBaseManager.술집친구정보3 == true || DataBaseManager.술집친구정보4 == true || DataBaseManager.술집친구정보5 == true || DataBaseManager.술집친구정보6 == true) && 술집친구버튼상승 == false)
        {
            술집친구버튼상승 = true;
            DataBaseManager.술집친구버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.동료기자정보1 == true || DataBaseManager.동료기자정보2 == true || DataBaseManager.동료기자정보3 == true || DataBaseManager.동료기자정보4 == true || DataBaseManager.동료기자정보5 == true || DataBaseManager.동료기자정보6 == true) && 동료기자버튼상승 == false)
        {
            동료기자버튼상승 = true;
            DataBaseManager.동료기자버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }
        if ((DataBaseManager.하수정비사무소소장정보1 == true || DataBaseManager.하수정비사무소소장정보2 == true || DataBaseManager.하수정비사무소소장정보3 == true || DataBaseManager.하수정비사무소소장정보4 == true || DataBaseManager.하수정비사무소소장정보5 == true || DataBaseManager.하수정비사무소소장정보5 == true) && 탐정사무소소장버튼상승 == false)
        {
            탐정사무소소장버튼상승 = true;
            DataBaseManager.하수정비사무소소장버튼순서 = DataBaseManager.현재획득한인물정보가지수;
            DataBaseManager.현재획득한인물정보가지수 += 1;
        }




    }



    void 세부정보버튼관리()
    {
        
        if(DataBaseManager.노아버튼순서 != -1)
        {
            노아버튼.SetActive(true);
            노아버튼.transform.SetSiblingIndex(DataBaseManager.노아버튼순서);
        }
        if (DataBaseManager.멜리사버튼순서 != -1)
        {
            멜리사버튼.SetActive(true);
            멜리사버튼.transform.SetSiblingIndex(DataBaseManager.멜리사버튼순서);
        }
        if (DataBaseManager.에이든버튼순서 != -1)
        {
            에이든버튼.SetActive(true);
            에이든버튼.transform.SetSiblingIndex(DataBaseManager.에이든버튼순서);
        }
        if (DataBaseManager.엘라버튼순서 != -1)
        {
            엘라버튼.SetActive(true);
            엘라버튼.transform.SetSiblingIndex(DataBaseManager.엘라버튼순서);
        }


        if (DataBaseManager.노교수버튼순서 != -1)
        {
            노교수버튼.SetActive(true);
            노교수버튼.transform.SetSiblingIndex(DataBaseManager.노교수버튼순서);
        }
        if (DataBaseManager.술집친구버튼순서 != -1)
        {
            술집친구버튼.SetActive(true);
            술집친구버튼.transform.SetSiblingIndex(DataBaseManager.술집친구버튼순서);
        }
        if (DataBaseManager.경찰친구버튼순서 != -1)
        {
            경찰친구버튼.SetActive(true);
            경찰친구버튼.transform.SetSiblingIndex(DataBaseManager.경찰친구버튼순서);
        }
        if (DataBaseManager.하수정비사무소소장버튼순서 != -1)
        {
            하수정비사무소소장버튼.SetActive(true);
            하수정비사무소소장버튼.transform.SetSiblingIndex(DataBaseManager.하수정비사무소소장버튼순서);
        }
        if (DataBaseManager.동료기자버튼순서 != -1)
        {
            동료기자버튼.SetActive(true);
            동료기자버튼.transform.SetSiblingIndex(DataBaseManager.동료기자버튼순서);
        }
        if (DataBaseManager.현재획득한인물정보가지수 > 6)
        {
            아래버튼.SetActive(true);
        }
    }

    public GameObject 버튼랙트;
    bool 아래버튼누름 = false;
    public void 위버튼클릭()
    {
        아래버튼누름 = false;
        위버튼.SetActive(false);
        아래버튼.SetActive(true);
    }

    public void 아래버튼클릭()
    {
        위버튼.SetActive(true);
        아래버튼.SetActive(false);
        아래버튼누름 = true;
        for (int i = 0; i < 6; i++)
        {
            Transform trChild = 버튼랙트.transform.GetChild(i);
            trChild.gameObject.SetActive(false);
        }

        if (DataBaseManager.현재획득한인물정보가지수 == 7)
        {
            Transform trChild16 = 버튼랙트.transform.GetChild(6);
            trChild16.gameObject.SetActive(true);
            Transform trChild7 = 버튼랙트.transform.GetChild(7);
            trChild7.gameObject.SetActive(false);
            Transform trChild8 = 버튼랙트.transform.GetChild(8);
            trChild8.gameObject.SetActive(false);
        }

        else if (DataBaseManager.현재획득한인물정보가지수 == 8)
        {
            Transform trC1hild6 = 버튼랙트.transform.GetChild(6);
            trC1hild6.gameObject.SetActive(true);
            Transform trC2hild7 = 버튼랙트.transform.GetChild(7);
            trC2hild7.gameObject.SetActive(true);
            Transform trChild8 = 버튼랙트.transform.GetChild(8);
            trChild8.gameObject.SetActive(false);
        }
        else if (DataBaseManager.현재획득한인물정보가지수 == 9)
        {
            Transform trChild6 = 버튼랙트.transform.GetChild(6);
            trChild6.gameObject.SetActive(true);
            Transform trChild7 = 버튼랙트.transform.GetChild(7);
            trChild7.gameObject.SetActive(true);
            Transform trChild8 = 버튼랙트.transform.GetChild(8);
            trChild8.gameObject.SetActive(true);
        }


    }

    public GameObject 정보프리팹;

    bool 노아정보1획득 = false;
    bool 노아정보2획득 = false;
    bool 노아정보3획득 = false;
    bool 노아정보4획득 = false;
    bool 노아정보5획득 = false;
    bool 노아정보6획득 = false;

    bool 멜리사정보1획득 = false;
    bool 멜리사정보2획득 = false;
    bool 멜리사정보3획득 = false;
    bool 멜리사정보4획득 = false;
    bool 멜리사정보5획득 = false;
    bool 멜리사정보6획득 = false;


    bool 에이든정보1획득 = false;
    bool 에이든정보2획득 = false;
    bool 에이든정보3획득 = false;
    bool 에이든정보4획득 = false;
    bool 에이든정보5획득 = false;
    bool 에이든정보6획득 = false;

    bool 엘라정보1획득 = false;
    bool 엘라정보2획득 = false;
    bool 엘라정보3획득 = false;
    bool 엘라정보4획득 = false;
    bool 엘라정보5획득 = false;
    bool 엘라정보6획득 = false;

    bool 동료기자정보1획득 = false;
    bool 동료기자정보2획득 = false;
    bool 동료기자정보3획득 = false;
    bool 동료기자정보4획득 = false;
    bool 동료기자정보5획득 = false;
    bool 동료기자정보6획득 = false;

    bool 노교수정보1획득 = false;
    bool 노교수정보2획득 = false;
    bool 노교수정보3획득 = false;
    bool 노교수정보4획득 = false;
    bool 노교수정보5획득 = false;
    bool 노교수정보6획득 = false;

    bool 경찰친구정보1획득 = false;
    bool 경찰친구정보2획득 = false;
    bool 경찰친구정보3획득 = false;
    bool 경찰친구정보4획득 = false;
    bool 경찰친구정보5획득 = false;
    bool 경찰친구정보6획득 = false;

    bool 술집친구정보1획득 = false;
    bool 술집친구정보2획득 = false;
    bool 술집친구정보3획득 = false;
    bool 술집친구정보4획득 = false;
    bool 술집친구정보5획득 = false;
    bool 술집친구정보6획득 = false;

    bool 하수정비사무소소장정보1획득 = false;
    bool 하수정비사무소소장정보2획득 = false;
    bool 하수정비사무소소장정보3획득 = false;
    bool 하수정비사무소소장정보4획득 = false;
    bool 하수정비사무소소장정보5획득 = false;
    bool 하수정비사무소소장정보6획득 = false;
    //정보컨텐츠


    public GameObject 노아정보컨텐츠;
    public GameObject 멜리사정보컨텐츠;
    public GameObject 엘라정보컨텐츠;
    public GameObject 에이든정보컨텐츠;
    public GameObject 동료기자정보컨텐츠;
    public GameObject 경찰친구정보컨텐츠;
    public GameObject 술집친구정보컨텐츠;
    public GameObject 하수정비소장정보컨텐츠;
    public GameObject 노교수정보컨텐츠;




    public static int 정보획득량;

    string 선택정보이름;

    public Text 페이지텍스트;

    public void 노아정보창켜기()
    {

        선택정보이름 = "노아";



        if (DataBaseManager.노아정보1 == true && 노아정보1획득 == false)
        {
            노아정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보1>";
            clone.transform.SetParent(노아정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.노아정보2 == true && 노아정보2획득 == false)
        {
            노아정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보2>";
            clone.transform.SetParent(노아정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.노아정보3 == true && 노아정보3획득 == false)
        {
            노아정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보3>";
            clone.transform.SetParent(노아정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.노아정보4 == true && 노아정보4획득 == false)
        {
            노아정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보4>";
            clone.transform.SetParent(노아정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.노아정보5 == true && 노아정보5획득 == false)
        {
            노아정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보5>";
            clone.transform.SetParent(노아정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.노아정보6 == true && 노아정보6획득 == false)
        {
            노아정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노아 정보6>";
            clone.transform.SetParent(노아정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        정보획득량 = 노아정보컨텐츠.transform.childCount;
        초기화함수(노아정보컨텐츠);

        if ( DataBaseManager.노아현재페이지 ==3)
        {
            페이지텍스트.text = "< 3 >";
            Transform trChild4 = 노아정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 노아정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.노아현재페이지 == 2)
        {
            페이지텍스트.text = "< 2 >";
            Transform trChild2 = 노아정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 노아정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }

            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.노아현재페이지 == 1)
        {
            페이지텍스트.text = "< 1 >";
            Transform trChild0 = 노아정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 노아정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }
            되돌리기버튼.SetActive(false);
            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
        }




    }
    public void 멜리사정보창켜기()
    {

        선택정보이름 = "멜리사";



        if (DataBaseManager.멜리사정보1 == true && 멜리사정보1획득 == false)
        {
            멜리사정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<멜리사 정보1>";
            clone.transform.SetParent(멜리사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }

        if (DataBaseManager.멜리사정보2 == true && 멜리사정보2획득 == false)
        {
            멜리사정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<멜리사 정보2>";
            clone.transform.SetParent(멜리사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }

        if (DataBaseManager.멜리사정보3 == true && 멜리사정보3획득 == false)
        {
            멜리사정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<멜리사 정보3>";
            clone.transform.SetParent(멜리사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }

        if (DataBaseManager.멜리사정보4 == true && 멜리사정보4획득 == false)
        {
            멜리사정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<멜리사 정보4>";
            clone.transform.SetParent(멜리사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }

        if (DataBaseManager.멜리사정보5 == true && 멜리사정보5획득 == false)
        {
            멜리사정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<멜리사 정보5>";
            clone.transform.SetParent(멜리사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }

        if (DataBaseManager.멜리사정보6 == true && 멜리사정보6획득 == false)
        {
            멜리사정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<멜리사 정보6>";
            clone.transform.SetParent(멜리사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        초기화함수(멜리사정보컨텐츠);

        정보획득량 = 멜리사정보컨텐츠.transform.childCount;


        if (DataBaseManager.멜리사현재페이지 == 3)
        {
            Transform trChild4 = 멜리사정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 멜리사정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.멜리사현재페이지 == 2)
        {
            Transform trChild2 = 멜리사정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 멜리사정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.멜리사현재페이지 == 1)
        {
            Transform trChild0 = 멜리사정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 멜리사정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }
            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }

            되돌리기버튼.SetActive(false);
        }





    }

    public void 에이든정보창켜기()
    {

        선택정보이름 = "에이든";



        if (DataBaseManager.에이든정보1 == true && 에이든정보1획득 == false)
        {
            에이든정보1획득 = true;
            var clone = Instantiate(정보프리팹); 
            clone.GetComponent<Text>().text = "<size=20><에이든 트리스 - 1></size> \n의뢰자 <color =#0026A9>(엘라 트리스)</color>의 남편.\n그의 직업은 기자로 최근 악몽에 시달리기 시작하며 이상해지기 시작했다고 한다. \n밤마다 악몽에 깨어나는 듯 하며 원인은 불명이라고.";
            clone.transform.SetParent(에이든정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);  

        }


        if (DataBaseManager.에이든정보2 == true && 에이든정보2획득 == false)
        {
            에이든정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<에이든 정보2>";
            clone.transform.SetParent(에이든정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.에이든정보3 == true && 에이든정보3획득 == false)
        {
            에이든정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<에이든 정보3>";
            clone.transform.SetParent(에이든정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.에이든정보4 == true && 에이든정보4획득 == false)
        {
            에이든정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<에이든 정보4>";
            clone.transform.SetParent(에이든정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.에이든정보5 == true && 에이든정보5획득 == false)
        {
            에이든정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<에이든 정보5>";
            clone.transform.SetParent(에이든정보컨텐츠.transform);

            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.에이든정보6 == true && 에이든정보6획득 == false)
        {
            에이든정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<에이든 정보6>";
            clone.transform.SetParent(에이든정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 에이든정보컨텐츠.transform.childCount;
        초기화함수(에이든정보컨텐츠);

        if (DataBaseManager.에이든현재페이지 == 3)
        {
            Transform trChild4 = 에이든정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 에이든정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.에이든현재페이지 == 2)
        {
            Transform trChild2 = 에이든정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 에이든정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.에이든현재페이지 == 1)
        {
            Transform trChild0 = 에이든정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 에이든정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }
    public void 엘라정보창켜기()
    {

        선택정보이름 = "엘라";



        if (DataBaseManager.엘라정보1 == true &&  엘라정보1획득== false)
        {
            엘라정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<엘라 정보1>";
            clone.transform.SetParent(엘라정보컨텐츠.transform);

            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        if (DataBaseManager.엘라정보2 == true && 엘라정보2획득 == false)
        {
            엘라정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<엘라 정보2>";
            clone.transform.SetParent(엘라정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.엘라정보3 == true && 엘라정보3획득 == false)
        {
            엘라정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<엘라 정보3>";
            clone.transform.SetParent(엘라정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.엘라정보4 == true && 엘라정보4획득 == false)
        {
            엘라정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<엘라 정보4>";
            clone.transform.SetParent(엘라정보컨텐츠.transform);

            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.엘라정보5 == true && 엘라정보5획득 == false)
        {
            엘라정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<엘라 정보5>";
            clone.transform.SetParent(엘라정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.엘라정보6 == true && 엘라정보6획득 == false)
        {
            엘라정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<엘라 정보6>";
            clone.transform.SetParent(엘라정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 엘라정보컨텐츠.transform.childCount;
        초기화함수(엘라정보컨텐츠);

        if (DataBaseManager.엘라현재페이지 == 3)
        {
            Transform trChild4 = 엘라정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 엘라정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.엘라현재페이지 == 2)
        {
            Transform trChild2 = 엘라정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 엘라정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.엘라현재페이지 == 1)
        {
            Transform trChild0 = 엘라정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 엘라정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }

    public void 동료기자정보창켜기()
    {

        선택정보이름 = "동료기자";



        if (DataBaseManager.동료기자정보1 == true && 동료기자정보1획득 == false)
        {
            동료기자정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<스탠리 정보1>";
            clone.transform.SetParent(동료기자정보컨텐츠.transform);

            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        if (DataBaseManager.동료기자정보2 == true && 동료기자정보2획득 == false)
        {
            동료기자정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<스탠리 정보2>";
            clone.transform.SetParent(동료기자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.동료기자정보3 == true && 동료기자정보3획득 == false)
        {
            동료기자정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<스탠리 정보3>";
            clone.transform.SetParent(동료기자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.동료기자정보4 == true && 동료기자정보4획득 == false)
        {
            동료기자정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<스탠리 정보4>";
            clone.transform.SetParent(동료기자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.동료기자정보5 == true && 동료기자정보5획득 == false)
        {
            동료기자정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<스탠리 정보5>";
            clone.transform.SetParent(동료기자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.동료기자정보6 == true && 동료기자정보6획득 == false)
        {
            동료기자정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<스탠리 정보6>";
            clone.transform.SetParent(동료기자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 동료기자정보컨텐츠.transform.childCount;
        초기화함수(동료기자정보컨텐츠);

        if (DataBaseManager.동료기자현재페이지 == 3)
        {
            Transform trChild4 = 동료기자정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 동료기자정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.동료기자현재페이지 == 2)
        {
            Transform trChild2 = 동료기자정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 동료기자정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.동료기자현재페이지 == 1)
        {
            Transform trChild0 = 동료기자정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);

                
            if (정보획득량 >= 2)
            {
                Transform trChild1 = 동료기자정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }
    public void 노교수정보창켜기()
    {

        선택정보이름 = "노교수";



        if (DataBaseManager.노교수정보1 == true && 노교수정보1획득 == false)
        {
            노교수정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노교수 정보1>";
            clone.transform.SetParent(노교수정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }


        if (DataBaseManager.노교수정보2 == true && 노교수정보2획득 == false)
        {
            노교수정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노교수 정보2>";
            clone.transform.SetParent(노교수정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.노교수정보3 == true && 노교수정보3획득 == false)
        {
            노교수정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노교수 정보3>";
            clone.transform.SetParent(노교수정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.노교수정보4 == true && 노교수정보4획득 == false)
        {
            노교수정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노교수 정보4>";
            clone.transform.SetParent(노교수정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.노교수정보5 == true && 노교수정보5획득 == false)
        {
            노교수정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노교수 정보5>";
            clone.transform.SetParent(노교수정보컨텐츠.transform);

            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.노교수정보6 == true && 노교수정보6획득 == false)
        {
            노교수정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<노교수 정보6>";
            clone.transform.SetParent(노교수정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 노교수정보컨텐츠.transform.childCount;
        초기화함수(노교수정보컨텐츠);

        if (DataBaseManager.노교수현재페이지 == 3)
        {
            Transform trChild4 = 노교수정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 노교수정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.노교수현재페이지 == 2)
        {
            Transform trChild2 = 노교수정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 노교수정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.노교수현재페이지 == 1)
        {
            Transform trChild0 = 노교수정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 노교수정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }
    public void 경찰친구정보창켜기()
    {

        선택정보이름 = "경찰친구";



        if (DataBaseManager.경찰친구정보1 == true && 경찰친구정보1획득 == false)
        {
            경찰친구정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<알버트 정보1>";
            clone.transform.SetParent(경찰친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }


        if (DataBaseManager.경찰친구정보2 == true && 경찰친구정보2획득 == false)
        {
            경찰친구정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<알버트 정보2>";
            clone.transform.SetParent(경찰친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.경찰친구정보3 == true && 경찰친구정보3획득 == false)
        {
            경찰친구정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<알버트 정보3>";
            clone.transform.SetParent(경찰친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.경찰친구정보4 == true && 경찰친구정보4획득 == false)
        {
            경찰친구정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<알버트 정보4>";
            clone.transform.SetParent(경찰친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.경찰친구정보5 == true && 경찰친구정보5획득 == false)
        {
            경찰친구정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<알버트 정보5>";
            clone.transform.SetParent(경찰친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.경찰친구정보6 == true && 경찰친구정보6획득 == false)
        {
            경찰친구정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<알버트 정보6>";
            clone.transform.SetParent(경찰친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 경찰친구정보컨텐츠.transform.childCount;
        초기화함수(경찰친구정보컨텐츠);

        if (DataBaseManager.경찰친구현재페이지 == 3)
        {
            Transform trChild4 = 경찰친구정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 경찰친구정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.경찰친구현재페이지 == 2)
        {
            Transform trChild2 = 경찰친구정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 경찰친구정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.경찰친구현재페이지 == 1)
        {
            Transform trChild0 = 경찰친구정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 경찰친구정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }
    public void 술집친구정보창켜기()
    {

        선택정보이름 = "술집친구";



        if (DataBaseManager.술집친구정보1 == true && 술집친구정보1획득 == false)
        {
            술집친구정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집친구 정보1>";
            clone.transform.SetParent(술집친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }


        if (DataBaseManager.술집친구정보2 == true && 술집친구정보2획득 == false)
        {
            술집친구정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집친구 정보2>";
            clone.transform.SetParent(술집친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.술집친구정보3 == true && 술집친구정보3획득 == false)
        {
            술집친구정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집친구 정보3>";
            clone.transform.SetParent(술집친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.술집친구정보4 == true && 술집친구정보4획득 == false)
        {
            술집친구정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집친구 정보4>";
            clone.transform.SetParent(술집친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.술집친구정보5 == true && 술집친구정보5획득 == false)
        {
            술집친구정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집친구 정보5>";
            clone.transform.SetParent(술집친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.술집친구정보6 == true && 술집친구정보6획득 == false)
        {
            술집친구정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집친구 정보6>";
            clone.transform.SetParent(술집친구정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 술집친구정보컨텐츠.transform.childCount;
        초기화함수(술집친구정보컨텐츠);

        if (DataBaseManager.술집친구현재페이지 == 3)
        {
            Transform trChild4 = 술집친구정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 술집친구정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.술집친구현재페이지 == 2)
        {
            Transform trChild2 = 술집친구정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 술집친구정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.술집친구현재페이지 == 1)
        {
            Transform trChild0 = 술집친구정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 술집친구정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }
    public void 하수정비사무소소장정보창켜기()
    {

        선택정보이름 = "하수정비사무소소장";



        if (DataBaseManager.하수정비사무소소장정보1 == true && 하수정비사무소소장정보1획득 == false)
        {
            하수정비사무소소장정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소소장 정보1>";
            clone.transform.SetParent(하수정비소장정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }


        if (DataBaseManager.하수정비사무소소장정보2 == true && 하수정비사무소소장정보2획득 == false)
        {
            하수정비사무소소장정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소소장 정보2>";
            clone.transform.SetParent(하수정비소장정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.하수정비사무소소장정보3 == true && 하수정비사무소소장정보3획득 == false)
        {
            하수정비사무소소장정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소소장 정보3>";
            clone.transform.SetParent(하수정비소장정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        if (DataBaseManager.하수정비사무소소장정보4 == true && 하수정비사무소소장정보4획득 == false)
        {
            하수정비사무소소장정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소소장 정보4>";
            clone.transform.SetParent(하수정비소장정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.하수정비사무소소장정보5 == true && 하수정비사무소소장정보5획득 == false)
        {
            하수정비사무소소장정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소소장 정보5>";
            clone.transform.SetParent(하수정비소장정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.하수정비사무소소장정보6 == true && 하수정비사무소소장정보6획득 == false)
        {
            하수정비사무소소장정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소소장 정보6>";
            clone.transform.SetParent(하수정비소장정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 하수정비소장정보컨텐츠.transform.childCount;
        초기화함수(하수정비소장정보컨텐츠);

        if (DataBaseManager.하수정비사무소장현재페이지 == 3)
        {
            Transform trChild4 = 하수정비소장정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 하수정비소장정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.하수정비사무소장현재페이지 == 2)
        {
            Transform trChild2 = 하수정비소장정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 하수정비소장정보컨텐츠.transform.GetChild(3);
                trChild3.gameObject.SetActive(true);
            }
            if (정보획득량 > 4)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(true);
        }

        if (DataBaseManager.하수정비사무소장현재페이지 == 1)
        {
            Transform trChild0 = 하수정비소장정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 하수정비소장정보컨텐츠.transform.GetChild(1);
                trChild1.gameObject.SetActive(true);
            }

            if (정보획득량 > 2)
            {
                페이지넘기기버튼.SetActive(true);
            }
            else
            {
                페이지넘기기버튼.SetActive(false);
            }
            되돌리기버튼.SetActive(false);
        }




    }










    public GameObject 페이지넘기기버튼;

    public void 페이지넘기기()
    {
        if (선택정보이름=="노아") 
        {

            페이지넘기기함수(정보획득량, DataBaseManager.노아현재페이지, 노아정보컨텐츠);
        }

        if (선택정보이름 == "멜리사")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.멜리사현재페이지, 멜리사정보컨텐츠);
        }
        if (선택정보이름 == "에이든")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.에이든현재페이지, 에이든정보컨텐츠);
        }
        if (선택정보이름 == "엘라")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.엘라현재페이지, 엘라정보컨텐츠);
        }
        if (선택정보이름 == "동료기자")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.동료기자현재페이지, 동료기자정보컨텐츠);
        }
        if (선택정보이름 == "노교수")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.노교수현재페이지, 노교수정보컨텐츠);
        }
        if (선택정보이름 == "경찰친구")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.경찰친구현재페이지, 경찰친구정보컨텐츠);
        }
        if (선택정보이름 == "술집친구")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.술집친구현재페이지, 술집친구정보컨텐츠);
        }
        if (선택정보이름 == "하수정비사무소소장")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.하수정비사무소장현재페이지, 하수정비소장정보컨텐츠);
        }


    }
    public void 페이지되돌리기()
    {
        if (선택정보이름 == "노아")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.노아현재페이지, 노아정보컨텐츠);
        }
        if (선택정보이름 == "멜리사")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.멜리사현재페이지, 멜리사정보컨텐츠);
        }
        if (선택정보이름 == "에이든")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.에이든현재페이지, 에이든정보컨텐츠);
        }
        if (선택정보이름 == "엘라")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.엘라현재페이지, 엘라정보컨텐츠);
        }
        if (선택정보이름 == "동료기자")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.동료기자현재페이지, 동료기자정보컨텐츠);
        }
        if (선택정보이름 == "노교수")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.노교수현재페이지, 노교수정보컨텐츠);
        }
        if (선택정보이름 == "경찰친구")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.경찰친구현재페이지, 경찰친구정보컨텐츠);
        }
        if (선택정보이름 == "술집친구")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.술집친구현재페이지, 술집친구정보컨텐츠);
        }
        if (선택정보이름 == "하수정비사무소소장")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.하수정비사무소장현재페이지, 하수정비소장정보컨텐츠);
        }


    }



    public void 페이지넘기기함수(int 대상정보획득량,int 대상페이지 ,GameObject 정보컨텐츠 )
    {


        if (대상정보획득량 <= 4)
        {
            페이지넘기기버튼.SetActive(false);
        }




        if (대상페이지 == 1)
        {
            페이지텍스트.text = "< 2 >";
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
                DataBaseManager.노아현재페이지 = 2;
            }
            if (선택정보이름 == "멜리사")
            {
                DataBaseManager.멜리사현재페이지 = 2;
            }
            if (선택정보이름 == "에이든")
            {
                DataBaseManager.에이든현재페이지 = 2;
            }
            if (선택정보이름 == "엘라")
            {
                DataBaseManager.엘라현재페이지 = 2;
            }

            if (선택정보이름 == "동료기자")
            {
                DataBaseManager.동료기자현재페이지 = 2;
            }
            if (선택정보이름 == "노교수")
            {
                DataBaseManager.노교수현재페이지 = 2;
            }
            if (선택정보이름 == "경찰친구")
            {
                DataBaseManager.경찰친구현재페이지 = 2;
            }
            if (선택정보이름 == "술집친구")
            {
                DataBaseManager.술집친구현재페이지 = 2;
            }
            if (선택정보이름 == "하수정비사무소소장")
            {
                DataBaseManager.하수정비사무소장현재페이지 = 2;
            }






        }


        else if (대상페이지 == 2)
        {
            페이지텍스트.text = "< 3 >";

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
                페이지넘기기버튼.SetActive(false);
            }

            if (선택정보이름 == "노아")
            {
                DataBaseManager.노아현재페이지 = 3;
            }
            if (선택정보이름 == "멜리사")
            {
                DataBaseManager.멜리사현재페이지 = 3;
            }
            if (선택정보이름 == "에이든")
            {
                DataBaseManager.에이든현재페이지 = 3;
            }

            if (선택정보이름 == "엘라")
            {
                DataBaseManager.엘라현재페이지 = 3;
            }

            if (선택정보이름 == "동료기자")
            {
                DataBaseManager.동료기자현재페이지 = 3;
            }
            if (선택정보이름 == "노교수")
            {
                DataBaseManager.노교수현재페이지 = 3;
            }
            if (선택정보이름 == "경찰친구")
            {
                DataBaseManager.경찰친구현재페이지 = 3;
            }
            if (선택정보이름 == "술집친구")
            {
                DataBaseManager.술집친구현재페이지 = 3;
            }
            if (선택정보이름 == "하수정비사무소소장")
            {
                DataBaseManager.하수정비사무소장현재페이지 = 3;
            }
        }
    }

    public GameObject 되돌리기버튼;

    public void 페이지되돌리기함수(int 대상정보획득량, int 대상페이지, GameObject 정보컨텐츠)
    {

        소초기화함수(정보컨텐츠);



        if (대상페이지 == 2)
        {
            페이지텍스트.text = "< 1 >";
            되돌리기버튼.SetActive(false);
            페이지넘기기버튼.SetActive(true);


            Transform trChild0 = 정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            
            Transform trChild1 = 정보컨텐츠.transform.GetChild(1);
            trChild1.gameObject.SetActive(true);






            if (선택정보이름 == "노아")
            {
                DataBaseManager.노아현재페이지 = 1;
            }
            if (선택정보이름 == "멜리사")
            {
                DataBaseManager.멜리사현재페이지 = 1;
            }
            if (선택정보이름 == "에이든")
            {
                DataBaseManager.에이든현재페이지 = 1;
            }
            if (선택정보이름 == "엘라")
            {
                DataBaseManager.엘라현재페이지 = 1;
            }

            if (선택정보이름 == "동료기자")
            {
                DataBaseManager.동료기자현재페이지 = 1;
            }
            if (선택정보이름 == "노교수")
            {
                DataBaseManager.노교수현재페이지 = 1;
            }
            if (선택정보이름 == "경찰친구")
            {
                DataBaseManager.경찰친구현재페이지 = 1;
            }
            if (선택정보이름 == "술집친구")
            {
                DataBaseManager.술집친구현재페이지 = 1;
            }
            if (선택정보이름 == "하수정비사무소소장")
            {
                DataBaseManager.하수정비사무소장현재페이지 = 1;
            }
        }


        else if (대상페이지 == 3)
        {
            페이지텍스트.text = "< 2 >";
            페이지넘기기버튼.SetActive(true);
            Transform trChild2 = 정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);


            Transform trChild3 = 정보컨텐츠.transform.GetChild(3);
            trChild3.gameObject.SetActive(true);






            if (선택정보이름 == "노아")
            {
                DataBaseManager.노아현재페이지 = 2;
            }
            if (선택정보이름 == "멜리사")
            {
                DataBaseManager.멜리사현재페이지 = 2;
            }
            if (선택정보이름 == "에이든")
            {
                DataBaseManager.에이든현재페이지 = 2;
            }
            if (선택정보이름 == "엘라")
            {
                DataBaseManager.엘라현재페이지 = 2;
            }

            if (선택정보이름 == "동료기자")
            {
                DataBaseManager.동료기자현재페이지 = 2;
            }
            if (선택정보이름 == "노교수")
            {
                DataBaseManager.노교수현재페이지 = 2;
            }
            if (선택정보이름 == "경찰친구")
            {
                DataBaseManager.경찰친구현재페이지 = 2;
            }
            if (선택정보이름 == "술집친구")
            {
                DataBaseManager.술집친구현재페이지 = 2;
            }
            if (선택정보이름 == "하수정비사무소소장")
            {
                DataBaseManager.하수정비사무소장현재페이지 = 2;
            }
        }
    }

    void 소초기화함수(GameObject 켤컨텐츠)
    {
        int iCount = 켤컨텐츠.transform.childCount;
        for (int i = 0; i < iCount; i++)
        {
            Transform trChild = 켤컨텐츠.transform.GetChild(i);
            trChild.gameObject.SetActive(false);
        }

    }
        void 초기화함수(GameObject 켤컨텐츠)
    {
        int iCount = 켤컨텐츠.transform.childCount;
        for (int i = 0; i < iCount; i++)
        {
            Transform trChild = 켤컨텐츠.transform.GetChild(i);
            trChild.gameObject.SetActive(false);
        }


        되돌리기버튼.SetActive(false);
        페이지넘기기버튼.SetActive(false);

        노아정보컨텐츠.SetActive(false);
        멜리사정보컨텐츠.SetActive(false);
        엘라정보컨텐츠.SetActive(false);
        에이든정보컨텐츠.SetActive(false);
        동료기자정보컨텐츠.SetActive(false);
        경찰친구정보컨텐츠.SetActive(false);
        술집친구정보컨텐츠.SetActive(false);
        하수정비소장정보컨텐츠.SetActive(false);
        노교수정보컨텐츠.SetActive(false);
        켤컨텐츠.SetActive(true);

    }
}
