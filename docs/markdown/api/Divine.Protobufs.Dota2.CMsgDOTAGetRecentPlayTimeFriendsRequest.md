# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest"></a> Class CMsgDOTAGetRecentPlayTimeFriendsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetRecentPlayTimeFriendsRequest : IMessage<CMsgDOTAGetRecentPlayTimeFriendsRequest>, IEquatable<CMsgDOTAGetRecentPlayTimeFriendsRequest>, IDeepCloneable<CMsgDOTAGetRecentPlayTimeFriendsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetRecentPlayTimeFriendsRequest](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsRequest.md)

#### Implements

IMessage<CMsgDOTAGetRecentPlayTimeFriendsRequest\>, 
[IEquatable<CMsgDOTAGetRecentPlayTimeFriendsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetRecentPlayTimeFriendsRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetRecentPlayTimeFriendsRequest\>\(CMsgDOTAGetRecentPlayTimeFriendsRequest, params CMsgDOTAGetRecentPlayTimeFriendsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest__ctor"></a> CMsgDOTAGetRecentPlayTimeFriendsRequest\(\)

```csharp
public CMsgDOTAGetRecentPlayTimeFriendsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_"></a> CMsgDOTAGetRecentPlayTimeFriendsRequest\(CMsgDOTAGetRecentPlayTimeFriendsRequest\)

```csharp
public CMsgDOTAGetRecentPlayTimeFriendsRequest(CMsgDOTAGetRecentPlayTimeFriendsRequest other)
```

#### Parameters

`other` [CMsgDOTAGetRecentPlayTimeFriendsRequest](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetRecentPlayTimeFriendsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetRecentPlayTimeFriendsRequest](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetRecentPlayTimeFriendsRequest Clone()
```

#### Returns

 [CMsgDOTAGetRecentPlayTimeFriendsRequest](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_"></a> Equals\(CMsgDOTAGetRecentPlayTimeFriendsRequest\)

```csharp
public bool Equals(CMsgDOTAGetRecentPlayTimeFriendsRequest other)
```

#### Parameters

`other` [CMsgDOTAGetRecentPlayTimeFriendsRequest](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_"></a> MergeFrom\(CMsgDOTAGetRecentPlayTimeFriendsRequest\)

```csharp
public void MergeFrom(CMsgDOTAGetRecentPlayTimeFriendsRequest other)
```

#### Parameters

`other` [CMsgDOTAGetRecentPlayTimeFriendsRequest](Divine.Protobufs.Dota2.CMsgDOTAGetRecentPlayTimeFriendsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetRecentPlayTimeFriendsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

