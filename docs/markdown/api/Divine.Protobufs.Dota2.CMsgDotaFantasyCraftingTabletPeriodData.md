# <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData"></a> Class CMsgDotaFantasyCraftingTabletPeriodData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaFantasyCraftingTabletPeriodData : IMessage<CMsgDotaFantasyCraftingTabletPeriodData>, IEquatable<CMsgDotaFantasyCraftingTabletPeriodData>, IDeepCloneable<CMsgDotaFantasyCraftingTabletPeriodData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)

#### Implements

IMessage<CMsgDotaFantasyCraftingTabletPeriodData\>, 
[IEquatable<CMsgDotaFantasyCraftingTabletPeriodData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaFantasyCraftingTabletPeriodData\>, 
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
[EnumerableExtensions.In<CMsgDotaFantasyCraftingTabletPeriodData\>\(CMsgDotaFantasyCraftingTabletPeriodData, params CMsgDotaFantasyCraftingTabletPeriodData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData__ctor"></a> CMsgDotaFantasyCraftingTabletPeriodData\(\)

```csharp
public CMsgDotaFantasyCraftingTabletPeriodData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData__ctor_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_"></a> CMsgDotaFantasyCraftingTabletPeriodData\(CMsgDotaFantasyCraftingTabletPeriodData\)

```csharp
public CMsgDotaFantasyCraftingTabletPeriodData(CMsgDotaFantasyCraftingTabletPeriodData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_FantasyPeriodFieldNumber"></a> FantasyPeriodFieldNumber

```csharp
public const int FantasyPeriodFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_TabletsFieldNumber"></a> TabletsFieldNumber

```csharp
public const int TabletsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_FantasyPeriod"></a> FantasyPeriod

```csharp
public uint FantasyPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_HasFantasyPeriod"></a> HasFantasyPeriod

```csharp
public bool HasFantasyPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaFantasyCraftingTabletPeriodData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_Tablets"></a> Tablets

```csharp
public RepeatedField<CMsgDotaFantasyCraftingTabletPeriodData.Types.Tablet> Tablets { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md).[Types](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.Types.md).[Tablet](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.Types.Tablet.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_ClearFantasyPeriod"></a> ClearFantasyPeriod\(\)

```csharp
public void ClearFantasyPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_Clone"></a> Clone\(\)

```csharp
public CMsgDotaFantasyCraftingTabletPeriodData Clone()
```

#### Returns

 [CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_Equals_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_"></a> Equals\(CMsgDotaFantasyCraftingTabletPeriodData\)

```csharp
public bool Equals(CMsgDotaFantasyCraftingTabletPeriodData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_"></a> MergeFrom\(CMsgDotaFantasyCraftingTabletPeriodData\)

```csharp
public void MergeFrom(CMsgDotaFantasyCraftingTabletPeriodData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletPeriodData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

