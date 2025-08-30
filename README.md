# Input Test Helper

[![Meta file check](https://github.com/nowsprinting/test-helper.input/actions/workflows/metacheck.yml/badge.svg)](https://github.com/nowsprinting/test-helper.input/actions/workflows/metacheck.yml)
[![Test](https://github.com/nowsprinting/test-helper.input/actions/workflows/test.yml/badge.svg)](https://github.com/nowsprinting/test-helper.input/actions/workflows/test.yml)
[![openupm](https://img.shields.io/npm/v/com.nowsprinting.test-helper.input?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.nowsprinting.test-helper.input/)
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/nowsprinting/test-helper.input)

Library for mocking the Input Manager (Legacy, [UnityEngine.Input](https://docs.unity3d.com/ScriptReference/Input.html)).  
Required Unity 2019 LTS or later.



## Features

### Mocking `UnityEngine.Input`

The `UnityEngine.Input` class provides static methods.
You can inject test stubs into your tests by replacing `Input` with the `IInput` interface.

Usage:

#### 1. Insert the code below into your product code to replace `UnityEngine.Input` with a `TestHelper.Input.InputWrapper` instance

```csharp
#if UNITY_INCLUDE_TESTS
    internal IInput Input { private get; set; } = new InputWrapper();
#endif
```

> [!TIP]  
> `InputWrapper` also works at runtime, but you can remove the `TestHelper.Input` assembly from the build using the `#if UNITY_INCLUDE_TESTS` directive.

#### 2. Create test stub in your test

```csharp
public class StubInput : InputWrapper
{
    public KeyCode[] PushedKeys { get; set; } = Array.Empty<KeyCode>();

    public override bool GetKey(KeyCode key)
    {
        return PushedKeys.Contains(key);
    }
}
```

#### 3. Write test using test stub

```csharp
[UnityTest]
public IEnumerator PushW_MoveForward()
{
    var sut = new GameObject().AddComponent<SUT>();
    var stub = new StubInput();
    sut.Input = stub; // Inject test stub

    stub.PushedKeys = new[] { KeyCode.W }; // Push W key
    yield return new WaitForSeconds(0.5f);
    stub.PushedKeys = Array.Empty<KeyCode>(); // Release key

    var actual = sut.transform.position;
    Assert.That(actual, Is.EqualTo(new Vector3(0f, 0f, 4f))
        .Using(new Vector3EqualityComparer(0.3f)));
}
```



## Installation

### 1. Install via Package Manager window

1. Open the Project Settings window (**Editor > Project Settings**) and select **Package Manager** tab (figure 1.)
2. Click **+** button under the **Scoped Registries** and enter the following settings:
    1. **Name:** `package.openupm.com`
    2. **URL:** `https://package.openupm.com`
    3. **Scope(s):** `com.nowsprinting`
3. Open the Package Manager window (**Window > Package Manager**) and select **My Registries** tab (figure 2.)
4. Select **Input Test Helper** and click the **Install** button

**Figure 1.** Scoped Registries setting in Project Settings window

![](Documentation~/ScopedRegistries_Dark.png#gh-dark-mode-only)
![](Documentation~/ScopedRegistries_Light.png#gh-light-mode-only)

**Figure 2.** My Registries in Package Manager window

![](Documentation~/PackageManager_Dark.png#gh-dark-mode-only)
![](Documentation~/PackageManager_Light.png#gh-light-mode-only)


### 2. Add assembly reference

1. Open your product and test assembly definition file (.asmdef) in **Inspector** window
2. Add **TestHelper.Input** into **Assembly Definition References**



## License

MIT License


## How to contribute

Open an issue or create a pull request.

Be grateful if you could label the PR as `enhancement`, `bug`, `chore`, and `documentation`.
See [PR Labeler settings](.github/pr-labeler.yml) for automatically labeling from the branch name.


## How to development

### Clone repo as a embedded package

Add this repository as a submodule to the Packages/ directory in your project.

Run the command below:

```bash
git submodule add git@github.com:nowsprinting/test-helper.input.git Packages/com.nowsprinting.test-helper.input
```


### Run tests

Generate a temporary project and run tests on each Unity version from the command line.

```bash
make create_project
UNITY_VERSION=2019.4.40f1 make -k test
```

> [!WARNING]  
> You must select "Input Manager (Old)" or "Both" in the **Project Settings > Player > Active Input Handling** for running tests.


### Release workflow

The release process is as follows:

1. Run **Actions > Create release pull request > Run workflow**
2. Merge created pull request

Then, will do the release process automatically by [Release](.github/workflows/release.yml) workflow.
After tagging, [OpenUPM](https://openupm.com/) retrieves the tag and updates it.

> [!CAUTION]  
> Do **NOT** manually operation the following operations:
> - Create a release tag
> - Publish draft releases

> [!CAUTION]  
> You must modify the package name to publish a forked package.

> [!TIP]  
> If you want to specify the version number to be released, change the version number of the draft release before running the "Create release pull request" workflow.
