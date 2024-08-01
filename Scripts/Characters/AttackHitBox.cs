using Godot;
using System;

public partial class AttackHitBox : Area3D, IHitBox
{
    public float GetDamage()
    {
        return GetOwner<Character>().GetStatResource(Stat.Strength).StatValue;
    }
}
