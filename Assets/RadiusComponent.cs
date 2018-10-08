using System;
using Unity.Entities;


[Serializable]
public struct Radius : IComponentData
{
    //触发方块旋转的半径
    public float radius;
}
/// <summary>
/// 触发方块旋转的半径
/// </summary>
public class RadiusComponent : ComponentDataWrapper<Radius> { }

