// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/Test Assignment.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace TestAssignment.Input
{
    public class @TestAssignmentInputAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TestAssignmentInputAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Test Assignment"",
    ""maps"": [
        {
            ""name"": ""SkyCar"",
            ""id"": ""eae6e247-2bb3-449e-b026-7eabb8b11112"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""a54ea6fb-cedb-43ea-9e20-a2257ee75b84"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Value"",
                    ""id"": ""3d2fc7c6-b5cb-4fe7-a405-695f876bba0b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left/Right"",
                    ""type"": ""Value"",
                    ""id"": ""45397707-1a62-492b-a2c4-58a64e3a46ae"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""31f6fb25-2339-4cc0-a346-ea6928dd1be2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4ad75e42-0979-4c7f-a604-3086f414f95e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c0a30d83-eca7-4be4-87c4-bfd574e8ee61"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""262fd048-9fd7-4239-af66-fd21f68d3e7d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""33014b12-f8a9-4771-927f-5eba355a2e44"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7825da92-9d8b-4f2e-9ca2-f38945ac17de"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4786ed9f-6d26-48df-97fb-3f58cf81894e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Left/Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // SkyCar
            m_SkyCar = asset.FindActionMap("SkyCar", throwIfNotFound: true);
            m_SkyCar_Accelerate = m_SkyCar.FindAction("Accelerate", throwIfNotFound: true);
            m_SkyCar_Handbrake = m_SkyCar.FindAction("Handbrake", throwIfNotFound: true);
            m_SkyCar_LeftRight = m_SkyCar.FindAction("Left/Right", throwIfNotFound: true);
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

        // SkyCar
        private readonly InputActionMap m_SkyCar;
        private ISkyCarActions m_SkyCarActionsCallbackInterface;
        private readonly InputAction m_SkyCar_Accelerate;
        private readonly InputAction m_SkyCar_Handbrake;
        private readonly InputAction m_SkyCar_LeftRight;
        public struct SkyCarActions
        {
            private @TestAssignmentInputAction m_Wrapper;
            public SkyCarActions(@TestAssignmentInputAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @Accelerate => m_Wrapper.m_SkyCar_Accelerate;
            public InputAction @Handbrake => m_Wrapper.m_SkyCar_Handbrake;
            public InputAction @LeftRight => m_Wrapper.m_SkyCar_LeftRight;
            public InputActionMap Get() { return m_Wrapper.m_SkyCar; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SkyCarActions set) { return set.Get(); }
            public void SetCallbacks(ISkyCarActions instance)
            {
                if (m_Wrapper.m_SkyCarActionsCallbackInterface != null)
                {
                    @Accelerate.started -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnAccelerate;
                    @Accelerate.performed -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnAccelerate;
                    @Accelerate.canceled -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnAccelerate;
                    @Handbrake.started -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnHandbrake;
                    @Handbrake.performed -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnHandbrake;
                    @Handbrake.canceled -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnHandbrake;
                    @LeftRight.started -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_SkyCarActionsCallbackInterface.OnLeftRight;
                }
                m_Wrapper.m_SkyCarActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Accelerate.started += instance.OnAccelerate;
                    @Accelerate.performed += instance.OnAccelerate;
                    @Accelerate.canceled += instance.OnAccelerate;
                    @Handbrake.started += instance.OnHandbrake;
                    @Handbrake.performed += instance.OnHandbrake;
                    @Handbrake.canceled += instance.OnHandbrake;
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                }
            }
        }
        public SkyCarActions @SkyCar => new SkyCarActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        private int m_JoystickSchemeIndex = -1;
        public InputControlScheme JoystickScheme
        {
            get
            {
                if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
                return asset.controlSchemes[m_JoystickSchemeIndex];
            }
        }
        private int m_XRSchemeIndex = -1;
        public InputControlScheme XRScheme
        {
            get
            {
                if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
                return asset.controlSchemes[m_XRSchemeIndex];
            }
        }
        public interface ISkyCarActions
        {
            void OnAccelerate(InputAction.CallbackContext context);
            void OnHandbrake(InputAction.CallbackContext context);
            void OnLeftRight(InputAction.CallbackContext context);
        }
    }
}
