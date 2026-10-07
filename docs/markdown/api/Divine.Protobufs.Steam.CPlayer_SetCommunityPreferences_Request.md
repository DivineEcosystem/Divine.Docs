# <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request"></a> Class CPlayer\_SetCommunityPreferences\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_SetCommunityPreferences_Request : IMessage<CPlayer_SetCommunityPreferences_Request>, IEquatable<CPlayer_SetCommunityPreferences_Request>, IDeepCloneable<CPlayer_SetCommunityPreferences_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_SetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_SetCommunityPreferences\_Request.md)

#### Implements

IMessage<CPlayer\_SetCommunityPreferences\_Request\>, 
[IEquatable<CPlayer\_SetCommunityPreferences\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_SetCommunityPreferences\_Request\>, 
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
[EnumerableExtensions.In<CPlayer\_SetCommunityPreferences\_Request\>\(CPlayer\_SetCommunityPreferences\_Request, params CPlayer\_SetCommunityPreferences\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request__ctor"></a> CPlayer\_SetCommunityPreferences\_Request\(\)

```csharp
public CPlayer_SetCommunityPreferences_Request()
```

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request__ctor_Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_"></a> CPlayer\_SetCommunityPreferences\_Request\(CPlayer\_SetCommunityPreferences\_Request\)

```csharp
public CPlayer_SetCommunityPreferences_Request(CPlayer_SetCommunityPreferences_Request other)
```

#### Parameters

`other` [CPlayer\_SetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_SetCommunityPreferences\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_PreferencesFieldNumber"></a> PreferencesFieldNumber

```csharp
public const int PreferencesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_SetCommunityPreferences_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_SetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_SetCommunityPreferences\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_Preferences"></a> Preferences

```csharp
public CPlayer_CommunityPreferences Preferences { get; set; }
```

#### Property Value

 [CPlayer\_CommunityPreferences](Divine.Protobufs.Steam.CPlayer\_CommunityPreferences.md)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_Clone"></a> Clone\(\)

```csharp
public CPlayer_SetCommunityPreferences_Request Clone()
```

#### Returns

 [CPlayer\_SetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_SetCommunityPreferences\_Request.md)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_Equals_Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_"></a> Equals\(CPlayer\_SetCommunityPreferences\_Request\)

```csharp
public bool Equals(CPlayer_SetCommunityPreferences_Request other)
```

#### Parameters

`other` [CPlayer\_SetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_SetCommunityPreferences\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_MergeFrom_Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_"></a> MergeFrom\(CPlayer\_SetCommunityPreferences\_Request\)

```csharp
public void MergeFrom(CPlayer_SetCommunityPreferences_Request other)
```

#### Parameters

`other` [CPlayer\_SetCommunityPreferences\_Request](Divine.Protobufs.Steam.CPlayer\_SetCommunityPreferences\_Request.md)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_SetCommunityPreferences_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

