using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 플로팅택스트 : MonoBehaviour
{

    public float moveSpeed;
    public float destroyTime;



    public Text Text;

    private Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        vector.Set(Text.transform.position.x + (1 * Time.deltaTime), Text.transform.position.y + (moveSpeed * Time.deltaTime), Text.transform.position.z);
        Text.transform.position = vector;

        destroyTime -= Time.deltaTime;

        if (destroyTime <= 0)
        {
            Destroy(this.gameObject);
        }






    }



}
