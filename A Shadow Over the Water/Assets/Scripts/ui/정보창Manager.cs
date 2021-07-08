using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 정보창Manager : MonoBehaviour
{

    public GameObject 인물창켜는버튼;
    public GameObject 사건창켜는버튼;
    public GameObject 장소창켜는버튼;

    public GameObject 인물창;
    public GameObject 사건창;
    public GameObject 장소창;

    public GameObject 정보창;






    public void 정보창끄기()
    {
        정보창.SetActive(false);
    }

    public void 인물창켜기()
    {
        인물창.SetActive(true);
        사건창.SetActive(false);
        장소창.SetActive(false);
    }

    public void 사건창켜기()
    {
        인물창.SetActive(false);
        사건창.SetActive(true);
        장소창.SetActive(false);
    }
    public void 장소창켜기()
    {
        인물창.SetActive(false);
        사건창.SetActive(false);
        장소창.SetActive(true);
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
