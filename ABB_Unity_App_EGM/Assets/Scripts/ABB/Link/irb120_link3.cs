// System
using System;
// Unity 
using UnityEngine;
using static Robot_Ctrl;
using Debug = UnityEngine.Debug;

public class irb120_link3 : MonoBehaviour
{
    void FixedUpdate()
    {
        try
        {
            transform.localEulerAngles = new Vector3(0f, 0f, (float)(-1 * ABB_EGM_Control.J_Orientation[2]));
        }
        catch (Exception e)
        {
            Debug.Log("Exception:" + e);
        }
    }

    void OnApplicationQuit()
    {
        Destroy(this);
    }
}
