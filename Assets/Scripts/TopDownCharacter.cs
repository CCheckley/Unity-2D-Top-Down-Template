using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class TopDownCharacter : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;

    public float movementSpeed = 1000.0f;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        rigidbody2D.isKinematic = false;
        rigidbody2D.angularDrag = 0.0f;
        rigidbody2D.gravityScale = 0.0f;
    }

    public void Move(Vector2 velocityDelta)
    {
        rigidbody2D.velocity = (velocityDelta * movementSpeed) * Time.deltaTime;
    }

    public void Rotate(Vector2 rotationDelta)
    {
        rigidbody2D.rotation = Mathf.Atan2(rotationDelta.y, rotationDelta.x) * Mathf.Rad2Deg;
    }
}
