# <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request"></a> Class CPlayer\_GetCommunityPreferences\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetCommunityPreferences_Request : IMessage<CPlayer_GetCommunityPreferences_Request>, IEquatable<CPlayer_GetCommunityPreferences_Request>, IDeepCloneable<CPlayer_GetCommunityPreferences_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_GetCommunityPreferences\_Request.md)

#### Implements

IMessage<CPlayer\_GetCommunityPreferences\_Request\>, 
[IEquatable<CPlayer\_GetCommunityPreferences\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetCommunityPreferences\_Request\>, 
IBufferMessage, 
IMessage

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
[EnumerableExtensions.In<CPlayer\_GetCommunityPreferences\_Request\>\(CPlayer\_GetCommunityPreferences\_Request, params CPlayer\_GetCommunityPreferences\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request__ctor"></a> CPlayer\_GetCommunityPreferences\_Request\(\)

```csharp
public CPlayer_GetCommunityPreferences_Request()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request__ctor_Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_"></a> CPlayer\_GetCommunityPreferences\_Request\(CPlayer\_GetCommunityPreferences\_Request\)

```csharp
public CPlayer_GetCommunityPreferences_Request(CPlayer_GetCommunityPreferences_Request other)
```

#### Parameters

`other` [CPlayer\_GetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_GetCommunityPreferences\_Request.md)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetCommunityPreferences_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_GetCommunityPreferences\_Request.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetCommunityPreferences_Request Clone()
```

#### Returns

 [CPlayer\_GetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_GetCommunityPreferences\_Request.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_Equals_Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_"></a> Equals\(CPlayer\_GetCommunityPreferences\_Request\)

```csharp
public bool Equals(CPlayer_GetCommunityPreferences_Request other)
```

#### Parameters

`other` [CPlayer\_GetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_GetCommunityPreferences\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_"></a> MergeFrom\(CPlayer\_GetCommunityPreferences\_Request\)

```csharp
public void MergeFrom(CPlayer_GetCommunityPreferences_Request other)
```

#### Parameters

`other` [CPlayer\_GetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_GetCommunityPreferences\_Request.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetCommunityPreferences_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

