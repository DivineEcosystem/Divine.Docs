# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse"></a> Class CMsgDOTASubmitPlayerReportResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitPlayerReportResponse : IMessage<CMsgDOTASubmitPlayerReportResponse>, IEquatable<CMsgDOTASubmitPlayerReportResponse>, IDeepCloneable<CMsgDOTASubmitPlayerReportResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md)

#### Implements

IMessage<CMsgDOTASubmitPlayerReportResponse\>, 
[IEquatable<CMsgDOTASubmitPlayerReportResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitPlayerReportResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitPlayerReportResponse\>\(CMsgDOTASubmitPlayerReportResponse, params CMsgDOTASubmitPlayerReportResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse__ctor"></a> CMsgDOTASubmitPlayerReportResponse\(\)

```csharp
public CMsgDOTASubmitPlayerReportResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_"></a> CMsgDOTASubmitPlayerReportResponse\(CMsgDOTASubmitPlayerReportResponse\)

```csharp
public CMsgDOTASubmitPlayerReportResponse(CMsgDOTASubmitPlayerReportResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_DebugMessageFieldNumber"></a> DebugMessageFieldNumber

```csharp
public const int DebugMessageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_EnumResultFieldNumber"></a> EnumResultFieldNumber

```csharp
public const int EnumResultFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ReportFlagsFieldNumber"></a> ReportFlagsFieldNumber

```csharp
public const int ReportFlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_DebugMessage"></a> DebugMessage

```csharp
public string DebugMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_EnumResult"></a> EnumResult

```csharp
public CMsgDOTASubmitPlayerReportResponse.Types.EResult EnumResult { get; set; }
```

#### Property Value

 [CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.Types.EResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_HasDebugMessage"></a> HasDebugMessage

```csharp
public bool HasDebugMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_HasEnumResult"></a> HasEnumResult

```csharp
public bool HasEnumResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_HasReportFlags"></a> HasReportFlags

```csharp
public bool HasReportFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitPlayerReportResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ReportFlags"></a> ReportFlags

```csharp
public uint ReportFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ClearDebugMessage"></a> ClearDebugMessage\(\)

```csharp
public void ClearDebugMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ClearEnumResult"></a> ClearEnumResult\(\)

```csharp
public void ClearEnumResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ClearReportFlags"></a> ClearReportFlags\(\)

```csharp
public void ClearReportFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitPlayerReportResponse Clone()
```

#### Returns

 [CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_"></a> Equals\(CMsgDOTASubmitPlayerReportResponse\)

```csharp
public bool Equals(CMsgDOTASubmitPlayerReportResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_"></a> MergeFrom\(CMsgDOTASubmitPlayerReportResponse\)

```csharp
public void MergeFrom(CMsgDOTASubmitPlayerReportResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

