// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using System.Linq;
using UnityEngine;

namespace TestHelper.Input.TestDoubles
{
    public class StubInputKey : InputWrapper
    {
        public KeyCode[] PushedKeys { get; set; } = Array.Empty<KeyCode>();

        public override bool GetKey(KeyCode key)
        {
            return PushedKeys.Contains(key);
        }
    }
}
