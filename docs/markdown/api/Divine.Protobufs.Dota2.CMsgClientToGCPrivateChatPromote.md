# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote"></a> Class CMsgClientToGCPrivateChatPromote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPrivateChatPromote : IMessage<CMsgClientToGCPrivateChatPromote>, IEquatable<CMsgClientToGCPrivateChatPromote>, IDeepCloneable<CMsgClientToGCPrivateChatPromote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPrivateChatPromote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatPromote.md)

#### Implements

IMessage<CMsgClientToGCPrivateChatPromote\>, 
[IEquatable<CMsgClientToGCPrivateChatPromote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPrivateChatPromote\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPrivateChatPromote\>\(CMsgClientToGCPrivateChatPromote, params CMsgClientToGCPrivateChatPromote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote__ctor"></a> CMsgClientToGCPrivateChatPromote\(\)

```csharp
public CMsgClientToGCPrivateChatPromote()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_"></a> CMsgClientToGCPrivateChatPromote\(CMsgClientToGCPrivateChatPromote\)

```csharp
public CMsgClientToGCPrivateChatPromote(CMsgClientToGCPrivateChatPromote other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatPromote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatPromote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_PrivateChatChannelNameFieldNumber"></a> PrivateChatChannelNameFieldNumber

```csharp
public const int PrivateChatChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_PromoteAccountIdFieldNumber"></a> PromoteAccountIdFieldNumber

```csharp
public const int PromoteAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_HasPrivateChatChannelName"></a> HasPrivateChatChannelName

```csharp
public bool HasPrivateChatChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_HasPromoteAccountId"></a> HasPromoteAccountId

```csharp
public bool HasPromoteAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPrivateChatPromote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPrivateChatPromote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatPromote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_PrivateChatChannelName"></a> PrivateChatChannelName

```csharp
public string PrivateChatChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_PromoteAccountId"></a> PromoteAccountId

```csharp
public uint PromoteAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_ClearPrivateChatChannelName"></a> ClearPrivateChatChannelName\(\)

```csharp
public void ClearPrivateChatChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_ClearPromoteAccountId"></a> ClearPromoteAccountId\(\)

```csharp
public void ClearPromoteAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPrivateChatPromote Clone()
```

#### Returns

 [CMsgClientToGCPrivateChatPromote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatPromote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_"></a> Equals\(CMsgClientToGCPrivateChatPromote\)

```csharp
public bool Equals(CMsgClientToGCPrivateChatPromote other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatPromote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatPromote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_"></a> MergeFrom\(CMsgClientToGCPrivateChatPromote\)

```csharp
public void MergeFrom(CMsgClientToGCPrivateChatPromote other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatPromote](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatPromote.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatPromote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

