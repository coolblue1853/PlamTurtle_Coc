using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class battleSoundManager : MonoBehaviour
{

    public Slider bgm볼륨;
    public AudioSource mainBgm;


    public Slider sfx볼륨;
    public AudioSource effectBgm;
    public AudioClip 근접공격효과음;
    public void 근접공격효과음함수()
    {
        효과음창.PlayOneShot(근접공격효과음);
    }


    public AudioClip 샷건장전효과음;
    public AudioClip 샷건탄약부족효과음;
    public AudioClip 샷건발포효과음;
    public AudioClip 샷건조준효과음;

    public AudioClip 리볼버장전효과음;
    public AudioClip 리볼버탄약부족효과음;
    public AudioClip 리볼버발포효과음;
    public AudioClip 리볼버조준효과음;

    public AudioClip 데린저장전효과음;
    public AudioClip 데린저탄약부족효과음;
    public AudioClip 데린저발포효과음;
    public AudioClip 데린저조준효과음;

    public AudioClip 소총장전효과음;
    public AudioClip 소총탄약부족효과음;
    public AudioClip 소총발포효과음;
    public AudioClip 소총조준효과음;

    public AudioClip 찰칵소리효과음;
    public AudioClip 기계돌아가는소리효과음;


    public void 찰칵효과음함수()
    {
        효과음창.PlayOneShot(찰칵소리효과음);

    }


    public void 기계돌아가는효과음함수()
    {
        효과음창.PlayOneShot(기계돌아가는소리효과음);
    }
    public void 효과음멈춤()
    {
        효과음창.Stop();
    }


    //
    public void 소총장전효과음함수()
    {
        효과음창.PlayOneShot(소총장전효과음);
    }
    public void 소총발포효과음함수()
    {
        효과음창.PlayOneShot(소총발포효과음);
    }
    public void 소총탄약부족효과음함수()
    {
        효과음창.PlayOneShot(소총탄약부족효과음);
    }

    public void 소총조준효과음함수()
    {
        효과음창.PlayOneShot(소총조준효과음);
    }




    public void 데린저장전효과음함수()
    {
        효과음창.PlayOneShot(데린저장전효과음);
    }
    public void 데린저발포효과음함수()
    {
        효과음창.PlayOneShot(데린저발포효과음);
    }
    public void 데린저탄약부족효과음함수()
    {
        효과음창.PlayOneShot(데린저탄약부족효과음);
    }

    public void 데린저조준효과음함수()
    {
        효과음창.PlayOneShot(데린저조준효과음);
    }



    public AudioSource 효과음창;

    bool 달리기효과음켜짐 = false;

    public void 리볼버장전효과음함수()
    {
        효과음창.PlayOneShot(리볼버장전효과음);
    }
    public void 리볼버발포효과음함수()
    {
        효과음창.PlayOneShot(리볼버발포효과음);
    }
    public void 리볼버탄약부족효과음함수()
    {
        효과음창.PlayOneShot(리볼버탄약부족효과음);
    }

    public void 리볼버조준효과음함수()
    {
        효과음창.PlayOneShot(리볼버조준효과음);
    }



    //
    public void 샷건장전효과음함수()
    {
        효과음창.PlayOneShot(샷건장전효과음);
    }
    public void 샷건발포효과음함수()
    {
        효과음창.PlayOneShot(샷건발포효과음); 
    }
    public void 샷건탄약부족효과음함수()
    {
        효과음창.PlayOneShot(샷건탄약부족효과음);
    }

    public void 샷건조준효과음함수()
    {
        효과음창.PlayOneShot(샷건조준효과음);
    }
    void bgm소리설정()
    {
        mainBgm.volume = DataBaseManager.음악소리크기;
        effectBgm.volume = DataBaseManager.이펙트소리크기;
    }

    public void 슬라이드bgm관리()
    {
        DataBaseManager.음악소리크기 = bgm볼륨.value;


    }
    public void 슬라이드효과관리()
    {

        DataBaseManager.이펙트소리크기 = sfx볼륨.value;

    }

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        bgm볼륨.value = DataBaseManager.음악소리크기;
        sfx볼륨.value = DataBaseManager.이펙트소리크기;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DataBaseManager.보유리볼버탄약 += 1;
        }

        슬라이드효과관리();
        슬라이드bgm관리();
        bgm소리설정();
    }
}
