// GENERATED AUTOMATICALLY FROM 'Assets/scripte/Comnbat2/Combat.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Combat : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Combat()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Combat"",
    ""maps"": [
        {
            ""name"": ""Combat2"",
            ""id"": ""e758569f-df82-4243-8f23-97bdff60262a"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""0ab0b59e-557f-4713-bfb5-00dbaa6b0d5b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""b07f6893-5a2f-4e5f-86f4-8892a7044e65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeClick"",
                    ""type"": ""Button"",
                    ""id"": ""7172cf55-edd2-49da-bc9a-bda8133b251b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e74bd6aa-f854-42bb-b169-6a59d99e3829"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a19de58-40fa-4cdd-927e-5ee615c604a0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfd4c1ce-c7e8-4a1a-bee5-bb9754b2d4c9"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FPSWalker"",
            ""id"": ""9e86e2c0-bdb7-4201-a4b0-60b22e735666"",
            ""actions"": [
                {
                    ""name"": ""ZQSD"",
                    ""type"": ""Value"",
                    ""id"": ""19c2ad6c-9685-489a-beac-898e4729cf14"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""e9275e4a-b371-4109-84eb-49286e69563e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""f7987e1a-7f46-418e-9d11-d00e7725f7e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""52c25332-ced2-4fbb-ba7d-546a0854a76b"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""25343168-53ad-452a-ad0d-033982fb22dc"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZQSD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""49b3e01d-318a-44ce-b7a9-d2c0a6c4e243"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""ZQSD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""588562f2-7210-4a3d-8f6a-95d82e201711"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""ZQSD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""605c95c9-8a89-4a00-b4eb-d66a8ad38114"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZQSD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""de4795e9-780a-456f-b5e4-1990fa88de0d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZQSD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""40888a44-75d3-4b16-8d13-e23bc4214fd9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Combat2
        m_Combat2 = asset.FindActionMap("Combat2", throwIfNotFound: true);
        m_Combat2_Newaction = m_Combat2.FindAction("New action", throwIfNotFound: true);
        m_Combat2_Click = m_Combat2.FindAction("Click", throwIfNotFound: true);
        m_Combat2_LeClick = m_Combat2.FindAction("LeClick", throwIfNotFound: true);
        // FPSWalker
        m_FPSWalker = asset.FindActionMap("FPSWalker", throwIfNotFound: true);
        m_FPSWalker_ZQSD = m_FPSWalker.FindAction("ZQSD", throwIfNotFound: true);
        m_FPSWalker_Click = m_FPSWalker.FindAction("Click", throwIfNotFound: true);
        m_FPSWalker_CameraControl = m_FPSWalker.FindAction("CameraControl", throwIfNotFound: true);
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

    // Combat2
    private readonly InputActionMap m_Combat2;
    private ICombat2Actions m_Combat2ActionsCallbackInterface;
    private readonly InputAction m_Combat2_Newaction;
    private readonly InputAction m_Combat2_Click;
    private readonly InputAction m_Combat2_LeClick;
    public struct Combat2Actions
    {
        private @Combat m_Wrapper;
        public Combat2Actions(@Combat wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Combat2_Newaction;
        public InputAction @Click => m_Wrapper.m_Combat2_Click;
        public InputAction @LeClick => m_Wrapper.m_Combat2_LeClick;
        public InputActionMap Get() { return m_Wrapper.m_Combat2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Combat2Actions set) { return set.Get(); }
        public void SetCallbacks(ICombat2Actions instance)
        {
            if (m_Wrapper.m_Combat2ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnNewaction;
                @Click.started -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnClick;
                @LeClick.started -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnLeClick;
                @LeClick.performed -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnLeClick;
                @LeClick.canceled -= m_Wrapper.m_Combat2ActionsCallbackInterface.OnLeClick;
            }
            m_Wrapper.m_Combat2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @LeClick.started += instance.OnLeClick;
                @LeClick.performed += instance.OnLeClick;
                @LeClick.canceled += instance.OnLeClick;
            }
        }
    }
    public Combat2Actions @Combat2 => new Combat2Actions(this);

    // FPSWalker
    private readonly InputActionMap m_FPSWalker;
    private IFPSWalkerActions m_FPSWalkerActionsCallbackInterface;
    private readonly InputAction m_FPSWalker_ZQSD;
    private readonly InputAction m_FPSWalker_Click;
    private readonly InputAction m_FPSWalker_CameraControl;
    public struct FPSWalkerActions
    {
        private @Combat m_Wrapper;
        public FPSWalkerActions(@Combat wrapper) { m_Wrapper = wrapper; }
        public InputAction @ZQSD => m_Wrapper.m_FPSWalker_ZQSD;
        public InputAction @Click => m_Wrapper.m_FPSWalker_Click;
        public InputAction @CameraControl => m_Wrapper.m_FPSWalker_CameraControl;
        public InputActionMap Get() { return m_Wrapper.m_FPSWalker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FPSWalkerActions set) { return set.Get(); }
        public void SetCallbacks(IFPSWalkerActions instance)
        {
            if (m_Wrapper.m_FPSWalkerActionsCallbackInterface != null)
            {
                @ZQSD.started -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnZQSD;
                @ZQSD.performed -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnZQSD;
                @ZQSD.canceled -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnZQSD;
                @Click.started -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnClick;
                @CameraControl.started -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_FPSWalkerActionsCallbackInterface.OnCameraControl;
            }
            m_Wrapper.m_FPSWalkerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ZQSD.started += instance.OnZQSD;
                @ZQSD.performed += instance.OnZQSD;
                @ZQSD.canceled += instance.OnZQSD;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
            }
        }
    }
    public FPSWalkerActions @FPSWalker => new FPSWalkerActions(this);
    public interface ICombat2Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnLeClick(InputAction.CallbackContext context);
    }
    public interface IFPSWalkerActions
    {
        void OnZQSD(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
    }
}
