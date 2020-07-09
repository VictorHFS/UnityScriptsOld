// GENERATED AUTOMATICALLY FROM 'Assets/LocalAssets/UserControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UserControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""73278cdc-418d-461e-81c1-789ca1d186a8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5044f9d0-e100-4671-a9b4-629dcea7ccf8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cast Freeze"",
                    ""type"": ""Button"",
                    ""id"": ""7b43f672-74ae-41cd-816b-f41ddf27f92b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CancelCast"",
                    ""type"": ""Button"",
                    ""id"": ""85bb21ad-3cc7-49be-a9b4-4093a03cd8c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c88a5a9-da44-46e9-a468-30667c3a4ce1"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cast Freeze"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Default"",
                    ""id"": ""912375a2-e12a-4095-b00c-96d4a0525e85"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""df99abe7-9bae-4507-95d9-0d5e104f20f7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1ffc15f8-b6ec-47a8-a4ea-91b74f72b7df"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""644d6270-d171-4699-a457-04c874a60c1f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a715d868-0657-4fab-8161-f0e711953cfe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3bdfc338-e382-40ac-ae80-af8e6618a891"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelCast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""76326a74-ec4a-4c88-8c9e-4941660f41dc"",
            ""actions"": [
                {
                    ""name"": ""MouseMove"",
                    ""type"": ""Value"",
                    ""id"": ""d39f84b3-c6c0-420f-a81c-9a01070156a5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c9093b96-3f63-470f-9385-c58e0156ed43"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Cast"",
            ""id"": ""2d2b0680-b5be-4c05-a0f9-68175119f65e"",
            ""actions"": [
                {
                    ""name"": ""Cast"",
                    ""type"": ""Button"",
                    ""id"": ""5fbbd514-b457-4dd5-a609-8fa9ad33a747"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForcePush"",
                    ""type"": ""Button"",
                    ""id"": ""263d6317-d198-47b7-9c57-36f3795742ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PullIn"",
                    ""type"": ""Button"",
                    ""id"": ""3f02bd5d-d36a-4160-856e-5d0d2ba61f22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CancelCast"",
                    ""type"": ""Button"",
                    ""id"": ""221b809e-fc2f-4bdc-b0db-42753bdca79c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5cb7a456-bdab-47f5-9032-fd4919b34c0b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eee5863-d9d9-468c-9000-74c0cad077b9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForcePush"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc80e73a-2a97-436b-868b-df415468355e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PullIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""150295fb-7f41-4e57-892b-89af67ec4278"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelCast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_CastFreeze = m_Player.FindAction("Cast Freeze", throwIfNotFound: true);
        m_Player_CancelCast = m_Player.FindAction("CancelCast", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_MouseMove = m_Camera.FindAction("MouseMove", throwIfNotFound: true);
        // Cast
        m_Cast = asset.FindActionMap("Cast", throwIfNotFound: true);
        m_Cast_Cast = m_Cast.FindAction("Cast", throwIfNotFound: true);
        m_Cast_ForcePush = m_Cast.FindAction("ForcePush", throwIfNotFound: true);
        m_Cast_PullIn = m_Cast.FindAction("PullIn", throwIfNotFound: true);
        m_Cast_CancelCast = m_Cast.FindAction("CancelCast", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_CastFreeze;
    private readonly InputAction m_Player_CancelCast;
    public struct PlayerActions
    {
        private @UserControls m_Wrapper;
        public PlayerActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @CastFreeze => m_Wrapper.m_Player_CastFreeze;
        public InputAction @CancelCast => m_Wrapper.m_Player_CancelCast;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @CastFreeze.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCastFreeze;
                @CastFreeze.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCastFreeze;
                @CastFreeze.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCastFreeze;
                @CancelCast.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCancelCast;
                @CancelCast.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCancelCast;
                @CancelCast.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCancelCast;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @CastFreeze.started += instance.OnCastFreeze;
                @CastFreeze.performed += instance.OnCastFreeze;
                @CastFreeze.canceled += instance.OnCastFreeze;
                @CancelCast.started += instance.OnCancelCast;
                @CancelCast.performed += instance.OnCancelCast;
                @CancelCast.canceled += instance.OnCancelCast;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_MouseMove;
    public struct CameraActions
    {
        private @UserControls m_Wrapper;
        public CameraActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseMove => m_Wrapper.m_Camera_MouseMove;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @MouseMove.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMouseMove;
                @MouseMove.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMouseMove;
                @MouseMove.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMouseMove;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseMove.started += instance.OnMouseMove;
                @MouseMove.performed += instance.OnMouseMove;
                @MouseMove.canceled += instance.OnMouseMove;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Cast
    private readonly InputActionMap m_Cast;
    private ICastActions m_CastActionsCallbackInterface;
    private readonly InputAction m_Cast_Cast;
    private readonly InputAction m_Cast_ForcePush;
    private readonly InputAction m_Cast_PullIn;
    private readonly InputAction m_Cast_CancelCast;
    public struct CastActions
    {
        private @UserControls m_Wrapper;
        public CastActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cast => m_Wrapper.m_Cast_Cast;
        public InputAction @ForcePush => m_Wrapper.m_Cast_ForcePush;
        public InputAction @PullIn => m_Wrapper.m_Cast_PullIn;
        public InputAction @CancelCast => m_Wrapper.m_Cast_CancelCast;
        public InputActionMap Get() { return m_Wrapper.m_Cast; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CastActions set) { return set.Get(); }
        public void SetCallbacks(ICastActions instance)
        {
            if (m_Wrapper.m_CastActionsCallbackInterface != null)
            {
                @Cast.started -= m_Wrapper.m_CastActionsCallbackInterface.OnCast;
                @Cast.performed -= m_Wrapper.m_CastActionsCallbackInterface.OnCast;
                @Cast.canceled -= m_Wrapper.m_CastActionsCallbackInterface.OnCast;
                @ForcePush.started -= m_Wrapper.m_CastActionsCallbackInterface.OnForcePush;
                @ForcePush.performed -= m_Wrapper.m_CastActionsCallbackInterface.OnForcePush;
                @ForcePush.canceled -= m_Wrapper.m_CastActionsCallbackInterface.OnForcePush;
                @PullIn.started -= m_Wrapper.m_CastActionsCallbackInterface.OnPullIn;
                @PullIn.performed -= m_Wrapper.m_CastActionsCallbackInterface.OnPullIn;
                @PullIn.canceled -= m_Wrapper.m_CastActionsCallbackInterface.OnPullIn;
                @CancelCast.started -= m_Wrapper.m_CastActionsCallbackInterface.OnCancelCast;
                @CancelCast.performed -= m_Wrapper.m_CastActionsCallbackInterface.OnCancelCast;
                @CancelCast.canceled -= m_Wrapper.m_CastActionsCallbackInterface.OnCancelCast;
            }
            m_Wrapper.m_CastActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cast.started += instance.OnCast;
                @Cast.performed += instance.OnCast;
                @Cast.canceled += instance.OnCast;
                @ForcePush.started += instance.OnForcePush;
                @ForcePush.performed += instance.OnForcePush;
                @ForcePush.canceled += instance.OnForcePush;
                @PullIn.started += instance.OnPullIn;
                @PullIn.performed += instance.OnPullIn;
                @PullIn.canceled += instance.OnPullIn;
                @CancelCast.started += instance.OnCancelCast;
                @CancelCast.performed += instance.OnCancelCast;
                @CancelCast.canceled += instance.OnCancelCast;
            }
        }
    }
    public CastActions @Cast => new CastActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnCastFreeze(InputAction.CallbackContext context);
        void OnCancelCast(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMouseMove(InputAction.CallbackContext context);
    }
    public interface ICastActions
    {
        void OnCast(InputAction.CallbackContext context);
        void OnForcePush(InputAction.CallbackContext context);
        void OnPullIn(InputAction.CallbackContext context);
        void OnCancelCast(InputAction.CallbackContext context);
    }
}
