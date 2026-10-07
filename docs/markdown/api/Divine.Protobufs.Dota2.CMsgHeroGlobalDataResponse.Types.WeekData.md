# <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData"></a> Class CMsgHeroGlobalDataResponse.Types.WeekData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroGlobalDataResponse.Types.WeekData : IMessage<CMsgHeroGlobalDataResponse.Types.WeekData>, IEquatable<CMsgHeroGlobalDataResponse.Types.WeekData>, IDeepCloneable<CMsgHeroGlobalDataResponse.Types.WeekData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroGlobalDataResponse.Types.WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)

#### Implements

IMessage<CMsgHeroGlobalDataResponse.Types.WeekData\>, 
[IEquatable<CMsgHeroGlobalDataResponse.Types.WeekData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroGlobalDataResponse.Types.WeekData\>, 
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
[EnumerableExtensions.In<CMsgHeroGlobalDataResponse.Types.WeekData\>\(CMsgHeroGlobalDataResponse.Types.WeekData, params CMsgHeroGlobalDataResponse.Types.WeekData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData__ctor"></a> WeekData\(\)

```csharp
public WeekData()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData__ctor_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_"></a> WeekData\(WeekData\)

```csharp
public WeekData(CMsgHeroGlobalDataResponse.Types.WeekData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_BanPercentFieldNumber"></a> BanPercentFieldNumber

```csharp
public const int BanPercentFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_PickPercentFieldNumber"></a> PickPercentFieldNumber

```csharp
public const int PickPercentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_WeekFieldNumber"></a> WeekFieldNumber

```csharp
public const int WeekFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_WinPercentFieldNumber"></a> WinPercentFieldNumber

```csharp
public const int WinPercentFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_BanPercent"></a> BanPercent

```csharp
public float BanPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_HasBanPercent"></a> HasBanPercent

```csharp
public bool HasBanPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_HasPickPercent"></a> HasPickPercent

```csharp
public bool HasPickPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_HasWeek"></a> HasWeek

```csharp
public bool HasWeek { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_HasWinPercent"></a> HasWinPercent

```csharp
public bool HasWinPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroGlobalDataResponse.Types.WeekData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_PickPercent"></a> PickPercent

```csharp
public float PickPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_Week"></a> Week

```csharp
public uint Week { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_WinPercent"></a> WinPercent

```csharp
public float WinPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_ClearBanPercent"></a> ClearBanPercent\(\)

```csharp
public void ClearBanPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_ClearPickPercent"></a> ClearPickPercent\(\)

```csharp
public void ClearPickPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_ClearWeek"></a> ClearWeek\(\)

```csharp
public void ClearWeek()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_ClearWinPercent"></a> ClearWinPercent\(\)

```csharp
public void ClearWinPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_Clone"></a> Clone\(\)

```csharp
public CMsgHeroGlobalDataResponse.Types.WeekData Clone()
```

#### Returns

 [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_Equals_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_"></a> Equals\(WeekData\)

```csharp
public bool Equals(CMsgHeroGlobalDataResponse.Types.WeekData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_"></a> MergeFrom\(WeekData\)

```csharp
public void MergeFrom(CMsgHeroGlobalDataResponse.Types.WeekData other)
```

#### Parameters

`other` [CMsgHeroGlobalDataResponse](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.md).[WeekData](Divine.Protobufs.Dota2.CMsgHeroGlobalDataResponse.Types.WeekData.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroGlobalDataResponse_Types_WeekData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

