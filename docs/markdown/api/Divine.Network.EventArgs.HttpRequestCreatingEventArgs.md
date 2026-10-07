# <a id="Divine_Network_EventArgs_HttpRequestCreatingEventArgs"></a> Struct HttpRequestCreatingEventArgs

Namespace: [Divine.Network.EventArgs](Divine.Network.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public ref struct HttpRequestCreatingEventArgs
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Divine_Network_EventArgs_HttpRequestCreatingEventArgs_Method"></a> Method

```csharp
public readonly HttpRequestMethod Method { get; set; }
```

#### Property Value

 [HttpRequestMethod](Divine.Network.Components.HttpRequestMethod.md)

### <a id="Divine_Network_EventArgs_HttpRequestCreatingEventArgs_Process"></a> Process

```csharp
public bool Process { readonly get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Network_EventArgs_HttpRequestCreatingEventArgs_Url"></a> Url

```csharp
public readonly sbyte* Url { get; set; }
```

#### Property Value

 [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)\*

### <a id="Divine_Network_EventArgs_HttpRequestCreatingEventArgs_UrlSpan"></a> UrlSpan

```csharp
public readonly ReadOnlySpan<byte> UrlSpan { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Network_EventArgs_HttpRequestCreatingEventArgs_UrlStr"></a> UrlStr

```csharp
public string UrlStr { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

