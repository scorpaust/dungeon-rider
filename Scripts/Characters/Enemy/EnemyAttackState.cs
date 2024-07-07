using Godot;
using System;
using System.Linq;

public partial class EnemyAttackState : EnemyState
{
    private Vector3 targetPosition;

    protected override void EnterState()
    {
        characterNode.AnimPlayerNode.Play(GameConstants.ANIM_ATTACK);

        Node3D target = characterNode.AttackAreaNode.GetOverlappingBodies().First();

        targetPosition = target.GlobalPosition;
    }

    private void PerformHit()
    {
        characterNode.ToggleHitBox(false);

        characterNode.HitBoxNode.GlobalPosition = targetPosition;
    }
}
