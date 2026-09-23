using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    // Movement fields
    private float horizontalMovement;
    private float verticalMovement;
    private float force;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        force = 4.75f;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // Moves the player
    private void MovePlayer()
    {
        Vector3 direction = new Vector3(horizontalMovement, 0, verticalMovement);
        GetComponent<Rigidbody>().AddForce(direction * force);
    }
    private void SetMoveDirection(Vector2 input)
    {
    horizontalMovement = input.x;
    verticalMovement = input.y;
    }
    public void OnMoveInput(InputAction.CallbackContext ctx)
    {
    SetMoveDirection(ctx.ReadValue<Vector2>());  
    }
}   
