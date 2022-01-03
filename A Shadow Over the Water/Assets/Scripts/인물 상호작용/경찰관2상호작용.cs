using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 경찰관2상호작용 : MonoBehaviour
{
	public Text 간단표기제목;
	public Text 간단표기내용;

	public GameObject 상호작용판;
	public InterctionController_D1경찰서 인터렉션컨트롤러;
	public Animator 플레이어애니메이션;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물

		if (collision.name == "Player")
		{
			멜리사상호작용가능여부 = true;
			간단표기제목.text = "경찰관B";
			간단표기내용.text = "서류정리 담당인 경관.";
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

	public void 상호작용체커()
    {
		if(멜리사상호작용가능여부 == true && 상호작용판.activeSelf == false)
        {

			if (DataBaseManager.판정창여부 == false && DataBaseManager.옵션창여부 == false)
			{

				if (Input.GetKeyDown(KeyCode.E))
				{
					DataBaseManager.판정창여부 = true;
					플레이어애니메이션.SetFloat("move", 0);
					플레이어애니메이션.SetFloat("walk", 0);
					플레이어애니메이션.SetFloat("run", 0);


					DataBaseManager.대화창켜짐 = true;

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

		int 숫자 = Random.Range(1, 4);


		if(최초대화여부_1일차아침 == false)
        {
			최초대화여부_1일차아침 = true;
			인터렉션컨트롤러.경찰관2_1일차낮_최초대화();

		}
        else
        {
			if (숫자 == 1)
			{
				인터렉션컨트롤러.경찰관2_1일차낮_반복대화1();
			}
			else if (숫자 == 2)
			{
				인터렉션컨트롤러.경찰관2_1일차낮_반복대화2();
			}
			else if (숫자 == 3)
			{
				인터렉션컨트롤러.경찰관2_1일차낮_반복대화3();
			}
		}



	}

	public void 멜리사기능판정()
    {

    }
	/*
	public void 멜리사키워드()
	{
		상호작용판.SetActive(false);
		DataBaseManager.연출중움직임제한 = false;
		if (DataBaseManager.키워드하위 == "행성대직렬 신문기사")
        {
			인터렉션컨트롤러.멜리사_행성대직렬_키워드();
		}
		else if (DataBaseManager.키워드하위 == "에이든의 악몽")
		{
			인터렉션컨트롤러.멜리사_악몽_키워드();
		}
		else if (DataBaseManager.키워드하위 == "불면증 유행")
		{
			인터렉션컨트롤러.멜리사_불면증_키워드();
		}
		else if (DataBaseManager.키워드하위 == "에이든 트리스")
		{
			인터렉션컨트롤러.멜리사_에이든_키워드();
		}
		else if (DataBaseManager.키워드하위 == "엘라 트리스")
		{
			인터렉션컨트롤러.멜리사_엘라_키워드();
		}
		else if (DataBaseManager.키워드하위 == "병원과 의뢰자")
		{
			인터렉션컨트롤러.멜리사_병원_키워드();
		}
		else if (DataBaseManager.키워드하위 == "남편의 직장") // 신문사
		{
			인터렉션컨트롤러.멜리사_신문사_키워드();
		}
		else if (DataBaseManager.키워드하위 == "의뢰자의 집")
		{
			인터렉션컨트롤러.멜리사_의뢰자의집_키워드();
		}
	}
	*/
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
