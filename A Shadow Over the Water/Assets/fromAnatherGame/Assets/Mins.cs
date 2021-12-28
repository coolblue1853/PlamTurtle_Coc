using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Mins : MonoBehaviour
{
	Animator anime;

	float ChInRommSize = 0.8249288f;
	//float ChSize = 0.5055861f;

	public InterctionController_D1사무소 인터렉션컨트롤러;
	bool isAttack = false;
	bool isAttack2 = false;
	public bool isGrounded = true;
	public float movePower = 3f;
	public float runPower = 6f;
	public float jumpPower = 5f;
	public int jumpCount = 0;
	Rigidbody2D rigid;
	Transform trans;
	public GameObject JumpStemp;
	public CameraManager 카메라;


	public static bool isDialogONing = false ;

	public  bool isEllaON = false;

	public InterctionController Ella ;



	public void isDialogOnChangeF()
    {
		isDialogONing = false;

	}
	public void isDialogOnChangeT()
	{
		isDialogONing = true;
	}


	//카메라 조정 + 오브젝트 확인

	public Text 간단표기제목;
	public Text 간단표기내용;
	//public 마이름튜토리얼매니저 튜토리얼매니저;


	// /////////////////////////////////////////////// 주인공과의 접촉물 출현에 따른 반응
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물

		if (collision.name == "신문")
		{
			신문상호작용가능여부 = true;
			간단표기제목.text = "신문";
			간단표기내용.text = "오늘자로 발간된 신문이다.";
			//튜토리얼매니저.오번버튼();
		}

		if (collision.transform.tag == "cameraCheck")
		{


			카메라.카메라다시움직이기();

		}







	}

	public GameObject 신문상호작용;
	public bool 신문상호작용가능여부 = false;
	public GameObject 신문white1;
	public GameObject 신문white2;
	public GameObject 신문white3;
	public int 신문whiteNum = 1;
	public Text 사물기능판정텍스트;
	public GameObject 사물기능판정창;
	private void OnTriggerExit2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물
		if (collision.name == "신문")
		{
			신문상호작용가능여부 = false;
			//신문상호작용.SetActive(false);
			간단표기제목.text = "";
			간단표기내용.text = "";
		}


	}

	//기물반응

	public GameObject 신문기능판정버튼;

	public void 상호작용체커()
	{
        if (DataBaseManager.신문기능판정여부 == true)
        {
			신문white2.SetActive(false);
			신문기능판정버튼.SetActive(false);

		}


		if (신문whiteNum == 1)
		{
			신문white1.SetActive(true);
			신문white2.SetActive(false);
			신문white3.SetActive(false);
		}
		else if (신문whiteNum == 2)
		{
			신문white1.SetActive(false);
			신문white2.SetActive(true);
			신문white3.SetActive(false);
		}
		else if (신문whiteNum == 3)
		{
			신문white1.SetActive(false);
			신문white2.SetActive(false);
			신문white3.SetActive(true);
		}
		//켜질수 있는가?
		if (신문상호작용가능여부 == true && 신문상호작용.activeSelf== false)
		{
			if(DataBaseManager.판정창여부 == false && DataBaseManager.옵션창여부 == false)
			{

				if (Input.GetKeyDown(KeyCode.E))
				{
					DataBaseManager.판정창여부 = true;
					anime.SetFloat("move", 0);
					anime.SetFloat("walk", 0);
					anime.SetFloat("run", 0);


					DataBaseManager.연출중움직임제한 = true;
					신문whiteNum = 1;
					신문상호작용.SetActive(true);
				}

			}


		}
		// 켜져 있는가?
		else if( 신문상호작용.activeSelf == true)
        {
			
			if (Input.GetKeyDown(KeyCode.S))
            {
				if(신문whiteNum== 1)
                {
					if(DataBaseManager.신문기능판정여부== false)
                    {
						신문whiteNum = 2;
					}
					else if (DataBaseManager.신문기능판정여부 == true)
					{
						신문whiteNum = 3;
					}

				}
				else if (신문whiteNum == 2)
				{
					
					신문whiteNum = 3;

				}
				else if (신문whiteNum == 3)
				{
					신문whiteNum = 1;

				}
			}
			if (Input.GetKeyDown(KeyCode.W))
			{         
				if (신문whiteNum == 1)
				{
					신문whiteNum = 3;

				}
				else if (신문whiteNum == 2)
				{
					신문whiteNum = 1;

				}

				else if (신문whiteNum == 3)
				{
					if(DataBaseManager.신문기능판정여부 == false)
                    {
						신문whiteNum = 2;
					}
					else if (DataBaseManager.신문기능판정여부 == true)
					{
						신문whiteNum = 1;
					}

				}
			}

            if (DataBaseManager.대화창켜짐 == false)
            {
				if (Input.GetKeyDown(KeyCode.E))
				{

					if (신문whiteNum == 1)
					{

						신문살펴보기();

					}
					else if (신문whiteNum == 2)
					{
						신문기능판정();
					}
					else if (신문whiteNum == 3)//그만두기
					{

						신문그만두기();
					}
				}
			}



			



			if (Input.GetKeyDown(KeyCode.Escape))
            {

				신문상호작용.SetActive(false);
			}
			
		}


	}



	public void 신문살펴보기()
    {
		신문상호작용.SetActive(false);
		DataBaseManager.연출중움직임제한 = false;
		인터렉션컨트롤러.신문살펴보기대화();
	}

	public void 신문기능판정()
	{

		DataBaseManager.판정창여부 = true;
		신문상호작용.SetActive(false);

		사물기능판정창.SetActive(true);
		사물기능판정텍스트.text = "신문에 대하여 <정보조사> 기능을 사용합니다.\n 현재 해당기능 수치는 " + DataBaseManager.정보조사 + " 입니다.";
	}


	public void 신문그만두기()
	{
		신문상호작용.SetActive(false);
		DataBaseManager.연출중움직임제한 = false;
		DataBaseManager.판정창여부 = false;
	}




	float att1Time = 0;


	// Use this for initialization
	void Start()
	{
		trans = gameObject.GetComponent<Transform>();
		rigid = gameObject.GetComponent<Rigidbody2D>();
		anime = gameObject.GetComponent<Animator>();
	}

    // Update is called once per frame
    private void Update()
	{
		상호작용체커();
		if (isDialogONing == false && DataBaseManager.연출중움직임제한 == false)
		{
			runAndWalkChanger();
			Move();
		}




	}


	public void 다이얼로그온()
    {
		anime.SetBool("IsDialog", true);

	}
	public void 다이얼로그다운()
    {
		anime.SetBool("IsDialog", false);

	}

	void runAndWalkChanger()
    {
		if(Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0)
		{
			anime.SetFloat("move", 1);

			if (Input.GetKey(KeyCode.E))
			{
				anime.SetFloat("run", 1);
				anime.SetFloat("walk", 0);
			}
            else
			{
				anime.SetFloat("run", 0);
				anime.SetFloat("walk", 1);

			}

	
        }

		else if (Input.GetAxisRaw("Horizontal") == 0)
		{
			anime.SetFloat("move", 0);
			anime.SetFloat("walk", 0);
			anime.SetFloat("run", 0);
		}
	}

	void Move()
	{
		Vector3 moveVelocity = Vector3.zero;

		if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetKey(KeyCode.Z) && isAttack == false)
		{
			
			moveVelocity = Vector3.left;

			transform.localScale = new Vector3(-ChInRommSize, ChInRommSize, 1);
			//X값 스케일을 -1로 주어 좌우반전
		}
		else if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetKey(KeyCode.Z) && isAttack == false)
		{
			moveVelocity = Vector3.right;

			transform.localScale = new Vector3(ChInRommSize, ChInRommSize, 1);
			//X값 스케일을 1로 주어 다시 원위치 
		}

		if (Input.GetAxisRaw("Horizontal") < 0 && isAttack == false)
		{

			moveVelocity = Vector3.left;

			transform.localScale = new Vector3(-ChInRommSize, ChInRommSize, 1);
			//X값 스케일을 -1로 주어 좌우반전
		}
		else if (Input.GetAxisRaw("Horizontal") > 0 && isAttack == false)
		{
			moveVelocity = Vector3.right;

			transform.localScale = new Vector3(ChInRommSize, ChInRommSize, 1);
			//X값 스케일을 1로 주어 다시 원위치 
		}





		if (Input.GetKey(KeyCode.Z))
		    transform.position += moveVelocity * movePower * Time.deltaTime;
		else
			transform.position += moveVelocity * runPower * Time.deltaTime;
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].normal.y > 0.7f)
		{
			anime.SetFloat("DBJump", 0);
			isGrounded = true;
			jumpCount = 0;

		}
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
		isGrounded = false;
	}

}