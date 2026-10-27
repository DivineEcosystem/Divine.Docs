# <a id="Divine_Shared_Plugin"></a> Class Plugin

Namespace: [Divine.Shared](Divine.Shared.md)  
Assembly: Divine.Common.dll  

```csharp
[MemoryPackable(GenerateType.Object)]
public sealed record Plugin : IMemoryPackable<Plugin>, IMemoryPackFormatterRegister, IEquatable<Plugin>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Plugin](Divine.Shared.Plugin.md)

#### Implements

IMemoryPackable<Plugin\>, 
IMemoryPackFormatterRegister, 
[IEquatable<Plugin\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<Plugin\>\(Plugin, params Plugin\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Shared_Plugin__ctor_System_String_System_String_System_String_"></a> Plugin\(string, string, string\)

```csharp
public Plugin(string Name, string AssemblyName, string FilePath)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`AssemblyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`FilePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="Divine_Shared_Plugin_AssemblyName"></a> AssemblyName

```csharp
public string AssemblyName { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Shared_Plugin_FilePath"></a> FilePath

```csharp
public string FilePath { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Shared_Plugin_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Shared_Plugin__Clone__"></a> <Clone\>$\(\)

```csharp
public Plugin <Clone>$()
```

#### Returns

 [Plugin](Divine.Shared.Plugin.md)

### <a id="Divine_Shared_Plugin_Deconstruct_System_String__System_String__System_String__"></a> Deconstruct\(out string, out string, out string\)

```csharp
public void Deconstruct(out string Name, out string AssemblyName, out string FilePath)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`AssemblyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`FilePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Shared_Plugin_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Shared_Plugin_Equals_Divine_Shared_Plugin_"></a> Equals\(Plugin?\)

```csharp
public bool Equals(Plugin? other)
```

#### Parameters

`other` [Plugin](Divine.Shared.Plugin.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Shared_Plugin_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Shared_Plugin_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Divine_Shared_Plugin_op_Equality_Divine_Shared_Plugin_Divine_Shared_Plugin_"></a> operator ==\(Plugin?, Plugin?\)

```csharp
public static bool operator ==(Plugin? left, Plugin? right)
```

#### Parameters

`left` [Plugin](Divine.Shared.Plugin.md)?

`right` [Plugin](Divine.Shared.Plugin.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Shared_Plugin_op_Inequality_Divine_Shared_Plugin_Divine_Shared_Plugin_"></a> operator \!=\(Plugin?, Plugin?\)

```csharp
public static bool operator !=(Plugin? left, Plugin? right)
```

#### Parameters

`left` [Plugin](Divine.Shared.Plugin.md)?

`right` [Plugin](Divine.Shared.Plugin.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

