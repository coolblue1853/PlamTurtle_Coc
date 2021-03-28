using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mins : MonoBehaviour
{
	Animator anime;

	float ChInRommSize = 0.8249288f;
	//float ChSize = 0.5055861f;


	bool isAttack = false;
	bool isAttack2 = false;
	public bool isGrounded = true;
	public float movePower = 1f;
	public float runPower = 3f;
	public float jumpPower = 5f;
	public int jumpCount = 0;
	Rigidbody2D rigid;
	Transform trans;
	public GameObject JumpStemp;
	public CameraManager 카메라;


	public bool isDialogONing = false;

	public bool isEllaON = false;

	public InterctionController Ella ;



	public void isDialogOnChangeF()
    {
		isDialogONing = false;

	}
	public void isDialogOnChangeT()
	{
		isDialogONing = true;
	}



	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.transform.tag == "cameraCheck")
		{


			카메라.카메라다시움직이기();

		}
		if (collision.transform.tag == "Ella")
		{

			isEllaON = true;


		}



	}


    private void OnTriggerExit2D(Collider2D collision)
    {
		if (collision.transform.tag == "Ella")
		{

			isEllaON = false;


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
	void Update()
	{

        if (!isDialogONing)
        {
			Jump();
			AttackCheker();
		}


		if (isEllaON)
        {
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Ella.checkObject();
			}
		}
	}

	void FixedUpdate()
	{

		if (!isDialogONing)
		{
			runAndWalkChanger();
			Move();
		}


	}

	void endAttack()
    {
		isAttack = false;
		isAttack2 = false;
		attcount = 0;
	}

	int attcount = 0;
	void AttackCheker()
    {

		if(isGrounded == true)
        {

			if (Input.GetKeyDown(KeyCode.X))
			{

				StartCoroutine(Attack1());

			}
		}


		                                                                                                                                                                                                                                                                                                                                                                                                                                                                      


		anime.SetBool("attack", isAttack);
	}


	IEnumerator Attack1()
	{
		att1Time = Time.time;
		isAttack = true;


		while (Time.time - att1Time > 2f)
		{
			Debug.Log("연속");
			if (Input.GetKey(KeyCode.X))
            {
				Debug.Log("연속");
				StartCoroutine(Attack2());
				yield break;

            }


        }

		yield return null;	


	}

	IEnumerator Attack2()
    {
		isAttack2 = true;
		anime.SetBool("attack", isAttack2);
		yield break;
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

	bool isjumping = false;
	void Jump()
	{




		if (Input.GetKeyDown(KeyCode.C) && jumpCount < 2)
		{

			if (Input.GetKeyDown(KeyCode.C) && jumpCount == 1)
			{
				Instantiate(JumpStemp, trans.position - new Vector3(0, 0.8f), Quaternion.identity);
				anime.SetFloat("DBJump", 1);
			}

			jumpCount++;
			rigid.velocity = Vector2.zero;
			Vector2 jumpVelocity = new Vector2(0, jumpPower);
			rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

		}

		anime.SetBool("isJump", isGrounded);


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