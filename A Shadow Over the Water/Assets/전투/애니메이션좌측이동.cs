using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 애니메이션좌측이동 : MonoBehaviour
{

    public float moveSpeed;
    public float destroyTime;

    public GameObject 이미지;
    Vector3 초기위치;
    private Vector3 vector;         

    // Start is called before the first frame update
    void Start()
    {

        초기위치 = this.gameObject.transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.activeSelf == true)
        {
            vector.Set(this.gameObject.transform.position.x - (moveSpeed * Time.deltaTime), this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            this.gameObject.transform.position = vector;

            destroyTime -= Time.deltaTime;

            if (destroyTime <= 0)
            {
                destroyTime = 3;
                this.gameObject.transform.position = 초기위치;
                this.gameObject.SetActive(false);
            }
        }

   
    
    
    }



}
