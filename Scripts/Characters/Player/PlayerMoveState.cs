using Godot;
using System;

public partial class PlayerMoveState : PlayerState
{
    [Export(PropertyHint.Range, "0, 20, 0.1")] private float speed = 5;

    public override void _PhysicsProcess(double delta)
    {
        if (characterNode.direction == Vector2.Zero)
        {
            characterNode.StateMachineNode.SwitchState<PlayerIdleState>();

            return;
        }

        characterNode.Velocity = new(characterNode.direction.X, 0, characterNode.direction.Y);

        characterNode.Velocity *= speed;

        characterNode.MoveAndSlide();

        characterNode.Flip();
    }

    protected override void EnterState()
    {
        base.EnterState();

        characterNode.AnimPlayerNode.Play(GameConstants.ANIM_MOVE);
    }

    public override void _Input(InputEvent @event)
    {
        CheckForAttackInput();
        
        if (Input.IsActionJustPressed(GameConstants.INPUT_DASH))
        {
            characterNode.StateMachineNode.SwitchState<PlayerDashState>();
        }
    }
}
