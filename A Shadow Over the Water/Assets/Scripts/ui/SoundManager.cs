using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    public Animator 주인공움직임;
    public Slider bgm볼륨;
    public AudioSource mainBgm;

    public AudioClip 찰칵소리효과음;
    public Slider sfx볼륨;
    public AudioSource effectBgm;

    public AudioClip 달리기효과음;
    public AudioSource 효과음창;

    bool 달리기효과음켜짐 = false;

    public AudioClip 문열고닫기효과음;
    public AudioClip 놑크효과음;

    public AudioClip 기계돌아가는소리효과음;


    public void 기계돌아가는효과음함수()
    {
        효과음창.PlayOneShot(기계돌아가는소리효과음);
    }
    public void 문열고닫기함수()
    {
        //효과음창.Play();

        효과음창.PlayOneShot(문열고닫기효과음);
    }
    public void 노크효과음효과음함수()
    {
        //효과음창.Play();

        효과음창.PlayOneShot(놑크효과음);
    }

    public void 찰칵효과음함수()
    {
        효과음창.PlayOneShot(찰칵소리효과음);

    }
    void 효과음관리()
    {

        if (주인공움직임.GetFloat("walk") == 1 && 달리기효과음켜짐 == false)
        {
            달리기효과음켜짐 = true;
            효과음창.clip = 달리기효과음;


            효과음창.PlayOneShot(달리기효과음);
        }
        else if (주인공움직임.GetFloat("walk") == 0)
        {
            효과음창.clip = null;
            달리기효과음켜짐 = false;
            if(DataBaseManager.연출중움직임제한 == false)
            {
                효과음창.Stop();
            }

        }
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
        효과음관리();
        슬라이드효과관리();
        슬라이드bgm관리();
        bgm소리설정();
    }
}
