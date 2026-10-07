# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan"></a> Class CMsgDOTAChatModeratorBan

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatModeratorBan : IMessage<CMsgDOTAChatModeratorBan>, IEquatable<CMsgDOTAChatModeratorBan>, IDeepCloneable<CMsgDOTAChatModeratorBan>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatModeratorBan](Divine.Protobufs.Dota2.CMsgDOTAChatModeratorBan.md)

#### Implements

IMessage<CMsgDOTAChatModeratorBan\>, 
[IEquatable<CMsgDOTAChatModeratorBan\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatModeratorBan\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatModeratorBan\>\(CMsgDOTAChatModeratorBan, params CMsgDOTAChatModeratorBan\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan__ctor"></a> CMsgDOTAChatModeratorBan\(\)

```csharp
public CMsgDOTAChatModeratorBan()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_"></a> CMsgDOTAChatModeratorBan\(CMsgDOTAChatModeratorBan\)

```csharp
public CMsgDOTAChatModeratorBan(CMsgDOTAChatModeratorBan other)
```

#### Parameters

`other` [CMsgDOTAChatModeratorBan](Divine.Protobufs.Dota2.CMsgDOTAChatModeratorBan.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_ChannelId"></a> ChannelId

```csharp
public ulong ChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatModeratorBan> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatModeratorBan](Divine.Protobufs.Dota2.CMsgDOTAChatModeratorBan.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatModeratorBan Clone()
```

#### Returns

 [CMsgDOTAChatModeratorBan](Divine.Protobufs.Dota2.CMsgDOTAChatModeratorBan.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_"></a> Equals\(CMsgDOTAChatModeratorBan\)

```csharp
public bool Equals(CMsgDOTAChatModeratorBan other)
```

#### Parameters

`other` [CMsgDOTAChatModeratorBan](Divine.Protobufs.Dota2.CMsgDOTAChatModeratorBan.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_"></a> MergeFrom\(CMsgDOTAChatModeratorBan\)

```csharp
public void MergeFrom(CMsgDOTAChatModeratorBan other)
```

#### Parameters

`other` [CMsgDOTAChatModeratorBan](Divine.Protobufs.Dota2.CMsgDOTAChatModeratorBan.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatModeratorBan_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

