# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo"></a> Class CMsgItemBattlerPlayerInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerPlayerInfo : IMessage<CMsgItemBattlerPlayerInfo>, IEquatable<CMsgItemBattlerPlayerInfo>, IDeepCloneable<CMsgItemBattlerPlayerInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerPlayerInfo](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerInfo.md)

#### Implements

IMessage<CMsgItemBattlerPlayerInfo\>, 
[IEquatable<CMsgItemBattlerPlayerInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerPlayerInfo\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerPlayerInfo\>\(CMsgItemBattlerPlayerInfo, params CMsgItemBattlerPlayerInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo__ctor"></a> CMsgItemBattlerPlayerInfo\(\)

```csharp
public CMsgItemBattlerPlayerInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_"></a> CMsgItemBattlerPlayerInfo\(CMsgItemBattlerPlayerInfo\)

```csharp
public CMsgItemBattlerPlayerInfo(CMsgItemBattlerPlayerInfo other)
```

#### Parameters

`other` [CMsgItemBattlerPlayerInfo](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ConcedeCountFieldNumber"></a> ConcedeCountFieldNumber

```csharp
public const int ConcedeCountFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_RankFieldNumber"></a> RankFieldNumber

```csharp
public const int RankFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_RunCountFieldNumber"></a> RunCountFieldNumber

```csharp
public const int RunCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_VictoryCountFieldNumber"></a> VictoryCountFieldNumber

```csharp
public const int VictoryCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ConcedeCount"></a> ConcedeCount

```csharp
public uint ConcedeCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_HasConcedeCount"></a> HasConcedeCount

```csharp
public bool HasConcedeCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_HasRank"></a> HasRank

```csharp
public bool HasRank { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_HasRunCount"></a> HasRunCount

```csharp
public bool HasRunCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_HasVictoryCount"></a> HasVictoryCount

```csharp
public bool HasVictoryCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerPlayerInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerPlayerInfo](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_Rank"></a> Rank

```csharp
public uint Rank { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_RunCount"></a> RunCount

```csharp
public uint RunCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_VictoryCount"></a> VictoryCount

```csharp
public uint VictoryCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ClearConcedeCount"></a> ClearConcedeCount\(\)

```csharp
public void ClearConcedeCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ClearRank"></a> ClearRank\(\)

```csharp
public void ClearRank()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ClearRunCount"></a> ClearRunCount\(\)

```csharp
public void ClearRunCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ClearVictoryCount"></a> ClearVictoryCount\(\)

```csharp
public void ClearVictoryCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerPlayerInfo Clone()
```

#### Returns

 [CMsgItemBattlerPlayerInfo](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_"></a> Equals\(CMsgItemBattlerPlayerInfo\)

```csharp
public bool Equals(CMsgItemBattlerPlayerInfo other)
```

#### Parameters

`other` [CMsgItemBattlerPlayerInfo](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_"></a> MergeFrom\(CMsgItemBattlerPlayerInfo\)

```csharp
public void MergeFrom(CMsgItemBattlerPlayerInfo other)
```

#### Parameters

`other` [CMsgItemBattlerPlayerInfo](Divine.Protobufs.Dota2.CMsgItemBattlerPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerPlayerInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

