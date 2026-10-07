# <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest"></a> Class CMsgFriendPracticeLobbyListRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFriendPracticeLobbyListRequest : IMessage<CMsgFriendPracticeLobbyListRequest>, IEquatable<CMsgFriendPracticeLobbyListRequest>, IDeepCloneable<CMsgFriendPracticeLobbyListRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFriendPracticeLobbyListRequest](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListRequest.md)

#### Implements

IMessage<CMsgFriendPracticeLobbyListRequest\>, 
[IEquatable<CMsgFriendPracticeLobbyListRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFriendPracticeLobbyListRequest\>, 
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
[EnumerableExtensions.In<CMsgFriendPracticeLobbyListRequest\>\(CMsgFriendPracticeLobbyListRequest, params CMsgFriendPracticeLobbyListRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest__ctor"></a> CMsgFriendPracticeLobbyListRequest\(\)

```csharp
public CMsgFriendPracticeLobbyListRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest__ctor_Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_"></a> CMsgFriendPracticeLobbyListRequest\(CMsgFriendPracticeLobbyListRequest\)

```csharp
public CMsgFriendPracticeLobbyListRequest(CMsgFriendPracticeLobbyListRequest other)
```

#### Parameters

`other` [CMsgFriendPracticeLobbyListRequest](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_FriendsFieldNumber"></a> FriendsFieldNumber

```csharp
public const int FriendsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_Friends"></a> Friends

```csharp
public RepeatedField<uint> Friends { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFriendPracticeLobbyListRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFriendPracticeLobbyListRequest](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_Clone"></a> Clone\(\)

```csharp
public CMsgFriendPracticeLobbyListRequest Clone()
```

#### Returns

 [CMsgFriendPracticeLobbyListRequest](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_Equals_Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_"></a> Equals\(CMsgFriendPracticeLobbyListRequest\)

```csharp
public bool Equals(CMsgFriendPracticeLobbyListRequest other)
```

#### Parameters

`other` [CMsgFriendPracticeLobbyListRequest](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_"></a> MergeFrom\(CMsgFriendPracticeLobbyListRequest\)

```csharp
public void MergeFrom(CMsgFriendPracticeLobbyListRequest other)
```

#### Parameters

`other` [CMsgFriendPracticeLobbyListRequest](Divine.Protobufs.Dota2.CMsgFriendPracticeLobbyListRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFriendPracticeLobbyListRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

