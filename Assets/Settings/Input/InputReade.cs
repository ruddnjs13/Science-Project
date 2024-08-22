using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

[CreateAssetMenu(menuName ="SO/InputReader")]
public class InputReader : ScriptableObject, IPlayerInputActions
{
    public event Action<Vector3> OnMovementEvent;

    private Controls controls;
    private void OnEnable()
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

    public void OnUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnMovementEvent?.Invoke(new Vector3(0,1,0));
        }
    }

    public void OnDown(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            OnMovementEvent?.Invoke(new Vector3(0,-1,0));
        }
    }

    public void OnLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnMovementEvent?.Invoke(new Vector3(-1, 0, 0));
        }
    }

    public void OnRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnMovementEvent?.Invoke(new Vector3(1, 0, 0));
        }
    }
}
