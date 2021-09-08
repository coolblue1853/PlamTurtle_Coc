using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 장소정보창manager : MonoBehaviour
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
            DataBaseManager.탐정사무소정보1 = true;
            DataBaseManager.병원정보1 = true;
            DataBaseManager.신문사정보1 = true;
            DataBaseManager.의뢰자의집정보1 = true;
            DataBaseManager.아컴역정보1 = true;
            DataBaseManager.경찰서정보1 = true;
            DataBaseManager.식당정보1 = true;
            DataBaseManager.대학정보1 = true;
            DataBaseManager.강가정보1 = true;
            DataBaseManager.술집정보1 = true;
            DataBaseManager.빈민가정보1 = true;
            DataBaseManager.경찰서정보1 = true;
            DataBaseManager.총포상정보1 = true;
            DataBaseManager.하수정비사무소정보1 = true;
        }





        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DataBaseManager.대학정보1 = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DataBaseManager.강가정보1 = true;


        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            DataBaseManager.술집정보1 = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            DataBaseManager.빈민가정보1 = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            DataBaseManager.총포상정보1 = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {

            DataBaseManager.하수정비사무소정보1 = true;
        }

        ㅁ낭라();
        if (아래버튼누름 == false)
        {
            세부정보버튼관리();
        }

    }

    public GameObject 위버튼;
    public GameObject 아래버튼;

    public GameObject 탐정사무소버튼;
    public GameObject 병원버튼;
    public GameObject 신문사버튼;
    public GameObject 의뢰자의집버튼;
    public GameObject 아컴역버튼;

    public GameObject 식당버튼;
    public GameObject 대학버튼;   
    public GameObject 강가버튼;
    public GameObject 술집버튼;
    public GameObject 빈민가버튼;

    public GameObject 경찰서버튼;
    public GameObject 총포상버튼;
    public GameObject 하수정비사무소버튼;

    bool 탐정사무소버튼상승 = false;
    bool 병원버튼상승 = false;
    bool 신문사버튼상승 = false;
    bool 의뢰자의집버튼상승 = false;
    bool 아컴역버튼상승 = false;
    bool 식당버튼상승 = false;
    bool 대학버튼상승 = false;
    bool 강가버튼상승 = false;
    bool 술집버튼상승 = false;
    bool 빈민가버튼상승 = false;
    bool 경찰서버튼상승 = false;
    bool 총포상버튼상승 = false;
    bool 하수정비사무소버튼상승 = false;


    void ㅁ낭라()
    {
        if ((DataBaseManager.탐정사무소정보1 == true || DataBaseManager.탐정사무소정보2 == true || DataBaseManager.탐정사무소정보3 == true || DataBaseManager.탐정사무소정보4 == true || DataBaseManager.탐정사무소정보5 == true || DataBaseManager.탐정사무소정보6 == true) && 탐정사무소버튼상승 == false)
        {
            탐정사무소버튼상승 = true;
            DataBaseManager.탐정사무소버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.병원정보1 == true || DataBaseManager.병원정보2 == true || DataBaseManager.병원정보3 == true || DataBaseManager.병원정보4 == true || DataBaseManager.병원정보5 == true || DataBaseManager.병원정보6 == true) && 병원버튼상승 == false)
        {
            병원버튼상승 = true;
            DataBaseManager.병원버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.신문사정보1 == true || DataBaseManager.신문사정보2 == true || DataBaseManager.신문사정보3 == true || DataBaseManager.신문사정보4 == true || DataBaseManager.신문사정보5 == true || DataBaseManager.신문사정보6 == true) && 신문사버튼상승 == false)
        {
            신문사버튼상승 = true;
            DataBaseManager.신문사버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.의뢰자의집정보1 == true || DataBaseManager.의뢰자의집정보2 == true || DataBaseManager.의뢰자의집정보3 == true || DataBaseManager.의뢰자의집정보4 == true || DataBaseManager.의뢰자의집정보5 == true || DataBaseManager.의뢰자의집정보6 == true) && 의뢰자의집버튼상승 == false)
        {
            의뢰자의집버튼상승 = true;
            DataBaseManager.의뢰자의집버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.아컴역정보1 == true || DataBaseManager.아컴역정보2 == true || DataBaseManager.아컴역정보3 == true || DataBaseManager.아컴역정보4 == true || DataBaseManager.아컴역정보5 == true || DataBaseManager.아컴역정보6 == true) && 아컴역버튼상승 == false)
        {
            아컴역버튼상승 = true;
            DataBaseManager.아컴역버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.식당정보1 == true || DataBaseManager.식당정보2 == true || DataBaseManager.식당정보3 == true || DataBaseManager.식당정보4 == true || DataBaseManager.식당정보5 == true || DataBaseManager.식당정보6 == true) && 식당버튼상승 == false)
        {
            식당버튼상승 = true;
            DataBaseManager.식당버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.대학정보1 == true || DataBaseManager.대학정보2 == true || DataBaseManager.대학정보3 == true || DataBaseManager.대학정보4 == true || DataBaseManager.대학정보5 == true || DataBaseManager.대학정보6 == true) && 대학버튼상승 == false)
        {
            대학버튼상승 = true;
            DataBaseManager.대학버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.강가정보1 == true || DataBaseManager.강가정보2 == true || DataBaseManager.강가정보3 == true || DataBaseManager.강가정보4 == true || DataBaseManager.강가정보5 == true || DataBaseManager.강가정보6 == true) && 강가버튼상승 == false)
        {
            강가버튼상승 = true;
            DataBaseManager.강가버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.술집정보1 == true || DataBaseManager.술집정보2 == true || DataBaseManager.술집정보3 == true || DataBaseManager.술집정보4 == true || DataBaseManager.술집정보5 == true || DataBaseManager.술집정보6 == true) && 술집버튼상승 == false)
        {
            술집버튼상승 = true;
            DataBaseManager.술집버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.빈민가정보1 == true || DataBaseManager.빈민가정보2 == true || DataBaseManager.빈민가정보3 == true || DataBaseManager.빈민가정보4 == true || DataBaseManager.빈민가정보5 == true || DataBaseManager.빈민가정보6 == true) && 빈민가버튼상승 == false)
        {
            빈민가버튼상승 = true;
            DataBaseManager.빈민가버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.경찰서정보1 == true || DataBaseManager.경찰서정보2 == true || DataBaseManager.경찰서정보3 == true || DataBaseManager.경찰서정보4 == true || DataBaseManager.경찰서정보5 == true || DataBaseManager.경찰서정보6 == true) && 경찰서버튼상승 == false)
        {
            경찰서버튼상승 = true;
            DataBaseManager.경찰서버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.총포상정보1 == true || DataBaseManager.총포상정보2 == true || DataBaseManager.총포상정보3 == true || DataBaseManager.총포상정보4 == true || DataBaseManager.총포상정보5 == true || DataBaseManager.총포상정보6 == true) && 총포상버튼상승 == false)
        {
            총포상버튼상승 = true;
            DataBaseManager.총포상버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }
        if ((DataBaseManager.하수정비사무소정보1 == true || DataBaseManager.하수정비사무소정보2 == true || DataBaseManager.하수정비사무소정보3 == true || DataBaseManager.하수정비사무소정보4 == true || DataBaseManager.하수정비사무소정보5 == true || DataBaseManager.하수정비사무소정보6 == true) && 하수정비사무소버튼상승 == false)
        {
            하수정비사무소버튼상승 = true;
            DataBaseManager.하수정비사무소버튼순서 = DataBaseManager.현재획득한장소정보가지수;
            DataBaseManager.현재획득한장소정보가지수 += 1;
        }

    }



    void 세부정보버튼관리()
    {

        if (DataBaseManager.탐정사무소버튼순서 != -1)
        {
            탐정사무소버튼.SetActive(true);
            탐정사무소버튼.transform.SetSiblingIndex(DataBaseManager.탐정사무소버튼순서);
        }
        if (DataBaseManager.병원버튼순서 != -1)
        {
            병원버튼.SetActive(true);
            병원버튼.transform.SetSiblingIndex(DataBaseManager.병원버튼순서);
        }
        if (DataBaseManager.신문사버튼순서 != -1)
        {
            신문사버튼.SetActive(true);
            신문사버튼.transform.SetSiblingIndex(DataBaseManager.신문사버튼순서);
        }
        if (DataBaseManager.의뢰자의집버튼순서 != -1)
        {
            의뢰자의집버튼.SetActive(true);
            의뢰자의집버튼.transform.SetSiblingIndex(DataBaseManager.의뢰자의집버튼순서);
        }
        if (DataBaseManager.아컴역버튼순서 != -1)
        {
            아컴역버튼.SetActive(true);
            아컴역버튼.transform.SetSiblingIndex(DataBaseManager.아컴역버튼순서);
        }
        if (DataBaseManager.식당버튼순서 != -1)
        {
            식당버튼.SetActive(true);
            식당버튼.transform.SetSiblingIndex(DataBaseManager.식당버튼순서);
        }
        if (DataBaseManager.대학버튼순서 != -1)
        {
            대학버튼.SetActive(true);
            대학버튼.transform.SetSiblingIndex(DataBaseManager.대학버튼순서);
        }
        if (DataBaseManager.강가버튼순서 != -1)
        {
            강가버튼.SetActive(true);
            강가버튼.transform.SetSiblingIndex(DataBaseManager.강가버튼순서);
        }
        if (DataBaseManager.술집버튼순서 != -1)
        {
            술집버튼.SetActive(true);
            술집버튼.transform.SetSiblingIndex(DataBaseManager.술집버튼순서);
        }
        if (DataBaseManager.빈민가버튼순서 != -1)
        {
            빈민가버튼.SetActive(true);
            빈민가버튼.transform.SetSiblingIndex(DataBaseManager.빈민가버튼순서);
        }
        if (DataBaseManager.경찰서버튼순서 != -1)
        {
            경찰서버튼.SetActive(true);
            경찰서버튼.transform.SetSiblingIndex(DataBaseManager.경찰서버튼순서);
        }
        if (DataBaseManager.총포상버튼순서 != -1)
        {
            총포상버튼.SetActive(true);
            총포상버튼.transform.SetSiblingIndex(DataBaseManager.총포상버튼순서);
        }
        if (DataBaseManager.하수정비사무소버튼순서 != -1)
        {
            하수정비사무소버튼.SetActive(true);
            하수정비사무소버튼.transform.SetSiblingIndex(DataBaseManager.하수정비사무소버튼순서);
        }


        if (DataBaseManager.현재획득한장소정보가지수 > 6)
        {
            아래버튼.SetActive(true);
        }
    }

    public GameObject 버튼랙트;
    bool 아래버튼누름 = false;
    bool 아래버튼누름투 = false;

    public GameObject 위버튼투;
    public GameObject 아래버튼투;
    public void 위버튼클릭()
    {
        아래버튼누름 = false;
        위버튼.SetActive(false);
        아래버튼.SetActive(true);
    }
    public void 위버튼투클릭()
    {
        위버튼.SetActive(true);
        위버튼투.SetActive(false);
        아래버튼.SetActive(true);
        아래버튼투.SetActive(false);

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
        Transform trChild12 = 버튼랙트.transform.GetChild(11);
        trChild12.gameObject.SetActive(true);
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
        else if (DataBaseManager.현재획득한사건정보가지수 == 12)
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
            Transform trChild12 = 버튼랙트.transform.GetChild(11);
            trChild12.gameObject.SetActive(true);
        }
        if (DataBaseManager.현재획득한장소정보가지수 >12)
        {
            아래버튼투.SetActive(true);
        }
    }

    public void 아래버튼투클릭()
    {
        위버튼.SetActive(false);
        위버튼투.SetActive(true);
        아래버튼.SetActive(false);
        아래버튼투.SetActive(false);
        
        아래버튼누름투 = true;
        for (int i = 0; i < 12; i++)
        {
            Transform trChild = 버튼랙트.transform.GetChild(i);
            trChild.gameObject.SetActive(false);
        }

        if (DataBaseManager.현재획득한장소정보가지수 == 13)
        {
            Transform trChild12 = 버튼랙트.transform.GetChild(12);
            trChild12.gameObject.SetActive(true);

        }

      


    }










    public GameObject 정보프리팹;

    bool 탐정사무소정보1획득 = false;
    bool 탐정사무소정보2획득 = false;
    bool 탐정사무소정보3획득 = false;
    bool 탐정사무소정보4획득 = false;
    bool 탐정사무소정보5획득 = false;
    bool 탐정사무소정보6획득 = false;

    bool 병원정보1획득 = false;
    bool 병원정보2획득 = false;
    bool 병원정보3획득 = false;
    bool 병원정보4획득 = false;
    bool 병원정보5획득 = false;
    bool 병원정보6획득 = false;

    bool 신문사정보1획득 = false;
    bool 신문사정보2획득 = false;
    bool 신문사정보3획득 = false;
    bool 신문사정보4획득 = false;
    bool 신문사정보5획득 = false;
    bool 신문사정보6획득 = false;

    bool 의뢰자의집정보1획득 = false;
    bool 의뢰자의집정보2획득 = false;
    bool 의뢰자의집정보3획득 = false;
    bool 의뢰자의집정보4획득 = false;
    bool 의뢰자의집정보5획득 = false;
    bool 의뢰자의집정보6획득 = false;


    bool 아컴역정보1획득 = false;
    bool 아컴역정보2획득 = false;
    bool 아컴역정보3획득 = false;
    bool 아컴역정보4획득 = false;
    bool 아컴역정보5획득 = false;
    bool 아컴역정보6획득 = false;

    bool 식당정보1획득 = false;
    bool 식당정보2획득 = false;
    bool 식당정보3획득 = false;
    bool 식당정보4획득 = false;
    bool 식당정보5획득 = false;
    bool 식당정보6획득 = false;

        

    bool 대학정보1획득 = false;
    bool 대학정보2획득 = false;
    bool 대학정보3획득 = false;
    bool 대학정보4획득 = false;
    bool 대학정보5획득 = false;
    bool 대학정보6획득 = false;

    bool 강가정보1획득 = false;
    bool 강가정보2획득 = false;
    bool 강가정보3획득 = false;
    bool 강가정보4획득 = false;
    bool 강가정보5획득 = false;
    bool 강가정보6획득 = false;

    bool 술집정보1획득 = false;
    bool 술집정보2획득 = false;
    bool 술집정보3획득 = false;
    bool 술집정보4획득 = false;
    bool 술집정보5획득 = false;
    bool 술집정보6획득 = false;

    bool 빈민가정보1획득 = false;
    bool 빈민가정보2획득 = false;
    bool 빈민가정보3획득 = false;
    bool 빈민가정보4획득 = false;
    bool 빈민가정보5획득 = false;
    bool 빈민가정보6획득 = false;

    bool 경찰서정보1획득 = false;
    bool 경찰서정보2획득 = false;
    bool 경찰서정보3획득 = false;
    bool 경찰서정보4획득 = false;
    bool 경찰서정보5획득 = false;
    bool 경찰서정보6획득 = false;

    bool 총포상정보1획득 = false;
    bool 총포상정보2획득 = false;
    bool 총포상정보3획득 = false;
    bool 총포상정보4획득 = false;
    bool 총포상정보5획득 = false;
    bool 총포상정보6획득 = false;

    bool 하수정비사무소정보1획득 = false;
    bool 하수정비사무소정보2획득 = false;
    bool 하수정비사무소정보3획득 = false;
    bool 하수정비사무소정보4획득 = false;
    bool 하수정비사무소정보5획득 = false;
    bool 하수정비사무소정보6획득 = false;
    //정보컨텐츠


    public GameObject 탐정사무소정보컨텐츠;
    public GameObject 병원정보컨텐츠;
    public GameObject 신문사정보컨텐츠;
    public GameObject 의뢰자의집정보컨텐츠;
    public GameObject 아컴역정보컨텐츠;
    public GameObject 식당정보컨텐츠;

    public GameObject 대학정보컨텐츠;
    public GameObject 강가정보컨텐츠;
    public GameObject 술집정보컨텐츠;
    public GameObject 빈민가정보컨텐츠;
    public GameObject 경찰서정보컨텐츠;
    public GameObject 총포상정보컨텐츠;
    public GameObject 하수정비사무소정보컨텐츠;


    public static int 정보획득량;

    string 선택정보이름;

    public Text 페이지텍스트;

    public void 탐정사무소정보창켜기()
    {

        선택정보이름 = "탐정사무소";



        if (DataBaseManager.탐정사무소정보1 == true && 탐정사무소정보1획득 == false)
        {
            탐정사무소정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<탐정사무소 정보1>";
            clone.transform.SetParent(탐정사무소정보컨텐츠.transform);


        }
        if (DataBaseManager.탐정사무소정보2 == true && 탐정사무소정보2획득 == false)
        {
            탐정사무소정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<탐정사무소 정보2>";
            clone.transform.SetParent(탐정사무소정보컨텐츠.transform);


        }
        if (DataBaseManager.탐정사무소정보3 == true && 탐정사무소정보3획득 == false)
        {
            탐정사무소정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<탐정사무소 정보3>";
            clone.transform.SetParent(탐정사무소정보컨텐츠.transform);


        }
        if (DataBaseManager.탐정사무소정보4 == true && 탐정사무소정보4획득 == false)
        {
            탐정사무소정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<탐정사무소 정보4>";
            clone.transform.SetParent(탐정사무소정보컨텐츠.transform);


        }
        if (DataBaseManager.탐정사무소정보5 == true && 탐정사무소정보5획득 == false)
        {
            탐정사무소정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<탐정사무소 정보5>";
            clone.transform.SetParent(탐정사무소정보컨텐츠.transform);


        }
        if (DataBaseManager.탐정사무소정보6 == true && 탐정사무소정보6획득 == false)
        {
            탐정사무소정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<탐정사무소 정보6>";
            clone.transform.SetParent(탐정사무소정보컨텐츠.transform);


        }

        정보획득량 = 탐정사무소정보컨텐츠.transform.childCount;
        초기화함수(탐정사무소정보컨텐츠);

        if (DataBaseManager.탐정사무소현재페이지 == 3)
        {
            페이지텍스트.text = "< 3 >";
            Transform trChild4 = 탐정사무소정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 탐정사무소정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.탐정사무소현재페이지 == 2)
        {
            페이지텍스트.text = "< 2 >";
            Transform trChild2 = 탐정사무소정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 탐정사무소정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.탐정사무소현재페이지 == 1)
        {
            페이지텍스트.text = "< 1 >";
            Transform trChild0 = 탐정사무소정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 탐정사무소정보컨텐츠.transform.GetChild(1);
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
    public void 병원정보창켜기()
    {

        선택정보이름 = "병원";



        if (DataBaseManager.병원정보1 == true && 병원정보1획득 == false)
        {
            병원정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<병원 정보1>";
            clone.transform.SetParent(병원정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.병원정보2 == true && 병원정보2획득 == false)
        {
            병원정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<병원 정보2>";
            clone.transform.SetParent(병원정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.병원정보3 == true && 병원정보3획득 == false)
        {
            병원정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<병원 정보3>";
            clone.transform.SetParent(병원정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.병원정보4 == true && 병원정보4획득 == false)
        {
            병원정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<병원 정보4>";
            clone.transform.SetParent(병원정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.병원정보5 == true && 병원정보5획득 == false)
        {
            병원정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<병원 정보5>";
            clone.transform.SetParent(병원정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.병원정보6 == true && 병원정보6획득 == false)
        {
            병원정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<병원 정보6>";
            clone.transform.SetParent(병원정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }



        초기화함수(병원정보컨텐츠);

        정보획득량 = 병원정보컨텐츠.transform.childCount;


        if (DataBaseManager.병원현재페이지 == 3)
        {
            Transform trChild4 = 병원정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 병원정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.병원현재페이지 == 2)
        {
            Transform trChild2 = 병원정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 병원정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.병원현재페이지 == 1)
        {
            Transform trChild0 = 병원정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 병원정보컨텐츠.transform.GetChild(1);
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
    public void 신문사정보창켜기()
    {

        선택정보이름 = "신문사";



        if (DataBaseManager.신문사정보1 == true && 신문사정보1획득 == false)
        {
            신문사정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<신문사 정보1>";
            clone.transform.SetParent(신문사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.신문사정보2 == true && 신문사정보2획득 == false)
        {
            신문사정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<신문사 정보2>";
            clone.transform.SetParent(신문사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.신문사정보3 == true && 신문사정보3획득 == false)
        {
            신문사정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<신문사 정보3>";
            clone.transform.SetParent(신문사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.신문사정보4 == true && 신문사정보4획득 == false)
        {
            신문사정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<신문사 정보4>";
            clone.transform.SetParent(신문사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.신문사정보5 == true && 신문사정보5획득 == false)
        {
            신문사정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<신문사 정보5>";
            clone.transform.SetParent(신문사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.신문사정보6 == true && 신문사정보6획득 == false)
        {
            신문사정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<신문사 정보6>";
            clone.transform.SetParent(신문사정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }




        정보획득량 = 신문사정보컨텐츠.transform.childCount;
        초기화함수(신문사정보컨텐츠);

        if (DataBaseManager.신문사현재페이지 == 3)
        {
            Transform trChild4 = 신문사정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 신문사정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.신문사현재페이지 == 2)
        {
            Transform trChild2 = 신문사정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 신문사정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.신문사현재페이지 == 1)
        {
            Transform trChild0 = 신문사정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 신문사정보컨텐츠.transform.GetChild(1);
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
    public void 의뢰자의집정보창켜기()
    {

        선택정보이름 = "의뢰자의집";



        if (DataBaseManager.의뢰자의집정보1 == true && 의뢰자의집정보1획득 == false)
        {
            의뢰자의집정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<의뢰자의집 정보1>";
            clone.transform.SetParent(의뢰자의집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.의뢰자의집정보2 == true && 의뢰자의집정보2획득 == false)
        {
            의뢰자의집정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<의뢰자의집 정보2>";
            clone.transform.SetParent(의뢰자의집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.의뢰자의집정보3 == true && 의뢰자의집정보3획득 == false)
        {
            의뢰자의집정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<의뢰자의집 정보3>";
            clone.transform.SetParent(의뢰자의집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.의뢰자의집정보4 == true && 의뢰자의집정보4획득 == false)
        {
            의뢰자의집정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<의뢰자의집 정보4>";
            clone.transform.SetParent(의뢰자의집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.의뢰자의집정보5 == true && 의뢰자의집정보5획득 == false)
        {
            의뢰자의집정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<의뢰자의집 정보5>";
            clone.transform.SetParent(의뢰자의집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }
        if (DataBaseManager.의뢰자의집정보6 == true && 의뢰자의집정보6획득 == false)
        {
            의뢰자의집정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<의뢰자의집 정보6>";
            clone.transform.SetParent(의뢰자의집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);


        }

        정보획득량 = 의뢰자의집정보컨텐츠.transform.childCount;
        초기화함수(의뢰자의집정보컨텐츠);

        if (DataBaseManager.의뢰자의집현재페이지 == 3)
        {
            Transform trChild4 = 의뢰자의집정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 의뢰자의집정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.의뢰자의집현재페이지 == 2)
        {
            Transform trChild2 = 의뢰자의집정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 의뢰자의집정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.의뢰자의집현재페이지 == 1)
        {
            Transform trChild0 = 의뢰자의집정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 의뢰자의집정보컨텐츠.transform.GetChild(1);
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
    public void 아컴역정보창켜기()
    {

        선택정보이름 = "아컴역";



        if (DataBaseManager.아컴역정보1 == true && 아컴역정보1획득 == false)
        {
            아컴역정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<아컴역 정보1>";
            clone.transform.SetParent(아컴역정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.아컴역정보2 == true && 아컴역정보2획득 == false)
        {
            아컴역정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<아컴역 정보2>";
            clone.transform.SetParent(아컴역정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.아컴역정보3 == true && 아컴역정보3획득 == false)
        {
            아컴역정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<아컴역 정보3>";
            clone.transform.SetParent(아컴역정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.아컴역정보4 == true && 아컴역정보4획득 == false)
        {
            아컴역정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<아컴역 정보4>";
            clone.transform.SetParent(아컴역정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.아컴역정보5 == true && 아컴역정보5획득 == false)
        {
            아컴역정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<아컴역 정보5>";
            clone.transform.SetParent(아컴역정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.아컴역정보6 == true && 아컴역정보6획득 == false)
        {
            아컴역정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<아컴역 정보6>";
            clone.transform.SetParent(아컴역정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        정보획득량 = 아컴역정보컨텐츠.transform.childCount;
        초기화함수(아컴역정보컨텐츠);

        if (DataBaseManager.아컴역현재페이지 == 3)
        {
            Transform trChild4 = 아컴역정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 아컴역정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.아컴역현재페이지 == 2)
        {
            Transform trChild2 = 아컴역정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 아컴역정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.아컴역현재페이지 == 1)
        {
            Transform trChild0 = 아컴역정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 아컴역정보컨텐츠.transform.GetChild(1);
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
    public void 식당정보창켜기()
    {

        선택정보이름 = "식당";



        if (DataBaseManager.식당정보1 == true && 식당정보1획득 == false)
        {
            식당정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<식당 정보1>";
            clone.transform.SetParent(식당정보컨텐츠.transform);
        }
        if (DataBaseManager.식당정보2 == true && 식당정보2획득 == false)
        {
            식당정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<식당 정보2>";
            clone.transform.SetParent(식당정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        if (DataBaseManager.식당정보3 == true && 식당정보3획득 == false)
        {
            식당정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<식당 정보3>";
            clone.transform.SetParent(식당정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.식당정보4 == true && 식당정보4획득 == false)
        {
            식당정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<식당 정보4>";
            clone.transform.SetParent(식당정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.식당정보5 == true && 식당정보5획득 == false)
        {
            식당정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<식당 정보5>";
            clone.transform.SetParent(식당정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.식당정보6 == true && 식당정보6획득 == false)
        {
            식당정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<식당 정보6>";

            clone.transform.SetParent(식당정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        정보획득량 = 식당정보컨텐츠.transform.childCount;
        초기화함수(식당정보컨텐츠);

        if (DataBaseManager.식당현재페이지 == 3)
        {
            Transform trChild4 = 식당정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 식당정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.식당현재페이지 == 2)
        {
            Transform trChild2 = 식당정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 식당정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.식당현재페이지 == 1)
        {
            Transform trChild0 = 식당정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 식당정보컨텐츠.transform.GetChild(1);
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
    public void 대학정보창켜기()
    {

        선택정보이름 = "대학";



        if (DataBaseManager.대학정보1 == true && 대학정보1획득 == false)
        {
            대학정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<대학 정보1>";
            clone.transform.SetParent(대학정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.대학정보2 == true && 대학정보2획득 == false)
        {
            대학정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<대학 정보2>";
            clone.transform.SetParent(대학정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.대학정보3 == true && 대학정보3획득 == false)
        {
            대학정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<대학 정보3>";
            clone.transform.SetParent(대학정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.대학정보4 == true && 대학정보4획득 == false)
        {
            대학정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<대학 정보4>";
            clone.transform.SetParent(대학정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.대학정보5 == true && 대학정보5획득 == false)
        {
            대학정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<대학 정보5>";
            clone.transform.SetParent(대학정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.대학정보6 == true && 대학정보6획득 == false)
        {
            대학정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<대학 정보6>";
            clone.transform.SetParent(대학정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }


        정보획득량 = 대학정보컨텐츠.transform.childCount;
        초기화함수(대학정보컨텐츠);

        if (DataBaseManager.대학현재페이지 == 3)
        {
            Transform trChild4 = 대학정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 대학정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.대학현재페이지 == 2)
        {
            Transform trChild2 = 대학정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 대학정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.대학현재페이지 == 1)
        {
            Transform trChild0 = 대학정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 대학정보컨텐츠.transform.GetChild(1);
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
    public void 강가정보창켜기()
    {

        선택정보이름 = "강가";



        if (DataBaseManager.강가정보1 == true && 강가정보1획득 == false)
        {
            강가정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강가 정보1>";
            clone.transform.SetParent(강가정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강가정보2 == true && 강가정보2획득 == false)
        {
            강가정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강가 정보2>";
            clone.transform.SetParent(강가정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강가정보3 == true && 강가정보3획득 == false)
        {
            강가정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강가 정보3>";
            clone.transform.SetParent(강가정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강가정보4 == true && 강가정보4획득 == false)
        {
            강가정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강가 정보4>";
            clone.transform.SetParent(강가정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강가정보5 == true && 강가정보5획득 == false)
        {
            강가정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강가 정보5>";
            clone.transform.SetParent(강가정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.강가정보6 == true && 강가정보6획득 == false)
        {
            강가정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<강가 정보6>";
            clone.transform.SetParent(강가정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }





        정보획득량 = 강가정보컨텐츠.transform.childCount;
        초기화함수(강가정보컨텐츠);

        if (DataBaseManager.강가현재페이지 == 3)
        {
            Transform trChild4 = 강가정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 강가정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.강가현재페이지 == 2)
        {
            Transform trChild2 = 강가정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 강가정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.강가현재페이지 == 1)
        {
            Transform trChild0 = 강가정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 강가정보컨텐츠.transform.GetChild(1);
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
    public void 술집정보창켜기()
    {

        선택정보이름 = "술집";



        if (DataBaseManager.술집정보1 == true && 술집정보1획득 == false)
        {
            술집정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집 정보1>";
            clone.transform.SetParent(술집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.술집정보2 == true && 술집정보2획득 == false)
        {
            술집정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집 정보2>";
            clone.transform.SetParent(술집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.술집정보3 == true && 술집정보3획득 == false)
        {
            술집정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집 정보3>";
            clone.transform.SetParent(술집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.술집정보4 == true && 술집정보4획득 == false)
        {
            술집정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집 정보4>";
            clone.transform.SetParent(술집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.술집정보5 == true && 술집정보5획득 == false)
        {
            술집정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집 정보5>";
            clone.transform.SetParent(술집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }
        if (DataBaseManager.술집정보6 == true && 술집정보6획득 == false)
        {
            술집정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<술집 정보6>";
            clone.transform.SetParent(술집정보컨텐츠.transform);
            clone.transform.localScale = new Vector3(1, 1, 1);
        }

        정보획득량 = 술집정보컨텐츠.transform.childCount;
        초기화함수(술집정보컨텐츠);

        if (DataBaseManager.술집현재페이지 == 3)
        {
            Transform trChild4 = 술집정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 술집정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.술집현재페이지 == 2)
        {
            Transform trChild2 = 술집정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 술집정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.술집현재페이지 == 1)
        {
            Transform trChild0 = 술집정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 술집정보컨텐츠.transform.GetChild(1);
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
    public void 빈민가정보창켜기()
    {

        선택정보이름 = "빈민가";



        if (DataBaseManager.빈민가정보1 == true && 빈민가정보1획득 == false)
        {
            빈민가정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<빈민가 정보1>";
            clone.transform.SetParent(빈민가정보컨텐츠.transform);
        }
        if (DataBaseManager.빈민가정보2 == true && 빈민가정보2획득 == false)
        {
            빈민가정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<빈민가 정보2>";
            clone.transform.SetParent(빈민가정보컨텐츠.transform);
        }
        if (DataBaseManager.빈민가정보3 == true && 빈민가정보3획득 == false)
        {
            빈민가정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<빈민가 정보3>";
            clone.transform.SetParent(빈민가정보컨텐츠.transform);
        }
        if (DataBaseManager.빈민가정보4 == true && 빈민가정보4획득 == false)
        {
            빈민가정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<빈민가 정보4>";
            clone.transform.SetParent(빈민가정보컨텐츠.transform);
        }
        if (DataBaseManager.빈민가정보5 == true && 빈민가정보5획득 == false)
        {
            빈민가정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<빈민가 정보5>";
            clone.transform.SetParent(빈민가정보컨텐츠.transform);
        }
        if (DataBaseManager.빈민가정보6 == true && 빈민가정보6획득 == false)
        {
            빈민가정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<빈민가 정보6>";
            clone.transform.SetParent(빈민가정보컨텐츠.transform);
        }

        정보획득량 = 빈민가정보컨텐츠.transform.childCount;
        초기화함수(빈민가정보컨텐츠);

        if (DataBaseManager.빈민가현재페이지 == 3)
        {
            Transform trChild4 = 빈민가정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 빈민가정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.빈민가현재페이지 == 2)
        {
            Transform trChild2 = 빈민가정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 빈민가정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.빈민가현재페이지 == 1)
        {
            Transform trChild0 = 빈민가정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 빈민가정보컨텐츠.transform.GetChild(1);
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
    public void 경찰서정보창켜기()
    {

        선택정보이름 = "경찰서";



        if (DataBaseManager.경찰서정보1 == true && 경찰서정보1획득 == false)
        {
            경찰서정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<경찰서 정보1>";
            clone.transform.SetParent(경찰서정보컨텐츠.transform);
        }
        if (DataBaseManager.경찰서정보2 == true && 경찰서정보2획득 == false)
        {
            경찰서정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<경찰서 정보2>";
            clone.transform.SetParent(경찰서정보컨텐츠.transform);
        }
        if (DataBaseManager.경찰서정보3 == true && 경찰서정보3획득 == false)
        {
            경찰서정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<경찰서 정보3>";
            clone.transform.SetParent(경찰서정보컨텐츠.transform);
        }
        if (DataBaseManager.경찰서정보4 == true && 경찰서정보4획득 == false)
        {
            경찰서정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<경찰서 정보4>";
            clone.transform.SetParent(경찰서정보컨텐츠.transform);
        }
        if (DataBaseManager.경찰서정보5 == true && 경찰서정보5획득 == false)
        {
            경찰서정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<경찰서 정보5>";
            clone.transform.SetParent(경찰서정보컨텐츠.transform);
 
        }
        if (DataBaseManager.경찰서정보6 == true && 경찰서정보6획득 == false)
        {
            경찰서정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<경찰서 정보6>";
            clone.transform.SetParent(경찰서정보컨텐츠.transform);
        }

        정보획득량 = 경찰서정보컨텐츠.transform.childCount;
        초기화함수(경찰서정보컨텐츠);

        if (DataBaseManager.경찰서현재페이지 == 3)
        {
            Transform trChild4 = 경찰서정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 경찰서정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.경찰서현재페이지 == 2)
        {
            Transform trChild2 = 경찰서정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 경찰서정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.경찰서현재페이지 == 1)
        {
            Transform trChild0 = 경찰서정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 경찰서정보컨텐츠.transform.GetChild(1);
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

    public void 총포상정보창켜기()
    {

        선택정보이름 = "총포상";



        if (DataBaseManager.총포상정보1 == true && 총포상정보1획득 == false)
        {
            총포상정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<총포상 정보1>";
            clone.transform.SetParent(총포상정보컨텐츠.transform);
        }
        if (DataBaseManager.총포상정보2 == true && 총포상정보2획득 == false)
        {
            총포상정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<총포상 정보2>";
            clone.transform.SetParent(총포상정보컨텐츠.transform);
        }
        if (DataBaseManager.총포상정보3 == true && 총포상정보3획득 == false)
        {
            총포상정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<총포상 정보3>";
            clone.transform.SetParent(총포상정보컨텐츠.transform);
        }
        if (DataBaseManager.총포상정보4 == true && 총포상정보4획득 == false)
        {
            총포상정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<총포상 정보4>";
            clone.transform.SetParent(총포상정보컨텐츠.transform);
        }
        if (DataBaseManager.총포상정보5 == true && 총포상정보5획득 == false)
        {
            총포상정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<총포상 정보5>";
            clone.transform.SetParent(총포상정보컨텐츠.transform);

        }
        if (DataBaseManager.총포상정보6 == true && 총포상정보6획득 == false)
        {
            총포상정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<총포상 정보6>";
            clone.transform.SetParent(총포상정보컨텐츠.transform);
        }
        정보획득량 = 총포상정보컨텐츠.transform.childCount;
        초기화함수(총포상정보컨텐츠);

        if (DataBaseManager.총포상현재페이지 == 3)
        {
            Transform trChild4 = 총포상정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 총포상정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.총포상현재페이지 == 2)
        {
            Transform trChild2 = 총포상정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 총포상정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.총포상현재페이지 == 1)
        {
            Transform trChild0 = 총포상정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 총포상정보컨텐츠.transform.GetChild(1);
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

    public void 하수정비사무소정보창켜기()
    {

        선택정보이름 = "하수정비사무소";



        if (DataBaseManager.하수정비사무소정보1 == true && 하수정비사무소정보1획득 == false)
        {
            하수정비사무소정보1획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소 정보1>";
            clone.transform.SetParent(하수정비사무소정보컨텐츠.transform);
        }
        if (DataBaseManager.하수정비사무소정보2 == true && 하수정비사무소정보2획득 == false)
        {
            하수정비사무소정보2획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소 정보2>";
            clone.transform.SetParent(하수정비사무소정보컨텐츠.transform);
        }
        if (DataBaseManager.하수정비사무소정보3 == true && 하수정비사무소정보3획득 == false)
        {
            하수정비사무소정보3획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소 정보3>";
            clone.transform.SetParent(하수정비사무소정보컨텐츠.transform);
        }
        if (DataBaseManager.하수정비사무소정보4 == true && 하수정비사무소정보4획득 == false)
        {
            하수정비사무소정보4획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소 정보4>";
            clone.transform.SetParent(하수정비사무소정보컨텐츠.transform);
        }
        if (DataBaseManager.하수정비사무소정보5 == true && 하수정비사무소정보5획득 == false)
        {
            하수정비사무소정보5획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소 정보5>";
            clone.transform.SetParent(하수정비사무소정보컨텐츠.transform);
        }
        if (DataBaseManager.하수정비사무소정보6 == true && 하수정비사무소정보6획득 == false)
        {
            하수정비사무소정보6획득 = true;
            var clone = Instantiate(정보프리팹);
            clone.GetComponent<Text>().text = "<하수정비사무소 정보6>";
            clone.transform.SetParent(하수정비사무소정보컨텐츠.transform);
        }

        정보획득량 = 하수정비사무소정보컨텐츠.transform.childCount;
        초기화함수(하수정비사무소정보컨텐츠);

        if (DataBaseManager.하수정비사무소현재페이지 == 3)
        {
            Transform trChild4 = 하수정비사무소정보컨텐츠.transform.GetChild(4);
            trChild4.gameObject.SetActive(true);


            if (정보획득량 >= 6)
            {
                Transform trChild5 = 하수정비사무소정보컨텐츠.transform.GetChild(5);
                trChild5.gameObject.SetActive(true);
            }
            페이지넘기기버튼.SetActive(false);
            되돌리기버튼.SetActive(true);
        }



        if (DataBaseManager.하수정비사무소현재페이지 == 2)
        {
            Transform trChild2 = 하수정비사무소정보컨텐츠.transform.GetChild(2);
            trChild2.gameObject.SetActive(true);
            if (정보획득량 >= 4)
            {
                Transform trChild3 = 하수정비사무소정보컨텐츠.transform.GetChild(3);
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

        if (DataBaseManager.하수정비사무소현재페이지 == 1)
        {
            Transform trChild0 = 하수정비사무소정보컨텐츠.transform.GetChild(0);
            trChild0.gameObject.SetActive(true);


            if (정보획득량 >= 2)
            {
                Transform trChild1 = 하수정비사무소정보컨텐츠.transform.GetChild(1);
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
        if (선택정보이름 == "탐정사무소")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.탐정사무소현재페이지, 탐정사무소정보컨텐츠);
        }

        if (선택정보이름 == "병원")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.병원현재페이지, 병원정보컨텐츠);
        }
        if (선택정보이름 == "신문사")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.신문사현재페이지, 신문사정보컨텐츠);
        }
        if (선택정보이름 == "의뢰자의집")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.의뢰자의집현재페이지, 의뢰자의집정보컨텐츠);
        }
        if (선택정보이름 == "아컴역")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.아컴역현재페이지, 아컴역정보컨텐츠);
        }
        if (선택정보이름 == "식당")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.식당현재페이지, 식당정보컨텐츠);
        }


        if (선택정보이름 == "대학")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.대학현재페이지, 대학정보컨텐츠);
        }
        if (선택정보이름 == "강가")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.강가현재페이지, 강가정보컨텐츠);
        }
        if (선택정보이름 == "술집")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.술집현재페이지, 술집정보컨텐츠);
        }
        if (선택정보이름 == "빈민가")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.빈민가현재페이지, 빈민가정보컨텐츠);
        }
        if (선택정보이름 == "경찰서")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.경찰서현재페이지, 경찰서정보컨텐츠);
        }
        if (선택정보이름 == "총포상")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.총포상현재페이지, 총포상정보컨텐츠);
        }
        if (선택정보이름 == "하수정비사무소")
        {

            페이지넘기기함수(정보획득량, DataBaseManager.하수정비사무소현재페이지, 하수정비사무소정보컨텐츠);
        }
    }
    public void 페이지되돌리기()
    {
        if (선택정보이름 == "탐정사무소")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.탐정사무소현재페이지, 탐정사무소정보컨텐츠);
        }

        if (선택정보이름 == "병원")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.병원현재페이지, 병원정보컨텐츠);
        }
        if (선택정보이름 == "신문사")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.신문사현재페이지, 신문사정보컨텐츠);
        }
        if (선택정보이름 == "의뢰자의집")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.의뢰자의집현재페이지, 의뢰자의집정보컨텐츠);
        }
        if (선택정보이름 == "아컴역")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.아컴역현재페이지, 아컴역정보컨텐츠);
        }
        if (선택정보이름 == "식당")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.식당현재페이지, 식당정보컨텐츠);
        }


        if (선택정보이름 == "대학")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.대학현재페이지, 대학정보컨텐츠);
        }
        if (선택정보이름 == "강가")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.강가현재페이지, 강가정보컨텐츠);
        }
        if (선택정보이름 == "술집")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.술집현재페이지, 술집정보컨텐츠);
        }
        if (선택정보이름 == "빈민가")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.빈민가현재페이지, 빈민가정보컨텐츠);
        }
        if (선택정보이름 == "경찰서")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.경찰서현재페이지, 경찰서정보컨텐츠);
        }
        if (선택정보이름 == "총포상")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.총포상현재페이지, 총포상정보컨텐츠);
        }
        if (선택정보이름 == "하수정비사무소")
        {

            페이지되돌리기함수(정보획득량, DataBaseManager.하수정비사무소현재페이지, 하수정비사무소정보컨텐츠);
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



            if (선택정보이름 == "탐정사무소")
            {
                DataBaseManager.탐정사무소현재페이지 = 2;
            }
            if (선택정보이름 == "병원")
            {
                DataBaseManager.병원현재페이지 = 2;
            }
            if (선택정보이름 == "신문사")
            {
                DataBaseManager.신문사현재페이지 = 2;
            }
            if (선택정보이름 == "의뢰자의집")
            {
                DataBaseManager.의뢰자의집현재페이지 = 2;
            }
            if (선택정보이름 == "아컴역")
            {
                DataBaseManager.아컴역현재페이지 = 2;
            }
            if (선택정보이름 == "식당")
            {
                DataBaseManager.식당현재페이지 = 2;
            }
            if (선택정보이름 == "대학")
            {
                DataBaseManager.대학현재페이지 = 2;
            }
            if (선택정보이름 == "강가")
            {
                DataBaseManager.강가현재페이지 = 2;
            }
            if (선택정보이름 == "술집")
            {
                DataBaseManager.술집현재페이지 = 2;
            }
            if (선택정보이름 == "빈민가")
            {
                DataBaseManager.빈민가현재페이지 = 2;
            }
            if (선택정보이름 == "경찰서")
            {
                DataBaseManager.경찰서현재페이지 = 2;
            }
            if (선택정보이름 == "총포상")
            {
                DataBaseManager.총포상현재페이지 = 2;
            }
            if (선택정보이름 == "하수정비사무소")
            {
                DataBaseManager.하수정비사무소현재페이지 = 2;
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

            if (선택정보이름 == "탐정사무소")
            {
                DataBaseManager.탐정사무소현재페이지 = 3;
            }
            if (선택정보이름 == "병원")
            {
                DataBaseManager.병원현재페이지 = 3;
            }
            if (선택정보이름 == "신문사")
            {
                DataBaseManager.신문사현재페이지 = 3;
            }
            if (선택정보이름 == "의뢰자의집")
            {
                DataBaseManager.의뢰자의집현재페이지 = 3;
            }
            if (선택정보이름 == "아컴역")
            {
                DataBaseManager.아컴역현재페이지 = 3;
            }
            if (선택정보이름 == "식당")
            {
                DataBaseManager.식당현재페이지 = 3;
            }
            if (선택정보이름 == "대학")
            {
                DataBaseManager.대학현재페이지 = 3;
            }
            if (선택정보이름 == "강가")
            {
                DataBaseManager.강가현재페이지 = 3;
            }
            if (선택정보이름 == "술집")
            {
                DataBaseManager.술집현재페이지 = 3;
            }
            if (선택정보이름 == "빈민가")
            {
                DataBaseManager.빈민가현재페이지 = 3;
            }
            if (선택정보이름 == "경찰서")
            {
                DataBaseManager.경찰서현재페이지 = 3;
            }
            if (선택정보이름 == "총포상")
            {
                DataBaseManager.총포상현재페이지 = 3;
            }
            if (선택정보이름 == "하수정비사무소")
            {
                DataBaseManager.하수정비사무소현재페이지 = 3;
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






            if (선택정보이름 == "탐정사무소")
            {
                DataBaseManager.탐정사무소현재페이지 = 1;
            }
            if (선택정보이름 == "병원")
            {
                DataBaseManager.병원현재페이지 = 1;
            }
            if (선택정보이름 == "신문사")
            {
                DataBaseManager.신문사현재페이지 = 1;
            }
            if (선택정보이름 == "의뢰자의집")
            {
                DataBaseManager.의뢰자의집현재페이지 = 1;
            }
            if (선택정보이름 == "아컴역")
            {
                DataBaseManager.아컴역현재페이지 = 1;
            }
            if (선택정보이름 == "식당")
            {
                DataBaseManager.식당현재페이지 = 1;
            }
            if (선택정보이름 == "대학")
            {
                DataBaseManager.대학현재페이지 = 1;
            }
            if (선택정보이름 == "강가")
            {
                DataBaseManager.강가현재페이지 = 1;
            }
            if (선택정보이름 == "술집")
            {
                DataBaseManager.술집현재페이지 = 1;
            }
            if (선택정보이름 == "빈민가")
            {
                DataBaseManager.빈민가현재페이지 = 1;
            }
            if (선택정보이름 == "경찰서")
            {
                DataBaseManager.경찰서현재페이지 = 1;
            }
            if (선택정보이름 == "총포상")
            {
                DataBaseManager.총포상현재페이지 = 1;
            }
            if (선택정보이름 == "하수정비사무소")
            {
                DataBaseManager.하수정비사무소현재페이지 = 1;
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





            if (선택정보이름 == "탐정사무소")
            {
                DataBaseManager.탐정사무소현재페이지 = 2;
            }
            if (선택정보이름 == "병원")
            {
                DataBaseManager.병원현재페이지 = 2;
            }
            if (선택정보이름 == "신문사")
            {
                DataBaseManager.신문사현재페이지 = 2;
            }
            if (선택정보이름 == "의뢰자의집")
            {
                DataBaseManager.의뢰자의집현재페이지 = 2;
            }
            if (선택정보이름 == "아컴역")
            {
                DataBaseManager.아컴역현재페이지 = 2;
            }
            if (선택정보이름 == "식당")
            {
                DataBaseManager.식당현재페이지 = 2;
            }
            if (선택정보이름 == "대학")
            {
                DataBaseManager.대학현재페이지 = 2;
            }
            if (선택정보이름 == "강가")
            {
                DataBaseManager.강가현재페이지 = 2;
            }
            if (선택정보이름 == "술집")
            {
                DataBaseManager.술집현재페이지 = 2;
            }
            if (선택정보이름 == "빈민가")
            {
                DataBaseManager.빈민가현재페이지 = 2;
            }
            if (선택정보이름 == "경찰서")
            {
                DataBaseManager.경찰서현재페이지 = 2;
            }
            if (선택정보이름 == "총포상")
            {
                DataBaseManager.총포상현재페이지 = 2;
            }
            if (선택정보이름 == "하수정비사무소")
            {
                DataBaseManager.하수정비사무소현재페이지 = 2;
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

        탐정사무소정보컨텐츠.SetActive(false);
        병원정보컨텐츠.SetActive(false);
        신문사정보컨텐츠.SetActive(false);
        의뢰자의집정보컨텐츠.SetActive(false);
        아컴역정보컨텐츠.SetActive(false);
        식당정보컨텐츠.SetActive(false);

        대학정보컨텐츠.SetActive(false);
        강가정보컨텐츠.SetActive(false);
        술집정보컨텐츠.SetActive(false);
        빈민가정보컨텐츠.SetActive(false);
        경찰서정보컨텐츠.SetActive(false);
        총포상정보컨텐츠.SetActive(false);
        하수정비사무소정보컨텐츠.SetActive(false);

        켤컨텐츠.SetActive(true);

    }
}
