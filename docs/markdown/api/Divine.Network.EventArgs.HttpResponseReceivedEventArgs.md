# <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs"></a> Struct HttpResponseReceivedEventArgs

Namespace: [Divine.Network.EventArgs](Divine.Network.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public ref struct HttpResponseReceivedEventArgs
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_Body"></a> Body

```csharp
public byte* Body { get; set; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_BodySize"></a> BodySize

```csharp
public uint BodySize { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_BodySpan"></a> BodySpan

```csharp
public Span<byte> BodySpan { get; }
```

#### Property Value

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_Process"></a> Process

```csharp
public bool Process { readonly get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_Request"></a> Request

```csharp
public readonly uint Request { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_Url"></a> Url

```csharp
public readonly sbyte* Url { get; }
```

#### Property Value

 [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)\*

### <a id="Divine_Network_EventArgs_HttpResponseReceivedEventArgs_UrlSpan"></a> UrlSpan

```csharp
public ReadOnlySpan<byte> UrlSpan { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

