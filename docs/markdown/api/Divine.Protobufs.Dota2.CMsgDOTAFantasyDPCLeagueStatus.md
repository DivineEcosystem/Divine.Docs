# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus"></a> Class CMsgDOTAFantasyDPCLeagueStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyDPCLeagueStatus : IMessage<CMsgDOTAFantasyDPCLeagueStatus>, IEquatable<CMsgDOTAFantasyDPCLeagueStatus>, IDeepCloneable<CMsgDOTAFantasyDPCLeagueStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md)

#### Implements

IMessage<CMsgDOTAFantasyDPCLeagueStatus\>, 
[IEquatable<CMsgDOTAFantasyDPCLeagueStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyDPCLeagueStatus\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyDPCLeagueStatus\>\(CMsgDOTAFantasyDPCLeagueStatus, params CMsgDOTAFantasyDPCLeagueStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus__ctor"></a> CMsgDOTAFantasyDPCLeagueStatus\(\)

```csharp
public CMsgDOTAFantasyDPCLeagueStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_"></a> CMsgDOTAFantasyDPCLeagueStatus\(CMsgDOTAFantasyDPCLeagueStatus\)

```csharp
public CMsgDOTAFantasyDPCLeagueStatus(CMsgDOTAFantasyDPCLeagueStatus other)
```

#### Parameters

`other` [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_LeagueInfosFieldNumber"></a> LeagueInfosFieldNumber

```csharp
public const int LeagueInfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_LeagueInfos"></a> LeagueInfos

```csharp
public RepeatedField<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo> LeagueInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyDPCLeagueStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyDPCLeagueStatus Clone()
```

#### Returns

 [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_"></a> Equals\(CMsgDOTAFantasyDPCLeagueStatus\)

```csharp
public bool Equals(CMsgDOTAFantasyDPCLeagueStatus other)
```

#### Parameters

`other` [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_"></a> MergeFrom\(CMsgDOTAFantasyDPCLeagueStatus\)

```csharp
public void MergeFrom(CMsgDOTAFantasyDPCLeagueStatus other)
```

#### Parameters

`other` [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

