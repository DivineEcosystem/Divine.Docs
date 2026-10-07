# <a id="Divine_Services_EventArgs_SandboxServiceMessageEventArgs"></a> Struct SandboxServiceMessageEventArgs

Namespace: [Divine.Services.EventArgs](Divine.Services.EventArgs.md)  
Assembly: Divine.Common.dll  

```csharp
public readonly ref struct SandboxServiceMessageEventArgs
```

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Divine_Services_EventArgs_SandboxServiceMessageEventArgs__ctor_System_ReadOnlySpan_System_Char__System_Span_System_Byte__"></a> SandboxServiceMessageEventArgs\(ReadOnlySpan<char\>, Span<byte\>\)

```csharp
[SetsRequiredMembers]
public SandboxServiceMessageEventArgs(ReadOnlySpan<char> name, Span<byte> value)
```

#### Parameters

`name` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

`value` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

## Properties

### <a id="Divine_Services_EventArgs_SandboxServiceMessageEventArgs_Name"></a> Name

```csharp
public required ReadOnlySpan<char> Name { get; init; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

### <a id="Divine_Services_EventArgs_SandboxServiceMessageEventArgs_Value"></a> Value

```csharp
public required Span<byte> Value { get; init; }
```

#### Property Value

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

