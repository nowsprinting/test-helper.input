// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace TestHelper.Input
{
    /// <summary>
    /// Calling real methods of the <see cref="UnityEngine.Input">UnityEngine.Input</see> class.
    /// Use this implementation for IInput in production builds.
    /// </summary>
    /// <remarks>
    /// If you are concerned about performance degradation due to method calls between assemblies, copy this class to your assembly.
    /// Would be inlining the compiler if they were in the same assembly.
    /// </remarks>
    public class InputWrapper : IInput
    {
        /// <inheritdoc/>
        public virtual float GetAxis(string axisName) => UnityEngine.Input.GetAxis(axisName);

        /// <inheritdoc/>
        public virtual float GetAxisRaw(string axisName) => UnityEngine.Input.GetAxisRaw(axisName);

        /// <inheritdoc/>
        public virtual bool GetButton(string buttonName) => UnityEngine.Input.GetButton(buttonName);

        /// <inheritdoc/>
        public virtual bool GetButtonDown(string buttonName) => UnityEngine.Input.GetButtonDown(buttonName);

        /// <inheritdoc/>
        public virtual bool GetButtonUp(string buttonName) => UnityEngine.Input.GetButtonUp(buttonName);

        /// <inheritdoc/>
        public virtual bool GetMouseButton(int button) => UnityEngine.Input.GetMouseButton(button);

        /// <inheritdoc/>
        public virtual bool GetMouseButtonDown(int button) => UnityEngine.Input.GetMouseButtonDown(button);

        /// <inheritdoc/>
        public virtual bool GetMouseButtonUp(int button) => UnityEngine.Input.GetMouseButtonUp(button);

        /// <inheritdoc/>
        public virtual void ResetInputAxes() => UnityEngine.Input.ResetInputAxes();

        /// <inheritdoc/>
#if UNITY_EDITOR
        public virtual bool IsJoystickPreconfigured(string joystickName) =>
            UnityEngine.Input.IsJoystickPreconfigured(joystickName);
#else
        public virtual bool IsJoystickPreconfigured(string joystickName) => false;
        // TODO: 'Input' does not contain a definition for 'IsJoystickPreconfigured'
#endif

        /// <inheritdoc/>
        public virtual string[] GetJoystickNames() => UnityEngine.Input.GetJoystickNames();

        /// <inheritdoc/>
        public virtual Touch GetTouch(int index) => UnityEngine.Input.GetTouch(index);

        /// <inheritdoc/>
        public virtual AccelerationEvent GetAccelerationEvent(int index) =>
            UnityEngine.Input.GetAccelerationEvent(index);

        /// <inheritdoc/>
        public virtual bool GetKey(KeyCode key) => UnityEngine.Input.GetKey(key);

        /// <inheritdoc/>
        public virtual bool GetKey(string name) => UnityEngine.Input.GetKey(name);

        /// <inheritdoc/>
        public virtual bool GetKeyUp(KeyCode key) => UnityEngine.Input.GetKeyUp(key);

        /// <inheritdoc/>
        public virtual bool GetKeyUp(string name) => UnityEngine.Input.GetKeyUp(name);

        /// <inheritdoc/>
        public virtual bool GetKeyDown(KeyCode key) => UnityEngine.Input.GetKeyDown(key);

        /// <inheritdoc/>
        public virtual bool GetKeyDown(string name) => UnityEngine.Input.GetKeyDown(name);

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool simulateMouseWithTouches
        {
            get => UnityEngine.Input.simulateMouseWithTouches;
            set { UnityEngine.Input.simulateMouseWithTouches = value; }
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool anyKey { get => UnityEngine.Input.anyKey; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool anyKeyDown { get => UnityEngine.Input.anyKeyDown; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual string inputString { get => UnityEngine.Input.inputString; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Vector3 mousePosition { get => UnityEngine.Input.mousePosition; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Vector2 mouseScrollDelta { get => UnityEngine.Input.mouseScrollDelta; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual IMECompositionMode imeCompositionMode
        {
            get => UnityEngine.Input.imeCompositionMode;
            set { UnityEngine.Input.imeCompositionMode = value; }
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual string compositionString { get => UnityEngine.Input.compositionString; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool imeIsSelected { get => UnityEngine.Input.imeIsSelected; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Vector2 compositionCursorPos
        {
            get => UnityEngine.Input.compositionCursorPos;
            set { UnityEngine.Input.compositionCursorPos = value; }
        }

        /// <inheritdoc/>
        [Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool eatKeyPressOnTextFieldFocus
        {
            get => UnityEngine.Input.eatKeyPressOnTextFieldFocus;
            set { UnityEngine.Input.eatKeyPressOnTextFieldFocus = value; }
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool mousePresent { get => UnityEngine.Input.mousePresent; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual int touchCount { get => UnityEngine.Input.touchCount; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool touchPressureSupported { get => UnityEngine.Input.touchPressureSupported; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool stylusTouchSupported { get => UnityEngine.Input.stylusTouchSupported; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool touchSupported { get => UnityEngine.Input.touchSupported; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool multiTouchEnabled
        {
            get => UnityEngine.Input.multiTouchEnabled;
            set { UnityEngine.Input.multiTouchEnabled = value; }
        }

        [Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        [SuppressMessage("ReSharper", "MissingXmlDoc")]
        public virtual bool isGyroAvailable { get => UnityEngine.Input.isGyroAvailable; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual DeviceOrientation deviceOrientation { get => UnityEngine.Input.deviceOrientation; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Vector3 acceleration { get => UnityEngine.Input.acceleration; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool compensateSensors
        {
            get => UnityEngine.Input.compensateSensors;
            set { UnityEngine.Input.compensateSensors = value; }
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual int accelerationEventCount { get => UnityEngine.Input.accelerationEventCount; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual bool backButtonLeavesApp
        {
            get => UnityEngine.Input.backButtonLeavesApp;
            set { UnityEngine.Input.backButtonLeavesApp = value; }
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual LocationService location
        {
            get => UnityEngine.Input.location;
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Compass compass
        {
            get => UnityEngine.Input.compass;
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Gyroscope gyro
        {
            get => UnityEngine.Input.gyro;
        }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual Touch[] touches { get => UnityEngine.Input.touches; }

        /// <inheritdoc/>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public virtual AccelerationEvent[] accelerationEvents { get => UnityEngine.Input.accelerationEvents; }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"wrapping UnityEngine.Input";
        }
    }
}
