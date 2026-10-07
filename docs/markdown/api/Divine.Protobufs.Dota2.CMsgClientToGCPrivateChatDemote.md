# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote"></a> Class CMsgClientToGCPrivateChatDemote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPrivateChatDemote : IMessage<CMsgClientToGCPrivateChatDemote>, IEquatable<CMsgClientToGCPrivateChatDemote>, IDeepCloneable<CMsgClientToGCPrivateChatDemote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPrivateChatDemote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatDemote.md)

#### Implements

IMessage<CMsgClientToGCPrivateChatDemote\>, 
[IEquatable<CMsgClientToGCPrivateChatDemote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPrivateChatDemote\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPrivateChatDemote\>\(CMsgClientToGCPrivateChatDemote, params CMsgClientToGCPrivateChatDemote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote__ctor"></a> CMsgClientToGCPrivateChatDemote\(\)

```csharp
public CMsgClientToGCPrivateChatDemote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_"></a> CMsgClientToGCPrivateChatDemote\(CMsgClientToGCPrivateChatDemote\)

```csharp
public CMsgClientToGCPrivateChatDemote(CMsgClientToGCPrivateChatDemote other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatDemote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatDemote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_DemoteAccountIdFieldNumber"></a> DemoteAccountIdFieldNumber

```csharp
public const int DemoteAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_PrivateChatChannelNameFieldNumber"></a> PrivateChatChannelNameFieldNumber

```csharp
public const int PrivateChatChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_DemoteAccountId"></a> DemoteAccountId

```csharp
public uint DemoteAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_HasDemoteAccountId"></a> HasDemoteAccountId

```csharp
public bool HasDemoteAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_HasPrivateChatChannelName"></a> HasPrivateChatChannelName

```csharp
public bool HasPrivateChatChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPrivateChatDemote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPrivateChatDemote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatDemote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_PrivateChatChannelName"></a> PrivateChatChannelName

```csharp
public string PrivateChatChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_ClearDemoteAccountId"></a> ClearDemoteAccountId\(\)

```csharp
public void ClearDemoteAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_ClearPrivateChatChannelName"></a> ClearPrivateChatChannelName\(\)

```csharp
public void ClearPrivateChatChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPrivateChatDemote Clone()
```

#### Returns

 [CMsgClientToGCPrivateChatDemote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatDemote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_"></a> Equals\(CMsgClientToGCPrivateChatDemote\)

```csharp
public bool Equals(CMsgClientToGCPrivateChatDemote other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatDemote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatDemote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_"></a> MergeFrom\(CMsgClientToGCPrivateChatDemote\)

```csharp
public void MergeFrom(CMsgClientToGCPrivateChatDemote other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatDemote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatDemote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatDemote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

