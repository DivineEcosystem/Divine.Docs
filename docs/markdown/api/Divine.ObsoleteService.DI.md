# <a id="Divine_ObsoleteService_DI"></a> Class DI

Namespace: [Divine.ObsoleteService](Divine.ObsoleteService.md)  
Assembly: Divine.Common.dll  

```csharp
public static class DI
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DI](Divine.ObsoleteService.DI.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_ObsoleteService_DI_GetService__1"></a> GetService<T\>\(\)

```csharp
public static T GetService<T>() where T : IService
```

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_ObsoleteService_DI_GetServices__1"></a> GetServices<T\>\(\)

```csharp
public static IEnumerable<T> GetServices<T>() where T : IService
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

### <a id="Divine_ObsoleteService_DI_Register_Divine_SourceGenerator_IDIContext_"></a> Register\(IDIContext\)

```csharp
public static void Register(IDIContext context)
```

#### Parameters

`context` [IDIContext](Divine.SourceGenerator.IDIContext.md)

