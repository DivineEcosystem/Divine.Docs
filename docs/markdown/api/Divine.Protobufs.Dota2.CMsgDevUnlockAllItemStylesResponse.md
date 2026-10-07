# <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse"></a> Class CMsgDevUnlockAllItemStylesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDevUnlockAllItemStylesResponse : IMessage<CMsgDevUnlockAllItemStylesResponse>, IEquatable<CMsgDevUnlockAllItemStylesResponse>, IDeepCloneable<CMsgDevUnlockAllItemStylesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDevUnlockAllItemStylesResponse](Divine.Protobufs.Dota2.CMsgDevUnlockAllItemStylesResponse.md)

#### Implements

IMessage<CMsgDevUnlockAllItemStylesResponse\>, 
[IEquatable<CMsgDevUnlockAllItemStylesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDevUnlockAllItemStylesResponse\>, 
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
[EnumerableExtensions.In<CMsgDevUnlockAllItemStylesResponse\>\(CMsgDevUnlockAllItemStylesResponse, params CMsgDevUnlockAllItemStylesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse__ctor"></a> CMsgDevUnlockAllItemStylesResponse\(\)

```csharp
public CMsgDevUnlockAllItemStylesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse__ctor_Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_"></a> CMsgDevUnlockAllItemStylesResponse\(CMsgDevUnlockAllItemStylesResponse\)

```csharp
public CMsgDevUnlockAllItemStylesResponse(CMsgDevUnlockAllItemStylesResponse other)
```

#### Parameters

`other` [CMsgDevUnlockAllItemStylesResponse](Divine.Protobufs.Dota2.CMsgDevUnlockAllItemStylesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDevUnlockAllItemStylesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDevUnlockAllItemStylesResponse](Divine.Protobufs.Dota2.CMsgDevUnlockAllItemStylesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDevUnlockAllItemStylesResponse Clone()
```

#### Returns

 [CMsgDevUnlockAllItemStylesResponse](Divine.Protobufs.Dota2.CMsgDevUnlockAllItemStylesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_Equals_Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_"></a> Equals\(CMsgDevUnlockAllItemStylesResponse\)

```csharp
public bool Equals(CMsgDevUnlockAllItemStylesResponse other)
```

#### Parameters

`other` [CMsgDevUnlockAllItemStylesResponse](Divine.Protobufs.Dota2.CMsgDevUnlockAllItemStylesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_"></a> MergeFrom\(CMsgDevUnlockAllItemStylesResponse\)

```csharp
public void MergeFrom(CMsgDevUnlockAllItemStylesResponse other)
```

#### Parameters

`other` [CMsgDevUnlockAllItemStylesResponse](Divine.Protobufs.Dota2.CMsgDevUnlockAllItemStylesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevUnlockAllItemStylesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

