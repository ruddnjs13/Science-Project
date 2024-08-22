using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

public class InputReade : ScriptableObject, IPlayerInputActions
{
    private Controls controls;
    private void Awake()
    {
        if (controls == null)
        {
            controls = new Controls();
        }

        controls.PlayerInput.SetCallbacks(this);
        controls.PlayerInput.Enable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("มกวม");
        }
    }
}
