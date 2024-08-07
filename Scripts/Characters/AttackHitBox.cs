using Godot;
using System;

public partial class AttackHitBox : Area3D, IHitBox
{
    public bool CanStun()
    {
        return false;
    }


    public float GetDamage()
    {
        return GetOwner<Character>().GetStatResource(Stat.Strength).StatValue;
    }
}
