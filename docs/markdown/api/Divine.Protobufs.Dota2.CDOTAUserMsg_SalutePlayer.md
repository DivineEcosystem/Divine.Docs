# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer"></a> Class CDOTAUserMsg\_SalutePlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SalutePlayer : IMessage<CDOTAUserMsg_SalutePlayer>, IEquatable<CDOTAUserMsg_SalutePlayer>, IDeepCloneable<CDOTAUserMsg_SalutePlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_SalutePlayer.md)

#### Implements

IMessage<CDOTAUserMsg\_SalutePlayer\>, 
[IEquatable<CDOTAUserMsg\_SalutePlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SalutePlayer\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SalutePlayer\>\(CDOTAUserMsg\_SalutePlayer, params CDOTAUserMsg\_SalutePlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer__ctor"></a> CDOTAUserMsg\_SalutePlayer\(\)

```csharp
public CDOTAUserMsg_SalutePlayer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_"></a> CDOTAUserMsg\_SalutePlayer\(CDOTAUserMsg\_SalutePlayer\)

```csharp
public CDOTAUserMsg_SalutePlayer(CDOTAUserMsg_SalutePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_SalutePlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_CustomTipStyleFieldNumber"></a> CustomTipStyleFieldNumber

```csharp
public const int CustomTipStyleFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_NumRecentTipsFieldNumber"></a> NumRecentTipsFieldNumber

```csharp
public const int NumRecentTipsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_TipAmountFieldNumber"></a> TipAmountFieldNumber

```csharp
public const int TipAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_CustomTipStyle"></a> CustomTipStyle

```csharp
public string CustomTipStyle { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_HasCustomTipStyle"></a> HasCustomTipStyle

```csharp
public bool HasCustomTipStyle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_HasNumRecentTips"></a> HasNumRecentTips

```csharp
public bool HasNumRecentTips { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_HasTipAmount"></a> HasTipAmount

```csharp
public bool HasTipAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_NumRecentTips"></a> NumRecentTips

```csharp
public uint NumRecentTips { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SalutePlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_SalutePlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_TipAmount"></a> TipAmount

```csharp
public uint TipAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ClearCustomTipStyle"></a> ClearCustomTipStyle\(\)

```csharp
public void ClearCustomTipStyle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ClearNumRecentTips"></a> ClearNumRecentTips\(\)

```csharp
public void ClearNumRecentTips()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ClearTipAmount"></a> ClearTipAmount\(\)

```csharp
public void ClearTipAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SalutePlayer Clone()
```

#### Returns

 [CDOTAUserMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_SalutePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_"></a> Equals\(CDOTAUserMsg\_SalutePlayer\)

```csharp
public bool Equals(CDOTAUserMsg_SalutePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_SalutePlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_"></a> MergeFrom\(CDOTAUserMsg\_SalutePlayer\)

```csharp
public void MergeFrom(CDOTAUserMsg_SalutePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_SalutePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SalutePlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

