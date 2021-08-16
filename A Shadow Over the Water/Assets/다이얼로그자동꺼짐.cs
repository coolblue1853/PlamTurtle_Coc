using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 다이얼로그자동꺼짐 : MonoBehaviour
{
    public GameObject 이름파트;
    public GameObject 내용;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (내용.activeSelf== false)
        {
            이름파트.SetActive(false);
        }
    }
}
