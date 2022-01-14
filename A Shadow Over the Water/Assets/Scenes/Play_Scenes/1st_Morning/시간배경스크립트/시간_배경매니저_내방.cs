using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 시간_배경매니저_내방 : MonoBehaviour
{
    public GameObject 배경판;

    public Sprite 아침이미지;
    public Sprite 점심이미지;
    public Sprite 저녁이미지;
    public Sprite 밤이미지;

    public GameObject 멜리사;
    public GameObject 신문;
    public GameObject 다이닝;
    public GameObject 소파1;
    public GameObject 소파2;
    public GameObject 책상1;
    public GameObject 책상2;
    public GameObject 테이블;

    public Sprite 다이닝아침;
    public Sprite 소파1아침;
    public Sprite 소파2아침;
    public Sprite 책상1아침;
    public Sprite 책상2아침;
    public Sprite 테이블아침;

    public Sprite 다이닝점심;
    public Sprite 소파1점심;
    public Sprite 소파2점심;
    public Sprite 책상1점심;
    public Sprite 책상2점심;
    public Sprite 테이블점심;

    public Sprite 다이닝저녁;
    public Sprite 소파1저녁;
    public Sprite 소파2저녁;
    public Sprite 책상1저녁;
    public Sprite 책상2저녁;
    public Sprite 테이블저녁;

    public Sprite 다이닝밤;
    public Sprite 소파1밤;
    public Sprite 소파2밤;
    public Sprite 책상1밤;
    public Sprite 책상2밤;
    public Sprite 테이블밤;




    int 시간대;
    // Start is called before the first frame update
    void Start()
    {


        시간대 = DataBaseManager.시간대;

    }

    // Update is called once per frame
    void Update()
    {


        if ((시간대 % 4) == 1)   //아침
        {
            배경판.GetComponent<SpriteRenderer>().sprite = 아침이미지;
        }
        else if ((시간대 % 4) == 2)   //점심
        {
            배경판.GetComponent<SpriteRenderer>().sprite = 점심이미지;
        }
        else if ((시간대 % 4) == 3)   //저녁
        {
            배경판.GetComponent<SpriteRenderer>().sprite = 저녁이미지;
        }
        else if ((시간대 % 4) == 0)   //밤
        {
            멜리사.SetActive(false);
            신문.SetActive(false);
            배경판.GetComponent<SpriteRenderer>().sprite = 밤이미지;
        }
    }
}
