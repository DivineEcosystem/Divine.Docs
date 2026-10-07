# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse"></a> Class CMsgClientToGCRecyclePlayerCardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRecyclePlayerCardResponse : IMessage<CMsgClientToGCRecyclePlayerCardResponse>, IEquatable<CMsgClientToGCRecyclePlayerCardResponse>, IDeepCloneable<CMsgClientToGCRecyclePlayerCardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md)

#### Implements

IMessage<CMsgClientToGCRecyclePlayerCardResponse\>, 
[IEquatable<CMsgClientToGCRecyclePlayerCardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRecyclePlayerCardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRecyclePlayerCardResponse\>\(CMsgClientToGCRecyclePlayerCardResponse, params CMsgClientToGCRecyclePlayerCardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse__ctor"></a> CMsgClientToGCRecyclePlayerCardResponse\(\)

```csharp
public CMsgClientToGCRecyclePlayerCardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_"></a> CMsgClientToGCRecyclePlayerCardResponse\(CMsgClientToGCRecyclePlayerCardResponse\)

```csharp
public CMsgClientToGCRecyclePlayerCardResponse(CMsgClientToGCRecyclePlayerCardResponse other)
```

#### Parameters

`other` [CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_DustAmountFieldNumber"></a> DustAmountFieldNumber

```csharp
public const int DustAmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_DustAmount"></a> DustAmount

```csharp
public uint DustAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_HasDustAmount"></a> HasDustAmount

```csharp
public bool HasDustAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRecyclePlayerCardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_Result"></a> Result

```csharp
public CMsgClientToGCRecyclePlayerCardResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_ClearDustAmount"></a> ClearDustAmount\(\)

```csharp
public void ClearDustAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRecyclePlayerCardResponse Clone()
```

#### Returns

 [CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_"></a> Equals\(CMsgClientToGCRecyclePlayerCardResponse\)

```csharp
public bool Equals(CMsgClientToGCRecyclePlayerCardResponse other)
```

#### Parameters

`other` [CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_"></a> MergeFrom\(CMsgClientToGCRecyclePlayerCardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRecyclePlayerCardResponse other)
```

#### Parameters

`other` [CMsgClientToGCRecyclePlayerCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

