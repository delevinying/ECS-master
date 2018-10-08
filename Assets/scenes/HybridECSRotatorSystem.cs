using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class HybridECSRotator : MonoBehaviour
{
    //monobehavior 只存放数据
    public float rotateSpeed = 100;
}

public class HybridECSRotatorSystem : ComponentSystem
{
    //HybridECSRotatorSystem要处理的数据集合
    //注意这里是结构体，在ECS中数据都保存在结构体中方便进行分块序列存储。
    struct CubeEntity
    {
        public Transform transform;
        public HybridECSRotator rotator;
    }

    override protected void OnUpdate()
    {
        //所有enitity的deltaTime都是相同的，所以这里可以直接让他们公用相同的deltaTime
        float deltaTime = Time.deltaTime;
        foreach (var cubeEntity in GetEntities<CubeEntity>())
        {
            cubeEntity.transform.rotation *= Quaternion.AngleAxis(deltaTime * cubeEntity.rotator.rotateSpeed, Vector3.up);	
        }	
    }
}