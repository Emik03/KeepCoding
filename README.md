# Keep Coding

*KeepCoding* is a C# class library meant to help speed up the process of scripting [Keep Talking and Nobody Explodes](https://keeptalkinggame.com/) modules by giving better alternatives to common commands, and automating things universal to module-creation. (such as moduleIds, or logging)

### Installing
---

*KeepCoding* is compiled as a Managed DLL file. You may either compile this DLL yourself, or [download one of the release builds](https://github.com/Emik03/KeepCodingAndNobodyExplodes/releases).

Unity will start reloading the scripts at this stage. After the reload, you can start using the library's code by going into any script file and accessing the namespace:

```cs
using KeepCoding;
```

### Contribute
---

As with most [GitHub](https://github.com/) repositories, you can contribute by:
* [Creating an issue](https://github.com/Emik03/KeepCoding/issues) to either address bugs, feature suggestions, or other changes.
* [Creating/reviewing pull requests](https://github.com/Emik03/KeepCoding/pulls) is also welcome.

### Building

In order to compile the DLL yourself, you need a program that can compile C# class libraries, such as [Visual Studio 2019](https://visualstudio.microsoft.com/).

1. Download and extract the full source code, or clone the repository:

```bash
git clone https://github.com/Emik03/KeepCoding.git
```

2. Edit the `KeepCoding.csproj.user` file and replace the properties `GameFolder` and `Unity` with the folder directory of Keep Talking and Nobody Explodes, and the root of the Unity folder respectively.

3. Open the solution file with your desired IDE, located at the root folder with a ".sln" extension.

4. Inside the IDE, locate the solution explorer and right click the solution then go into "Properties".

5. Go into "Build Events" and copy the following code block, replacing "X:\My Module Directory\" with the directory leading to your unity project. If multiple projects depends on this repository, you will need to copy-paste these code-blocks for each project you have. If you use an operating system other than Windows, `xcopy` may have to be replaced with the equivalent of your operating system.

```cs
xcopy /y "$(ProjectDir)$(OutDir)KeepCoding.dll" "X:\My Module Directory\Assets\Plugins\Managed"
xcopy /y "$(ProjectDir)$(OutDir)KeepCoding.xml" "X:\My Module Directory\Assets\Plugins\Managed"
```

6. Go to "Signing" and create your own strong name and signature. This ensures that it will not conflict with other versions of this namespace.

7. Press the key combination **CTRL+B**, or alternatively go to the dropdown located at the top named "Build" and press "Build Solution". Assuming no build errors occur, you can go back to Unity, which will start reloading.

### Credit
---

While this project initally started before its release, I do have to credit [Qkrisi's module utility](https://github.com/Qkrisi/ktane-module-utils) for inspiring me to improve on the design of this library by seeing someone else's implementation of an abstract Keep Talking and Nobody Explodes module class file.

### License
---

This project falls under the [GPLv3 License](https://github.com/Emik03/KeepCoding/blob/main/LICENSE.md), which in-short means that you copy, modify, and redistribute under private and commerical use, but the author cannot be held liable, the license must stay intact as is, a disclosure of the original source has to be made, and you must state changes to this repository.

Prior to 10th of July 2020, the [MIT License](https://github.com/Emik03/KeepCoding/blob/48bdd7f7f276029ff1fa16f93c305c9ef6d5e9d1/LICENSE.md) was used instead, which in-short means that these versions allow you to copy, modify, and redistribute under private and commerical use, but the author cannot be held liable and the license must stay intact as is.

### Wiki
---

For more information about how to get started when using this library, refer to the [Wiki](https://github.com/Emik03/KeepCoding/wiki), which outlines specifications about the different classes and methods you'll be using and their general purposes.

For more specific details about each individual method, additional documentation is provided within the XML file, in which most common IDEs give you a tooltip when hovering over a method from *KeepCoding*.
