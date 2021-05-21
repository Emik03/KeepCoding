# Security Policy

## Supported Versions

To ensure that your modules remain stable, ensure that your version of `KeepCoding` is up-to-date with security.

- A :white_check_mark: symbol indicates that there are no major or minor security issues. 
- A :x: indicates that the version is vulnerable and is not recommended to be used.

| Version       | Supported          |
| ------------- | ------------------ |
| 1.8.2+        | :white_check_mark: |
| 1.7.1 - 1.8.1 | :x:                |
| 1.6.2 - 1.7   | :white_check_mark: |
| 1.6 - 1.6.1   | :x:                |
| 1.5.1 - 1.5.4 | :white_check_mark: |
| 1.0 - 1.5     | :x:                |

## Reporting a Vulnerability

For minor cases, the vulnerability can be addressed by creating an issue. For more severe cases, you may contact me directly in Discord. (@Emik#0001)

A vulnerability will be acknowledged if it fits in one of four (4) conditions:

- The vulnerability makes the library unstable for other modules that depend on this library.
- The library itself has a piece of code that doesn't work or causes problems.
- The library itself allows to make other modules ━ regardless if they use `KeepCoding` ━ unstable.
- The library can be overriden with malicious code.

[System.Reflection](https://docs.microsoft.com/en-us/dotnet/api/system.reflection?view=net-5.0) **WILL NOT** count as a vulnerability by itself, as this is an inherit feature of C# and cannot be prevented.
