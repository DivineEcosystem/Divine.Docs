# <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse"></a> Class CMsgServerToGCNewBloomGiftResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCNewBloomGiftResponse : IMessage<CMsgServerToGCNewBloomGiftResponse>, IEquatable<CMsgServerToGCNewBloomGiftResponse>, IDeepCloneable<CMsgServerToGCNewBloomGiftResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCNewBloomGiftResponse](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGiftResponse.md)

#### Implements

IMessage<CMsgServerToGCNewBloomGiftResponse\>, 
[IEquatable<CMsgServerToGCNewBloomGiftResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCNewBloomGiftResponse\>, 
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
[EnumerableExtensions.In<CMsgServerToGCNewBloomGiftResponse\>\(CMsgServerToGCNewBloomGiftResponse, params CMsgServerToGCNewBloomGiftResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse__ctor"></a> CMsgServerToGCNewBloomGiftResponse\(\)

```csharp
public CMsgServerToGCNewBloomGiftResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse__ctor_Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_"></a> CMsgServerToGCNewBloomGiftResponse\(CMsgServerToGCNewBloomGiftResponse\)

```csharp
public CMsgServerToGCNewBloomGiftResponse(CMsgServerToGCNewBloomGiftResponse other)
```

#### Parameters

`other` [CMsgServerToGCNewBloomGiftResponse](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGiftResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_ReceivedAccountIdsFieldNumber"></a> ReceivedAccountIdsFieldNumber

```csharp
public const int ReceivedAccountIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCNewBloomGiftResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCNewBloomGiftResponse](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGiftResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_ReceivedAccountIds"></a> ReceivedAccountIds

```csharp
public RepeatedField<uint> ReceivedAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_Result"></a> Result

```csharp
public ENewBloomGiftingResponse Result { get; set; }
```

#### Property Value

 [ENewBloomGiftingResponse](Divine.Protobufs.Dota2.ENewBloomGiftingResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCNewBloomGiftResponse Clone()
```

#### Returns

 [CMsgServerToGCNewBloomGiftResponse](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGiftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_Equals_Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_"></a> Equals\(CMsgServerToGCNewBloomGiftResponse\)

```csharp
public bool Equals(CMsgServerToGCNewBloomGiftResponse other)
```

#### Parameters

`other` [CMsgServerToGCNewBloomGiftResponse](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGiftResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_"></a> MergeFrom\(CMsgServerToGCNewBloomGiftResponse\)

```csharp
public void MergeFrom(CMsgServerToGCNewBloomGiftResponse other)
```

#### Parameters

`other` [CMsgServerToGCNewBloomGiftResponse](Divine.Protobufs.Dota2.CMsgServerToGCNewBloomGiftResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCNewBloomGiftResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

