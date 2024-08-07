using Godot;
using System;

public partial class AbilityHitBox : Area3D, IHitBox
{
    public bool CanStun()
    {
        return true;
    }


    public float GetDamage() => GetOwner<Ability>().Damage;
}