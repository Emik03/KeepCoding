using System;
using System.Reflection;
using System.Resources;

[assembly: AssemblyCompany("Emik")]
[assembly: AssemblyCopyright("Emik")]
[assembly: AssemblyDescription(@"KeepCoding is a C# class library by Emik (https://github.com/Emik03) meant to help speed up the process of scripting Keep Talking and Nobody Explodes modules by giving better alternatives to common commands, and automating things universal to module-creation. (such as moduleIds, or logging)")]
#if LITE
[assembly: AssemblyProduct("KeepCodingLite")]
[assembly: AssemblyTitle("KeepCodingLite")]
#else
[assembly: AssemblyProduct("KeepCoding")]
[assembly: AssemblyTitle("KeepCoding")]
#endif
[assembly: AssemblyVersion("14")]
[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en-150")]
