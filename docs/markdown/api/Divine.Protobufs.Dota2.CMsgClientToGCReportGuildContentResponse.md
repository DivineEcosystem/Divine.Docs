# <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse"></a> Class CMsgClientToGCReportGuildContentResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCReportGuildContentResponse : IMessage<CMsgClientToGCReportGuildContentResponse>, IEquatable<CMsgClientToGCReportGuildContentResponse>, IDeepCloneable<CMsgClientToGCReportGuildContentResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md)

#### Implements

IMessage<CMsgClientToGCReportGuildContentResponse\>, 
[IEquatable<CMsgClientToGCReportGuildContentResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCReportGuildContentResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCReportGuildContentResponse\>\(CMsgClientToGCReportGuildContentResponse, params CMsgClientToGCReportGuildContentResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse__ctor"></a> CMsgClientToGCReportGuildContentResponse\(\)

```csharp
public CMsgClientToGCReportGuildContentResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_"></a> CMsgClientToGCReportGuildContentResponse\(CMsgClientToGCReportGuildContentResponse\)

```csharp
public CMsgClientToGCReportGuildContentResponse(CMsgClientToGCReportGuildContentResponse other)
```

#### Parameters

`other` [CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCReportGuildContentResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_Result"></a> Result

```csharp
public CMsgClientToGCReportGuildContentResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCReportGuildContentResponse Clone()
```

#### Returns

 [CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_"></a> Equals\(CMsgClientToGCReportGuildContentResponse\)

```csharp
public bool Equals(CMsgClientToGCReportGuildContentResponse other)
```

#### Parameters

`other` [CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_"></a> MergeFrom\(CMsgClientToGCReportGuildContentResponse\)

```csharp
public void MergeFrom(CMsgClientToGCReportGuildContentResponse other)
```

#### Parameters

`other` [CMsgClientToGCReportGuildContentResponse](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContentResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContentResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

