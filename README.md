# Keep Coding and Nobody Explodes

*KeepCodingAndNobodyExplodes* is a C# class library meant to help speed up the process of scripting [Keep Talking and Nobody Explodes](https://keeptalkinggame.com/) modules by giving better alternatives to common commands, and automating things universal to module-creation. (such as moduleIds, or logging)

### Installing
---

*KeepCodingAndNobodyExplodes* is compiled as a Managed DLL file. You may either compile this DLL yourself, or download one of the release builds found [here](https://github.com/Emik03/KeepCodingAndNobodyExplodes/releases).

Inside of your Unity project, drag this DLL file into **/Assets/Plugins/Managed**. Unity will start reloading the scripts at this stage. After the reload, you can start using the library's code by going into any script file and accessing the namespace:

```cs
using KeepCodingAndNobodyExplodes;
```

### Contribute
---

As with most [GitHub](https://github.com/) repositories, you can contribute by:
* [Creating an issue](https://github.com/Emik03/KeepCodingAndNobodyExplodes/issues) to either address bugs, feature suggestions, or other changes.
* [Creating/reviewing pull requests](https://github.com/Emik03/KeepCodingAndNobodyExplodes/pulls) is also welcome.

### Building

In order to compile the DLL yourself, you need a program that can compile C# class libraries, such as [Visual Studio 2019](https://visualstudio.microsoft.com/).

1. Download and extract the full source code, or clone the repository:

```bash
git clone https://github.com/Emik03/KeepCodingAndNobodyExplodes.git
```

2. Open the solution file with your desired IDE, located at the root folder with a ".sln" extension.

3. Inside the IDE, locate the solution explorer and right click the solution then go into "Properties".

4. Go to "Build" and ensure that the tickbox "XML Documentation File" is checked, with a directory leading to somewhere on your drive, such as the root directory of the repository.

5. Go into "Build Events" and copy the following code block, replacing "X:\My Module Directory\" with the directory leading to your unity project. If multiple projects depends on this repository, you will need to copy-paste these code-blocks for each project you have.

```cs
xcopy /y "$(ProjectDir)$(OutDir)KeepCodingAndNobodyExplodes.dll" "X:\My Module Directory\Assets\Plugins\Managed"
xcopy /y "$(ProjectDir)$(OutDir)KeepCodingAndNobodyExplodes.xml" "X:\My Module Directory\Assets\Plugins\Managed"
xcopy /y "$(ProjectDir)$(OutDir)KeepCodingAndNobodyExplodes.pdb" "X:\My Module Directory\Assets\Plugins\Managed"
```

6. Press the key combination **CTRL+SHIFT+B**, or alternatively go to the dropdown located at the top named "Build" and press "Build Solution". Assuming no build errors occur, you can go back to Unity, which will start reloading.

### License
---

This project falls under the [MIT license](https://github.com/Emik03/KeepCodingAndNobodyExplodes/blob/main/LICENSE.md), which in-short means that you can copy, modify, and redistribute this repository, but the license must stay intact as is.

### Wiki
---

For more information about how to get started when using this library, refer to the [Wiki](https://github.com/Emik03/KeepCodingAndNobodyExplodes/wiki), which outlines specifications about the different classes and methods you'll be using and their general purposes.

For more specific details about each individual method, additional documentation is provided within the XML file, in which most common IDEs give you a tooltip when hovering over a method from *KeepCodingAndNobodyExplodes*.