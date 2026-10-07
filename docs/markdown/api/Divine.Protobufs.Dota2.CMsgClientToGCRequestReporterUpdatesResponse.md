# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse"></a> Class CMsgClientToGCRequestReporterUpdatesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestReporterUpdatesResponse : IMessage<CMsgClientToGCRequestReporterUpdatesResponse>, IEquatable<CMsgClientToGCRequestReporterUpdatesResponse>, IDeepCloneable<CMsgClientToGCRequestReporterUpdatesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestReporterUpdatesResponse\>, 
[IEquatable<CMsgClientToGCRequestReporterUpdatesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestReporterUpdatesResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestReporterUpdatesResponse\>\(CMsgClientToGCRequestReporterUpdatesResponse, params CMsgClientToGCRequestReporterUpdatesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse__ctor"></a> CMsgClientToGCRequestReporterUpdatesResponse\(\)

```csharp
public CMsgClientToGCRequestReporterUpdatesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_"></a> CMsgClientToGCRequestReporterUpdatesResponse\(CMsgClientToGCRequestReporterUpdatesResponse\)

```csharp
public CMsgClientToGCRequestReporterUpdatesResponse(CMsgClientToGCRequestReporterUpdatesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_EnumResultFieldNumber"></a> EnumResultFieldNumber

```csharp
public const int EnumResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_NumNoActionTakenFieldNumber"></a> NumNoActionTakenFieldNumber

```csharp
public const int NumNoActionTakenFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_NumReportedFieldNumber"></a> NumReportedFieldNumber

```csharp
public const int NumReportedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_UpdatesFieldNumber"></a> UpdatesFieldNumber

```csharp
public const int UpdatesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_EnumResult"></a> EnumResult

```csharp
public CMsgClientToGCRequestReporterUpdatesResponse.Types.EResponse EnumResult { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_HasEnumResult"></a> HasEnumResult

```csharp
public bool HasEnumResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_HasNumNoActionTaken"></a> HasNumNoActionTaken

```csharp
public bool HasNumNoActionTaken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_HasNumReported"></a> HasNumReported

```csharp
public bool HasNumReported { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_NumNoActionTaken"></a> NumNoActionTaken

```csharp
public int NumNoActionTaken { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_NumReported"></a> NumReported

```csharp
public int NumReported { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestReporterUpdatesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Updates"></a> Updates

```csharp
public RepeatedField<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate> Updates { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_ClearEnumResult"></a> ClearEnumResult\(\)

```csharp
public void ClearEnumResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_ClearNumNoActionTaken"></a> ClearNumNoActionTaken\(\)

```csharp
public void ClearNumNoActionTaken()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_ClearNumReported"></a> ClearNumReported\(\)

```csharp
public void ClearNumReported()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestReporterUpdatesResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_"></a> Equals\(CMsgClientToGCRequestReporterUpdatesResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestReporterUpdatesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_"></a> MergeFrom\(CMsgClientToGCRequestReporterUpdatesResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestReporterUpdatesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

