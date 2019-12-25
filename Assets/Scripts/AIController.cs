using UnityEngine;

public class AIController : TopDownCharacterController
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void Update()
    {
        Vector2 targetDirection = PlayerController.playerPosition - transform.position;
        Vector2 movementDelta = new Vector2(Mathf.Clamp(targetDirection.x, -1.0f, 1.0f), Mathf.Clamp(targetDirection.y, -1.0f, 1.0f));

        character.Move(movementDelta);
        character.Rotate(targetDirection);
    }
}
