// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using UnityEngine;

namespace TestHelper.Input.TestDoubles
{
    public class StubInputKey : InputWrapper
    {
        public KeyCode[] PushedKeys { get; set; } = Array.Empty<KeyCode>();

        public override bool GetKey(KeyCode key)
        {
            foreach (var pushedKey in PushedKeys)
            {
                if (pushedKey == key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
