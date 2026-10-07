# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse"></a> Class CMsgDOTAGetRecentPlayTimeFriendsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetRecentPlayTimeFriendsResponse : IMessage<CMsgDOTAGetRecentPlayTimeFriendsResponse>, IEquatable<CMsgDOTAGetRecentPlayTimeFriendsResponse>, IDeepCloneable<CMsgDOTAGetRecentPlayTimeFriendsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetRecentPlayTimeFriendsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsResponse.md)

#### Implements

IMessage<CMsgDOTAGetRecentPlayTimeFriendsResponse\>, 
[IEquatable<CMsgDOTAGetRecentPlayTimeFriendsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetRecentPlayTimeFriendsResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetRecentPlayTimeFriendsResponse\>\(CMsgDOTAGetRecentPlayTimeFriendsResponse, params CMsgDOTAGetRecentPlayTimeFriendsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse__ctor"></a> CMsgDOTAGetRecentPlayTimeFriendsResponse\(\)

```csharp
public CMsgDOTAGetRecentPlayTimeFriendsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_"></a> CMsgDOTAGetRecentPlayTimeFriendsResponse\(CMsgDOTAGetRecentPlayTimeFriendsResponse\)

```csharp
public CMsgDOTAGetRecentPlayTimeFriendsResponse(CMsgDOTAGetRecentPlayTimeFriendsResponse other)
```

#### Parameters

`other` [CMsgDOTAGetRecentPlayTimeFriendsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetRecentPlayTimeFriendsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetRecentPlayTimeFriendsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetRecentPlayTimeFriendsResponse Clone()
```

#### Returns

 [CMsgDOTAGetRecentPlayTimeFriendsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_"></a> Equals\(CMsgDOTAGetRecentPlayTimeFriendsResponse\)

```csharp
public bool Equals(CMsgDOTAGetRecentPlayTimeFriendsResponse other)
```

#### Parameters

`other` [CMsgDOTAGetRecentPlayTimeFriendsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_"></a> MergeFrom\(CMsgDOTAGetRecentPlayTimeFriendsResponse\)

```csharp
public void MergeFrom(CMsgDOTAGetRecentPlayTimeFriendsResponse other)
```

#### Parameters

`other` [CMsgDOTAGetRecentPlayTimeFriendsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

