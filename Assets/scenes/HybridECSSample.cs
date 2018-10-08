﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class HybridECSSample : MonoBehaviour 
{
    public GameObject cubePrefab;
    public int count = 15000;

    private Dictionary<int, GameObject> m_gameObjectDic = new Dictionary<int, GameObject>();

    public void SwitchToECS()
    {
        DestroyOldGameObject();
        for(int i = 0; i < count; i++)
        {
            var originalCube = GameObject.Instantiate(cubePrefab) as GameObject;
            originalCube.transform.position = UnityEngine.Random.insideUnitSphere * (count / 100);
            originalCube.AddComponent<HybridECSRotator>();
            //需要给GameObject添加GameObjectEntity组件，才能让原先的GameObject被EntityManger识别为Enity。
            originalCube.AddComponent<GameObjectEntity>();

            m_gameObjectDic.Add(originalCube.GetInstanceID(), originalCube);
        }
    }

    public void SwitchToOriginal()
    {
        DestroyOldGameObject();
        for(int i = 0; i < count; i++)
        {
            var originalCube = GameObject.Instantiate(cubePrefab) as GameObject;
            originalCube.AddComponent<OldMonoBehaviour>();
            originalCube.transform.position = UnityEngine.Random.insideUnitSphere * (count / 100);
    
            m_gameObjectDic.Add(originalCube.GetInstanceID(), originalCube);
        }
    }

    private void DestroyOldGameObject()
    {
        foreach(var pair in m_gameObjectDic)
        {
            Destroy(pair.Value);
        }

        m_gameObjectDic.Clear();
    }
}