<img src="https://github.com/akbarbuneri/QuickMapper/blob/main/Logo.png?raw=true" alt="QuickMapper">

[![CI](https://github.com/QuickMapper/QuickMapper/workflows/CI/badge.svg)](https://github.com/QuickMapper/QuickMapper/actions?query=workflow%3ACI)
[![NuGet](http://img.shields.io/nuget/v/QuickMapper.svg)](https://www.nuget.org/packages/QuickMapper/)
[![MyGet (dev)](https://img.shields.io/myget/QuickMapperdev/v/QuickMapper.svg)](https://myget.org/feed/QuickMapperdev/package/nuget/QuickMapper)

### What is QuickMapper?

QuickMapper is a simple little library built to solve a deceptively complex problem - getting rid of code that mapped one object to another. This type of code is rather dreary and boring to write, so why not invent a tool to do it for us?

This is the main repository for QuickMapper, but there's more:

* [Microsoft DI Extensions](https://github.com/QuickMapper/QuickMapper.Extensions.Microsoft.DependencyInjection)
* [Collection Extensions](https://github.com/QuickMapper/QuickMapper.Collection)
* [Expression Mapping](https://github.com/QuickMapper/QuickMapper.Extensions.ExpressionMapping)
* [EF6 Extensions](https://github.com/QuickMapper/QuickMapper.EF6)
* [IDataReader/Record Extensions](https://github.com/QuickMapper/QuickMapper.Data)
* [Enum Extensions](https://github.com/QuickMapper/QuickMapper.Extensions.EnumMapping)

### How do I get started?

First, configure QuickMapper to know what types you want to map, in the startup of your application:

```csharp
var configuration = new MapperConfiguration(cfg => 
{
    cfg.CreateMap<Foo, FooDto>();
    cfg.CreateMap<Bar, BarDto>();
});
// only during development, validate your mappings; remove it before release
configuration.AssertConfigurationIsValid();
// use DI (http://docs.QuickMapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
var mapper = configuration.CreateMapper();
```
Then in your application code, execute the mappings:

```csharp
var fooDto = mapper.Map<FooDto>(foo);
var barDto = mapper.Map<BarDto>(bar);
```

Check out the [getting started guide](https://QuickMapper.readthedocs.io/en/latest/Getting-started.html). When you're done there, the [wiki](https://QuickMapper.readthedocs.io/en/latest/) goes in to the nitty-gritty details. If you have questions, you can post them to [Stack Overflow](https://stackoverflow.com/questions/tagged/QuickMapper) or in our [Gitter](https://gitter.im/QuickMapper/QuickMapper).

### Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [QuickMapper](https://www.nuget.org/packages/QuickMapper/) from the package manager console:

```
PM> Install-Package QuickMapper
```

### Do you have an issue?

First check if it's already fixed by trying the [MyGet build](https://QuickMapper.readthedocs.io/en/latest/The-MyGet-build.html).

You might want to know exactly what [your mapping does](https://QuickMapper.readthedocs.io/en/latest/Understanding-your-mapping.html) at runtime.

If you're still running into problems, file an issue above.

### License, etc.

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

QuickMapper is Copyright &copy; 2009 [Jimmy Bogard](https://jimmybogard.com) and other contributors under the [MIT license](LICENSE.txt).

### .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).