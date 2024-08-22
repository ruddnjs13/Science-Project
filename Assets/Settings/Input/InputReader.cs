using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

[CreateAssetMenu(menuName = ("SO/InputReader"))]
public class InputReader : ScriptableObject, IPlayerActions
{
    Controls controls;

    public Vector2 Movement {  get; private set; }

    private void Awake()
    {
        if (controls == null)
        {
            controls = new Controls();
        }


        controls.Player.SetCallbacks(this);
        controls.Enable();
    }

    public void OnPlayerMovement(InputAction.CallbackContext context)
    {
        Vector2 movement = context.ReadValue<Vector2>();
        Movement = movement;
    }
}
