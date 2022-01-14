﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 바텐더상호작용 : MonoBehaviour
{
	public Text 간단표기제목;
	public Text 간단표기내용;

	public GameObject 상호작용판;
	public InterctionController_D1바 인터렉션컨트롤러;
	public Animator 플레이어애니메이션;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물

		if (collision.name == "Player")
		{
			멜리사상호작용가능여부 = true;
			간단표기제목.text = "맥켄리";
			간단표기내용.text = "술집의 바텐더이자 나의 친구.";
		}



	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물
		if (collision.name == "Player" )
		{
			멜리사상호작용가능여부 = false;
			간단표기제목.text = "";
			간단표기내용.text = "";
		}


	}

	bool 멜리사상호작용가능여부 = false;
	public GameObject 대화창;
	public void 상호작용체커()
    {
		if(멜리사상호작용가능여부 == true && 상호작용판.activeSelf == false && 대화창.activeSelf == false)
        {

			if (DataBaseManager.판정창여부 == false && DataBaseManager.옵션창여부 == false)
			{
				
				if (Input.GetKeyDown(KeyCode.E))
				{
					DataBaseManager.판정창여부 = true;
					플레이어애니메이션.SetFloat("move", 0);
					플레이어애니메이션.SetFloat("walk", 0);
					플레이어애니메이션.SetFloat("run", 0);


					//DataBaseManager.대화창켜짐 = true;

					상호작용판.SetActive(true);
				}

			}
		}


    }

	bool 최초대화여부_1일차아침;
	public void 멜리사대화()
    {
		상호작용판.SetActive(false);
		DataBaseManager.대화창켜짐 = true;

		int 숫자 = Random.Range(1, 3);


		if(최초대화여부_1일차아침 == false)
        {
			최초대화여부_1일차아침 = true;
			인터렉션컨트롤러.맥캔리_1일차밤_최초대화();

		}
        else
        {
			if (숫자 == 1)
			{
				인터렉션컨트롤러.맥캔리_1일차밤_반복1대화();
			}
			else if (숫자 == 2)
			{
				인터렉션컨트롤러.맥캔리_1일차밤_반복2대화();
			}

		}



	}

	public void 멜리사기능판정()
    {

    }

	public void 알버트키워드()
	{
		상호작용판.SetActive(false);
		DataBaseManager.연출중움직임제한 = false;



		//알버트한테얻는거
		if (DataBaseManager.키워드하위 == "연속 실종 사건" || DataBaseManager.키워드하위 == "취재 - 연속 실종")
		{
			인터렉션컨트롤러.맥캔리_1일차밤_실종대화();
		}
		if (DataBaseManager.키워드하위 == "에이든 트리스")
		{
			인터렉션컨트롤러.맥캔리_1일차밤_에이든대화();
		}
		if (DataBaseManager.키워드하위 == "비릿한 냄새 소문")
		{
			인터렉션컨트롤러.맥캔리_1일차밤_비릿한냄새대화();
		}
		if (DataBaseManager.키워드하위 == "하수도노동자의 부당해고")
		{
			인터렉션컨트롤러.맥캔리_1일차밤_부당해고대화();
		}

        else
        {
			인터렉션컨트롤러.맥캔리_1일차밤_그외대화();
		}




	}

	public void 그만두기()
    {
		상호작용판.SetActive(false);
		DataBaseManager.대화창켜짐 = false;
		DataBaseManager.판정창여부 = false;
	}


		// Start is called before the first frame update
		void Start()
    {

		
	}

    // Update is called once per frame
    void Update()
    {
		상호작용체커();


	}
}
