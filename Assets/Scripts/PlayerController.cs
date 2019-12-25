using UnityEngine;

public class PlayerController : TopDownCharacterController
{
    public static Vector3 playerPosition;

    protected override void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        character.Move(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
        character.Rotate(Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);

        playerPosition = transform.position;
    }
}
