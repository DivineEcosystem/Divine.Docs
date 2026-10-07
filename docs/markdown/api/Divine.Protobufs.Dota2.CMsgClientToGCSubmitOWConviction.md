# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction"></a> Class CMsgClientToGCSubmitOWConviction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitOWConviction : IMessage<CMsgClientToGCSubmitOWConviction>, IEquatable<CMsgClientToGCSubmitOWConviction>, IDeepCloneable<CMsgClientToGCSubmitOWConviction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitOWConviction](Divine.Protobufs.Dota2.CMsgClientToGCSubmitOWConviction.md)

#### Implements

IMessage<CMsgClientToGCSubmitOWConviction\>, 
[IEquatable<CMsgClientToGCSubmitOWConviction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitOWConviction\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitOWConviction\>\(CMsgClientToGCSubmitOWConviction, params CMsgClientToGCSubmitOWConviction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction__ctor"></a> CMsgClientToGCSubmitOWConviction\(\)

```csharp
public CMsgClientToGCSubmitOWConviction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_"></a> CMsgClientToGCSubmitOWConviction\(CMsgClientToGCSubmitOWConviction\)

```csharp
public CMsgClientToGCSubmitOWConviction(CMsgClientToGCSubmitOWConviction other)
```

#### Parameters

`other` [CMsgClientToGCSubmitOWConviction](Divine.Protobufs.Dota2.CMsgClientToGCSubmitOWConviction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_CheatingConvictionFieldNumber"></a> CheatingConvictionFieldNumber

```csharp
public const int CheatingConvictionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_GriefingConvictionFieldNumber"></a> GriefingConvictionFieldNumber

```csharp
public const int GriefingConvictionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_OverwatchReplayIdFieldNumber"></a> OverwatchReplayIdFieldNumber

```csharp
public const int OverwatchReplayIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_TargetPlayerSlotFieldNumber"></a> TargetPlayerSlotFieldNumber

```csharp
public const int TargetPlayerSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_CheatingConviction"></a> CheatingConviction

```csharp
public EOverwatchConviction CheatingConviction { get; set; }
```

#### Property Value

 [EOverwatchConviction](Divine.Protobufs.Dota2.EOverwatchConviction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_GriefingConviction"></a> GriefingConviction

```csharp
public EOverwatchConviction GriefingConviction { get; set; }
```

#### Property Value

 [EOverwatchConviction](Divine.Protobufs.Dota2.EOverwatchConviction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_HasCheatingConviction"></a> HasCheatingConviction

```csharp
public bool HasCheatingConviction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_HasGriefingConviction"></a> HasGriefingConviction

```csharp
public bool HasGriefingConviction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_HasOverwatchReplayId"></a> HasOverwatchReplayId

```csharp
public bool HasOverwatchReplayId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_HasTargetPlayerSlot"></a> HasTargetPlayerSlot

```csharp
public bool HasTargetPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_OverwatchReplayId"></a> OverwatchReplayId

```csharp
public ulong OverwatchReplayId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitOWConviction> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitOWConviction](Divine.Protobufs.Dota2.CMsgClientToGCSubmitOWConviction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_TargetPlayerSlot"></a> TargetPlayerSlot

```csharp
public uint TargetPlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_ClearCheatingConviction"></a> ClearCheatingConviction\(\)

```csharp
public void ClearCheatingConviction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_ClearGriefingConviction"></a> ClearGriefingConviction\(\)

```csharp
public void ClearGriefingConviction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_ClearOverwatchReplayId"></a> ClearOverwatchReplayId\(\)

```csharp
public void ClearOverwatchReplayId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_ClearTargetPlayerSlot"></a> ClearTargetPlayerSlot\(\)

```csharp
public void ClearTargetPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitOWConviction Clone()
```

#### Returns

 [CMsgClientToGCSubmitOWConviction](Divine.Protobufs.Dota2.CMsgClientToGCSubmitOWConviction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_"></a> Equals\(CMsgClientToGCSubmitOWConviction\)

```csharp
public bool Equals(CMsgClientToGCSubmitOWConviction other)
```

#### Parameters

`other` [CMsgClientToGCSubmitOWConviction](Divine.Protobufs.Dota2.CMsgClientToGCSubmitOWConviction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_"></a> MergeFrom\(CMsgClientToGCSubmitOWConviction\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitOWConviction other)
```

#### Parameters

`other` [CMsgClientToGCSubmitOWConviction](Divine.Protobufs.Dota2.CMsgClientToGCSubmitOWConviction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitOWConviction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

