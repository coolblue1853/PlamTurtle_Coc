using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BillowUIManager : MonoBehaviour
{

    public Image 체력바;
    public Image 이성바;
    public PlayerStat 플레이어스탯생성기;



    public float 반영체력;
    public float  최초체력;
    public float 단위체력;


    public float 반영이성;
    public float 최초이성;
    public float 단위이성;

    // Start is called before the first frame update
    void Start()
    {
        반영체력 = 1;
           최초체력 = DataBaseManager.체력;
        단위체력 = 1 / 최초체력;


        반영이성 = 1;
        최초이성 = DataBaseManager.정신력;
        단위이성 = 1 / 최초이성;

    }



    // Update is called once per frame
    void Update()
    {
        체력바관리();
    }


    void 체력바관리()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            반영체력 = 반영체력 - 단위체력;

            체력바.fillAmount = 반영체력;




        }



        if (Input.GetKeyDown(KeyCode.E))
        {

            반영이성 = 반영이성 - 단위이성;

            이성바.color = new Color(1, 1, 1, 반영이성);


        }



    }
}
