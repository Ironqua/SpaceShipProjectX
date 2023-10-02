using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager 
{
    private DefaultAction _input;
    public bool IsForceUp { get; private set; }
    public float pressLeftRight { get; private set; }


    public InputManager()
    {
        _input = new DefaultAction();

        _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
        _input.Rocket.LeftRight.performed += context => pressLeftRight = context.ReadValue<float>();



        _input.Enable();

    }
    





}
