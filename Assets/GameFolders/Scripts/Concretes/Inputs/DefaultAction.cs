//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/GameFolders/Scripts/Concretes/Inputs/DefaultAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DefaultAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""68b7ddc8-4f67-4e41-b55c-ba09a1a1202c"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d5649918-3be8-48c9-b4f1-3cd0d619ddc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9401f580-fec1-454d-a1cd-de844f971aa9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d3bbe319-9acb-4253-8f7f-74bd6c289277"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""f29eb0ea-3ee5-4c9c-9711-5ecb85d7ef6f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7c1adaed-6b73-42ed-8760-77ca1249f5c2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2c320569-2e3c-49c0-a64a-2a7f35478832"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
        m_Rocket_LeftRight = m_Rocket.FindAction("LeftRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Rocket
    private readonly InputActionMap m_Rocket;
    private List<IRocketActions> m_RocketActionsCallbackInterfaces = new List<IRocketActions>();
    private readonly InputAction m_Rocket_ForceUp;
    private readonly InputAction m_Rocket_LeftRight;
    public struct RocketActions
    {
        private @DefaultAction m_Wrapper;
        public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
        public InputAction @LeftRight => m_Wrapper.m_Rocket_LeftRight;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void AddCallbacks(IRocketActions instance)
        {
            if (instance == null || m_Wrapper.m_RocketActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RocketActionsCallbackInterfaces.Add(instance);
            @ForceUp.started += instance.OnForceUp;
            @ForceUp.performed += instance.OnForceUp;
            @ForceUp.canceled += instance.OnForceUp;
            @LeftRight.started += instance.OnLeftRight;
            @LeftRight.performed += instance.OnLeftRight;
            @LeftRight.canceled += instance.OnLeftRight;
        }

        private void UnregisterCallbacks(IRocketActions instance)
        {
            @ForceUp.started -= instance.OnForceUp;
            @ForceUp.performed -= instance.OnForceUp;
            @ForceUp.canceled -= instance.OnForceUp;
            @LeftRight.started -= instance.OnLeftRight;
            @LeftRight.performed -= instance.OnLeftRight;
            @LeftRight.canceled -= instance.OnLeftRight;
        }

        public void RemoveCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRocketActions instance)
        {
            foreach (var item in m_Wrapper.m_RocketActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RocketActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RocketActions @Rocket => new RocketActions(this);
    public interface IRocketActions
    {
        void OnForceUp(InputAction.CallbackContext context);
        void OnLeftRight(InputAction.CallbackContext context);
    }
}
