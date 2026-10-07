# <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData"></a> Class CMsgBingoIndividualStatData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBingoIndividualStatData : IMessage<CMsgBingoIndividualStatData>, IEquatable<CMsgBingoIndividualStatData>, IDeepCloneable<CMsgBingoIndividualStatData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)

#### Implements

IMessage<CMsgBingoIndividualStatData\>, 
[IEquatable<CMsgBingoIndividualStatData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBingoIndividualStatData\>, 
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
[EnumerableExtensions.In<CMsgBingoIndividualStatData\>\(CMsgBingoIndividualStatData, params CMsgBingoIndividualStatData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData__ctor"></a> CMsgBingoIndividualStatData\(\)

```csharp
public CMsgBingoIndividualStatData()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData__ctor_Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_"></a> CMsgBingoIndividualStatData\(CMsgBingoIndividualStatData\)

```csharp
public CMsgBingoIndividualStatData(CMsgBingoIndividualStatData other)
```

#### Parameters

`other` [CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_StatIdFieldNumber"></a> StatIdFieldNumber

```csharp
public const int StatIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_StatValueFieldNumber"></a> StatValueFieldNumber

```csharp
public const int StatValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_HasStatId"></a> HasStatId

```csharp
public bool HasStatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_HasStatValue"></a> HasStatValue

```csharp
public bool HasStatValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBingoIndividualStatData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_StatId"></a> StatId

```csharp
public uint StatId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_StatValue"></a> StatValue

```csharp
public int StatValue { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_ClearStatId"></a> ClearStatId\(\)

```csharp
public void ClearStatId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_ClearStatValue"></a> ClearStatValue\(\)

```csharp
public void ClearStatValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_Clone"></a> Clone\(\)

```csharp
public CMsgBingoIndividualStatData Clone()
```

#### Returns

 [CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_Equals_Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_"></a> Equals\(CMsgBingoIndividualStatData\)

```csharp
public bool Equals(CMsgBingoIndividualStatData other)
```

#### Parameters

`other` [CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_MergeFrom_Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_"></a> MergeFrom\(CMsgBingoIndividualStatData\)

```csharp
public void MergeFrom(CMsgBingoIndividualStatData other)
```

#### Parameters

`other` [CMsgBingoIndividualStatData](Divine.Protobufs.Dota2.CMsgBingoIndividualStatData.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBingoIndividualStatData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

