# <a id="Divine_Protobufs_Dota2_CMsgClientPingData"></a> Class CMsgClientPingData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientPingData : IMessage<CMsgClientPingData>, IEquatable<CMsgClientPingData>, IDeepCloneable<CMsgClientPingData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

#### Implements

IMessage<CMsgClientPingData\>, 
[IEquatable<CMsgClientPingData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientPingData\>, 
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
[EnumerableExtensions.In<CMsgClientPingData\>\(CMsgClientPingData, params CMsgClientPingData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData__ctor"></a> CMsgClientPingData\(\)

```csharp
public CMsgClientPingData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData__ctor_Divine_Protobufs_Dota2_CMsgClientPingData_"></a> CMsgClientPingData\(CMsgClientPingData\)

```csharp
public CMsgClientPingData(CMsgClientPingData other)
```

#### Parameters

`other` [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RegionCodesFieldNumber"></a> RegionCodesFieldNumber

```csharp
public const int RegionCodesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RegionPingFailedBitmaskFieldNumber"></a> RegionPingFailedBitmaskFieldNumber

```csharp
public const int RegionPingFailedBitmaskFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RegionPingsFieldNumber"></a> RegionPingsFieldNumber

```csharp
public const int RegionPingsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RelayCodesFieldNumber"></a> RelayCodesFieldNumber

```csharp
public const int RelayCodesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RelayPingsFieldNumber"></a> RelayPingsFieldNumber

```csharp
public const int RelayPingsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_HasRegionPingFailedBitmask"></a> HasRegionPingFailedBitmask

```csharp
public bool HasRegionPingFailedBitmask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientPingData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RegionCodes"></a> RegionCodes

```csharp
public RepeatedField<uint> RegionCodes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RegionPingFailedBitmask"></a> RegionPingFailedBitmask

```csharp
public ulong RegionPingFailedBitmask { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RegionPings"></a> RegionPings

```csharp
public RepeatedField<uint> RegionPings { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RelayCodes"></a> RelayCodes

```csharp
public RepeatedField<uint> RelayCodes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_RelayPings"></a> RelayPings

```csharp
public RepeatedField<uint> RelayPings { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_ClearRegionPingFailedBitmask"></a> ClearRegionPingFailedBitmask\(\)

```csharp
public void ClearRegionPingFailedBitmask()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_Clone"></a> Clone\(\)

```csharp
public CMsgClientPingData Clone()
```

#### Returns

 [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_Equals_Divine_Protobufs_Dota2_CMsgClientPingData_"></a> Equals\(CMsgClientPingData\)

```csharp
public bool Equals(CMsgClientPingData other)
```

#### Parameters

`other` [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientPingData_"></a> MergeFrom\(CMsgClientPingData\)

```csharp
public void MergeFrom(CMsgClientPingData other)
```

#### Parameters

`other` [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientPingData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

