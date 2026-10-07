# <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse"></a> Class CMsgDOTAReportsRemainingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAReportsRemainingResponse : IMessage<CMsgDOTAReportsRemainingResponse>, IEquatable<CMsgDOTAReportsRemainingResponse>, IDeepCloneable<CMsgDOTAReportsRemainingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAReportsRemainingResponse](Divine.Protobufs.Dota2.CMsgDOTAReportsRemainingResponse.md)

#### Implements

IMessage<CMsgDOTAReportsRemainingResponse\>, 
[IEquatable<CMsgDOTAReportsRemainingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAReportsRemainingResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAReportsRemainingResponse\>\(CMsgDOTAReportsRemainingResponse, params CMsgDOTAReportsRemainingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse__ctor"></a> CMsgDOTAReportsRemainingResponse\(\)

```csharp
public CMsgDOTAReportsRemainingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_"></a> CMsgDOTAReportsRemainingResponse\(CMsgDOTAReportsRemainingResponse\)

```csharp
public CMsgDOTAReportsRemainingResponse(CMsgDOTAReportsRemainingResponse other)
```

#### Parameters

`other` [CMsgDOTAReportsRemainingResponse](Divine.Protobufs.Dota2.CMsgDOTAReportsRemainingResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumCommsReportsRemainingFieldNumber"></a> NumCommsReportsRemainingFieldNumber

```csharp
public const int NumCommsReportsRemainingFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumCommsReportsTotalFieldNumber"></a> NumCommsReportsTotalFieldNumber

```csharp
public const int NumCommsReportsTotalFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumNegativeReportsRemainingFieldNumber"></a> NumNegativeReportsRemainingFieldNumber

```csharp
public const int NumNegativeReportsRemainingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumNegativeReportsTotalFieldNumber"></a> NumNegativeReportsTotalFieldNumber

```csharp
public const int NumNegativeReportsTotalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumPositiveReportsRemainingFieldNumber"></a> NumPositiveReportsRemainingFieldNumber

```csharp
public const int NumPositiveReportsRemainingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumPositiveReportsTotalFieldNumber"></a> NumPositiveReportsTotalFieldNumber

```csharp
public const int NumPositiveReportsTotalFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_HasNumCommsReportsRemaining"></a> HasNumCommsReportsRemaining

```csharp
public bool HasNumCommsReportsRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_HasNumCommsReportsTotal"></a> HasNumCommsReportsTotal

```csharp
public bool HasNumCommsReportsTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_HasNumNegativeReportsRemaining"></a> HasNumNegativeReportsRemaining

```csharp
public bool HasNumNegativeReportsRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_HasNumNegativeReportsTotal"></a> HasNumNegativeReportsTotal

```csharp
public bool HasNumNegativeReportsTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_HasNumPositiveReportsRemaining"></a> HasNumPositiveReportsRemaining

```csharp
public bool HasNumPositiveReportsRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_HasNumPositiveReportsTotal"></a> HasNumPositiveReportsTotal

```csharp
public bool HasNumPositiveReportsTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumCommsReportsRemaining"></a> NumCommsReportsRemaining

```csharp
public uint NumCommsReportsRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumCommsReportsTotal"></a> NumCommsReportsTotal

```csharp
public uint NumCommsReportsTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumNegativeReportsRemaining"></a> NumNegativeReportsRemaining

```csharp
public uint NumNegativeReportsRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumNegativeReportsTotal"></a> NumNegativeReportsTotal

```csharp
public uint NumNegativeReportsTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumPositiveReportsRemaining"></a> NumPositiveReportsRemaining

```csharp
public uint NumPositiveReportsRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_NumPositiveReportsTotal"></a> NumPositiveReportsTotal

```csharp
public uint NumPositiveReportsTotal { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAReportsRemainingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAReportsRemainingResponse](Divine.Protobufs.Dota2.CMsgDOTAReportsRemainingResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ClearNumCommsReportsRemaining"></a> ClearNumCommsReportsRemaining\(\)

```csharp
public void ClearNumCommsReportsRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ClearNumCommsReportsTotal"></a> ClearNumCommsReportsTotal\(\)

```csharp
public void ClearNumCommsReportsTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ClearNumNegativeReportsRemaining"></a> ClearNumNegativeReportsRemaining\(\)

```csharp
public void ClearNumNegativeReportsRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ClearNumNegativeReportsTotal"></a> ClearNumNegativeReportsTotal\(\)

```csharp
public void ClearNumNegativeReportsTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ClearNumPositiveReportsRemaining"></a> ClearNumPositiveReportsRemaining\(\)

```csharp
public void ClearNumPositiveReportsRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ClearNumPositiveReportsTotal"></a> ClearNumPositiveReportsTotal\(\)

```csharp
public void ClearNumPositiveReportsTotal()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAReportsRemainingResponse Clone()
```

#### Returns

 [CMsgDOTAReportsRemainingResponse](Divine.Protobufs.Dota2.CMsgDOTAReportsRemainingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_"></a> Equals\(CMsgDOTAReportsRemainingResponse\)

```csharp
public bool Equals(CMsgDOTAReportsRemainingResponse other)
```

#### Parameters

`other` [CMsgDOTAReportsRemainingResponse](Divine.Protobufs.Dota2.CMsgDOTAReportsRemainingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_"></a> MergeFrom\(CMsgDOTAReportsRemainingResponse\)

```csharp
public void MergeFrom(CMsgDOTAReportsRemainingResponse other)
```

#### Parameters

`other` [CMsgDOTAReportsRemainingResponse](Divine.Protobufs.Dota2.CMsgDOTAReportsRemainingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAReportsRemainingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

