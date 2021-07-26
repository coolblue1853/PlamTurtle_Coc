using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput; // << 추가
public class 한영키대첵 : MonoBehaviour
{

    bool key_window_active;
    void OnApplicationFocus(bool b) // 게임창이 활성화 되면 true 비활성화 false
    {
        key_window_active = b;
    }
    void Update()
    {

        if (key_window_active)
        {
            if (WindowsInput.WindowsInput.GetKeyDown(KeyCode.A)) Debug.Log("key down");
            if (WindowsInput.WindowsInput.GetKeyUp(KeyCode.A)) Debug.Log("key up");
            if (WindowsInput.WindowsInput.GetKey(KeyCode.S)) Debug.Log("Key");
        }
    }
}   