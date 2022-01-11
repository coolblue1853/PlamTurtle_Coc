using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 시간_배경매니저_ : MonoBehaviour
{
    public GameObject 배경판;

    public Sprite 아침이미지;
    public Sprite 점심이미지;
    public Sprite 저녁이미지;







    int 시간대;
    // Start is called before the first frame update
    void Start()
    {


        시간대 = DataBaseManager.시간대;

    }

    // Update is called once per frame
    void Update()
    {

        if ((DataBaseManager.시간대 % 4) == 1)   //아침
        {
            배경판.GetComponent<SpriteRenderer>().sprite = 아침이미지;

        }
        else if ((DataBaseManager.시간대 % 4) == 2)   //점심
        {
            배경판.GetComponent<SpriteRenderer>().sprite = 점심이미지;


        }
        else if ((DataBaseManager.시간대 % 4) == 3)   //저녁
        {
            배경판.GetComponent<SpriteRenderer>().sprite = 저녁이미지;

        }

    }
}
