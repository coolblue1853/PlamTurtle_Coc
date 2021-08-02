using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mapManager : MonoBehaviour
{
    public GameObject 페이드이미지오브젝트;
    public Image 페이드이미지;

    public void 시간이동으로씬전환()
    {
        if(DataBaseManager.시간대 == 2)
        {
            DataBaseManager.시간대 = 3;
            SceneManager.LoadScene("01");
        }

    }

    public void 페이드아웃()
    {
        StartCoroutine(페이드아웃코루틴());
    }

    IEnumerator 페이드아웃코루틴()
    {
        페이드이미지오브젝트.SetActive(true);
        float 페이드카운트 = 0;
        while(페이드카운트 < 1.0f)
        {
            페이드카운트 += 0.01f;
            yield return new WaitForSeconds(0.01f);
            페이드이미지.color = new Color(0, 0, 0, 페이드카운트);


        }


        시간이동으로씬전환();
    }



    bool isPlaying = false;
    public GameObject 이동확인알람;
    public Text 이동확인텍스트;


    public void 대학버튼()
    {
        이동확인텍스트.text = "<대학>으로 이동 하시겠습니까?";
        이동확인알람.SetActive(true);
        DataBaseManager.이동지 = "대학";
    }

    public void 이동()
    {
        페이드아웃();

    }

    public void 이동아니오()
    {
        이동확인알람.SetActive(false);
        DataBaseManager.이동지 = "";
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
