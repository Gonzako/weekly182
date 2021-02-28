// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputAssets.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAssets : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAssets()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAssets"",
    ""maps"": [
        {
            ""name"": ""GameWorld"",
            ""id"": ""b035b5e6-6d3f-4a9b-9165-149280a248d3"",
            ""actions"": [
                {
                    ""name"": ""DesiredDelta"",
                    ""type"": ""Value"",
                    ""id"": ""25667d30-b0f3-44de-b3b2-7a07baf7c95e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5dd9c42d-3148-4675-95f1-8a36dd40dd27"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""346e20f8-8e06-4061-8792-9c5441ac801e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""979a1f5a-c14a-46cf-aac4-eaf56fdbda68"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0eda3124-8f03-4eb2-8dac-7284144b7f45"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b0a8a690-9bdd-4846-be28-ac026f5dd54a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b87ad8a-0326-42bf-934c-0a5bc70ac2fc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""77f098c8-6684-4f8d-b2e1-78330b4c630e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9e38a7d6-df05-4f18-aae0-09a804f5ee7a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d94efece-20e3-4c9f-afb1-ca3ca5d67ff0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""332319d9-cee6-44cd-869d-6e25b8adece5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""23bdd67a-a972-4b41-9e54-b813d16b2e73"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DesiredDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameWorld
        m_GameWorld = asset.FindActionMap("GameWorld", throwIfNotFound: true);
        m_GameWorld_DesiredDelta = m_GameWorld.FindAction("DesiredDelta", throwIfNotFound: true);
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

    // GameWorld
    private readonly InputActionMap m_GameWorld;
    private IGameWorldActions m_GameWorldActionsCallbackInterface;
    private readonly InputAction m_GameWorld_DesiredDelta;
    public struct GameWorldActions
    {
        private @PlayerInputAssets m_Wrapper;
        public GameWorldActions(@PlayerInputAssets wrapper) { m_Wrapper = wrapper; }
        public InputAction @DesiredDelta => m_Wrapper.m_GameWorld_DesiredDelta;
        public InputActionMap Get() { return m_Wrapper.m_GameWorld; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameWorldActions set) { return set.Get(); }
        public void SetCallbacks(IGameWorldActions instance)
        {
            if (m_Wrapper.m_GameWorldActionsCallbackInterface != null)
            {
                @DesiredDelta.started -= m_Wrapper.m_GameWorldActionsCallbackInterface.OnDesiredDelta;
                @DesiredDelta.performed -= m_Wrapper.m_GameWorldActionsCallbackInterface.OnDesiredDelta;
                @DesiredDelta.canceled -= m_Wrapper.m_GameWorldActionsCallbackInterface.OnDesiredDelta;
            }
            m_Wrapper.m_GameWorldActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DesiredDelta.started += instance.OnDesiredDelta;
                @DesiredDelta.performed += instance.OnDesiredDelta;
                @DesiredDelta.canceled += instance.OnDesiredDelta;
            }
        }
    }
    public GameWorldActions @GameWorld => new GameWorldActions(this);
    public interface IGameWorldActions
    {
        void OnDesiredDelta(InputAction.CallbackContext context);
    }
}
