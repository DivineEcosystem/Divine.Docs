# <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData"></a> Class CMsgPeriodicResourceData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPeriodicResourceData : IMessage<CMsgPeriodicResourceData>, IEquatable<CMsgPeriodicResourceData>, IDeepCloneable<CMsgPeriodicResourceData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPeriodicResourceData](Divine.Protobufs.Dota2.CMsgPeriodicResourceData.md)

#### Implements

IMessage<CMsgPeriodicResourceData\>, 
[IEquatable<CMsgPeriodicResourceData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPeriodicResourceData\>, 
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
[EnumerableExtensions.In<CMsgPeriodicResourceData\>\(CMsgPeriodicResourceData, params CMsgPeriodicResourceData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData__ctor"></a> CMsgPeriodicResourceData\(\)

```csharp
public CMsgPeriodicResourceData()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData__ctor_Divine_Protobufs_Dota2_CMsgPeriodicResourceData_"></a> CMsgPeriodicResourceData\(CMsgPeriodicResourceData\)

```csharp
public CMsgPeriodicResourceData(CMsgPeriodicResourceData other)
```

#### Parameters

`other` [CMsgPeriodicResourceData](Divine.Protobufs.Dota2.CMsgPeriodicResourceData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_MaxFieldNumber"></a> MaxFieldNumber

```csharp
public const int MaxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_PeriodicResourceIdFieldNumber"></a> PeriodicResourceIdFieldNumber

```csharp
public const int PeriodicResourceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_RemainingFieldNumber"></a> RemainingFieldNumber

```csharp
public const int RemainingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_HasMax"></a> HasMax

```csharp
public bool HasMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_HasPeriodicResourceId"></a> HasPeriodicResourceId

```csharp
public bool HasPeriodicResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_HasRemaining"></a> HasRemaining

```csharp
public bool HasRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Max"></a> Max

```csharp
public uint Max { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPeriodicResourceData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPeriodicResourceData](Divine.Protobufs.Dota2.CMsgPeriodicResourceData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_PeriodicResourceId"></a> PeriodicResourceId

```csharp
public uint PeriodicResourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Remaining"></a> Remaining

```csharp
public uint Remaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_ClearMax"></a> ClearMax\(\)

```csharp
public void ClearMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_ClearPeriodicResourceId"></a> ClearPeriodicResourceId\(\)

```csharp
public void ClearPeriodicResourceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_ClearRemaining"></a> ClearRemaining\(\)

```csharp
public void ClearRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Clone"></a> Clone\(\)

```csharp
public CMsgPeriodicResourceData Clone()
```

#### Returns

 [CMsgPeriodicResourceData](Divine.Protobufs.Dota2.CMsgPeriodicResourceData.md)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_Equals_Divine_Protobufs_Dota2_CMsgPeriodicResourceData_"></a> Equals\(CMsgPeriodicResourceData\)

```csharp
public bool Equals(CMsgPeriodicResourceData other)
```

#### Parameters

`other` [CMsgPeriodicResourceData](Divine.Protobufs.Dota2.CMsgPeriodicResourceData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_MergeFrom_Divine_Protobufs_Dota2_CMsgPeriodicResourceData_"></a> MergeFrom\(CMsgPeriodicResourceData\)

```csharp
public void MergeFrom(CMsgPeriodicResourceData other)
```

#### Parameters

`other` [CMsgPeriodicResourceData](Divine.Protobufs.Dota2.CMsgPeriodicResourceData.md)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

