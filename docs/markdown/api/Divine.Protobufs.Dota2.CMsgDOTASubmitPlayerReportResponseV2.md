# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2"></a> Class CMsgDOTASubmitPlayerReportResponseV2

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitPlayerReportResponseV2 : IMessage<CMsgDOTASubmitPlayerReportResponseV2>, IEquatable<CMsgDOTASubmitPlayerReportResponseV2>, IDeepCloneable<CMsgDOTASubmitPlayerReportResponseV2>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md)

#### Implements

IMessage<CMsgDOTASubmitPlayerReportResponseV2\>, 
[IEquatable<CMsgDOTASubmitPlayerReportResponseV2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitPlayerReportResponseV2\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitPlayerReportResponseV2\>\(CMsgDOTASubmitPlayerReportResponseV2, params CMsgDOTASubmitPlayerReportResponseV2\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2__ctor"></a> CMsgDOTASubmitPlayerReportResponseV2\(\)

```csharp
public CMsgDOTASubmitPlayerReportResponseV2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_"></a> CMsgDOTASubmitPlayerReportResponseV2\(CMsgDOTASubmitPlayerReportResponseV2\)

```csharp
public CMsgDOTASubmitPlayerReportResponseV2(CMsgDOTASubmitPlayerReportResponseV2 other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_DebugMessageFieldNumber"></a> DebugMessageFieldNumber

```csharp
public const int DebugMessageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_EnumResultFieldNumber"></a> EnumResultFieldNumber

```csharp
public const int EnumResultFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_ReportReasonFieldNumber"></a> ReportReasonFieldNumber

```csharp
public const int ReportReasonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_DebugMessage"></a> DebugMessage

```csharp
public string DebugMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_EnumResult"></a> EnumResult

```csharp
public CMsgDOTASubmitPlayerReportResponseV2.Types.EResult EnumResult { get; set; }
```

#### Property Value

 [CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.Types.EResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_HasDebugMessage"></a> HasDebugMessage

```csharp
public bool HasDebugMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_HasEnumResult"></a> HasEnumResult

```csharp
public bool HasEnumResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitPlayerReportResponseV2> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_ReportReason"></a> ReportReason

```csharp
public RepeatedField<uint> ReportReason { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_ClearDebugMessage"></a> ClearDebugMessage\(\)

```csharp
public void ClearDebugMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_ClearEnumResult"></a> ClearEnumResult\(\)

```csharp
public void ClearEnumResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitPlayerReportResponseV2 Clone()
```

#### Returns

 [CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_"></a> Equals\(CMsgDOTASubmitPlayerReportResponseV2\)

```csharp
public bool Equals(CMsgDOTASubmitPlayerReportResponseV2 other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_"></a> MergeFrom\(CMsgDOTASubmitPlayerReportResponseV2\)

```csharp
public void MergeFrom(CMsgDOTASubmitPlayerReportResponseV2 other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportResponseV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportResponseV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportResponseV2_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

