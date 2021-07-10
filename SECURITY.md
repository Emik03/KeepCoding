# Security Policy

## Supported Versions

To ensure that your modules remain stable, ensure that your version of `KeepCoding` is up-to-date with the latest version.

- A :white_check_mark: symbol indicates that there are no major or minor security issues. 
- A :grey_question: symbol indicates that there are no major security issues. 
- A :x: indicates that the version contains major vulnerabilities and is not recommended to be used.

| Version       | Supported          |
| ------------- | ------------------ |
| 5.1+          | :white_check_mark: |
| 1.9+          | :grey_question:    |
| 1.7.1 - 1.8.1 | :x:                |
| 1.6.2 - 1.7   | :grey_question:    |
| 1.6 - 1.6.1   | :x:                |
| 1.5.1 - 1.5.4 | :grey_question:    |
| 1.0 - 1.5     | :x:                |

## Reporting a Vulnerability

Minor cases are considered smaller than 3.0 on CVSSv3. Major cases are considered 3.0 or greater.

For minor cases, the vulnerability can be addressed by creating an issue. For more severe cases, you may contact me directly in Discord. (@Emik#0001)

A reply back will typically be noticed within 48 hours, and addressed in a few hours to a few days in the form of a new release depending on the severity and complexity of the problem.

A vulnerability will be acknowledged if it fits in one of four (4) conditions:

- The vulnerability makes the library unstable for other modules that depend on this library.
- The library itself has a piece of code that doesn't work or causes problems.
- The library itself allows to make other modules ━ regardless if they use `KeepCoding` ━ unstable.
- The library can be overriden with malicious code.

[System.Reflection](https://docs.microsoft.com/en-us/dotnet/api/system.reflection?view=net-5.0) **WILL NOT** count as a vulnerability by itself, as this is an inherent feature of C# and cannot be prevented.
