# <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response"></a> Class CPlayer\_RemoveFriend\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_RemoveFriend_Response : IMessage<CPlayer_RemoveFriend_Response>, IEquatable<CPlayer_RemoveFriend_Response>, IDeepCloneable<CPlayer_RemoveFriend_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_RemoveFriend\_Response](Divine.Protobufs.Steam.CPlayer\_RemoveFriend\_Response.md)

#### Implements

IMessage<CPlayer\_RemoveFriend\_Response\>, 
[IEquatable<CPlayer\_RemoveFriend\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_RemoveFriend\_Response\>, 
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
[EnumerableExtensions.In<CPlayer\_RemoveFriend\_Response\>\(CPlayer\_RemoveFriend\_Response, params CPlayer\_RemoveFriend\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response__ctor"></a> CPlayer\_RemoveFriend\_Response\(\)

```csharp
public CPlayer_RemoveFriend_Response()
```

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response__ctor_Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_"></a> CPlayer\_RemoveFriend\_Response\(CPlayer\_RemoveFriend\_Response\)

```csharp
public CPlayer_RemoveFriend_Response(CPlayer_RemoveFriend_Response other)
```

#### Parameters

`other` [CPlayer\_RemoveFriend\_Response](Divine.Protobufs.Steam.CPlayer\_RemoveFriend\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_FriendRelationshipFieldNumber"></a> FriendRelationshipFieldNumber

```csharp
public const int FriendRelationshipFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_FriendRelationship"></a> FriendRelationship

```csharp
public uint FriendRelationship { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_HasFriendRelationship"></a> HasFriendRelationship

```csharp
public bool HasFriendRelationship { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_RemoveFriend_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_RemoveFriend\_Response](Divine.Protobufs.Steam.CPlayer\_RemoveFriend\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_ClearFriendRelationship"></a> ClearFriendRelationship\(\)

```csharp
public void ClearFriendRelationship()
```

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_Clone"></a> Clone\(\)

```csharp
public CPlayer_RemoveFriend_Response Clone()
```

#### Returns

 [CPlayer\_RemoveFriend\_Response](Divine.Protobufs.Steam.CPlayer\_RemoveFriend\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_Equals_Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_"></a> Equals\(CPlayer\_RemoveFriend\_Response\)

```csharp
public bool Equals(CPlayer_RemoveFriend_Response other)
```

#### Parameters

`other` [CPlayer\_RemoveFriend\_Response](Divine.Protobufs.Steam.CPlayer\_RemoveFriend\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_MergeFrom_Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_"></a> MergeFrom\(CPlayer\_RemoveFriend\_Response\)

```csharp
public void MergeFrom(CPlayer_RemoveFriend_Response other)
```

#### Parameters

`other` [CPlayer\_RemoveFriend\_Response](Divine.Protobufs.Steam.CPlayer\_RemoveFriend\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_RemoveFriend_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

