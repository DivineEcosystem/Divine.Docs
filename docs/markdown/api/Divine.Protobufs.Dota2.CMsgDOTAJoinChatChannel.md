# <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel"></a> Class CMsgDOTAJoinChatChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAJoinChatChannel : IMessage<CMsgDOTAJoinChatChannel>, IEquatable<CMsgDOTAJoinChatChannel>, IDeepCloneable<CMsgDOTAJoinChatChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAJoinChatChannel](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannel.md)

#### Implements

IMessage<CMsgDOTAJoinChatChannel\>, 
[IEquatable<CMsgDOTAJoinChatChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAJoinChatChannel\>, 
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
[EnumerableExtensions.In<CMsgDOTAJoinChatChannel\>\(CMsgDOTAJoinChatChannel, params CMsgDOTAJoinChatChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel__ctor"></a> CMsgDOTAJoinChatChannel\(\)

```csharp
public CMsgDOTAJoinChatChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel__ctor_Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_"></a> CMsgDOTAJoinChatChannel\(CMsgDOTAJoinChatChannel\)

```csharp
public CMsgDOTAJoinChatChannel(CMsgDOTAJoinChatChannel other)
```

#### Parameters

`other` [CMsgDOTAJoinChatChannel](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ChannelNameFieldNumber"></a> ChannelNameFieldNumber

```csharp
public const int ChannelNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_SilentRejectionFieldNumber"></a> SilentRejectionFieldNumber

```csharp
public const int SilentRejectionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ChannelName"></a> ChannelName

```csharp
public string ChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ChannelType"></a> ChannelType

```csharp
public DOTAChatChannelType_t ChannelType { get; set; }
```

#### Property Value

 [DOTAChatChannelType\_t](Divine.Protobufs.Dota2.DOTAChatChannelType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_HasChannelName"></a> HasChannelName

```csharp
public bool HasChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_HasSilentRejection"></a> HasSilentRejection

```csharp
public bool HasSilentRejection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAJoinChatChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAJoinChatChannel](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_SilentRejection"></a> SilentRejection

```csharp
public bool SilentRejection { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ClearChannelName"></a> ClearChannelName\(\)

```csharp
public void ClearChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ClearSilentRejection"></a> ClearSilentRejection\(\)

```csharp
public void ClearSilentRejection()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAJoinChatChannel Clone()
```

#### Returns

 [CMsgDOTAJoinChatChannel](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_Equals_Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_"></a> Equals\(CMsgDOTAJoinChatChannel\)

```csharp
public bool Equals(CMsgDOTAJoinChatChannel other)
```

#### Parameters

`other` [CMsgDOTAJoinChatChannel](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_"></a> MergeFrom\(CMsgDOTAJoinChatChannel\)

```csharp
public void MergeFrom(CMsgDOTAJoinChatChannel other)
```

#### Parameters

`other` [CMsgDOTAJoinChatChannel](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

