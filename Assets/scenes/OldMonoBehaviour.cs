using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMonoBehaviour : MonoBehaviour 
{
    public float rotateSpeed = 100;

    void Update () 
    {
        // 我们最熟悉的配方，在Monobehavior中修改transform的rotation。
        transform.rotation *= Quaternion.AngleAxis(Time.deltaTime * rotateSpeed, Vector3.up);	
    }
}