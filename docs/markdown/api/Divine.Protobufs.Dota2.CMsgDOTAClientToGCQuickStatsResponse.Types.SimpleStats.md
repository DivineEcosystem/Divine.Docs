# <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats"></a> Class CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats : IMessage<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats>, IEquatable<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats>, IDeepCloneable<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

#### Implements

IMessage<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats\>, 
[IEquatable<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats\>, 
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
[EnumerableExtensions.In<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats\>\(CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats, params CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats__ctor"></a> SimpleStats\(\)

```csharp
public SimpleStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats__ctor_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_"></a> SimpleStats\(SimpleStats\)

```csharp
public SimpleStats(CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_PickCountFieldNumber"></a> PickCountFieldNumber

```csharp
public const int PickCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_PickPercentFieldNumber"></a> PickPercentFieldNumber

```csharp
public const int PickPercentFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_WinCountFieldNumber"></a> WinCountFieldNumber

```csharp
public const int WinCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_WinPercentFieldNumber"></a> WinPercentFieldNumber

```csharp
public const int WinPercentFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_HasPickCount"></a> HasPickCount

```csharp
public bool HasPickCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_HasPickPercent"></a> HasPickPercent

```csharp
public bool HasPickPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_HasWinCount"></a> HasWinCount

```csharp
public bool HasWinCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_HasWinPercent"></a> HasWinPercent

```csharp
public bool HasWinPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_PickCount"></a> PickCount

```csharp
public uint PickCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_PickPercent"></a> PickPercent

```csharp
public float PickPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_WinCount"></a> WinCount

```csharp
public uint WinCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_WinPercent"></a> WinPercent

```csharp
public float WinPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_ClearPickCount"></a> ClearPickCount\(\)

```csharp
public void ClearPickCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_ClearPickPercent"></a> ClearPickPercent\(\)

```csharp
public void ClearPickPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_ClearWinCount"></a> ClearWinCount\(\)

```csharp
public void ClearWinCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_ClearWinPercent"></a> ClearWinPercent\(\)

```csharp
public void ClearWinPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats Clone()
```

#### Returns

 [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_Equals_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_"></a> Equals\(SimpleStats\)

```csharp
public bool Equals(CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_"></a> MergeFrom\(SimpleStats\)

```csharp
public void MergeFrom(CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.md).[SimpleStats](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsResponse.Types.SimpleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsResponse_Types_SimpleStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

