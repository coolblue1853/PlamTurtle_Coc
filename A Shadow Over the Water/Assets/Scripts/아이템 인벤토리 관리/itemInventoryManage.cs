using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInventoryManage : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject 무기류배경칸;

    public GameObject 일반배경칸;
    public GameObject 열쇠;
    public GameObject 자동권총;
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "총")
        {
            일반배경칸.SetActive(false);
            무기류배경칸.SetActive(true);
            아이템설명초기회();
            자동권총.SetActive(true);
        }

        if (collision.name == "열쇠")
        {
            일반배경칸.SetActive(true);
            무기류배경칸.SetActive(false);
            아이템설명초기회();
            열쇠.SetActive(true);
        }
    }


    void 아이템설명초기회()
    {
        자동권총.SetActive(false);
        열쇠.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
