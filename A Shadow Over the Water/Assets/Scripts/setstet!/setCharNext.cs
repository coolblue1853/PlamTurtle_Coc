using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCharNext : MonoBehaviour
{
    public GameObject 능력치;
    public GameObject 스킬;

    public GameObject 힘설명;
    public GameObject 지능설명;
    public GameObject 민첩설명;
    public GameObject 행운설명;

    public GameObject 활력설명;
    public GameObject 의지력설명;
    public GameObject 마력설명;
    public GameObject 체력설명;
    public GameObject 정신력설명;
    public GameObject 스트레스내성설명;




    // Start is called before the first frame update
    public void 힘설명등장()
    {
        힘설명.SetActive(true);


    }
    public void 힘설명가림()
    {
        힘설명.SetActive(false);
    }

    public void 지능설명가림()
    {
        지능설명.SetActive(false);
    }

    public void 지능설명등장()
    {
        지능설명.SetActive(true);


    }

    public void 민첩설명가림()
    {
        민첩설명.SetActive(false);
    }

    public void 민첩설명등장()
    {
        민첩설명.SetActive(true);


    }
    public void 행운설명가림()
    {
        행운설명.SetActive(false);
    }

    public void 행운설명등장()
    {
        행운설명.SetActive(true);
    }


    public void 활력설명가림()
    {
        활력설명.SetActive(false);
    }

    public void 활력설명등장()
    {
        활력설명.SetActive(true);
    }

    public void 의지력설명가림()
    {
        의지력설명.SetActive(false);
    }

    public void 의지력설명등장()
    {
        의지력설명.SetActive(true);
    }
    public void 마력설명가림()
    {
        마력설명.SetActive(false);
    }

    public void 마력설명등장()
    {
        마력설명.SetActive(true);
    }
    public void 체력설명가림()
    {
        체력설명.SetActive(false);
    }

    public void 체력설명등장()
    {
        체력설명.SetActive(true);
    }
    public void 정신력설명가림()
    {
        정신력설명.SetActive(false);
    }

    public void 정신력설명등장()
    {
        정신력설명.SetActive(true);
    }
    public void 스트레스내성설명가림()
    {
        스트레스내성설명.SetActive(false);
    }

    public void 스트레스내성설명등장()
    {
        스트레스내성설명.SetActive(true);
    }











    public void 능력치이후로()
    {
        능력치.SetActive(false);
        스킬.SetActive(true);
    }

    public void 스킬이전으로()
    {
        스킬.SetActive(false);
        능력치.SetActive(true);
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
