# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards"></a> Class CMsgClientToGCMonsterHunterDevClaimInvestigationRewards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevClaimInvestigationRewards : IMessage<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards>, IEquatable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards>, IDeepCloneable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevClaimInvestigationRewards](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewards.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\>\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards, params CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards__ctor"></a> CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewards()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_"></a> CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\)

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewards(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClaimInvestigationRewards](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_InvestigationGameStateFieldNumber"></a> InvestigationGameStateFieldNumber

```csharp
public const int InvestigationGameStateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_WinFieldNumber"></a> WinFieldNumber

```csharp
public const int WinFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_HasWin"></a> HasWin

```csharp
public bool HasWin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_InvestigationGameState"></a> InvestigationGameState

```csharp
public CMsgMonsterHunterInvestigationGameState InvestigationGameState { get; set; }
```

#### Property Value

 [CMsgMonsterHunterInvestigationGameState](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigationGameState.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevClaimInvestigationRewards> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevClaimInvestigationRewards](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewards.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_Win"></a> Win

```csharp
public bool Win { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_ClearWin"></a> ClearWin\(\)

```csharp
public void ClearWin()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClaimInvestigationRewards Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevClaimInvestigationRewards](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_"></a> Equals\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClaimInvestigationRewards](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevClaimInvestigationRewards other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClaimInvestigationRewards](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClaimInvestigationRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClaimInvestigationRewards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

