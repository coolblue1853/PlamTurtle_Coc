using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 상점구매매니저 : MonoBehaviour
{
    public Text 소지금;
    public GameObject 소형권총솔드아웃;
    public GameObject 리볼버솔드아웃;
    public GameObject 소총솔드아웃;
    public GameObject 샷건솔드아웃;
    public GameObject 몽둥이솔드아웃;
    public GameObject 단검솔드아웃;
    public GameObject 도끼솔드아웃;
    

    public GameObject 상점창;



    //
    //public GameObject 인벤토리소형권총오브젝트;
    //public GameObject 인벤토리리볼버오브젝트;
   // public GameObject 인벤토리소총오브젝트;
   // public GameObject 인벤토리샷건오브젝트;

    public GameObject 인벤토리소형권총;
    public GameObject 인벤토리리볼버;
    public GameObject 인벤토리소총;
    public GameObject 인벤토리샷건;

    public GameObject 인벤토리권총탄약;
    public GameObject 인벤토리리볼버탄약;
    public GameObject 인벤토리소총탄약;
    public GameObject 인벤토리샷건탄약;
    public GameObject 인벤토리몽둥이;
    public GameObject 인벤토리단검;
    public GameObject 인벤토리도끼;
    public GameObject 인벤토리화염병;
    //
    //public GameObject 인벤토리소형권총탄약오브젝트;
    //public GameObject 인벤토리리볼버탄약오브젝트;
    //public GameObject 인벤토리소총탄약오브젝트;
    //public GameObject 인벤토리샷건탄약오브젝트;

    //public GameObject 인벤토리소형권총탄약설명;
    //public GameObject 인벤토리리볼버탄약설명;
    //public GameObject 인벤토리소총탄약설명;
    //public GameObject 인벤토리샷건탄약설명;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        상점창업데이터();


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DataBaseManager.재력 += 10;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            상점창켜기();
        }
        보유탄약들();
    }

    void 상점창업데이터()
    {
        소지금.text = "소지 금액 : " + DataBaseManager.재력.ToString() + " $";
    }


    public void 소형권총구매()
    {
        if(DataBaseManager.재력 >=12 && DataBaseManager.소형권총구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 12;
            DataBaseManager.소형권총구매여부 = true;
            소형권총솔드아웃.SetActive(true);
            인벤토리소형권총.transform.SetAsFirstSibling();
            //인벤토리소형권총오브젝트.SetActive(true);
        }


    }

    public void 리볼버권총구매()
    {
        if (DataBaseManager.재력 >= 25 && DataBaseManager.리볼버구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 25;
            DataBaseManager.리볼버구매여부 = true;
            리볼버솔드아웃.SetActive(true);
            인벤토리리볼버.transform.SetAsFirstSibling();
            //인벤토리리볼버오브젝트.SetActive(true);
        }


    }

    public void 소총구매()
    {
        if (DataBaseManager.재력 >= 20 && DataBaseManager.소총구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 20;
            DataBaseManager.소총구매여부 = true;
            소총솔드아웃.SetActive(true);
            인벤토리소총.transform.SetAsFirstSibling();
            //인벤토리소총오브젝트.SetActive(true);
        }


    }
    public void 샷건구매()
    {
        if (DataBaseManager.재력 >= 30 && DataBaseManager.샷건구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 30;
            DataBaseManager.샷건구매여부 = true;
            샷건솔드아웃.SetActive(true);
            인벤토리샷건.transform.SetAsFirstSibling();
            //인벤토리샷건오브젝트.SetActive(true);
        }


    }

    public Text 보유권총탄약;
    public Text 보유리볼버탄약;
    public Text 보유소총탄약;
    public Text 보유샷건탄약;
    public Text 보유화염병;
    public void 권총탄약구매()
    {
        if (DataBaseManager.재력 >= 1)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 1;

            
            if(인벤토리권총탄약.activeSelf == false)
            {
                인벤토리권총탄약.transform.SetAsFirstSibling();
            }
            DataBaseManager.보유권총탄약 = DataBaseManager.보유권총탄약 + 10;
        }


    }
    public void 리볼버탄약구매()
    {
        if (DataBaseManager.재력 >= 3)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 3;


            if (인벤토리리볼버탄약.activeSelf == false)
            {
                인벤토리리볼버탄약.transform.SetAsFirstSibling();
            }
            DataBaseManager.보유리볼버탄약 = DataBaseManager.보유리볼버탄약 + 6;
        }


    }
    public void 소총탄약구매()
    {
        if (DataBaseManager.재력 >= 1)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 1;


            if (인벤토리소총탄약.activeSelf == false)
            {
                인벤토리소총탄약.transform.SetAsFirstSibling();
            }
            DataBaseManager.보유소총탄약 = DataBaseManager.보유소총탄약 + 5;
        }


    }
    public void 샷건탄약구매()
    {
        if (DataBaseManager.재력 >= 4)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 4;


            if (인벤토리샷건탄약.activeSelf == false)
            {
                인벤토리샷건탄약.transform.SetAsFirstSibling();
            }
            DataBaseManager.보유샷건탄약 = DataBaseManager.보유샷건탄약 + 8;
        }


    }

    public void 몽둥이구매()
    {
        if (DataBaseManager.재력 >= 3 && DataBaseManager.몽둥이구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 3;
            DataBaseManager.몽둥이구매여부 = true;
            몽둥이솔드아웃.SetActive(true);
            인벤토리몽둥이.transform.SetAsFirstSibling();
            //인벤토리샷건오브젝트.SetActive(true);
        }


    }
    public void 단검구매()
    {
        if (DataBaseManager.재력 >= 4 && DataBaseManager.단검구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 4;
            DataBaseManager.단검구매여부 = true;
            단검솔드아웃.SetActive(true);
            인벤토리단검.transform.SetAsFirstSibling();
            //인벤토리샷건오브젝트.SetActive(true);
        }


    }
    public void 도끼구매()
    {
        if (DataBaseManager.재력 >= 5 && DataBaseManager.도끼구매여부 == false)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 5;
            DataBaseManager.도끼구매여부 = true;
            도끼솔드아웃.SetActive(true);
            인벤토리도끼.transform.SetAsFirstSibling();
            //인벤토리샷건오브젝트.SetActive(true);
        }


    }

    public void 화염병구매()
    {
        if (DataBaseManager.재력 >= 5)
        {
            DataBaseManager.재력 = DataBaseManager.재력 - 5;


            if (인벤토리화염병.activeSelf == false)
            {
                인벤토리화염병.transform.SetAsFirstSibling();
            }
            DataBaseManager.화염병보유수 = DataBaseManager.화염병보유수 + 1;
        }


    }
    public void 보유탄약들()
    {
        보유권총탄약.text = "보유수 : " + DataBaseManager.보유권총탄약;
        보유리볼버탄약.text = "보유수 : " + DataBaseManager.보유리볼버탄약;

        보유소총탄약.text = "보유수 : " + DataBaseManager.보유소총탄약;
        보유샷건탄약.text = "보유수 : " + DataBaseManager.보유샷건탄약;
        보유화염병.text = "보유수 : " + DataBaseManager.화염병보유수;


    }

   // public 상점튜토리얼매니저 튜토;

    public void 상점창끄기()
    {
       // 튜토.삼번버튼();
        상점창.SetActive(false);
    }

    public void 상점창켜기()
    {
        상점창.SetActive(true);

        총기류창.SetActive(true);
        탄약류창.SetActive(false);
        도검류창.SetActive(false);
        투척류창.SetActive(false);
    }


    public GameObject 총기류창;
    public GameObject 탄약류창;
    public GameObject 도검류창;
    public GameObject 투척류창;

    public void 총기류창켜기버튼()
    {
        총기류창.SetActive(true);
        탄약류창.SetActive(false);
        도검류창.SetActive(false);
        투척류창.SetActive(false);
    }
    public void 탄약류류창켜기버튼()
    {
        총기류창.SetActive(false);
        탄약류창.SetActive(true);
        도검류창.SetActive(false);
        투척류창.SetActive(false);
    }
    public void 도검류창켜기버튼()
    {
        총기류창.SetActive(false);
        탄약류창.SetActive(false);
        도검류창.SetActive(true);
        투척류창.SetActive(false);
    }
    public void 투척류창켜기버튼()
    {
        총기류창.SetActive(false);
        탄약류창.SetActive(false);
        도검류창.SetActive(false);
        투척류창.SetActive(true);
    }

}
