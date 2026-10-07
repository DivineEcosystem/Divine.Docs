# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward"></a> Class CMsgClientToGCOverworldClaimFortunePermanentReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldClaimFortunePermanentReward : IMessage<CMsgClientToGCOverworldClaimFortunePermanentReward>, IEquatable<CMsgClientToGCOverworldClaimFortunePermanentReward>, IDeepCloneable<CMsgClientToGCOverworldClaimFortunePermanentReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldClaimFortunePermanentReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentReward.md)

#### Implements

IMessage<CMsgClientToGCOverworldClaimFortunePermanentReward\>, 
[IEquatable<CMsgClientToGCOverworldClaimFortunePermanentReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldClaimFortunePermanentReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldClaimFortunePermanentReward\>\(CMsgClientToGCOverworldClaimFortunePermanentReward, params CMsgClientToGCOverworldClaimFortunePermanentReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward__ctor"></a> CMsgClientToGCOverworldClaimFortunePermanentReward\(\)

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_"></a> CMsgClientToGCOverworldClaimFortunePermanentReward\(CMsgClientToGCOverworldClaimFortunePermanentReward\)

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentReward(CMsgClientToGCOverworldClaimFortunePermanentReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortunePermanentReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_FortuneIdFieldNumber"></a> FortuneIdFieldNumber

```csharp
public const int FortuneIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_FortuneId"></a> FortuneId

```csharp
public uint FortuneId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_HasFortuneId"></a> HasFortuneId

```csharp
public bool HasFortuneId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldClaimFortunePermanentReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldClaimFortunePermanentReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentReward.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_ClearFortuneId"></a> ClearFortuneId\(\)

```csharp
public void ClearFortuneId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldClaimFortunePermanentReward Clone()
```

#### Returns

 [CMsgClientToGCOverworldClaimFortunePermanentReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_"></a> Equals\(CMsgClientToGCOverworldClaimFortunePermanentReward\)

```csharp
public bool Equals(CMsgClientToGCOverworldClaimFortunePermanentReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortunePermanentReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_"></a> MergeFrom\(CMsgClientToGCOverworldClaimFortunePermanentReward\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldClaimFortunePermanentReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortunePermanentReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortunePermanentReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortunePermanentReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

