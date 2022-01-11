using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 알버트상호작용1 : MonoBehaviour
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
			간단표기제목.text = "알버트";
			간단표기내용.text = "말단 경찰이자 나의 친구이다.";
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
			인터렉션컨트롤러.알버트_1일차낮_최초대화();

		}
        else
        {
			if (숫자 == 1)
			{
				인터렉션컨트롤러.알버트_1일차낮_반복대화1();
			}
			else if (숫자 == 2)
			{
				인터렉션컨트롤러.알버트_1일차낮_반복대화2();
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

		if (DataBaseManager.키워드하위 == "취재 - 연속 실종" && 최초대화여부_1일차아침 == false)
		{
			최초대화여부_1일차아침 = true;
			인터렉션컨트롤러.알버트_1일차낮_대화전실종취재대화();
		}

		else if (DataBaseManager.키워드하위 == "취재 - 연속 실종" && 최초대화여부_1일차아침 == true)
		{

			인터렉션컨트롤러.알버트_1일차낮_실종취재대화();
		}
		else if (DataBaseManager.키워드하위 == "불면증 유행")
		{
			인터렉션컨트롤러.알버트_불면증_키워드();
		}
		// 최초획득
		else if (DataBaseManager.키워드하위 == "행성대직렬 신문기사")
        {
			인터렉션컨트롤러.알버트_행성대직렬_키워드();
		}
		//알버트한테얻는거
		else if (DataBaseManager.키워드하위 == "연속 실종 사건")
		{
			인터렉션컨트롤러.알버트_실종사건_키워드();
		}
		if (DataBaseManager.키워드하위 == "에이든이 취재하던 것")
		{
			인터렉션컨트롤러.알버트_1일차낮_하수도괴담대화();
		}
		if (DataBaseManager.키워드하위 == "비릿한 냄새 소문")
		{
			인터렉션컨트롤러.알버트_1일차낮_비릿한냄새대화();
		}
		if (DataBaseManager.키워드하위 == "하수도의 섬뜩한 눈")
		{
			인터렉션컨트롤러.알버트_1일차낮_섬뜩한눈대화();
		}

        else
        {
			인터렉션컨트롤러.잘모르는키워드();
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
