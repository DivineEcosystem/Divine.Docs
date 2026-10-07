# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward"></a> Class CMsgClientToGCOverworldClaimFortuneReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldClaimFortuneReward : IMessage<CMsgClientToGCOverworldClaimFortuneReward>, IEquatable<CMsgClientToGCOverworldClaimFortuneReward>, IDeepCloneable<CMsgClientToGCOverworldClaimFortuneReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldClaimFortuneReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneReward.md)

#### Implements

IMessage<CMsgClientToGCOverworldClaimFortuneReward\>, 
[IEquatable<CMsgClientToGCOverworldClaimFortuneReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldClaimFortuneReward\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldClaimFortuneReward\>\(CMsgClientToGCOverworldClaimFortuneReward, params CMsgClientToGCOverworldClaimFortuneReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward__ctor"></a> CMsgClientToGCOverworldClaimFortuneReward\(\)

```csharp
public CMsgClientToGCOverworldClaimFortuneReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_"></a> CMsgClientToGCOverworldClaimFortuneReward\(CMsgClientToGCOverworldClaimFortuneReward\)

```csharp
public CMsgClientToGCOverworldClaimFortuneReward(CMsgClientToGCOverworldClaimFortuneReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortuneReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldClaimFortuneReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldClaimFortuneReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneReward.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldClaimFortuneReward Clone()
```

#### Returns

 [CMsgClientToGCOverworldClaimFortuneReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_"></a> Equals\(CMsgClientToGCOverworldClaimFortuneReward\)

```csharp
public bool Equals(CMsgClientToGCOverworldClaimFortuneReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortuneReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_"></a> MergeFrom\(CMsgClientToGCOverworldClaimFortuneReward\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldClaimFortuneReward other)
```

#### Parameters

`other` [CMsgClientToGCOverworldClaimFortuneReward](Divine.Protobufs.Dota2.CMsgClientToGCOverworldClaimFortuneReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldClaimFortuneReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

