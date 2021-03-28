using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpStemp : MonoBehaviour
{
    public GameObject my;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(my);

    }
}
