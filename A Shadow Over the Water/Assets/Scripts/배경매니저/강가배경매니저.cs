using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 강가배경매니저 : MonoBehaviour
{
    //좌측
    public Sprite 아침_좌측;
    public Sprite 점심_좌측;
    public Sprite 저녁_좌측;
    public Sprite 밤_좌측;


    //우측
    public Sprite 아침_우측;
    public Sprite 점심_우측;
    public Sprite 저녁_우측;
    public Sprite 밤_우측;

    //하부
    public Sprite 아침_하부;
    public Sprite 점심_하부;
    public Sprite 저녁_하부;
    public Sprite 밤_하부;

    public SpriteRenderer 좌측배경;
    public SpriteRenderer 우측배경;
    public SpriteRenderer 하부배경;


    public SpriteRenderer 플레이어;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {

            DataBaseManager.시간대++;
            Debug.Log(DataBaseManager.시간대);
        }


        if (DataBaseManager.시간대 == 3 || DataBaseManager.시간대 == 7 || DataBaseManager.시간대 == 11)
        {
            // 점심
            좌측배경.sprite = 점심_좌측;
            우측배경.sprite = 점심_우측;
            하부배경.sprite = 점심_하부;
            플레이어.color = new Color(255 / 255f, 255 / 255f, 255 / 255f);
        }

        else if (DataBaseManager.시간대 == 4 || DataBaseManager.시간대 == 8 || DataBaseManager.시간대 == 12)
        {
            //저녁
            좌측배경.sprite = 저녁_좌측;
            우측배경.sprite = 저녁_우측;
            하부배경.sprite = 저녁_하부;
            플레이어.color = new Color(133 / 255f, 133 / 255f, 133 / 255f);
        }

        else if (DataBaseManager.시간대 == 5 || DataBaseManager.시간대 == 9 || DataBaseManager.시간대 == 13)
        {
            좌측배경.sprite = 밤_좌측;
            우측배경.sprite = 밤_우측;
            하부배경.sprite = 밤_하부;
            플레이어.color = new Color(80 / 255f, 80 / 255f, 80 / 255f);



        }

        else if (DataBaseManager.시간대 == 2 || DataBaseManager.시간대 == 6 || DataBaseManager.시간대 == 10 || DataBaseManager.시간대 == 14)
        {
            //아침
            플레이어.color = new Color(199 / 255f, 199 / 255f, 199 / 255f);
            좌측배경.sprite = 아침_좌측;
            우측배경.sprite = 아침_우측;
            하부배경.sprite = 아침_하부;
        }






    }
}
