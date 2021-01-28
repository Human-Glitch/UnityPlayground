using Assets.Scripts.Configs;

namespace Assets.Scripts.Interfaces
{
    public interface IMovement
    {
        bool IsGrounded { get; }

        MovementSettings MovementSettings { get; }
    }
}
