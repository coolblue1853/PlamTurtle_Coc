using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 환자1상호작용 : MonoBehaviour
{
	public Text 간단표기제목;
	public Text 간단표기내용;

	public GameObject 상호작용판;
	public InterctionController_D1병원 인터렉션컨트롤러;
	public Animator 플레이어애니메이션;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물

		if (collision.name == "Player")
		{
			멜리사상호작용가능여부 = true;
			간단표기제목.text = "환자A";
			간단표기내용.text = "눈이 퀭해보이는 사람이다.";
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
	public void 대화()
    {
		상호작용판.SetActive(false);
		DataBaseManager.대화창켜짐 = true;

		int 숫자 = Random.Range(1, 3);


		if(최초대화여부_1일차아침 == false)
        {
			최초대화여부_1일차아침 = true;
			인터렉션컨트롤러.환자1_1일차낮_최초대화();

		}
        else
        {
			if (숫자 == 1)
			{
			    인터렉션컨트롤러.환자1_1일차낮_반복대화1();
			}
			else if (숫자 == 2)
			{
				인터렉션컨트롤러.환자1_1일차낮_반복대화2();
			}

		}



	}

	public void 기능판정()
    {

    }

	public void 키워드()
	{

		상호작용판.SetActive(false);
		DataBaseManager.연출중움직임제한 = false;

		// 최초획득
		if (DataBaseManager.키워드하위 == "에이든의 악몽")
		{
			인터렉션컨트롤러.환자1_1일차낮_악몽1대화();
		}

		else if (DataBaseManager.키워드하위 == "불면증 유행")
		{
			인터렉션컨트롤러.환자1_1일차낮_불면증1대화();
		}

		else if (DataBaseManager.키워드하위 == "병원과 의뢰자")
		{
			인터렉션컨트롤러.환자1_1일차낮_병원1대화();
		}

        else
        {
			인터렉션컨트롤러.환자1_1일차낮_잘모름대화();
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
