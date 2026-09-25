// Copyright (c) 2023-2026 Koji Hasegawa.
// This software is released under the MIT License.

using UnityEngine;

namespace TestHelper.Input.SUT
{
#if UNITY_2021_1_OR_NEWER
    [AddComponentMenu("/")]
#else
    // Not "/" on every version: Unity 2020.3 and earlier document only "" as the hidden menu name.
    [AddComponentMenu("")]
#endif
    internal class SampleController : MonoBehaviour
    {
        internal IInput Input { private get; set; } = new InputWrapper();

        private const float MoveSpeed = 7.0f;

        private void Update()
        {
            Move();
            Rotate();
        }

        private void Move()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * (MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * (MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * (MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * (MoveSpeed * Time.deltaTime);
            }
        }

        private void Rotate()
        {
            var horizontal = Input.GetAxis("Mouse X");
            transform.Rotate(new Vector3(0f, horizontal, 0f) * Time.deltaTime);
        }
    }
}
