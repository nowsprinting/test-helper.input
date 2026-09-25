// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;

namespace TestHelper.Input.TestDoubles
{
    public struct SimulateAxis
    {
        public string Name { get; private set; }
        public float Value { get; private set; }

        public SimulateAxis(string name, float value)
        {
            Name = name;
            Value = value;
        }
    }

    public class StubInputAxis : InputWrapper
    {
        public SimulateAxis[] Axes { get; set; } = Array.Empty<SimulateAxis>();

        public override float GetAxis(string axisName)
        {
            foreach (var axis in Axes)
            {
                if (axis.Name == axisName)
                {
                    return axis.Value;
                }
            }

            return 0f;
        }
    }
}
