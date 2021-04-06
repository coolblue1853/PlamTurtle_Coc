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

    // Start is called before the first frame update
    public void 힘설명등장()
    {
        힘설명.SetActive(true);


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

    public void 힘설명가림()
    {
        힘설명.SetActive(false);
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
