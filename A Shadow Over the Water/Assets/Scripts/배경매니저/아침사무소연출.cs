using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 아침사무소연출 : MonoBehaviour
{    //연출시 못움직이게하는

    public Mins 주인공;
    public GameObject 주인공캐릭터오브젝트;
    public SpriteRenderer 주인공캐릭터스프라이트랜더러;
    public Color 투명;

    // Start is called before the first frame update
    void Start()
    {
        투명.a = 0;
        주인공캐릭터스프라이트랜더러.color = 투명;
        DataBaseManager.연출중움직임제한 = true;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
