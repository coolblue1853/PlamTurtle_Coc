using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 시간_배경매니저_강가 : MonoBehaviour
{
    public GameObject 밖배경판;
    public Sprite 아침이미지;
    public Sprite 점심이미지;
    public Sprite 저녁이미지;
    public Sprite 밤이미지;
    public GameObject 차배경판;
    public Sprite 아침이미지차;
    public Sprite 점심이미지차;
    public Sprite 저녁이미지차;
    public Sprite 밤이미지차;
    public GameObject 현관배경판;
    public Sprite 아침이미지현관;
    public Sprite 점심이미지현관;
    public Sprite 저녁이미지현관;
    public Sprite 밤이미지현관;


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
            밖배경판.GetComponent<SpriteRenderer>().sprite = 아침이미지;
            차배경판.GetComponent<SpriteRenderer>().sprite = 아침이미지차;

            현관배경판.GetComponent<SpriteRenderer>().sprite = 아침이미지현관;

        }
        else if ((시간대 % 4) == 2)   //점심
        {
            밖배경판.GetComponent<SpriteRenderer>().sprite = 점심이미지;
            차배경판.GetComponent<SpriteRenderer>().sprite = 점심이미지차;

            현관배경판.GetComponent<SpriteRenderer>().sprite = 점심이미지현관;


        }
        else if ((시간대 % 4) == 3)   //저녁
        {
            밖배경판.GetComponent<SpriteRenderer>().sprite = 저녁이미지;
            차배경판.GetComponent<SpriteRenderer>().sprite = 저녁이미지차;

            현관배경판.GetComponent<SpriteRenderer>().sprite = 저녁이미지현관;

        }
        else if ((시간대 % 4) == 0)   //밤
        {
            밖배경판.GetComponent<SpriteRenderer>().sprite = 밤이미지;
            차배경판.GetComponent<SpriteRenderer>().sprite = 밤이미지차;

            현관배경판.GetComponent<SpriteRenderer>().sprite = 밤이미지현관;

        }
    }
}
