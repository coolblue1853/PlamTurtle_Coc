using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 카메라워킹우측 : MonoBehaviour
{

    public float moveSpeed;
    public float destroyTime;

    public GameObject 오브젝트;
    Vector3 초기위치;
    private Vector3 vector;         

    // Start is called before the first frame update
    void Start()
    {

        초기위치 = 오브젝트.transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        if(DataBaseManager.카메라워킹온오프 == true)
        {
            vector.Set(오브젝트.transform.position.x + (moveSpeed * Time.deltaTime), 오브젝트.transform.position.y, 오브젝트.transform.position.z);
            오브젝트.transform.position = vector;

            destroyTime -= Time.deltaTime;

            if (destroyTime <= 0)
            {

                destroyTime = 3;
                오브젝트.transform.position = 초기위치;
                DataBaseManager.카메라워킹온오프 = false;

            }
        }

        if (DataBaseManager.카메라왼쪽워킹온오프 == true)
        {
            vector.Set(오브젝트.transform.position.x - (moveSpeed * Time.deltaTime), 오브젝트.transform.position.y, 오브젝트.transform.position.z);
            오브젝트.transform.position = vector;

            destroyTime -= Time.deltaTime;

            if (destroyTime <= 0)
            {

                destroyTime = 3;
                오브젝트.transform.position = 초기위치;
                DataBaseManager.카메라왼쪽워킹온오프 = false;

            }
        }



    }



}
