using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 강가우측이동 : MonoBehaviour
{

    public Image 이동시커튼;
    public Image 이동시커튼2;
    public GameObject 이동시커튼오브;
    public GameObject 이동시커튼오브2;

    public Mins Player;


    public GameObject 카메라바디;
    public CameraManager 카메라;
    public SpriteRenderer 플레이어;
    public GameObject 플레이어바디;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if ( 우측이동인 == true && DataBaseManager.장면이동중 == false)
        {


            if (Input.GetKeyDown(KeyCode.W))
            {
                우측이동안내.SetActive(false);
                StartCoroutine(우좌이동());
            }


        }

        else if(우측이동인 == false)
        {

        }
    }

    public GameObject 우측이동안내;

    public bool 우측이동인 = false;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            우측이동안내.SetActive(false);
            우측이동인 = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {
            if (DataBaseManager.장면이동중 == false)
            {
                우측이동안내.SetActive(true);
            }

            우측이동인 = true;
        }

    }

    



    IEnumerator 우좌이동()
    {
        DataBaseManager.장면이동중 = true;
        이동시커튼오브.SetActive(true);
        이동시커튼.fillAmount = 0;
        이동시커튼2.fillAmount = 1;


        float 채커 = 0;
        카메라.카메라멈추기();

        Player.isDialogOnChangeT();

        for (int i =0; i < 40; i++)
        {
            채커 = 채커 + 0.03f;
            yield return new WaitForSeconds(0.01f);
            이동시커튼.fillAmount = 채커;
        }


        플레이어바디.transform.position = new Vector2(19.11f, -4.84f);
        카메라바디.transform.position = new Vector3(27f, -5.42f, -341.134f);



        이동시커튼오브.SetActive(false);
        이동시커튼오브2.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 40; i++)
        {
            채커 = 채커 - 0.03f;
            yield return new WaitForSeconds(0.01f);
            이동시커튼2.fillAmount = 채커;
        }
        이동시커튼오브2.SetActive(false);
        Player.isDialogOnChangeF();
        DataBaseManager.장면이동중 = false;
    }






}
