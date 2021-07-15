using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public class everyEnemy : MonoBehaviour
    {

        public int 힘 = 0;
        public int 지능 = 0;
        public int 민첩 = 0;
       
        
        public int 활력 = 0;
        public int 마력 = 0;
        public int 의지력 = 0;

        public int 체력 = 0;
        public int 정신력 = 0;

    }

    public class DeepOne : everyEnemy
    {
        public int 심해인맨손격투 = 0;
        public int 심해인회피 = 0 ;
        public int 심해인듣기 = 0;


        public void 심해인스탯생성()
        {
            힘 = Random.Range(4, 8);
            지능 = Random.Range(4, 7);
            민첩= Random.Range(4, 8);

            활력 = Random.Range(3, 6);
            마력 = Random.Range(4, 7);
            의지력 = Random.Range(3, 6);


            체력 = 활력 + 의지력;
            정신력 = 마력 + 의지력;


            심해인맨손격투 = Random.Range(3, 6);

            심해인회피 = Random.Range(3, 6);

            심해인듣기 = Random.Range(3, 6);
        }



    }







    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
