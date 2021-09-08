using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 화살표확대축소 : MonoBehaviour
{
    public GameObject 화살표;
    // Start is called before the first frame update
    void Start()
    {
        사이즈카운트 = 1;
        StartCoroutine(축소());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    float 사이즈카운트;

    IEnumerator 축소()
    {


        while (사이즈카운트 > 0.95)
        {
            사이즈카운트 -= 0.001f;
            yield return new WaitForSeconds(0.001f);
            화살표.transform.localScale = new Vector3(사이즈카운트, 사이즈카운트, 사이즈카운트);
        }

        StartCoroutine(확대());
    }

    IEnumerator 확대()
    {



        while (사이즈카운트 < 1.05f)
        {
            사이즈카운트 += 0.001f;
            yield return new WaitForSeconds(0.001f);
            화살표.transform.localScale = new Vector3(사이즈카운트, 사이즈카운트, 사이즈카운트);
        }
        StartCoroutine(축소());

    }
}
