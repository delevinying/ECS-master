using System;
using Unity.Entities;

/// <summary>
/// Logo碰撞方块后给予方块重置的速度
/// </summary>
[Serializable]
public struct RotationSpeedResetSphere : IComponentData
{
    //方块重置的速度
    public float speed;
}
/// <summary>
/// 方块旋转的速度
/// </summary>
public class RotationSpeedResetSphereComponent : ComponentDataWrapper<RotationSpeedResetSphere> { }
