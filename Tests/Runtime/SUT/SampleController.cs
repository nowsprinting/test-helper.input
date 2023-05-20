// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using UnityEngine;

namespace TestHelper.Input.SUT
{
    internal class SampleController : MonoBehaviour
    {
        internal IInput Input { private get; set; } = new InputWrapper();

        private const float MoveSpeed = 7.0f;

        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * Time.deltaTime * MoveSpeed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * Time.deltaTime * MoveSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * Time.deltaTime * MoveSpeed;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * Time.deltaTime * MoveSpeed;
            }
        }
    }
}
