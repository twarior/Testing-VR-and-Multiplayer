// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PLayer"",
            ""id"": ""20629c9f-847a-492f-8b59-091fd127de2d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""38d76c82-9435-4fd8-9b51-3ceca21c704b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""VR Thumbstick"",
                    ""id"": ""4abd4b5d-a8c9-4a1a-b0be-aa880cfcf604"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e0519dc6-88ee-4e2e-9c49-44668aac8044"",
                    ""path"": ""<OculusTouchController>/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aa2fca51-1405-49ef-a4e7-0079e5b30b9d"",
                    ""path"": ""<OculusTouchController>/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""45d12a15-5ffb-451e-80f1-001f2e6e4a21"",
                    ""path"": ""<OculusTouchController>/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d982f88f-1da2-4c64-86ef-3f17cf1f9759"",
                    ""path"": ""<OculusTouchController>/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a246da17-16de-49f2-a4f8-4ea26fee5036"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50230973-33b0-46e7-8551-afa03c243392"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""16738c77-573a-4c3d-93e6-632105053e70"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""be0a78d2-deff-4f53-9c1d-71f939b42ac3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dd7c2339-708e-43e2-9db3-f2c63564a834"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<OpenVROculusTouchController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<OculusTouchController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<OculusGoController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<AndroidJoystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PLayer
        m_PLayer = asset.FindActionMap("PLayer", throwIfNotFound: true);
        m_PLayer_Movement = m_PLayer.FindAction("Movement", throwIfNotFound: true);
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

    // PLayer
    private readonly InputActionMap m_PLayer;
    private IPLayerActions m_PLayerActionsCallbackInterface;
    private readonly InputAction m_PLayer_Movement;
    public struct PLayerActions
    {
        private @Controls m_Wrapper;
        public PLayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PLayer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PLayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PLayerActions set) { return set.Get(); }
        public void SetCallbacks(IPLayerActions instance)
        {
            if (m_Wrapper.m_PLayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PLayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PLayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PLayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PLayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PLayerActions @PLayer => new PLayerActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IPLayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
