# MimeTypes
The MimeTypes library is a powerful .NET Core 6.0 library designed to help developers manage MIME types in their applications. It provides a robust way to map file extensions to their corresponding MIME types and retrieve file extensions from MIME types efficiently.

## Features
Bidirectional Lookup: Supports looking up MIME types by file extension and finding file extensions based on MIME types.
Thread Safety: Uses thread-safe collections to ensure that the library can be used in multi-threaded applications without any issues.
Extensive MIME Type Support: Includes a comprehensive list of MIME types and file extensions.
Getting Started
### Prerequisites
Ensure you have the .NET Core 6.0 SDK installed on your machine. This SDK includes all the necessary tools to compile and run .NET Core applications.

### Installation
Start by cloning the MimeTypes repository:

``` csharp
git clone https://github.com/ePotok22/MimeTypes.git
Navigate into the project directory and build the project using .NET CLI:
```

``` csharp
cd MimeTypes
dotnet build
```
### Usage
To use the library in your project, you need to include it in your application. Here's how to retrieve a MIME type from a file extension using the MimeTypes library:

``` csharp
using FFF.MimeTypes;

// Get MIME type for a .txt file
string mimeType = MimeTypeMap.GetMimeType(".txt");

Console.WriteLine($"MIME type for .txt: {mimeType}");
```
## Contributing
Contributions to the MimeTypes library are welcome. Please feel free to fork the repository, make changes, and submit a pull request for review.

## License
This project is licensed under the MIT License - see the LICENSE file for more details.
