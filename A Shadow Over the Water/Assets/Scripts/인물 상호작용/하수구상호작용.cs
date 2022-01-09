using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 하수구상호작용 : MonoBehaviour
{

    public Text 간단표기제목;
    public Text 간단표기내용;

    public GameObject 상호작용판;
	public InterctionController_D1강가 인터렉션컨트롤러;
	public Animator 플레이어애니메이션;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물

		if (collision.name == "Player")
		{
			멜리사상호작용가능여부 = true;
			간단표기제목.text = "하수도";
			간단표기내용.text = "어두컴컴한 하수도. 자물쇠가 걸려있다.";
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

	bool 최초대화여부_1일차아침 = false;
	public void 멜리사대화()
    {
		상호작용판.SetActive(false);
		DataBaseManager.대화창켜짐 = true;

		int 숫자 = Random.Range(1, 4);



        인터렉션컨트롤러.하수도_1일차낮_살펴보기대화();






    }


    public void 에이든키워드()
    {
        상호작용판.SetActive(false);
        DataBaseManager.연출중움직임제한 = false;

        // 최초획득
        /*
        if (DataBaseManager.키워드하위 == "에이든의 악몽")
        {
            인터렉션컨트롤러.하수도_1일차낮_관찰력성공대화();
        }
        else if(DataBaseManager.키워드하위 == "불면증 유행")
        {
            인터렉션컨트롤러.대학생_1일차낮_불면증대화();
        }
        else
        {
            인터렉션컨트롤러.대학생_1일차낮_그외키워드대화();

        }
        */
    }

    public void 그만두기()
    {
        상호작용판.SetActive(false);
        DataBaseManager.대화창켜짐 = false;
        DataBaseManager.판정창여부 = false;
    }
    void Update()
    {
        상호작용체커();
     
        if (룰렛활성여부 == true && Input.GetMouseButtonDown(0))
        {
            전투클릭여부 = true;
            배틀사운드매니저.효과음멈춤();
        }
    
        if (DataBaseManager.대학생관찰력판정여부 == false)
        {
            관찰력버튼.SetActive(true);
        }
        else
        {
            관찰력버튼.SetActive(false);
        }
        if (DataBaseManager.에이든정신분석판정여부 == false)
        {
            //정신분석버튼.SetActive(true);
        }
        else
        {
           // 정신분석버튼.SetActive(false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        DataBaseManager.악몽정보1 = true;
        DataBaseManager.불면증정보1 = true;
    }

    public SoundManager 배틀사운드매니저;


    public GameObject 기능판청안내창;

    public GameObject 판정창;
    public Text 사용기능;
    public Text 결과;

    public GameObject 관찰력버튼;
    public GameObject 정신분석버튼;

    public GameObject 에이든기능판정배경;

	public void 에이든기능판정()
    {
		에이든기능판정배경.SetActive(true);
	}
	public void 에이든이전버튼()
	{
		에이든기능판정배경.SetActive(false);
	}
	public void 에이든의학버튼()
	{
		DataBaseManager.판정창여부 = true;
		에이든기능판정배경.SetActive(false);
		상호작용판.SetActive(false);

		의학기능판정창.SetActive(true);
		의학기능판정텍스트.text = "하수도에 대하여 <눈썰미> 기능을 사용합니다.\n 현재 해당기능 수치는 " + DataBaseManager.눈썰미 + " 입니다.";

	}

	public void 에이든의학아니오()
	{		DataBaseManager.연출중움직임제한 = false;
		DataBaseManager.판정창여부 = false;
		DataBaseManager.대화창켜짐 = false;
		의학기능판정창.SetActive(false);
	}

    public void 에이든정신분석버튼()
    {
        DataBaseManager.판정창여부 = true;
        에이든기능판정배경.SetActive(false);
        상호작용판.SetActive(false);

        정신분석기능판정안내창.SetActive(true);
        정신분석기능판정텍스트.text = "에이든에 대하여 <정신감정> 기능을 사용합니다.\n 현재 해당기능 수치는 " + DataBaseManager.정신감정 + " 입니다.";

    }

    public void 에이든정신분석아니오()
    {
        DataBaseManager.연출중움직임제한 = false;
        DataBaseManager.판정창여부 = false;
        DataBaseManager.대화창켜짐 = false;
        정신분석기능판정안내창.SetActive(false);
    }
    public GameObject 의학기능판정창;
	public Text 의학기능판정텍스트;






	// Update is called once per frame

    public void 의학기능판정()
    {


        기능판청안내창.SetActive(false);
        StartCoroutine(의학기능판정코루틴());

    }
    public IEnumerator 의학기능판정코루틴()
    {
        일의자리.text = "0";
        결과.text = "----";
        룰렛활성여부 = false;
        전투클릭여부 = false;
        DataBaseManager.하수도관찰력판정여부 = false;

        판정창.SetActive(true);


        사용기능.text = "눈썰미" + DataBaseManager.눈썰미;
        배틀사운드매니저.찰칵효과음함수();

        yield return new WaitForSeconds(2f);

        StartCoroutine(룰렛작동());

        //yield return new WaitForSeconds(6f);


    }

    IEnumerator 의학기능_1일차에이든()
    {
        배틀사운드매니저.찰칵효과음함수();




        if (출력기능값 <= DataBaseManager.눈썰미)
        {
            결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.눈썰미)
        {
            결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.눈썰미 / 3f) && (double)DataBaseManager.눈썰미 >= 3f)
        {
            결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            결과.text = "대실패";

        }


        yield return new WaitForSeconds(2f);

        판정창.SetActive(false);





        if (결과.text == "대성공")
        {

            인터렉션컨트롤러.하수도_1일차낮_관찰력성공대화();
        }

        if (결과.text == "보통성공")
        {

            인터렉션컨트롤러.하수도_1일차낮_관찰력성공대화();

        }
        if (결과.text == "실패")
        {

            인터렉션컨트롤러.하수도_1일차낮_관찰력실패대화();

        }
        if (결과.text == "대실패")
        {

            인터렉션컨트롤러.하수도_1일차낮_관찰력실패대화();

        }


    }




    public Text 정신분석기능판정텍스트;
    public GameObject 정신분석기능판정안내창;
    public void 정신분석기능판정()
    {


        정신분석기능판정안내창.SetActive(false);
        StartCoroutine(정신분석기능판정코루틴());

    }
    public IEnumerator 정신분석기능판정코루틴()
    {
        룰렛활성여부 = false;
        전투클릭여부 = false;
        결과.text = "----";
        일의자리.text = "0";
        DataBaseManager.에이든정신분석판정여부 = true;

        판정창.SetActive(true);


        사용기능.text = "정신감정" + DataBaseManager.정신감정;
        배틀사운드매니저.찰칵효과음함수();

        yield return new WaitForSeconds(2f);

        StartCoroutine(룰렛작동());

        //yield return new WaitForSeconds(6f);


    }

    IEnumerator 정신분석기능_1일차에이든()
    {
        배틀사운드매니저.찰칵효과음함수();




        if (출력기능값 <= DataBaseManager.정신감정)
        {
            결과.text = "보통성공";

        }
        if (출력기능값 > DataBaseManager.정신감정)
        {
            결과.text = "실패";

        }
        if (출력기능값 <= ((double)DataBaseManager.정신감정 / 3f) && (double)DataBaseManager.정신감정 >= 3f)
        {
            결과.text = "대성공";

        }
        if (출력기능값 == 10)
        {
            결과.text = "대실패";

        }


        yield return new WaitForSeconds(2f);

        판정창.SetActive(false);





        if (결과.text == "대성공")
        {

            //인터렉션컨트롤러.에이든_1일차낮_정신분석대화();
        }

        if (결과.text == "보통성공")
        {

            //인터렉션컨트롤러.에이든_1일차낮_정신분석대화();

        }
        if (결과.text == "실패")
        {

            //인터렉션컨트롤러.에이든_1일차낮_정신분석실패대화();

        }
        if (결과.text == "대실패")
        {

           // 인터렉션컨트롤러.에이든_1일차낮_정신분석실패대화();

        }


    }





    public IEnumerator 룰렉동작시키기()
    {

        룰렛머신온오프.SetActive(true);
        yield return StartCoroutine(룰렛작동());
        룰렛머신온오프.SetActive(false);
    }















    // 기능관련 룰렛
    public rollet 룰렛머신;

    // public Text 십의자리;
    public Text 일의자리;

    //public GameObject 십의자리몸통;
    public GameObject 일의자리몸통;
    public GameObject 룰렛머신온오프;






    //int 랜덤십의자리;
    int 랜덤일의자리;


    int 랜덤십의몸통위치;

    public static float 출력기능값;





    bool 전투클릭여부;
    bool 룰렛활성여부;

    public IEnumerator 룰렛끄기()
    {
        yield return new WaitForSeconds(2f);
        룰렛머신온오프.SetActive(false);
    }

    public IEnumerator 룰렛작동()
    {
        배틀사운드매니저.기계돌아가는효과음함수();
        while (전투클릭여부 == false)
        {
            룰렛활성여부 = true;
            //랜덤십의자리 = Random.Range(0, 10);
            랜덤일의자리 = Random.Range(0, 10);
            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2f, 십의자리몸통.transform.position.y - 1f);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2f, 십의자리몸통.transform.position.y + 1f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1f, 일의자리몸통.transform.position.y - 1f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1f);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 1f, 일의자리몸통.transform.position.y + 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 1, 일의자리몸통.transform.position.y - 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 2);
            }
            if (랜덤십의몸통위치 == 5)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y - 1);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 6)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 2);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 2);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
            }
            if (랜덤십의몸통위치 == 8)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 1, 십의자리몸통.transform.position.y - 1);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 1, 십의자리몸통.transform.position.y + 1);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 2, 십의자리몸통.transform.position.y - 1);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 2, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 2, 십의자리몸통.transform.position.y + 1);
            }



            일의자리.text = 랜덤일의자리.ToString();

            yield return new WaitForSeconds(0.005f);

        }






        배틀사운드매니저.찰칵효과음함수();
        출력기능값 = (랜덤일의자리);
        if (출력기능값 == 0)
        {
            출력기능값 = 10;
        }

        //연출흔들기
        for (int i = 0; i < 10; i++)
        {

            float 큰흔들기값 = 4f;
            float 작은흔들기값 = 2f;

            랜덤십의몸통위치 = Random.Range(1, 10);

            if (랜덤십의몸통위치 == 1)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                //  십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.005f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값   );
            }




            yield return new WaitForSeconds(0.005f);

        }
        for (int i = 0; i < 5; i++)
        {

            float 큰흔들기값 = 3f;
            float 작은흔들기값 = 2f;


            랜덤십의몸통위치 = Random.Range(1, 10);


            if (랜덤십의몸통위치 == 1)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
            }
            if (랜덤십의몸통위치 == 2)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);

            }
            if (랜덤십의몸통위치 == 3)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 작은흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 작은흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 4)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x, 십의자리몸통.transform.position.y - 큰흔들기값);
            }
            if (랜덤십의몸통위치 == 5)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y + 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y - 작은흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 6)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 1);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 1);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 7)
            {
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y - 큰흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x, 일의자리몸통.transform.position.y + 큰흔들기값);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 8)
            {
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 작은흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 작은흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }
            if (랜덤십의몸통위치 == 9)
            {
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x + 큰흔들기값, 일의자리몸통.transform.position.y);
                //십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x + 큰흔들기값, 십의자리몸통.transform.position.y - 작은흔들기값);
                yield return new WaitForSeconds(0.025f);
                일의자리몸통.transform.position = new Vector2(일의자리몸통.transform.position.x - 큰흔들기값, 일의자리몸통.transform.position.y);
                // 십의자리몸통.transform.position = new Vector2(십의자리몸통.transform.position.x - 큰흔들기값, 십의자리몸통.transform.position.y + 작은흔들기값);
            }






            yield return new WaitForSeconds(0.025f);

        }

        yield return new WaitForSeconds(2f);


        if (사용기능.text == "눈썰미" + DataBaseManager.눈썰미)
        {
            StartCoroutine(의학기능_1일차에이든());
        }
        else if (사용기능.text == "정신감정" + DataBaseManager.정신감정)
        {
            StartCoroutine(정신분석기능_1일차에이든());
        }

    }
    
}
