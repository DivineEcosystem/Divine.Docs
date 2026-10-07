# <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response"></a> Class CMsgGCReportMetrics\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCReportMetrics_Response : IMessage<CMsgGCReportMetrics_Response>, IEquatable<CMsgGCReportMetrics_Response>, IDeepCloneable<CMsgGCReportMetrics_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCReportMetrics\_Response](Divine.Protobufs.Steam.CMsgGCReportMetrics\_Response.md)

#### Implements

IMessage<CMsgGCReportMetrics\_Response\>, 
[IEquatable<CMsgGCReportMetrics\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCReportMetrics\_Response\>, 
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
[EnumerableExtensions.In<CMsgGCReportMetrics\_Response\>\(CMsgGCReportMetrics\_Response, params CMsgGCReportMetrics\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response__ctor"></a> CMsgGCReportMetrics\_Response\(\)

```csharp
public CMsgGCReportMetrics_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response__ctor_Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_"></a> CMsgGCReportMetrics\_Response\(CMsgGCReportMetrics\_Response\)

```csharp
public CMsgGCReportMetrics_Response(CMsgGCReportMetrics_Response other)
```

#### Parameters

`other` [CMsgGCReportMetrics\_Response](Divine.Protobufs.Steam.CMsgGCReportMetrics\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_FailedEntryCountFieldNumber"></a> FailedEntryCountFieldNumber

```csharp
public const int FailedEntryCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_FailedEntryCount"></a> FailedEntryCount

```csharp
public uint FailedEntryCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_HasFailedEntryCount"></a> HasFailedEntryCount

```csharp
public bool HasFailedEntryCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCReportMetrics_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCReportMetrics\_Response](Divine.Protobufs.Steam.CMsgGCReportMetrics\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_ClearFailedEntryCount"></a> ClearFailedEntryCount\(\)

```csharp
public void ClearFailedEntryCount()
```

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_Clone"></a> Clone\(\)

```csharp
public CMsgGCReportMetrics_Response Clone()
```

#### Returns

 [CMsgGCReportMetrics\_Response](Divine.Protobufs.Steam.CMsgGCReportMetrics\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_Equals_Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_"></a> Equals\(CMsgGCReportMetrics\_Response\)

```csharp
public bool Equals(CMsgGCReportMetrics_Response other)
```

#### Parameters

`other` [CMsgGCReportMetrics\_Response](Divine.Protobufs.Steam.CMsgGCReportMetrics\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_MergeFrom_Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_"></a> MergeFrom\(CMsgGCReportMetrics\_Response\)

```csharp
public void MergeFrom(CMsgGCReportMetrics_Response other)
```

#### Parameters

`other` [CMsgGCReportMetrics\_Response](Divine.Protobufs.Steam.CMsgGCReportMetrics\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCReportMetrics_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

