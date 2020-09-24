[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=nanoframework_lib-nanoFramework.System.Math&metric=alert_status)](https://sonarcloud.io/dashboard?id=nanoframework_lib-nanoFramework.System.Math) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=nanoframework_lib-nanoFramework.System.Math&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=nanoframework_lib-nanoFramework.System.Math) [![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE) [![NuGet](https://img.shields.io/nuget/dt/nanoFramework.System.Math.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.System.Math/) [![#yourfirstpr](https://img.shields.io/badge/first--timers--only-friendly-blue.svg)](https://github.com/nanoframework/Home/blob/master/CONTRIBUTING.md) [![Discord](https://img.shields.io/discord/478725473862549535.svg?logo=discord&logoColor=white&label=Discord&color=7289DA)](https://discord.gg/gCyBu8T)

![nanoFramework logo](https://github.com/nanoframework/Home/blob/master/resources/logo/nanoFramework-repo-logo.png)

-----

### Welcome to the **nanoFramework** System.Math Class Library repository!

## Build status

| Component | Build Status | NuGet Package |
|:-|---|---|
| nanoFramework.System.Math | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.System.Math/_apis/build/status/nanoframework.lib-nanoFramework.System.Math?branchName=develop)](https://dev.azure.com/nanoframework/nanoFramework.System.Math/_build/latest?definitionId=10?branchName=master) | [![NuGet](https://img.shields.io/nuget/v/nanoFramework.System.Math.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.System.Math/) |
| nanoFramework.System.Math (preview) | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.System.Math/_apis/build/status/nanoframework.lib-nanoFramework.System.Math?branchName=develop)](https://dev.azure.com/nanoframework/nanoFramework.System.Math/_build/latest?definitionId=10?branchName=develop) | [![](https://badgen.net/badge/NuGet/preview/D7B023?icon=https://simpleicons.now.sh/azuredevops/fff)](https://dev.azure.com/nanoframework/feed/_packaging?_a=package&feed=sandbox&package=nanoFramework.System.Math&protocolType=NuGet&view=overview) |

## Available APIs and floating-point implementations

The .NET System.Math APIs are available with `double` parameters. No sweat for the CPUs where the code usually runs.
When we move to embedded systems that's a totally different story. 

A few more details to properly set context:

- [`double` type](https://docs.microsoft.com/en-us/dotnet/api/system.double): represents a double-precision 64-bit number with values ranging from negative 1.79769313486232e308 to positive 1.79769313486232e308. Precision ~15-17 digits. Size 8 bytes.
- [`float` type](https://docs.microsoft.com/en-us/dotnet/api/system.single): represents a single-precision 32-bit number with values ranging from negative 3.402823e38 to positive 3.402823e38. Precision ~6-9 digits. Size 4 bytes.
- Comparison of [floating-point numeric types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types).

There are all sorts of variants and combinations on how to deal with FP and DP in the embedded world. From hardware support on the CPU to libraries that perform those calculations at the expense of more code and execution speed. .NET **nanoFramework** targets 32-bit MCUs, therefore support for 64-bits calculations requires extra code and processing.

Adding to the above, the extra precision provided by the `double` type is seldom required on typical embedded application use cases.

Considering all this and the ongoing quest to save flash space we've decided to provide two *flavours* for the System.Math API: the standard one with `double` type parameters and the alternative, lightweight one, with `float` type parameters.

This has zero impact on API and code reuse as both coexist. The only difference is on the firmware image. There is a build option (`DP_FLOATINGPOINT`) to build the image with DP floating point, when that extra precision is required.

A `NotImplementedException` will be throw when there is no native support for an API. The remedy is to call the API with the _other_ parameter type.

```(csharp)
// this is OK when running on a image that has DP floating point support
Math.Pow(1.01580092094650000000000000, 0.19029495718363400000000000000);

// this is the correct usage when running on a image WITHOUT support for DP floating point
Math.Pow(1.0158009209465f, 0.190294957183634f);
``` 

## Feedback and documentation

For documentation, providing feedback, issues and finding out how to contribute please refer to the [Home repo](https://github.com/nanoframework/Home).

Join our Discord community [here](https://discord.gg/gCyBu8T).

## Credits

The list of contributors to this project can be found at [CONTRIBUTORS](https://github.com/nanoframework/Home/blob/master/CONTRIBUTORS.md).

## License

The **nanoFramework** Class Libraries are licensed under the [MIT license](LICENSE.md).

## Code of Conduct

This project has adopted the code of conduct defined by the [Contributor Covenant](http://contributor-covenant.org/)
to clarify expected behavior in our community.
