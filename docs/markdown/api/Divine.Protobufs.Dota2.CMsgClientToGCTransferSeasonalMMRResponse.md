# <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse"></a> Class CMsgClientToGCTransferSeasonalMMRResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCTransferSeasonalMMRResponse : IMessage<CMsgClientToGCTransferSeasonalMMRResponse>, IEquatable<CMsgClientToGCTransferSeasonalMMRResponse>, IDeepCloneable<CMsgClientToGCTransferSeasonalMMRResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCTransferSeasonalMMRResponse](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRResponse.md)

#### Implements

IMessage<CMsgClientToGCTransferSeasonalMMRResponse\>, 
[IEquatable<CMsgClientToGCTransferSeasonalMMRResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCTransferSeasonalMMRResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCTransferSeasonalMMRResponse\>\(CMsgClientToGCTransferSeasonalMMRResponse, params CMsgClientToGCTransferSeasonalMMRResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse__ctor"></a> CMsgClientToGCTransferSeasonalMMRResponse\(\)

```csharp
public CMsgClientToGCTransferSeasonalMMRResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_"></a> CMsgClientToGCTransferSeasonalMMRResponse\(CMsgClientToGCTransferSeasonalMMRResponse\)

```csharp
public CMsgClientToGCTransferSeasonalMMRResponse(CMsgClientToGCTransferSeasonalMMRResponse other)
```

#### Parameters

`other` [CMsgClientToGCTransferSeasonalMMRResponse](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCTransferSeasonalMMRResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCTransferSeasonalMMRResponse](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCTransferSeasonalMMRResponse Clone()
```

#### Returns

 [CMsgClientToGCTransferSeasonalMMRResponse](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_"></a> Equals\(CMsgClientToGCTransferSeasonalMMRResponse\)

```csharp
public bool Equals(CMsgClientToGCTransferSeasonalMMRResponse other)
```

#### Parameters

`other` [CMsgClientToGCTransferSeasonalMMRResponse](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_"></a> MergeFrom\(CMsgClientToGCTransferSeasonalMMRResponse\)

```csharp
public void MergeFrom(CMsgClientToGCTransferSeasonalMMRResponse other)
```

#### Parameters

`other` [CMsgClientToGCTransferSeasonalMMRResponse](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

