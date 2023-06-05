// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using System.Collections;
using NUnit.Framework;
using TestHelper.Input.SUT;
using TestHelper.Input.TestDoubles;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

// ReSharper disable Unity.InefficientPropertyAccess

namespace TestHelper.Input
{
    /// <summary>
    /// Test <c>SampleController</c> using test stubs.
    /// </summary>
    [TestFixture]
    public class SampleControllerTest
    {
        private readonly Vector3EqualityComparer _positionComparer = new Vector3EqualityComparer(0.3f);
        private readonly QuaternionEqualityComparer _rotationComparer = new QuaternionEqualityComparer(0.3f);

        [UnityTest]
        public IEnumerator PushW_MoveForward()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInputKey();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.W }; // Push W key
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>(); // Release key

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(0f, 0f, 4f)).Using(_positionComparer));
        }

        [UnityTest]
        public IEnumerator PushA_MoveLeft()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInputKey();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.A };
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>();

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(-4f, 0f, 0f)).Using(_positionComparer));
        }

        [UnityTest]
        public IEnumerator PushS_MoveBack()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInputKey();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.S };
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>();

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(0f, 0f, -4f)).Using(_positionComparer));
        }

        [UnityTest]
        public IEnumerator PushD_MoveRight()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInputKey();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.D };
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>();

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(4f, 0f, 0f)).Using(_positionComparer));
        }

        [UnityTest]
        public IEnumerator MouseMoveToRight_RotateRight()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInputAxis();
            sut.Input = stub; // Inject test stub

            stub.Axes = new[] { new SimulateAxis("Mouse X", 2.0f) };
            yield return new WaitForSeconds(0.5f);
            stub.Axes = Array.Empty<SimulateAxis>();

            var actual = sut.transform.rotation;
            Assert.That(actual, Is.EqualTo(Quaternion.Euler(0f, 45f, 0f)).Using(_rotationComparer));
        }
    }
}
