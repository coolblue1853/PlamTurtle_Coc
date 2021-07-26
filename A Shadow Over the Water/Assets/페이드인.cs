using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 페이드인 : MonoBehaviour
{
    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;

    IEnumerator 페이드아웃코루틴()
    {
        float 페이드카운트 = 1;
        yield return new WaitForSeconds(3f);
        페이드이미지오브젝트.SetActive(true);

        while (페이드카운트 > 0)
        {
            페이드카운트 -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);
        }

        페이드이미지오브젝트.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(페이드아웃코루틴());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
