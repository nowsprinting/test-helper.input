// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace TestHelper.Input
{
    /// <summary>
    /// Interface extract from <see cref="UnityEngine.Input">UnityEngine.Input</see> class.
    /// <c>UnityEngine.Input</c>'s static methods are replaced with instance methods.
    /// </summary>
    public interface IInput
    {
        /// <summary>
        ///   <para>Returns the value of the virtual axis identified by axisName.</para>
        /// </summary>
        /// <param name="axisName"></param>
        float GetAxis(string axisName);

        /// <summary>
        ///   <para>Returns the value of the virtual axis identified by axisName with no smoothing filtering applied.</para>
        /// </summary>
        /// <param name="axisName"></param>
        float GetAxisRaw(string axisName);

        /// <summary>
        ///   <para>Returns true while the virtual button identified by buttonName is held down.</para>
        /// </summary>
        /// <param name="buttonName">The name of the button such as Jump.</param>
        /// <returns>
        ///   <para>True when an axis has been pressed and not released.</para>
        /// </returns>
        bool GetButton(string buttonName);

        /// <summary>
        ///   <para>Returns true during the frame the user pressed down the virtual button identified by buttonName.</para>
        /// </summary>
        /// <param name="buttonName"></param>
        bool GetButtonDown(string buttonName);

        /// <summary>
        ///   <para>Returns true the first frame the user releases the virtual button identified by buttonName.</para>
        /// </summary>
        /// <param name="buttonName"></param>
        bool GetButtonUp(string buttonName);

        /// <summary>
        ///   <para>Returns whether the given mouse button is held down.</para>
        /// </summary>
        /// <param name="button"></param>
        bool GetMouseButton(int button);

        /// <summary>
        ///   <para>Returns true during the frame the user pressed the given mouse button.</para>
        /// </summary>
        /// <param name="button"></param>
        bool GetMouseButtonDown(int button);

        /// <summary>
        ///   <para>Returns true during the frame the user releases the given mouse button.</para>
        /// </summary>
        /// <param name="button"></param>
        bool GetMouseButtonUp(int button);

        /// <summary>
        ///   <para>Resets all input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame.</para>
        /// </summary>
        void ResetInputAxes();

        /// <summary>
        ///   <para>Determine whether a particular joystick model has been preconfigured by Unity. (Linux-only).</para>
        /// </summary>
        /// <param name="joystickName">The name of the joystick to check (returned by Input.GetJoystickNames).</param>
        /// <returns>
        ///   <para>True if the joystick layout has been preconfigured; false otherwise.</para>
        /// </returns>
        bool IsJoystickPreconfigured(string joystickName);

        /// <summary>
        ///   <para>Retrieves a list of input device names corresponding to the index of an Axis configured within Input Manager.</para>
        /// </summary>
        /// <returns>
        ///   <para>Returns an array of joystick and gamepad device names.</para>
        /// </returns>
        string[] GetJoystickNames();

        /// <summary>
        ///   <para>Call Input.GetTouch to obtain a Touch struct.</para>
        /// </summary>
        /// <param name="index">The touch input on the device screen.</param>
        /// <returns>
        ///   <para>Touch details in the struct.</para>
        /// </returns>
        Touch GetTouch(int index);

        /// <summary>
        ///   <para>Returns specific acceleration measurement which occurred during last frame. (Does not allocate temporary variables).</para>
        /// </summary>
        /// <param name="index"></param>
        AccelerationEvent GetAccelerationEvent(int index);

        /// <summary>
        ///   <para>Returns true while the user holds down the key identified by the key KeyCode enum parameter.</para>
        /// </summary>
        /// <param name="key"></param>
        bool GetKey(KeyCode key);

        /// <summary>
        ///   <para>Returns true while the user holds down the key identified by name.</para>
        /// </summary>
        /// <param name="name"></param>
        bool GetKey(string name);

        /// <summary>
        ///   <para>Returns true during the frame the user releases the key identified by the key KeyCode enum parameter.</para>
        /// </summary>
        /// <param name="key"></param>
        bool GetKeyUp(KeyCode key);

        /// <summary>
        ///   <para>Returns true during the frame the user releases the key identified by name.</para>
        /// </summary>
        /// <param name="name"></param>
        bool GetKeyUp(string name);

        /// <summary>
        ///   <para>Returns true during the frame the user starts pressing down the key identified by the key KeyCode enum parameter.</para>
        /// </summary>
        /// <param name="key"></param>
        bool GetKeyDown(KeyCode key);

        /// <summary>
        ///   <para>Returns true during the frame the user starts pressing down the key identified by name.</para>
        /// </summary>
        /// <param name="name"></param>
        bool GetKeyDown(string name);

        /// <summary>
        ///   <para>Enables/Disables mouse simulation with touches. By default this option is enabled.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool simulateMouseWithTouches { get; set; }

        /// <summary>
        ///   <para>Is any key or mouse button currently held down? (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool anyKey { get; }

        /// <summary>
        ///   <para>Returns true the first frame the user hits any key or mouse button. (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool anyKeyDown { get; }

        /// <summary>
        ///   <para>Returns the keyboard input entered this frame. (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        string inputString { get; }

        /// <summary>
        ///   <para>The current mouse position in pixel coordinates. (Read Only).</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Vector3 mousePosition { get; }

        /// <summary>
        ///   <para>The current mouse scroll delta. (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Vector2 mouseScrollDelta { get; }

        /// <summary>
        ///   <para>Controls enabling and disabling of IME input composition.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        IMECompositionMode imeCompositionMode { get; set; }

        /// <summary>
        ///   <para>The current IME composition string being typed by the user.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        string compositionString { get; }

        /// <summary>
        ///   <para>Does the user have an IME keyboard input source selected?</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool imeIsSelected { get; }

        /// <summary>
        ///   <para>The current text input position used by IMEs to open windows.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Vector2 compositionCursorPos { get; set; }

        /// <summary>
        ///   <para>Property indicating whether keypresses are eaten by a textinput if it has focus (default true).</para>
        /// </summary>
        [Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool eatKeyPressOnTextFieldFocus { get; set; }

        /// <summary>
        ///   <para>Indicates if a mouse device is detected.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool mousePresent { get; }

        /// <summary>
        ///   <para>Number of touches. Guaranteed not to change throughout the frame. (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        int touchCount { get; }

        /// <summary>
        ///   <para>Bool value which let's users check if touch pressure is supported.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool touchPressureSupported { get; }

        /// <summary>
        ///   <para>Returns true when Stylus Touch is supported by a device or platform.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool stylusTouchSupported { get; }

        /// <summary>
        ///   <para>Returns whether the device on which application is currently running supports touch input.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool touchSupported { get; }

        /// <summary>
        ///   <para>Property indicating whether the system handles multiple touches.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool multiTouchEnabled { get; set; }

        [Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        [SuppressMessage("ReSharper", "MissingXmlDoc")]
        bool isGyroAvailable { get; }

        /// <summary>
        ///   <para>Device physical orientation as reported by OS. (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        DeviceOrientation deviceOrientation { get; }

        /// <summary>
        ///   <para>Last measured linear acceleration of a device in three-dimensional space. (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Vector3 acceleration { get; }

        /// <summary>
        ///   <para>This property controls if input sensors should be compensated for screen orientation.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool compensateSensors { get; set; }

        /// <summary>
        ///   <para>Number of acceleration measurements which occurred during last frame.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        int accelerationEventCount { get; }

        /// <summary>
        ///         <para>Should  Back button quit the application?
        /// 
        /// Only usable on Android, Windows Phone or Windows Tablets.</para>
        ///       </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        bool backButtonLeavesApp { get; set; }

        /// <summary>
        ///   <para>Property for accessing device location (handheld devices only). (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        LocationService location { get; }

        /// <summary>
        ///   <para>Property for accessing compass (handheld devices only). (Read Only)</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Compass compass { get; }

        /// <summary>
        ///   <para>Returns default gyroscope.</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Gyroscope gyro { get; }

        /// <summary>
        ///   <para>Returns list of objects representing status of all touches during last frame. (Read Only) (Allocates temporary variables).</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        Touch[] touches { get; }

        /// <summary>
        ///   <para>Returns list of acceleration measurements which occurred during the last frame. (Read Only) (Allocates temporary variables).</para>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        AccelerationEvent[] accelerationEvents { get; }
    }
}
