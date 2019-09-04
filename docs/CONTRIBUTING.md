# Contributing Guide - Dragan Talamh


## Introduction
This guide has been created with a programming novice in mind. We have combined best practices, guidelines and easy to follow tutorials to give everyone a chance to contribute to the Dragan Talamh project. However, an understanding of basic software development fundamentals and understanding of C# will come in handy!

## .NET API for C#
The Dragan Talamh project is using [C# .NET Framework version 4.7.2](https://docs.microsoft.com/en-us/dotnet/api/?view=netframework-4.7.2).

## IDE Recommendations
For Windows users, we strongly recommend using [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) edition. For our Linux brothers and sisters, we recommend using [MonoDevelop](https://www.monodevelop.com/) with [Microsoft .NET Core SDK](https://dotnet.microsoft.com/download/linux-package-manager/ubuntu18-04/sdk-current) and [Microsoft .NET Core 2.1 Runtime](https://dotnet.microsoft.com/download/linux-package-manager/ubuntu18-04/runtime-2.1.12). Just be aware that by default, Microsoft is collecting telemetry data while using any of their products under microwave, fridge, coffee machine and Linux.

## Git
We are using Git as our Version Control System. Basic knowledge and understanding of how Git works is necessary to contribute to the project. There is tones of tutorials out there on how to get started with Git. We recommend participating in free ["Learn Git"](https://www.codecademy.com/learn/learn-git) online course made by Code Academy to get yourself up to speed!

We have created an awesome [Git Recipes](https://github.com/fedpy/DraganTalamh/blob/master/docs/GIT_RECIPES.md) document where you can find all the basic Git commands to get you started in no time!

## Software Design
Software design is a cornerstone of any successful program. We have invested a considerable amount of time designing our application. However, the design should only serve as a guidelines or direction post to navigate through the void of the application. We decided to make use of the UML format for our design as we deemed it to be most easily understood by our team.

**Please notice that our UML diagram is a live document and should be referred to regularly.**

In order to access the content of our [UML design file](https://github.com/fedpy/DraganTalamh/blob/master/docs/Dragan-Talamh-UML.drawio), one must use fantastic application [draw.io](https://www.draw.io).

## Code Conventions
Code Conventions are important to Software Developers for serveral reasons. Code Conventions improve the quality and readibility of the code. The majority of code is maintaned by a team of people. We expect our contributors to adhere to the following Code Conventions at all times.

#### File Organization
Please ask for or follow the instructions given to you by the [Project Manager](https://github.com/fedpy) and/or [Product Owner](https://github.com/Mark-Barry).

#### Comments
- Files: Block comments **at the beginning of all files** giving a brief descriptions of the file. The Creator of the file and the date created
```
// ======================================
// = Author:                            =
// = Date:                              =
// ======================================
// = Description:                       =
// =                                    =
// =                                    =
// ======================================
```

- Instance Variables: Please use XML style comments
```
/// <summary>
/// 
/// </summary>
/// <remarks>
/// 
/// </remarks>
```

- Methods: Please use XML style comments
```
/// <summary>
/// 
/// </summary>
/// <param name=""></param>
/// <returns>
/// 
/// </returns>
/// <remarks>
/// 
/// </remarks>
```

- Code: Please only comment complex code, a single line comment to describe what it's doing, if there are multiple lines comment above each line individually
```
// The below line of code.... (Describe functionality) .....
```

#### Class Naming
- Pascal Case: ThisIsAnAwesomeExample

#### Method Naming
- Pascal Case: YetAnotherGreatExample

#### Instance Variable Naming
- Camel Case: exampleMember

#### Local Variable Naming
- Camel Case: thisIsNotSoAwesomeExample

#### Constants Naming
- Hungarian Notation: THISISCONSTANT

#### Special Considerations
Should you have any questions before, during or after the development please don't hesitate to contact [Project Manager](https://github.com/fedpy).

## Semantic Versioning
We are using [Semantic Versioning](https://semver.org/spec/v2.0.0.html) to manage versioning of our project.

## Keep a Changelog
We are using [Keep a Changelog](https://keepachangelog.com/en/1.0.0) to manage changelog of our project.
