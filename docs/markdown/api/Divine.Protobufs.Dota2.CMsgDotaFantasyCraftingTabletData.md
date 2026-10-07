# <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData"></a> Class CMsgDotaFantasyCraftingTabletData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaFantasyCraftingTabletData : IMessage<CMsgDotaFantasyCraftingTabletData>, IEquatable<CMsgDotaFantasyCraftingTabletData>, IDeepCloneable<CMsgDotaFantasyCraftingTabletData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

#### Implements

IMessage<CMsgDotaFantasyCraftingTabletData\>, 
[IEquatable<CMsgDotaFantasyCraftingTabletData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaFantasyCraftingTabletData\>, 
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
[EnumerableExtensions.In<CMsgDotaFantasyCraftingTabletData\>\(CMsgDotaFantasyCraftingTabletData, params CMsgDotaFantasyCraftingTabletData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData__ctor"></a> CMsgDotaFantasyCraftingTabletData\(\)

```csharp
public CMsgDotaFantasyCraftingTabletData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData__ctor_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_"></a> CMsgDotaFantasyCraftingTabletData\(CMsgDotaFantasyCraftingTabletData\)

```csharp
public CMsgDotaFantasyCraftingTabletData(CMsgDotaFantasyCraftingTabletData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_TabletPeriodDataFieldNumber"></a> TabletPeriodDataFieldNumber

```csharp
public const int TabletPeriodDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaFantasyCraftingTabletData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_TabletPeriodData"></a> TabletPeriodData

```csharp
public MapField<uint, CMsgDotaFantasyCraftingTabletPeriodData> TabletPeriodData { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgDotaFantasyCraftingTabletPeriodData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletPeriodData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_Clone"></a> Clone\(\)

```csharp
public CMsgDotaFantasyCraftingTabletData Clone()
```

#### Returns

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_Equals_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_"></a> Equals\(CMsgDotaFantasyCraftingTabletData\)

```csharp
public bool Equals(CMsgDotaFantasyCraftingTabletData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_"></a> MergeFrom\(CMsgDotaFantasyCraftingTabletData\)

```csharp
public void MergeFrom(CMsgDotaFantasyCraftingTabletData other)
```

#### Parameters

`other` [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaFantasyCraftingTabletData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

