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


	// /////////////////////////////////////////////// 주인공과의 접촉물 출현에 따른 반응
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// 탐정 사무소 접촉물

		if (collision.name == "신문")
		{
			신문상호작용가능여부 = true;
			간단표기제목.text = "신문";
			간단표기내용.text = "오늘자로 발간된 신문이다.";

		}

		if (collision.transform.tag == "cameraCheck")
		{


			카메라.카메라다시움직이기();

		}



		if (collision.transform.tag == "Ella")
		{

			isEllaON = true;


		}



	}

	public GameObject 신문상호작용;
	public bool 신문상호작용가능여부 = false;
	public GameObject 신문white1;
	public GameObject 신문white2;
	public int 신문whiteNum = 1;


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

		if (collision.transform.tag == "Ella")
		{

			isEllaON = false;


		}
	}

	public void 상호작용체커()
	{
		if (신문whiteNum == 1)
		{
			신문white1.SetActive(true);
			신문white2.SetActive(false);
		}
		else if (신문whiteNum == 2)
		{
			신문white1.SetActive(false);
			신문white2.SetActive(true);
		}

		//켜질수 있는가?
		if (신문상호작용가능여부 == true && 신문상호작용.activeSelf== false)
		{
            if (Input.GetKeyDown(KeyCode.Z))
            {
				DataBaseManager.연출중움직임제한 = true;
				신문whiteNum = 1;
				신문상호작용.SetActive(true);
			}


		}
		// 켜져 있는가?
		else if( 신문상호작용.activeSelf == true)
        {

			if (Input.GetKeyDown(KeyCode.S))
            {
				if(신문whiteNum== 1)
                {
					신문whiteNum = 2;

				}
				else if (신문whiteNum == 2)
				{
					신문whiteNum = 1;

				}
			}
			if (Input.GetKeyDown(KeyCode.W))
			{
				if (신문whiteNum == 2)
				{
					신문whiteNum = 1;

				}
				else if (신문whiteNum == 1)
				{
					신문whiteNum = 2;

				}
			}
			if (Input.GetKeyDown(KeyCode.Z))
			{
				
				if (신문whiteNum == 1)
				{

					신문상호작용.SetActive(false);
					DataBaseManager.연출중움직임제한 = false;
					// 살펴보기 함수 발동
				}
				else if (신문whiteNum == 2)
				{

					신문상호작용.SetActive(false);
					DataBaseManager.연출중움직임제한 = false;
					// 기능발동 함수 발동
				}

			}




			if (Input.GetKeyDown(KeyCode.Escape))
            {
				Time.timeScale = 1;
				신문상호작용.SetActive(false);
			}
			
		}


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

    void FixedUpdate()
	{






		if (isEllaON)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Ella.checkObject();
			}
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

			if (Input.GetKey(KeyCode.Z))
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