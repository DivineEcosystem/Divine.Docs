# <a id="Divine_SourceGenerator_IDIContext"></a> Interface IDIContext

Namespace: [Divine.SourceGenerator](Divine.SourceGenerator.md)  
Assembly: Divine.Common.dll  

```csharp
public interface IDIContext : IService
```

#### Implements

[IService](Divine.ObsoleteService.IService.md)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IDIContext\>\(IDIContext, params IDIContext\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_SourceGenerator_IDIContext_Objects"></a> Objects

```csharp
ReadOnlyCollection<object> Objects { get; }
```

#### Property Value

 [ReadOnlyCollection](https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlycollection\-1)<[object](https://learn.microsoft.com/dotnet/api/system.object)\>

### <a id="Divine_SourceGenerator_IDIContext_RawObjects"></a> RawObjects

```csharp
ReadOnlyCollection<object> RawObjects { get; }
```

#### Property Value

 [ReadOnlyCollection](https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlycollection\-1)<[object](https://learn.microsoft.com/dotnet/api/system.object)\>

### <a id="Divine_SourceGenerator_IDIContext_Services"></a> Services

```csharp
ReadOnlyCollection<IService> Services { get; }
```

#### Property Value

 [ReadOnlyCollection](https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.readonlycollection\-1)<[IService](Divine.ObsoleteService.IService.md)\>

## Methods

### <a id="Divine_SourceGenerator_IDIContext_GetService__1"></a> GetService<T\>\(\)

```csharp
T GetService<T>() where T : IService
```

#### Returns

 T

#### Type Parameters

`T` 

### <a id="Divine_SourceGenerator_IDIContext_GetServices__1"></a> GetServices<T\>\(\)

```csharp
IEnumerable<T> GetServices<T>() where T : IService
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

#### Type Parameters

`T` 

