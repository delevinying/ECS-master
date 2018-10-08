using System;
using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// 转动Logo的中心点和转动半径
/// </summary>
[Serializable]
public struct MoveAlongCircle : IComponentData
{
    //Logo对应的中心点
    public float3 center;
    //Logo对应的半径
    public float radius;
    //运行时间
    //[NonSerialized]
    public float t;
}
/// <summary>
/// 转动Logo的中心点和转动半径
/// </summary>
public class MoveAlongCircleComponent : ComponentDataWrapper<MoveAlongCircle> { }

