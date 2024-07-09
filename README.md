## Overview

This is a sample application to demonstrate the usage of [PhonePadLib](https://github.com/marinazzio/PhonePadLib) library

## How to use

Clone this repository:

```shell
git clone git@github.com:marinazzio/nokia3100.git
```

or

```shell
git clone https://github.com/marinazzio/nokia3100.git
```

Enter the project directory and initialize submodule:

```shell
cd nokia3100
git submodule update --init
```

Ensure you have the [.NET Core SDK](https://dotnet.microsoft.com/download) installed. The current version of the project is using .NET Core 8.0.

It was tested on Windows 11 and Ubuntu 22.04.

Build the application:

```shell
# first build the lib
dotnet build PhonePadLib/PhonePadTranslation/PhonePadTranslation.csproj --configuration Release

# then build the app
dotnet build nokia3100/nokia3100.csproj --configuration Release
```

Run the application:

```shell
dotnet run --project ./nokia3100 -- "8 88777444666*664#"
```

Or:

```shell
cd nokia3100/bin/Release/net8.0
./nokia3100 "8 88777444666*664#"
```
