using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 대학배경매니저 : MonoBehaviour
{

    public Sprite 아침;
    public Sprite 점심;
    public Sprite 저녁;
    public Sprite 밤;
    public SpriteRenderer 배경;

    public SpriteRenderer 플레이어;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //삭제
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DataBaseManager.시간대++;
        }


     if(DataBaseManager.시간대 == 3 || DataBaseManager.시간대 ==7 || DataBaseManager.시간대 == 11)
        {
            // 점심
            배경.sprite = 점심;
            플레이어.color = new Color(255 / 255f, 255 / 255f, 255 / 255f);
        }

        else if (DataBaseManager.시간대 == 4 || DataBaseManager.시간대 == 8 || DataBaseManager.시간대 == 12)
        {
            //저녁
            배경.sprite = 저녁;
            플레이어.color = new Color(133 / 255f, 133 / 255f, 133 / 255f);
        }

        else if (DataBaseManager.시간대 == 5 || DataBaseManager.시간대 == 9 || DataBaseManager.시간대 == 13)
        {
            배경.sprite = 밤;
            플레이어.color = new Color(80 / 255f, 80 / 255f, 80 / 255f);



        }

        else if (DataBaseManager.시간대 == 2 || DataBaseManager.시간대 == 6 || DataBaseManager.시간대 == 10 || DataBaseManager.시간대 == 14)
        {
            //아침
            플레이어.color = new Color(199 / 255f, 199 / 255f, 199 / 255f);
            배경.sprite = 아침;
        }




    }
}
