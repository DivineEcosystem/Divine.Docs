# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region"></a> Class CMsgDOTAChatRegionsEnabled.Types.Region

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatRegionsEnabled.Types.Region : IMessage<CMsgDOTAChatRegionsEnabled.Types.Region>, IEquatable<CMsgDOTAChatRegionsEnabled.Types.Region>, IDeepCloneable<CMsgDOTAChatRegionsEnabled.Types.Region>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatRegionsEnabled.Types.Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)

#### Implements

IMessage<CMsgDOTAChatRegionsEnabled.Types.Region\>, 
[IEquatable<CMsgDOTAChatRegionsEnabled.Types.Region\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatRegionsEnabled.Types.Region\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatRegionsEnabled.Types.Region\>\(CMsgDOTAChatRegionsEnabled.Types.Region, params CMsgDOTAChatRegionsEnabled.Types.Region\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region__ctor"></a> Region\(\)

```csharp
public Region()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_"></a> Region\(Region\)

```csharp
public Region(CMsgDOTAChatRegionsEnabled.Types.Region other)
```

#### Parameters

`other` [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.md).[Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MaxLatitudeFieldNumber"></a> MaxLatitudeFieldNumber

```csharp
public const int MaxLatitudeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MaxLongitudeFieldNumber"></a> MaxLongitudeFieldNumber

```csharp
public const int MaxLongitudeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MinLatitudeFieldNumber"></a> MinLatitudeFieldNumber

```csharp
public const int MinLatitudeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MinLongitudeFieldNumber"></a> MinLongitudeFieldNumber

```csharp
public const int MinLongitudeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_HasMaxLatitude"></a> HasMaxLatitude

```csharp
public bool HasMaxLatitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_HasMaxLongitude"></a> HasMaxLongitude

```csharp
public bool HasMaxLongitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_HasMinLatitude"></a> HasMinLatitude

```csharp
public bool HasMinLatitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_HasMinLongitude"></a> HasMinLongitude

```csharp
public bool HasMinLongitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MaxLatitude"></a> MaxLatitude

```csharp
public float MaxLatitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MaxLongitude"></a> MaxLongitude

```csharp
public float MaxLongitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MinLatitude"></a> MinLatitude

```csharp
public float MinLatitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MinLongitude"></a> MinLongitude

```csharp
public float MinLongitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatRegionsEnabled.Types.Region> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.md).[Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_ClearMaxLatitude"></a> ClearMaxLatitude\(\)

```csharp
public void ClearMaxLatitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_ClearMaxLongitude"></a> ClearMaxLongitude\(\)

```csharp
public void ClearMaxLongitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_ClearMinLatitude"></a> ClearMinLatitude\(\)

```csharp
public void ClearMinLatitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_ClearMinLongitude"></a> ClearMinLongitude\(\)

```csharp
public void ClearMinLongitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatRegionsEnabled.Types.Region Clone()
```

#### Returns

 [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.md).[Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_"></a> Equals\(Region\)

```csharp
public bool Equals(CMsgDOTAChatRegionsEnabled.Types.Region other)
```

#### Parameters

`other` [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.md).[Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_"></a> MergeFrom\(Region\)

```csharp
public void MergeFrom(CMsgDOTAChatRegionsEnabled.Types.Region other)
```

#### Parameters

`other` [CMsgDOTAChatRegionsEnabled](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.md).[Region](Divine.Protobufs.Dota2.CMsgDOTAChatRegionsEnabled.Types.Region.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatRegionsEnabled_Types_Region_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

