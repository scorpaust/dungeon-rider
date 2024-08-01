using Godot;
using System;

public partial class AbilityHitBox : Area3D, IHitBox
{
    public float GetDamage() => GetOwner<Bomb>().Damage;
}