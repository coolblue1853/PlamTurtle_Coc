using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 대학교연출 : MonoBehaviour
{
    public GameObject 대학생오브젝트;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(DataBaseManager.시간대 == 3)
        {
            대학생오브젝트.SetActive(false);
        }
        else
        {
            대학생오브젝트.SetActive(true);
        }
    }
}
