# <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results"></a> Class CMsgDOTAPlayerInfo.Types.Results

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPlayerInfo.Types.Results : IMessage<CMsgDOTAPlayerInfo.Types.Results>, IEquatable<CMsgDOTAPlayerInfo.Types.Results>, IDeepCloneable<CMsgDOTAPlayerInfo.Types.Results>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPlayerInfo.Types.Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)

#### Implements

IMessage<CMsgDOTAPlayerInfo.Types.Results\>, 
[IEquatable<CMsgDOTAPlayerInfo.Types.Results\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPlayerInfo.Types.Results\>, 
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
[EnumerableExtensions.In<CMsgDOTAPlayerInfo.Types.Results\>\(CMsgDOTAPlayerInfo.Types.Results, params CMsgDOTAPlayerInfo.Types.Results\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results__ctor"></a> Results\(\)

```csharp
public Results()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results__ctor_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_"></a> Results\(Results\)

```csharp
public Results(CMsgDOTAPlayerInfo.Types.Results other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_EarningsFieldNumber"></a> EarningsFieldNumber

```csharp
public const int EarningsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_PlacementFieldNumber"></a> PlacementFieldNumber

```csharp
public const int PlacementFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Earnings"></a> Earnings

```csharp
public uint Earnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_HasEarnings"></a> HasEarnings

```csharp
public bool HasEarnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_HasPlacement"></a> HasPlacement

```csharp
public bool HasPlacement { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPlayerInfo.Types.Results> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Placement"></a> Placement

```csharp
public uint Placement { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_ClearEarnings"></a> ClearEarnings\(\)

```csharp
public void ClearEarnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_ClearPlacement"></a> ClearPlacement\(\)

```csharp
public void ClearPlacement()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPlayerInfo.Types.Results Clone()
```

#### Returns

 [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_Equals_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_"></a> Equals\(Results\)

```csharp
public bool Equals(CMsgDOTAPlayerInfo.Types.Results other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_"></a> MergeFrom\(Results\)

```csharp
public void MergeFrom(CMsgDOTAPlayerInfo.Types.Results other)
```

#### Parameters

`other` [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.md).[Results](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.Types.Results.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerInfo_Types_Results_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

