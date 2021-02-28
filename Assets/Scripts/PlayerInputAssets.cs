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
