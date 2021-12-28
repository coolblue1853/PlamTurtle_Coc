using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 사건정보창manager : MonoBehaviour
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
            DataBaseManager.행성대직렬정보1 = true; 
            DataBaseManager.행성대직렬정보2 = true;
            DataBaseManager.행성대직렬정보3 = true;
            DataBaseManager.행성대직렬정보4 = true;
            DataBaseManager.행성대직렬정보5 = true;
        }



        ㅁ낭라();
        if (아래버튼누름 == false)
        {
            세부정보버튼관리();
        }

    }

    public GameObject 위버튼;
    public GameObject 아래버튼;

    public GameObject 행성대직렬버튼;
    public GameObject 악몽버튼;
    public GameObject 편집증버튼;
    public GameObject 불면증버튼;

    public GameObject 하수도괴담버튼;
    public GameObject 실종된사람들버튼;
    public GameObject 비릿한냄새버튼;   

    public GameObject 강의수질버튼;
    public GameObject 섬뜩한눈버튼;
    public GameObject 하수도노동자버튼;
    public GameObject 급격한교체버튼;


    bool 행성대직렬버튼상승 = false;
    bool 악몽버튼상승 = false;
    bool 편집증버튼상승 = false;
    bool 불면증버튼상승 = false;
    bool 하수도괴담버튼상승 = false;
    bool 실종된사람들버튼상승 = false;
    
    bool 비릿한냄새버튼상승 = false;

    bool 강의수질버튼상승 = false;
    bool 섬뜩한눈버튼상승 = false;
    bool 하수도노동자버튼상승 = false;
    bool 급격한교체버튼상승 = false;


    void ㅁ낭라()
    {
        if ((DataBaseManager.행성대직렬정보1 == true || DataBaseManager.행성대직렬정보2 == true || DataBaseManager.행성대직렬정보3 == true || DataBaseManager.행성대직렬정보4 == true || DataBaseManager.행성대직렬정보5 == true || DataBaseManager.행성대직렬정보6 == true) && 행성대직렬버튼상승 == false)
        {
            행성대직렬버튼상승 = true;
            DataBaseManager.행성대직렬버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.악몽정보1 == true || DataBaseManager.악몽정보2 == true || DataBaseManager.악몽정보3 == true || DataBaseManager.악몽정보4 == true || DataBaseManager.악몽정보5 == true || DataBaseManager.악몽정보6 == true) && 악몽버튼상승 == false)
        {
            악몽버튼상승 = true;
            DataBaseManager.악몽버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.편집증정보1 == true || DataBaseManager.편집증정보2 == true || DataBaseManager.편집증정보3 == true || DataBaseManager.편집증정보4 == true || DataBaseManager.편집증정보5 == true || DataBaseManager.편집증정보6 == true) && 편집증버튼상승 == false)
        {
            편집증버튼상승 = true;
            DataBaseManager.편집증버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.불면증정보1 == true || DataBaseManager.불면증정보2 == true || DataBaseManager.불면증정보3 == true || DataBaseManager.불면증정보4 == true || DataBaseManager.불면증정보5 == true || DataBaseManager.불면증정보6 == true) && 불면증버튼상승 == false)
        {
            불면증버튼상승 = true;
            DataBaseManager.불면증버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.하수도괴담정보1 == true || DataBaseManager.하수도괴담정보2 == true || DataBaseManager.하수도괴담정보3 == true || DataBaseManager.하수도괴담정보4 == true || DataBaseManager.하수도괴담정보5 == true || DataBaseManager.하수도괴담정보6 == true) && 하수도괴담버튼상승 == false)
        {
            하수도괴담버튼상승 = true;
            DataBaseManager.하수도괴담버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.실종된사람들정보1 == true || DataBaseManager.실종된사람들정보2 == true || DataBaseManager.실종된사람들정보3 == true || DataBaseManager.실종된사람들정보4 == true || DataBaseManager.실종된사람들정보5 == true || DataBaseManager.실종된사람들정보6 == true) && 실종된사람들버튼상승 == false)
        {
            실종된사람들버튼상승 = true;
            DataBaseManager.실종된사람들버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.비릿한냄새정보1 == true || DataBaseManager.비릿한냄새정보2 == true || DataBaseManager.비릿한냄새정보3 == true || DataBaseManager.비릿한냄새정보4 == true || DataBaseManager.비릿한냄새정보5 == true || DataBaseManager.비릿한냄새정보6 == true) && 비릿한냄새버튼상승 == false)
        {
            비릿한냄새버튼상승 = true;
            DataBaseManager.비릿한냄새버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }


        if ((DataBaseManager.강의수질정보1 == true || DataBaseManager.강의수질정보2 == true || DataBaseManager.강의수질정보3== true || DataBaseManager.강의수질정보4 == true || DataBaseManager.강의수질정보5== true || DataBaseManager.강의수질정보6 == true) && 강의수질버튼상승 == false)
        {
            강의수질버튼상승 = true;
            DataBaseManager.강의수질버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.섬뜩한눈정보1 == true || DataBaseManager.섬뜩한눈정보2== true || DataBaseManager.섬뜩한눈정보3 == true || DataBaseManager.섬뜩한눈정보4 == true || DataBaseManager.섬뜩한눈정보5 == true || DataBaseManager.섬뜩한눈정보6 == true) && 섬뜩한눈버튼상승 == false)
        {
            섬뜩한눈버튼상승 = true;
            DataBaseManager.섬뜩한눈버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.하수도노동자정보1 == true || DataBaseManager.하수도노동자정보2 == true || DataBaseManager.하수도노동자정보3 == true || DataBaseManager.하수도노동자정보4 == true || DataBaseManager.하수도노동자정보5 == true || DataBaseManager.하수도노동자정보6 == true) && 하수도노동자버튼상승 == false)
        {
            하수도노동자버튼상승 = true;
            DataBaseManager.하수도노동자버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }
        if ((DataBaseManager.급격한교체정보1 == true || DataBaseManager.급격한교체정보2 == true || DataBaseManager.급격한교체정보3 == true || DataBaseManager.급격한교체정보4== true || DataBaseManager.급격한교체정보5 == true || DataBaseManager.급격한교체정보6 == true) && 급격한교체버튼상승 == false)
        {
            급격한교체버튼상승 = true;
            DataBaseManager.급격한교체버튼순서 = DataBaseManager.현재획득한사건정보가지수;
            DataBaseManager.현재획득한사건정보가지수 += 1;
        }



    }



    void 세부정보버튼관리()
    {

        if (DataBaseManager.행성대직렬버튼순서 != -1)
        {
            행성대직렬버튼.SetActive(true);
            행성대직렬버튼.transform.SetSiblingIndex(DataBaseManager.행성대직렬버튼순서);
        }
        if (DataBaseManager.악몽버튼순서 != -1)
        {
            악몽버튼.SetActive(true);
            악몽버튼.transform.SetSiblingIndex(DataBaseManager.악몽버튼순서);
        }
        if (DataBaseManager.편집증버튼순서 != -1)
        {
            편집증버튼.SetActive(true);
            편집증버튼.transform.SetSiblingIndex(DataBaseManager.편집증버튼순서);
        }
        if (DataBaseManager.불면증버튼순서 != -1)
        {
            불면증버튼.SetActive(true);
            불면증버튼.transform.SetSiblingIndex(DataBaseManager.불면증버튼순서);
        }
        if (DataBaseManager.하수도괴담버튼순서 != -1)
        {
            하수도괴담버튼.SetActive(true);
            하수도괴담버튼.transform.SetSiblingIndex(DataBaseManager.하수도괴담버튼순서);
        }
        if (DataBaseManager.비릿한냄새버튼순서 != -1)
        {
            비릿한냄새버튼.SetActive(true);
            비릿한냄새버튼.transform.SetSiblingIndex(DataBaseManager.비릿한냄새버튼순서);
        }
        if (DataBaseManager.실종된사람들버튼순서 != -1)
        {
            실종된사람들버튼.SetActive(true);
            실종된사람들버튼.transform.SetSiblingIndex(DataBaseManager.실종된사람들버튼순서);
        }


        if (DataBaseManager.강의수질버튼순서 != -1)
        {
            강의수질버튼.SetActive(true);
            강의수질버튼.transform.SetSiblingIndex(DataBaseManager.강의수질버튼순서);
        }
        if (DataBaseManager.섬뜩한눈버튼순서 != -1)
        {
            섬뜩한눈버튼.SetActive(true);
            섬뜩한눈버튼.transform.SetSiblingIndex(DataBaseManager.섬뜩한눈버튼순서);
        }
        if (DataBaseManager.하수도노동자버튼순서 != -1)
        {
            하수도노동자버튼.SetActive(true);
            하수도노동자버튼.transform.SetSiblingIndex(DataBaseManager.하수도노동자버튼순서);
        }
        if (DataBaseManager.급격한교체버튼순서 != -1)
        {
            급격한교체버튼.SetActive(true);
            급격한교체버튼.transform.SetSiblingIndex(DataBaseManager.급격한교체버튼순서);
        }


        if (DataBaseManager.현재획득한사건정보가지수 > 6)
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

        if (DataBaseManager.현재획득한사건정보가지수 == 7)
        {
            Transform trChild16 = 버튼랙트.transform.GetChild(6);
            trChild16.gameObject.SetActive(true);

        }

        else if (DataBaseManager.현재획득한사건정보가지수 == 8)
        {
            Transform trChild16 = 버튼랙트.transform.GetChild(6);
            trChild16.gameObject.SetActive(true);
            Transform trChild7 = 버튼랙트.transform.GetChild(7);
            trChild7.gameObject.SetActive(true);

        }
        else if (DataBaseManager.현재획득한사건정보가지수 == 9)
        {
            Transform trChild16 = 버튼랙트.transform.GetChild(6);
            trChild16.gameObject.SetActive(true);
            Transform trChild7 = 버튼랙트.transform.GetChild(7);
            trChild7.gameObject.SetActive(true);
            Transform trChild9 = 버튼랙트.transform.GetChild(8);
            trChild9.gameObject.SetActive(true);

        }
        else if (DataBaseManager.현재획득한사건정보가지수 == 10)
        {
            Transform trChild16 = 버튼랙트.transform.GetChild(6);
            trChild16.gameObject.SetActive(true);
            Transform trChild7 = 버튼랙트.transform.GetChild(7);
            trChild7.gameObject.SetActive(true);
            Transform trChild9 = 버튼랙트.transform.GetChild(8);
            trChild9.gameObject.SetActive(true);
            Transform trChild10 = 버튼랙트.transform.GetChild(9);
            trChild10.gameObject.SetActive(true);


        }
        else if (DataBaseManager.현재획득한사건정보가지수 == 11)
        {
            Transform trChild16 = 버튼랙트.transform.GetChild(6);
            trChild16.gameObject.SetActive(true);
            Transform trChild7 = 버튼랙트.transform.GetChild(7);
            trChild7.gameObject.SetActive(true);
            Transform trChild9 = 버튼랙트.transform.GetChild(8);
            trChild9.gameObject.SetActive(true);
            Transform trChild10 = 버튼랙트.transform.GetChild(9);
            trChild10.gameObject.SetActive(true);
            Transform trChild11 = 버튼랙트.transform.GetChild(10);
            trChild11.gameObject.SetActive(true);
        }
    }

    public GameObject 정보프리팹;

    bool 행성대직렬정보1획득 = false;
    bool 행성대직렬정보2획득 = false;
    bool 행성대직렬정보3획득 = false;
    bool 행성대직렬정보4획득 = false;
    bool 행성대직렬정보5획득 = false;
    bool 행성대직렬정보6획득 = false;

    bool 악몽정보1획득 = false;
    bool 악몽정보2획득 = false;
    bool 악몽정보3획득 = false;
    bool 악몽정보4획득 = false;
    bool 악몽정보5획득 = false;
    bool 악몽정보6획득 = false;

    bool 편집증정보1획득 = false;
    bool 편집증정보2획득 = false;
    bool 편집증정보3획득 = false;
    bool 편집증정보4획득 = false;
    bool 편집증정보5획득 = false;
    bool 편집증정보6획득 = false;

    bool 불면증정보1획득 = false;
    bool 불면증정보2획득 = false;
    bool 불면증정보3획득 = false;
    bool 불면증정보4획득 = false;
    bool 불면증정보5획득 = false;
    bool 불면증정보6획득 = false;


    bool 하수도괴담정보1획득 = false;
    bool 하수도괴담정보2획득 = false;
    bool 하수도괴담정보3획득 = false;
    bool 하수도괴담정보4획득 = false;
    bool 하수도괴담정보5획득 = false;
    bool 하수도괴담정보6획득 = false;

    bool 실종된사람들정보1획득 = false;
    bool 실종된사람들정보2획득 = false;
    bool 실종된사람들정보3획득 = false;
    bool 실종된사람들정보4획득 = false;
    bool 실종된사람들정보5획득 = false;
    bool 실종된사람들정보6획득 = false;



    bool 비릿한냄새정보1획득 = false;
    bool 비릿한냄새정보2획득 = false;
    bool 비릿한냄새정보3획득 = false;
    bool 비릿한냄새정보4획득 = false;
    bool 비릿한냄새정보5획득 = false;
    bool 비릿한냄새정보6획득 = false;

    bool 강의수질정보1획득 = false;
    bool 강의수질정보2획득 = false;
    bool 강의수질정보3획득 = false;
    bool 강의수질정보4획득 = false;
    bool 강의수질정보5획득 = false;
    bool 강의수질정보6획득 = false;

    bool 섬뜩한눈정보1획득 = false;
    bool 섬뜩한눈정보2획득 = false;
    bool 섬뜩한눈정보3획득 = false;
    bool 섬뜩한눈정보4획득 = false;
    bool 섬뜩한눈정보5획득 = false;
    bool 섬뜩한눈정보6획득 = false;

    bool 하수도노동자정보1획득 = false;
    bool 하수도노동자정보2획득 = false;
    bool 하수도노동자정보3획득 = false;
    bool 하수도노동자정보4획득 = false;
    bool 하수도노동자정보5획득 = false;
    bool 하수도노동자정보6획득 = false;

    bool 급격한교체정보1획득 = false;
    bool 급격한교체정보2획득 = false;
    bool 급격한교체정보3획득 = false;
    bool 급격한교체정보4획득 = false;
    bool 급격한교체정보5획득 = false;
    bool 급격한교체정보6획득 = false;

    //정보컨텐츠


    public GameObject 행성대직렬정보컨텐츠;
    public GameObject 악몽정보컨텐츠;
    public GameObject 편집증정보컨텐츠;
    public GameObject 불면증정보컨텐츠;
    public GameObject 하수도괴담정보컨텐츠;
    public GameObject 실종된사람들정보컨텐츠;

    public GameObject 비릿한냄새정보컨텐츠;
    public GameObject 강의수질정보컨텐츠;
    public GameObject 섬뜩한눈정보컨텐츠;
    public GameObject 하수도노동자정보컨텐츠;
    public GameObject 급격한교체정보컨텐츠;


    public static int 정보획득량;

    string 선택정보이름;

    public Text 페이지텍스트;

    public void 행성대직렬정보창켜기()
    {

        선택정보이름 = "행성대직렬";



        if (DataBaseManager.행성대직렬정보1 == true && 행성대직렬정보1획득 == false)
        {
            행성대직렬정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = " <size=17>< 행성대직렬 신문기사 ></size> \n1921년 7월 14일 새벽에 지구를 포함한 5개의 행성이 일렬로 늘어서는 천문현상이 일어난다고 신문기사에 쓰여있었다.\n 대다수의 과학자들은 이것을 단순천문현상이라고 발표하였지만 일부 과학자나 예언가들은 이것을 종말의 징조로보고있는듯 하다. ";
            clone.transform.SetParent(행성대직렬정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.행성대직렬정보2 == true && 행성대직렬정보2획득 == false)
        {
            행성대직렬정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<행성대직렬 정보2>";
            clone.transform.SetParent(행성대직렬정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.행성대직렬정보3 == true && 행성대직렬정보3획득 == false)
        {
            행성대직렬정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<행성대직렬 정보3>";
            clone.transform.SetParent(행성대직렬정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.행성대직렬정보4 == true && 행성대직렬정보4획득 == false)
        {
            행성대직렬정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<행성대직렬 정보4>";
            clone.transform.SetParent(행성대직렬정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.행성대직렬정보5 == true && 행성대직렬정보5획득 == false)
        {
            행성대직렬정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<행성대직렬 정보5>";
            clone.transform.SetParent(행성대직렬정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }
        if (DataBaseManager.행성대직렬정보6 == true && 행성대직렬정보6획득 == false)
        {
            행성대직렬정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<행성대직렬 정보6>";
            clone.transform.SetParent(행성대직렬정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);

        }

        정보획득량 = 행성대직렬정보컨텐츠.transform.childCount;
        초기화함수(행성대직렬정보컨텐츠);

        if (DataBaseManager.행성대직렬현재페이지 == 3)
        {
            페이지텍스트.text = "< 3 >";
            Transform trChild4 = 행성대직렬정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 행성대직렬정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.행성대직렬현재페이지 == 2)
        {
            페이지텍스트.text = "< 2 >";
            Transform trChild2 = 행성대직렬정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 행성대직렬정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.행성대직렬현재페이지 == 1)
        {
            페이지텍스트.text = "< 1 >";
            Transform trChild0 = 행성대직렬정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 행성대직렬정보컨텐츠.transform.GetChild(1);
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
    public void 악몽정보창켜기()
    {

        선택정보이름 = "악몽";



        if (DataBaseManager.악몽정보1 == true && 악몽정보1획득 == false)
        {
            악몽정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = " <size=20>< 에이든의 악몽 ></size> \n의뢰자 <color=#0026A9>(엘라 트리스)</color>의 남편인 <color=#0026A9>(에이든 트리스)</color>가 겪고 있는 악몽은 생각보다 심각한 것인 듯 하다.\n갑자기 편집증이 생겨날 정도의 악몽이라면 정신적으로 상당히 내몰려있는 것일지도 모른다. ";
            clone.transform.SetParent(악몽정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.악몽정보2 == true && 악몽정보2획득 == false)
        {
            악몽정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<악몽 정보2>";
            clone.transform.SetParent(악몽정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.악몽정보3 == true && 악몽정보3획득 == false)
        {
            악몽정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<악몽 정보3>";
            clone.transform.SetParent(악몽정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.악몽정보4 == true && 악몽정보4획득 == false)
        {
            악몽정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<악몽 정보4>";
            clone.transform.SetParent(악몽정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.악몽정보5 == true && 악몽정보5획득 == false)
        {
            악몽정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<악몽 정보5>";
            clone.transform.SetParent(악몽정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.악몽정보6 == true && 악몽정보6획득 == false)
        {
            악몽정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<악몽 정보6>";
            clone.transform.SetParent(악몽정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }




        초기화함수(악몽정보컨텐츠);

        정보획득량 = 악몽정보컨텐츠.transform.childCount;


        if (DataBaseManager.악몽현재페이지 == 3)
        {
            Transform trChild4 = 악몽정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 악몽정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.악몽현재페이지 == 2)
        {
            Transform trChild2 = 악몽정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 악몽정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.악몽현재페이지 == 1)
        {
            Transform trChild0 = 악몽정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 악몽정보컨텐츠.transform.GetChild(1);
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
    public void 편집증정보창켜기()
    {

        선택정보이름 = "편집증";



        if (DataBaseManager.편집증정보1 == true && 편집증정보1획득 == false)
        {
            편집증정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<편집증 정보1>";
            clone.transform.SetParent(편집증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.편집증정보2 == true && 편집증정보2획득 == false)
        {
            편집증정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<편집증 정보2>";
            clone.transform.SetParent(편집증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.편집증정보3 == true && 편집증정보3획득 == false)
        {
            편집증정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<편집증 정보3>";
            clone.transform.SetParent(편집증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.편집증정보4 == true && 편집증정보4획득 == false)
        {
            편집증정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<편집증 정보4>";
            clone.transform.SetParent(편집증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.편집증정보5 == true && 편집증정보5획득 == false)
        {
            편집증정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<편집증 정보5>";
            clone.transform.SetParent(편집증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.편집증정보6 == true && 편집증정보6획득 == false)
        {
            편집증정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<편집증 정보6>";
            clone.transform.SetParent(편집증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }






        정보획득량 = 편집증정보컨텐츠.transform.childCount;
        초기화함수(편집증정보컨텐츠);

        if (DataBaseManager.편집증현재페이지 == 3)
        {
            Transform trChild4 = 편집증정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 편집증정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.편집증현재페이지 == 2)
        {
            Transform trChild2 = 편집증정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 편집증정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.편집증현재페이지 == 1)
        {
            Transform trChild0 = 편집증정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 편집증정보컨텐츠.transform.GetChild(1);
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
    public void 불면증정보창켜기()
    {

        선택정보이름 = "불면증";



        if (DataBaseManager.불면증정보1 == true && 불면증정보1획득 == false)
        {
            불면증정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = " <size=20>< 불면증 유행 ></size> \n최근들어 아컴시에서 원인 불명의<color=#B30000>(불면증)</color>이 유행중이라고 한다.";
            clone.transform.SetParent(불면증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.불면증정보2 == true && 불면증정보2획득 == false)
        {
            불면증정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<불면증 정보2>";
            clone.transform.SetParent(불면증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.불면증정보3 == true && 불면증정보3획득 == false)
        {
            불면증정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<불면증 정보3>";
            clone.transform.SetParent(불면증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.불면증정보4 == true && 불면증정보4획득 == false)
        {
            불면증정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<불면증 정보4>";
            clone.transform.SetParent(불면증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.불면증정보5 == true && 불면증정보5획득 == false)
        {
            불면증정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<불면증 정보5>";
            clone.transform.SetParent(불면증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.불면증정보6 == true && 불면증정보6획득 == false)
        {
            불면증정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<불면증 정보6>";
            clone.transform.SetParent(불면증정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 불면증정보컨텐츠.transform.childCount;
        초기화함수(불면증정보컨텐츠);

        if (DataBaseManager.불면증현재페이지 == 3)
        {
            Transform trChild4 = 불면증정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 불면증정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.불면증현재페이지 == 2)
        {
            Transform trChild2 = 불면증정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 불면증정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.불면증현재페이지 == 1)
        {
            Transform trChild0 = 불면증정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 불면증정보컨텐츠.transform.GetChild(1);
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
    public void 하수도괴담정보창켜기()
    {

        선택정보이름 = "하수도괴담";



        if (DataBaseManager.하수도괴담정보1 == true && 하수도괴담정보1획득 == false)
        {
            하수도괴담정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도괴담 정보1>";
            clone.transform.SetParent(하수도괴담정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도괴담정보2 == true && 하수도괴담정보2획득 == false)
        {
            하수도괴담정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도괴담 정보2>";
            clone.transform.SetParent(하수도괴담정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도괴담정보3 == true && 하수도괴담정보3획득 == false)
        {
            하수도괴담정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도괴담 정보3>";
            clone.transform.SetParent(하수도괴담정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도괴담정보4 == true && 하수도괴담정보4획득 == false)
        {
            하수도괴담정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도괴담 정보4>";
            clone.transform.SetParent(하수도괴담정보컨텐츠.transform); 
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도괴담정보5 == true && 하수도괴담정보5획득 == false)
        {
            하수도괴담정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도괴담 정보5>";
            clone.transform.SetParent(하수도괴담정보컨텐츠.transform); 
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도괴담정보6 == true && 하수도괴담정보6획득 == false)
        {
            하수도괴담정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도괴담 정보6>";
            clone.transform.SetParent(하수도괴담정보컨텐츠.transform); 
            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        정보획득량 = 하수도괴담정보컨텐츠.transform.childCount;
        초기화함수(하수도괴담정보컨텐츠);

        if (DataBaseManager.하수도괴담현재페이지 == 3)
        {
            Transform trChild4 = 하수도괴담정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 하수도괴담정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.하수도괴담현재페이지 == 2)
        {
            Transform trChild2 = 하수도괴담정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 하수도괴담정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.하수도괴담현재페이지 == 1)
        {
            Transform trChild0 = 하수도괴담정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 하수도괴담정보컨텐츠.transform.GetChild(1);
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
    public void 실종된사람들정보창켜기()
    {

        선택정보이름 = "실종된사람들";



        if (DataBaseManager.실종된사람들정보1 == true && 실종된사람들정보1획득 == false)
        {
            실종된사람들정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<실종된사람들 정보1>";
            clone.transform.SetParent(실종된사람들정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.실종된사람들정보2 == true && 실종된사람들정보2획득 == false)
        {
            실종된사람들정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<실종된사람들 정보2>";
            clone.transform.SetParent(실종된사람들정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.실종된사람들정보3 == true && 실종된사람들정보3획득 == false)
        {
            실종된사람들정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<실종된사람들 정보3>";
            clone.transform.SetParent(실종된사람들정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.실종된사람들정보4 == true && 실종된사람들정보4획득 == false)
        {
            실종된사람들정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<실종된사람들 정보4>";
            clone.transform.SetParent(실종된사람들정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.실종된사람들정보5 == true && 실종된사람들정보5획득 == false)
        {
            실종된사람들정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<실종된사람들 정보5>";
            clone.transform.SetParent(실종된사람들정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.실종된사람들정보6 == true && 실종된사람들정보6획득 == false)
        {
            실종된사람들정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<실종된사람들 정보6>";
            clone.transform.SetParent(실종된사람들정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        정보획득량 = 실종된사람들정보컨텐츠.transform.childCount;
        초기화함수(실종된사람들정보컨텐츠);

        if (DataBaseManager.실종된사람들현재페이지 == 3)
        {
            Transform trChild4 = 실종된사람들정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 실종된사람들정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.실종된사람들현재페이지 == 2)
        {
            Transform trChild2 = 실종된사람들정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 실종된사람들정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.실종된사람들현재페이지 == 1)
        {
            Transform trChild0 = 실종된사람들정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 실종된사람들정보컨텐츠.transform.GetChild(1);
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
    public void 비릿한냄새정보창켜기()
    {

        선택정보이름 = "비릿한냄새";



        if (DataBaseManager.비릿한냄새정보1 == true && 비릿한냄새정보1획득 == false)
        {
            비릿한냄새정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<비릿한냄새 정보1>";
            clone.transform.SetParent(비릿한냄새정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.비릿한냄새정보2 == true && 비릿한냄새정보2획득 == false)
        {
            비릿한냄새정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<비릿한냄새 정보2>";
            clone.transform.SetParent(비릿한냄새정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.비릿한냄새정보3 == true && 비릿한냄새정보3획득 == false)
        {
            비릿한냄새정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<비릿한냄새 정보3>";
            clone.transform.SetParent(비릿한냄새정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.비릿한냄새정보4 == true && 비릿한냄새정보4획득 == false)
        {
            비릿한냄새정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<비릿한냄새 정보4>";
            clone.transform.SetParent(비릿한냄새정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.비릿한냄새정보5 == true && 비릿한냄새정보5획득 == false)
        {
            비릿한냄새정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<비릿한냄새 정보5>";
            clone.transform.SetParent(비릿한냄새정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.비릿한냄새정보6 == true && 비릿한냄새정보6획득 == false)
        {
            비릿한냄새정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<비릿한냄새 정보6>";
            clone.transform.SetParent(비릿한냄새정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        정보획득량 = 비릿한냄새정보컨텐츠.transform.childCount;
        초기화함수(비릿한냄새정보컨텐츠);

        if (DataBaseManager.비릿한냄새현재페이지 == 3)
        {
            Transform trChild4 = 비릿한냄새정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 비릿한냄새정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.비릿한냄새현재페이지 == 2)
        {
            Transform trChild2 = 비릿한냄새정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 비릿한냄새정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.비릿한냄새현재페이지 == 1)
        {
            Transform trChild0 = 비릿한냄새정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 비릿한냄새정보컨텐츠.transform.GetChild(1);
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
    public void 강의수질정보창켜기()
    {

        선택정보이름 = "강의수질";



        if (DataBaseManager.강의수질정보1 == true && 강의수질정보1획득 == false)
        {
            강의수질정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강의수질 정보1>";
            clone.transform.SetParent(강의수질정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강의수질정보2 == true && 강의수질정보2획득 == false)
        {
            강의수질정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강의수질 정보2>";
            clone.transform.SetParent(강의수질정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강의수질정보3 == true && 강의수질정보3획득 == false)
        {
            강의수질정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강의수질 정보3>";
            clone.transform.SetParent(강의수질정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강의수질정보4 == true && 강의수질정보4획득 == false)
        {
            강의수질정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강의수질 정보4>";
            clone.transform.SetParent(강의수질정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강의수질정보5 == true && 강의수질정보5획득 == false)
        {
            강의수질정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강의수질 정보5>";
            clone.transform.SetParent(강의수질정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강의수질정보6 == true && 강의수질정보6획득 == false)
        {
            강의수질정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강의수질 정보6>";
            clone.transform.SetParent(강의수질정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }




        정보획득량 = 강의수질정보컨텐츠.transform.childCount;
        초기화함수(강의수질정보컨텐츠);

        if (DataBaseManager.강의수질현재페이지 == 3)
        {
            Transform trChild4 = 강의수질정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 강의수질정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.강의수질현재페이지 == 2)
        {
            Transform trChild2 = 강의수질정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 강의수질정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.강의수질현재페이지 == 1)
        {
            Transform trChild0 = 강의수질정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 강의수질정보컨텐츠.transform.GetChild(1);
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
    public void 섬뜩한눈정보창켜기()
    {

        선택정보이름 = "섬뜩한눈";



        if (DataBaseManager.섬뜩한눈정보1 == true && 섬뜩한눈정보1획득 == false)
        {
            섬뜩한눈정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<섬뜩한눈 정보1>";
            clone.transform.SetParent(섬뜩한눈정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.섬뜩한눈정보2 == true && 섬뜩한눈정보2획득 == false)
        {
            섬뜩한눈정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<섬뜩한눈 정보2>";
            clone.transform.SetParent(섬뜩한눈정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.섬뜩한눈정보3 == true && 섬뜩한눈정보3획득 == false)
        {
            섬뜩한눈정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<섬뜩한눈 정보3>";
            clone.transform.SetParent(섬뜩한눈정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.섬뜩한눈정보4 == true && 섬뜩한눈정보4획득 == false)
        {
            섬뜩한눈정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<섬뜩한눈 정보4>";
            clone.transform.SetParent(섬뜩한눈정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.섬뜩한눈정보5 == true && 섬뜩한눈정보5획득 == false)
        {
            섬뜩한눈정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<섬뜩한눈 정보5>";
            clone.transform.SetParent(섬뜩한눈정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.섬뜩한눈정보6 == true && 섬뜩한눈정보6획득 == false)
        {
            섬뜩한눈정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<섬뜩한눈 정보6>";
            clone.transform.SetParent(섬뜩한눈정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        정보획득량 = 섬뜩한눈정보컨텐츠.transform.childCount;
        초기화함수(섬뜩한눈정보컨텐츠);

        if (DataBaseManager.섬뜩한눈현재페이지 == 3)
        {
            Transform trChild4 = 섬뜩한눈정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 섬뜩한눈정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.섬뜩한눈현재페이지 == 2)
        {
            Transform trChild2 = 섬뜩한눈정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 섬뜩한눈정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.섬뜩한눈현재페이지 == 1)
        {
            Transform trChild0 = 섬뜩한눈정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 섬뜩한눈정보컨텐츠.transform.GetChild(1);
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
    public void 하수도노동자정보창켜기()
    {

        선택정보이름 = "하수도노동자";



        if (DataBaseManager.하수도노동자정보1 == true && 하수도노동자정보1획득 == false)
        {
            하수도노동자정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도노동자 정보1>";
            clone.transform.SetParent(하수도노동자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도노동자정보2 == true && 하수도노동자정보2획득 == false)
        {
            하수도노동자정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도노동자 정보2>";
            clone.transform.SetParent(하수도노동자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도노동자정보3 == true && 하수도노동자정보3획득 == false)
        {
            하수도노동자정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도노동자 정보3>";
            clone.transform.SetParent(하수도노동자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도노동자정보4 == true && 하수도노동자정보4획득 == false)
        {
            하수도노동자정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도노동자 정보4>";
            clone.transform.SetParent(하수도노동자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도노동자정보5 == true && 하수도노동자정보5획득 == false)
        {
            하수도노동자정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도노동자 정보5>";
            clone.transform.SetParent(하수도노동자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.하수도노동자정보6 == true && 하수도노동자정보6획득 == false)
        {
            하수도노동자정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수도노동자 정보6>";
            clone.transform.SetParent(하수도노동자정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        정보획득량 = 하수도노동자정보컨텐츠.transform.childCount;
        초기화함수(하수도노동자정보컨텐츠);

        if (DataBaseManager.하수도노동자현재페이지 == 3)
        {
            Transform trChild4 = 하수도노동자정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 하수도노동자정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.하수도노동자현재페이지 == 2)
        {
            Transform trChild2 = 하수도노동자정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 하수도노동자정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.하수도노동자현재페이지 == 1)
        {
            Transform trChild0 = 하수도노동자정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 하수도노동자정보컨텐츠.transform.GetChild(1);
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
    public void 급격한교체정보창켜기()
    {

        선택정보이름 = "급격한교체";



        if (DataBaseManager.급격한교체정보1 == true && 급격한교체정보1획득 == false)
        {
            급격한교체정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<급격한교체 정보1>";
            clone.transform.SetParent(급격한교체정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.급격한교체정보2 == true && 급격한교체정보2획득 == false)
        {
            급격한교체정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<급격한교체 정보2>";
            clone.transform.SetParent(급격한교체정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.급격한교체정보3 == true && 급격한교체정보3획득 == false)
        {
            급격한교체정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<급격한교체 정보3>";
            clone.transform.SetParent(급격한교체정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.급격한교체정보4 == true && 급격한교체정보4획득 == false)
        {
            급격한교체정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<급격한교체 정보4>";
            clone.transform.SetParent(급격한교체정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.급격한교체정보5 == true && 급격한교체정보5획득 == false)
        {
            급격한교체정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<급격한교체 정보5>";
            clone.transform.SetParent(급격한교체정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.급격한교체정보6 == true && 급격한교체정보6획득 == false)
        {
            급격한교체정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<급격한교체 정보6>";
            clone.transform.SetParent(급격한교체정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        정보획득량 = 급격한교체정보컨텐츠.transform.childCount;
        초기화함수(급격한교체정보컨텐츠);

        if (DataBaseManager.급격한교체현재페이지 == 3)
        {
            Transform trChild4 = 급격한교체정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 급격한교체정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.급격한교체현재페이지 == 2)
        {
            Transform trChild2 = 급격한교체정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 급격한교체정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.급격한교체현재페이지 == 1)
        {
            Transform trChild0 = 급격한교체정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 급격한교체정보컨텐츠.transform.GetChild(1);
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
        if (선택정보이름 == "행성대직렬")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.행성대직렬현재페이지, 행성대직렬정보컨텐츠);
        }

        if (선택정보이름 == "멜리사")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.악몽현재페이지, 악몽정보컨텐츠);
        }
        if (선택정보이름 == "편집증")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.편집증현재페이지, 편집증정보컨텐츠);
        }
        if (선택정보이름 == "불면증")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.불면증현재페이지, 불면증정보컨텐츠);
        }
        if (선택정보이름 == "하수도괴담")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.하수도괴담현재페이지, 하수도괴담정보컨텐츠);
        }
        if (선택정보이름 == "실종된사람들")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.실종된사람들현재페이지, 실종된사람들정보컨텐츠);
        }


        if (선택정보이름 == "비릿한냄새")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.비릿한냄새현재페이지, 비릿한냄새정보컨텐츠);
        }
        if (선택정보이름 == "강의수질")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.강의수질현재페이지, 강의수질정보컨텐츠);
        }
        if (선택정보이름 == "섬뜩한눈")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.섬뜩한눈현재페이지, 섬뜩한눈정보컨텐츠);
        }
        if (선택정보이름 == "하수도노동자")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.하수도노동자현재페이지, 하수도노동자정보컨텐츠);
        }
        if (선택정보이름 == "급격한교체")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.급격한교체현재페이지, 급격한교체정보컨텐츠);
        }

    }
    public void 페이지되돌리기()
    {
        if (선택정보이름 == "행성대직렬")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.행성대직렬현재페이지, 행성대직렬정보컨텐츠);
        }
        if (선택정보이름 == "멜리사")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.악몽현재페이지, 악몽정보컨텐츠);
        }
        if (선택정보이름 == "편집증")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.편집증현재페이지, 편집증정보컨텐츠);
        }
        if (선택정보이름 == "불면증")

        {

            페이지되돌리기함수(정보획득량, DataBaseManager.불면증현재페이지, 불면증정보컨텐츠);
        }
        if (선택정보이름 == "하수도괴담")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.하수도괴담현재페이지, 하수도괴담정보컨텐츠);
        }
        if (선택정보이름 == "실종된사람들")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.실종된사람들현재페이지, 실종된사람들정보컨텐츠);
        }


        if (선택정보이름 == "비릿한냄새")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.비릿한냄새현재페이지, 비릿한냄새정보컨텐츠);
        }
        if (선택정보이름 == "강의수질")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.강의수질현재페이지, 강의수질정보컨텐츠);
        }
        if (선택정보이름 == "섬뜩한눈")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.섬뜩한눈현재페이지, 섬뜩한눈정보컨텐츠);
        }
        if (선택정보이름 == "하수도노동자")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.하수도노동자현재페이지, 하수도노동자정보컨텐츠);
        }
        if (선택정보이름 == "급격한교체")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.급격한교체현재페이지, 급격한교체정보컨텐츠);
        }


    }



    public void 페이지넘기기함수(int 대상정보획득량, int 대상페이지, GameObject 정보컨텐츠)
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



            if (선택정보이름 == "행성대직렬")
            {
                DataBaseManager.행성대직렬현재페이지 = 2;
            }
            if (선택정보이름 == "악몽")
            {
                DataBaseManager.악몽현재페이지 = 2;
            }
            if (선택정보이름 == "편집증")
            {
                DataBaseManager.편집증현재페이지 = 2;
            }
            if (선택정보이름 == "불면증")
            {
                DataBaseManager.불면증현재페이지 = 2;
            }
            if (선택정보이름 == "하수도괴담")
            {
                DataBaseManager.하수도괴담현재페이지 = 2;
            }
            if (선택정보이름 == "실종된사람들")
            {
                DataBaseManager.실종된사람들현재페이지 = 2;
            }



            if (선택정보이름 == "비릿한냄새")
            {
                DataBaseManager.비릿한냄새현재페이지 = 2;
            }
            if (선택정보이름 == "강의수질")
            {
                DataBaseManager.강의수질현재페이지 = 2;
            }
            if (선택정보이름 == "섬뜩한눈")
            {
                DataBaseManager.섬뜩한눈현재페이지 = 2;
            }
            if (선택정보이름 == "하수도노동자")
            {
                DataBaseManager.하수도노동자현재페이지 = 2;
            }
            if (선택정보이름 == "급격한교체")
            {
                DataBaseManager.급격한교체현재페이지 = 2;
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

            if (선택정보이름 == "행성대직렬")
            {
                DataBaseManager.행성대직렬현재페이지 = 3;
            }
            if (선택정보이름 == "악몽")
            {
                DataBaseManager.악몽현재페이지 = 3;
            }
            if (선택정보이름 == "편집증")
            {
                DataBaseManager.편집증현재페이지 = 3;
            }
            if (선택정보이름 == "불면증")
            {
                DataBaseManager.불면증현재페이지 = 3;
            }
            if (선택정보이름 == "하수도괴담")
            {
                DataBaseManager.하수도괴담현재페이지 = 3;
            }
            if (선택정보이름 == "실종된사람들")
            {
                DataBaseManager.실종된사람들현재페이지 = 3;
            }



            if (선택정보이름 == "비릿한냄새")
            {
                DataBaseManager.비릿한냄새현재페이지 = 3;
            }
            if (선택정보이름 == "강의수질")
            {
                DataBaseManager.강의수질현재페이지 = 3;
            }
            if (선택정보이름 == "섬뜩한눈")
            {
                DataBaseManager.섬뜩한눈현재페이지 = 3;
            }
            if (선택정보이름 == "하수도노동자")
            {
                DataBaseManager.하수도노동자현재페이지 = 3;
            }
            if (선택정보이름 == "급격한교체")
            {
                DataBaseManager.급격한교체현재페이지 = 3;
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






            if (선택정보이름 == "행성대직렬")
            {
                DataBaseManager.행성대직렬현재페이지 = 1;
            }
            if (선택정보이름 == "악몽")
            {
                DataBaseManager.악몽현재페이지 = 1;
            }
            if (선택정보이름 == "편집증")
            {
                DataBaseManager.편집증현재페이지 = 1;
            }
            if (선택정보이름 == "불면증")
            {
                DataBaseManager.불면증현재페이지 = 1;
            }
            if (선택정보이름 == "하수도괴담")
            {
                DataBaseManager.하수도괴담현재페이지 = 1;
            }
            if (선택정보이름 == "실종된사람들")
            {
                DataBaseManager.실종된사람들현재페이지 = 1;
            }



            if (선택정보이름 == "비릿한냄새")
            {
                DataBaseManager.비릿한냄새현재페이지 = 1;
            }
            if (선택정보이름 == "강의수질")
            {
                DataBaseManager.강의수질현재페이지 = 1;
            }
            if (선택정보이름 == "섬뜩한눈")
            {
                DataBaseManager.섬뜩한눈현재페이지 = 1;
            }
            if (선택정보이름 == "하수도노동자")
            {
                DataBaseManager.하수도노동자현재페이지 = 1;
            }
            if (선택정보이름 == "급격한교체")
            {
                DataBaseManager.급격한교체현재페이지 = 1;
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






            if (선택정보이름 == "행성대직렬")
            {
                DataBaseManager.행성대직렬현재페이지 = 2;
            }
            if (선택정보이름 == "악몽")
            {
                DataBaseManager.악몽현재페이지 = 2;
            }
            if (선택정보이름 == "편집증")
            {
                DataBaseManager.편집증현재페이지 = 2;
            }
            if (선택정보이름 == "불면증")
            {
                DataBaseManager.불면증현재페이지 = 2;
            }
            if (선택정보이름 == "하수도괴담")
            {
                DataBaseManager.하수도괴담현재페이지 = 2;
            }
            if (선택정보이름 == "실종된사람들")
            {
                DataBaseManager.실종된사람들현재페이지 = 2;
            }


            if (선택정보이름 == "비릿한냄새")
            {
                DataBaseManager.비릿한냄새현재페이지 = 2;
            }
            if (선택정보이름 == "강의수질")
            {
                DataBaseManager.강의수질현재페이지 = 2;
            }
            if (선택정보이름 == "섬뜩한눈")
            {
                DataBaseManager.섬뜩한눈현재페이지 = 2;
            }
            if (선택정보이름 == "하수도노동자")
            {
                DataBaseManager.하수도노동자현재페이지 = 2;
            }
            if (선택정보이름 == "급격한교체")
            {
                DataBaseManager.급격한교체현재페이지 = 2;
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

        행성대직렬정보컨텐츠.SetActive(false);
        악몽정보컨텐츠.SetActive(false);
        편집증정보컨텐츠.SetActive(false);
        불면증정보컨텐츠.SetActive(false);
        하수도괴담정보컨텐츠.SetActive(false);
        실종된사람들정보컨텐츠.SetActive(false);

        비릿한냄새정보컨텐츠.SetActive(false);
        강의수질정보컨텐츠.SetActive(false);
        섬뜩한눈정보컨텐츠.SetActive(false);
        하수도노동자정보컨텐츠.SetActive(false);
        급격한교체정보컨텐츠.SetActive(false);

        켤컨텐츠.SetActive(true);

    }
}
