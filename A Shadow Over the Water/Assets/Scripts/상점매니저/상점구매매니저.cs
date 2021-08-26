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
    public GameObject 상점창;



    //
    public GameObject 인벤토리소형권총오브젝트;
    public GameObject 인벤토리리볼버오브젝트;
    public GameObject 인벤토리소총오브젝트;
    public GameObject 인벤토리샷건오브젝트;

    public GameObject 인벤토리소형권총;
    public GameObject 인벤토리리볼버;
    public GameObject 인벤토리소총;
    public GameObject 인벤토리샷건;


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
            인벤토리소형권총오브젝트.SetActive(true);
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
            인벤토리리볼버오브젝트.SetActive(true);
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
            인벤토리소총오브젝트.SetActive(true);
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
            인벤토리샷건오브젝트.SetActive(true);
        }


    }



    public void 상점창끄기()
    {
        상점창.SetActive(false);
    }

    public void 상점창켜기()
    {
        상점창.SetActive(true);
    }
}
