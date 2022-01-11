using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 의사상호작용 : MonoBehaviour
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
			간단표기제목.text = "의사";
			간단표기내용.text = "굉장히 바빠보이는 의사다.";
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
	bool 최초대화여부_1일차저녁;
	public void 멜리사대화()
    {
		상호작용판.SetActive(false);
		DataBaseManager.대화창켜짐 = true;

		int 숫자 = Random.Range(1, 3);

		if(DataBaseManager.시간대 == 3)
        {
			if (최초대화여부_1일차저녁 == false)
			{
				최초대화여부_1일차저녁 = true;
				인터렉션컨트롤러.의사1_1일차저녁_최초대화();

			}
			else
			{
				if(숫자 == 1)
				{
					인터렉션컨트롤러.의사1_1일차저녁_반복대화1();

				}

				else if (숫자 == 2)
				{
					인터렉션컨트롤러.의사1_1일차저녁_반복대화2();

				}

			}
		}
        else
        {
			if (최초대화여부_1일차아침 == false)
			{
				최초대화여부_1일차아침 = true;
				인터렉션컨트롤러.의사1_1일차낮_최초대화();

			}
			else
			{

				인터렉션컨트롤러.의사1_1일차낮_반복대화();


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

		if (DataBaseManager.시간대 == 3)
		{
			if (DataBaseManager.키워드하위 == "불면증 유행")
			{
				인터렉션컨트롤러.의사1_1일차저녁_불면증키워드대화();
			}
			else if (DataBaseManager.키워드하위 == "편집증 유행")
			{
				인터렉션컨트롤러.의사1_1일차저녁_편집증키워드대화();
			}
			else if (DataBaseManager.키워드하위 == "비릿한 냄새 소문")
			{
				인터렉션컨트롤러.의사1_1일차저녁_비릿한냄새키워드대화();
			}
			else
			{
				인터렉션컨트롤러.의사1_1일차저녁_그외키워드대화();
			}
		}
        else
        {
			인터렉션컨트롤러.의사1_1일차저녁_반복대화1();
		}
			// 최초획득

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
