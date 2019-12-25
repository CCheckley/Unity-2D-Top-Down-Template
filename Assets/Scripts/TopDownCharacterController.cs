using UnityEngine;

[RequireComponent(typeof(TopDownCharacter))]
public class TopDownCharacterController : MonoBehaviour
{
    protected TopDownCharacter character;

    protected virtual void Awake()
    {
        character = GetComponent<TopDownCharacter>();
    }
}