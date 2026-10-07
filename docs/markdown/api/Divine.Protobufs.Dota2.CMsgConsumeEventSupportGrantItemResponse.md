# <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse"></a> Class CMsgConsumeEventSupportGrantItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConsumeEventSupportGrantItemResponse : IMessage<CMsgConsumeEventSupportGrantItemResponse>, IEquatable<CMsgConsumeEventSupportGrantItemResponse>, IDeepCloneable<CMsgConsumeEventSupportGrantItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConsumeEventSupportGrantItemResponse](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItemResponse.md)

#### Implements

IMessage<CMsgConsumeEventSupportGrantItemResponse\>, 
[IEquatable<CMsgConsumeEventSupportGrantItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConsumeEventSupportGrantItemResponse\>, 
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
[EnumerableExtensions.In<CMsgConsumeEventSupportGrantItemResponse\>\(CMsgConsumeEventSupportGrantItemResponse, params CMsgConsumeEventSupportGrantItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse__ctor"></a> CMsgConsumeEventSupportGrantItemResponse\(\)

```csharp
public CMsgConsumeEventSupportGrantItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse__ctor_Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_"></a> CMsgConsumeEventSupportGrantItemResponse\(CMsgConsumeEventSupportGrantItemResponse\)

```csharp
public CMsgConsumeEventSupportGrantItemResponse(CMsgConsumeEventSupportGrantItemResponse other)
```

#### Parameters

`other` [CMsgConsumeEventSupportGrantItemResponse](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConsumeEventSupportGrantItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConsumeEventSupportGrantItemResponse](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItemResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_Result"></a> Result

```csharp
public ESupportEventRequestResult Result { get; set; }
```

#### Property Value

 [ESupportEventRequestResult](Divine.Protobufs.Dota2.ESupportEventRequestResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgConsumeEventSupportGrantItemResponse Clone()
```

#### Returns

 [CMsgConsumeEventSupportGrantItemResponse](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_Equals_Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_"></a> Equals\(CMsgConsumeEventSupportGrantItemResponse\)

```csharp
public bool Equals(CMsgConsumeEventSupportGrantItemResponse other)
```

#### Parameters

`other` [CMsgConsumeEventSupportGrantItemResponse](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_"></a> MergeFrom\(CMsgConsumeEventSupportGrantItemResponse\)

```csharp
public void MergeFrom(CMsgConsumeEventSupportGrantItemResponse other)
```

#### Parameters

`other` [CMsgConsumeEventSupportGrantItemResponse](Divine.Protobufs.Dota2.CMsgConsumeEventSupportGrantItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConsumeEventSupportGrantItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

