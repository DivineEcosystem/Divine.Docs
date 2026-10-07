# <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub"></a> Class CMsgGCToGCBroadcastMessageFromSub

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCBroadcastMessageFromSub : IMessage<CMsgGCToGCBroadcastMessageFromSub>, IEquatable<CMsgGCToGCBroadcastMessageFromSub>, IDeepCloneable<CMsgGCToGCBroadcastMessageFromSub>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCBroadcastMessageFromSub](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastMessageFromSub.md)

#### Implements

IMessage<CMsgGCToGCBroadcastMessageFromSub\>, 
[IEquatable<CMsgGCToGCBroadcastMessageFromSub\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCBroadcastMessageFromSub\>, 
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
[EnumerableExtensions.In<CMsgGCToGCBroadcastMessageFromSub\>\(CMsgGCToGCBroadcastMessageFromSub, params CMsgGCToGCBroadcastMessageFromSub\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub__ctor"></a> CMsgGCToGCBroadcastMessageFromSub\(\)

```csharp
public CMsgGCToGCBroadcastMessageFromSub()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub__ctor_Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_"></a> CMsgGCToGCBroadcastMessageFromSub\(CMsgGCToGCBroadcastMessageFromSub\)

```csharp
public CMsgGCToGCBroadcastMessageFromSub(CMsgGCToGCBroadcastMessageFromSub other)
```

#### Parameters

`other` [CMsgGCToGCBroadcastMessageFromSub](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastMessageFromSub.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_AccountIdListFieldNumber"></a> AccountIdListFieldNumber

```csharp
public const int AccountIdListFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_MsgIdFieldNumber"></a> MsgIdFieldNumber

```csharp
public const int MsgIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_SerializedMsgFieldNumber"></a> SerializedMsgFieldNumber

```csharp
public const int SerializedMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_SteamIdListFieldNumber"></a> SteamIdListFieldNumber

```csharp
public const int SteamIdListFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_AccountIdList"></a> AccountIdList

```csharp
public RepeatedField<uint> AccountIdList { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_HasMsgId"></a> HasMsgId

```csharp
public bool HasMsgId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_HasSerializedMsg"></a> HasSerializedMsg

```csharp
public bool HasSerializedMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_MsgId"></a> MsgId

```csharp
public uint MsgId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCBroadcastMessageFromSub> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCBroadcastMessageFromSub](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastMessageFromSub.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_SerializedMsg"></a> SerializedMsg

```csharp
public ByteString SerializedMsg { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_SteamIdList"></a> SteamIdList

```csharp
public RepeatedField<ulong> SteamIdList { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_ClearMsgId"></a> ClearMsgId\(\)

```csharp
public void ClearMsgId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_ClearSerializedMsg"></a> ClearSerializedMsg\(\)

```csharp
public void ClearSerializedMsg()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCBroadcastMessageFromSub Clone()
```

#### Returns

 [CMsgGCToGCBroadcastMessageFromSub](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastMessageFromSub.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_Equals_Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_"></a> Equals\(CMsgGCToGCBroadcastMessageFromSub\)

```csharp
public bool Equals(CMsgGCToGCBroadcastMessageFromSub other)
```

#### Parameters

`other` [CMsgGCToGCBroadcastMessageFromSub](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastMessageFromSub.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_"></a> MergeFrom\(CMsgGCToGCBroadcastMessageFromSub\)

```csharp
public void MergeFrom(CMsgGCToGCBroadcastMessageFromSub other)
```

#### Parameters

`other` [CMsgGCToGCBroadcastMessageFromSub](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastMessageFromSub.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastMessageFromSub_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

