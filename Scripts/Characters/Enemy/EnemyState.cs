using Godot;

public abstract partial class EnemyState : CharacterState
{
    protected Vector3 destination;

    protected Vector3 GetPointGlobalPosition(int index) 
    {
        Vector3 localPos = characterNode.PathNode.Curve.GetPointPosition(index);

        Vector3 globalPos = characterNode.PathNode.GlobalPosition;

        return localPos + globalPos;
    }

    protected void Move()
    {
        characterNode.AgentNode.GetNextPathPosition();
        
        characterNode.Velocity = characterNode.GlobalPosition.DirectionTo(destination);

        characterNode.MoveAndSlide();
    }
}
