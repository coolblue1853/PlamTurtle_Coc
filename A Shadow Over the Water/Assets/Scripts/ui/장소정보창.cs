using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 장소정보창 : MonoBehaviour
{
    public GameObject 탐정사무소;
    public GameObject 의뢰자의집;
    public GameObject 데일리뉴스신문사;
    public GameObject 병원;
    public GameObject 아캄역;


    public GameObject 병원1;
    public GameObject 아컴역1;
    public GameObject 신문사1;
    public GameObject 탐정사무소1;
    public GameObject 의뢰자의집1;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        //노아정보업데이트문();

        //임시로 확인용으로 넣어둔 파일, 추후 삭제


    }





    void 탐정사무소정보업데이트문()
    {
        if (DataBaseManager.탐정사무소정보1 == true)
        {
            탐정사무소1.SetActive(true);
        }
        else
        {
            탐정사무소1.SetActive(false);

        }
    }
    void 의뢰자의집정보업데이트문()
    {
        if (DataBaseManager.의뢰자의집정보1 == true)
        {
            의뢰자의집1.SetActive(true);
        }
        else
        {
            의뢰자의집1.SetActive(false);

        }
    }
    void 신문사정보업데이트문()
    {
        if (DataBaseManager.신문사정보1 == true)
        {
            신문사1.SetActive(true);
        }
        else
        {
            신문사1.SetActive(false);

        }
    }

    void 병원정보업데이트문()
    {
        if (DataBaseManager.병원정보1 == true)
        {
            병원1.SetActive(true);
        }
        else
        {
            병원1.SetActive(false);

        }
    }
    void 아컴역정보업데이트문()
    {
        if (DataBaseManager.아캄역정보1 == true)
        {
            아컴역1.SetActive(true);
        }
        else
        {
            아컴역1.SetActive(false);

        }
    }



    void 장소업데이터()
    {
        의뢰자의집정보업데이트문();
        탐정사무소정보업데이트문();
        신문사정보업데이트문();
        병원정보업데이트문();
        아컴역정보업데이트문();
    }


    public void 장소정보창초기화()
    {
        장소업데이터();
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(false);
        의뢰자의집.SetActive(false);
        병원.SetActive(false);
        아캄역.SetActive(false);
    }


    public void 탐정사무소정보표기()
    {
        장소업데이터();
        DataBaseManager.탐정사무소알리미 = false;
        탐정사무소.SetActive(true);
        데일리뉴스신문사.SetActive(false);
        의뢰자의집.SetActive(false);
        병원.SetActive(false);
        아캄역.SetActive(false);
    }

    public void 데일리뉴스신문사정보표기()
    {
        장소업데이터();
        DataBaseManager.신문사알리미 = false;
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(true);
        의뢰자의집.SetActive(false);
        병원.SetActive(false);
        아캄역.SetActive(false);
    }
    public void 의뢰자의집정보표기()
    {
        장소업데이터();
        DataBaseManager.의뢰자의집알리미 = false;
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(false);
        의뢰자의집.SetActive(true);
        병원.SetActive(false);
        아캄역.SetActive(false);
    }
    public void 병원정보표기()
    {
        장소업데이터();
        DataBaseManager.병원알리미 = false;
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(false);  
        의뢰자의집.SetActive(false);
        병원.SetActive(true);
        아캄역.SetActive(false);
    }

    public void 아캄역정보표기()
    {
        장소업데이터();
        DataBaseManager.아캄역알리미 = false;
        탐정사무소.SetActive(false);
        데일리뉴스신문사.SetActive(false);
        의뢰자의집.SetActive(false);
        병원.SetActive(false);
        아캄역.SetActive(true);
    }
}
