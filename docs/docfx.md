# DocFX: Documentation and API Reference Generator

## What is DocFX?

DocFX is a comprehensive documentation generation tool specifically designed for technical documentation. It converts multiple sources into a cohesive documentation website, including:

- .NET assembly files
- XML code comments
- REST API Swagger/OpenAPI specifications
- Markdown content

The output can be rendered as HTML pages, JSON models, or PDF files, making it versatile for various documentation needs.

## Key Features

- **Multiple Input Sources**: Combines API documentation with conceptual content
- **Cross-platform**: Works on Windows, macOS, and Linux
- **Highly Customizable**: Templates, themes, and plugins available
- **Metadata Extraction**: Automatically extracts documentation from .NET code and XML comments
- **Modern Output**: Generates responsive, searchable websites
- **PDF Generation**: Creates professional PDF documentation (requires Node.js)

## Installation Guide

### Prerequisites

Before installing DocFX, ensure you have:

- **Required**: .NET SDK 8.0 or higher
- **Optional**: Node.js v20 or higher (needed only for PDF generation)
- Basic familiarity with command-line operations

### Installation Steps

DocFX is distributed as a .NET tool. To install it globally on your system:

```bash
dotnet tool update -g docfx
```

This command will install the latest version of DocFX as a global tool, making it available from any directory.

## Getting Started

### Creating a New Documentation Project

To create a new documentation project:

```bash
docfx init
```

This interactive command will guide you through setting up a new DocFX project in your current directory. It will create the necessary configuration files and folder structure.

### Building Your Documentation

Once you've created a project, you can build it with:

```bash
docfx docfx.json --serve
```

This command:
1. Builds your documentation based on the configuration in `docfx.json`
2. Starts a local web server
3. Makes your documentation available at http://localhost:8080

### Previewing Changes

To preview changes as you work:

1. Save your changes to content files
2. In a new terminal window, run:
   ```bash
   docfx docfx.json
   ```
3. Refresh your browser to see the updated content

## Understanding DocFX

DocFX brings together static documentation pages and .NET API documentation in a seamless way. It supports both C# and VB.NET projects, utilizing the standard XML comment syntax for code documentation.

For example, this C# code with XML comments:

```csharp
/// <summary>
/// Calculates the age of a person on a certain date based on the supplied date of birth.  Takes account of leap years,
/// using the convention that someone born on 29th February in a leap year is not legally one year older until 1st March
/// of a non-leap year.
/// </summary>
/// <param name="dateOfBirth">Individual's date of birth.</param>
/// <param name="date">Date at which to evaluate age at.</param>
/// <returns>Age of the individual in years (as an integer).</returns>
/// <remarks>This code is not guaranteed to be correct for non-UK locales, as some countries have skipped certain dates
/// within living memory.</remarks>
public static int AgeAt(this DateOnly dateOfBirth, DateOnly date)
{
    int age = date.Year - dateOfBirth.Year;

    return dateOfBirth > date.AddYears(-age) ? --age : age;
}
```

Will be transformed into well-formatted API documentation with proper sections for description, parameters, return values, and remarks.

## Next Steps

After setting up your basic documentation:

1. **Customize your theme**: Modify templates to match your brand
2. **Add navigation**: Create a meaningful table of contents
3. **Include examples**: Add code snippets and examples
4. **Set up CI/CD**: Automate documentation builds with GitHub Actions or Azure DevOps

## Resources

- [Official DocFX Documentation](https://dotnet.github.io/docfx/)
- [GitHub Repository](https://github.com/dotnet/docfx)
- [Sample Projects](https://github.com/dotnet/docfx-seed)