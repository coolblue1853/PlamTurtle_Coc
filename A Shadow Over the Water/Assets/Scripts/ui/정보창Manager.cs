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

    public GameObject ui창;
    public GameObject 정보창;
    public GameObject 플로팅텍스트오브젝트;
    public GameObject 적플로팅위치;


    //사건
    public void 행성대직렬정보추가()
    {
        DataBaseManager.행성대직렬알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#B30000>(행성대직렬) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    public void 불면증정보추가()
    {
        DataBaseManager.불면증알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#B30000>(불면증) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    public void 악몽정보추가()
    {
        DataBaseManager.악몽알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#B30000>(악몽) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    //인물
    public void 엘라정보추가()
    {
        DataBaseManager.엘라알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#1A6800>(엘라 트리스) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    public void 에이든정보추가()
    {
        DataBaseManager.에이든알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#1A6800>(에이든 트리스) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }

    //장소
    public void 병원정보추가()
    {
        DataBaseManager.병원알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#0026A9>(병원) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    public void 아캄역정보추가()
    {
        DataBaseManager.아캄역알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#0026A9>(아컴역) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    public void 의뢰자의집정보추가()
    {
        DataBaseManager.의뢰자의집알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#0026A9>(의뢰자의 집) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }
    public void 신문사정보추가()
    {
        DataBaseManager.의뢰자의집알리미 = true;
        var clone = Instantiate(플로팅텍스트오브젝트, 적플로팅위치.transform.position, Quaternion.Euler(Vector3.zero));
        clone.GetComponent<정보플로팅>().Text.text = "<color=#0026A9>(데일리뉴스 신문사) </color>정보 획득".ToString();
        clone.transform.SetParent(ui창.transform);
    }

    public void 정보창끄기()
    {
        DataBaseManager.옵션창여부 = false;
        정보창.SetActive(false);
    }


    public GameObject 사건온;
    public GameObject 인물온;
    public GameObject 장소온;

    public void 인물창켜기()
    {
        인물온.SetActive(true);
        사건온.SetActive(false);
        장소온.SetActive(false);

        인물창.SetActive(true);
        사건창.SetActive(false);
        장소창.SetActive(false);
    }

    public void 사건창켜기()
    {
        인물온.SetActive(false);
        사건온.SetActive(true);
        장소온.SetActive(false);

        인물창.SetActive(false);
        사건창.SetActive(true);
        장소창.SetActive(false);
    }
    public void 장소창켜기()
    {
        인물온.SetActive(false);
        사건온.SetActive(false);
        장소온.SetActive(true);

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
