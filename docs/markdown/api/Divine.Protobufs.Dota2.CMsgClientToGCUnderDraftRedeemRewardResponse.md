# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse"></a> Class CMsgClientToGCUnderDraftRedeemRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftRedeemRewardResponse : IMessage<CMsgClientToGCUnderDraftRedeemRewardResponse>, IEquatable<CMsgClientToGCUnderDraftRedeemRewardResponse>, IDeepCloneable<CMsgClientToGCUnderDraftRedeemRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftRedeemRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemRewardResponse.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftRedeemRewardResponse\>, 
[IEquatable<CMsgClientToGCUnderDraftRedeemRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftRedeemRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftRedeemRewardResponse\>\(CMsgClientToGCUnderDraftRedeemRewardResponse, params CMsgClientToGCUnderDraftRedeemRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse__ctor"></a> CMsgClientToGCUnderDraftRedeemRewardResponse\(\)

```csharp
public CMsgClientToGCUnderDraftRedeemRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_"></a> CMsgClientToGCUnderDraftRedeemRewardResponse\(CMsgClientToGCUnderDraftRedeemRewardResponse\)

```csharp
public CMsgClientToGCUnderDraftRedeemRewardResponse(CMsgClientToGCUnderDraftRedeemRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRedeemRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftRedeemRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftRedeemRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_Result"></a> Result

```csharp
public EUnderDraftResponse Result { get; set; }
```

#### Property Value

 [EUnderDraftResponse](Divine.Protobufs.Dota2.EUnderDraftResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftRedeemRewardResponse Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftRedeemRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_"></a> Equals\(CMsgClientToGCUnderDraftRedeemRewardResponse\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftRedeemRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRedeemRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_"></a> MergeFrom\(CMsgClientToGCUnderDraftRedeemRewardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftRedeemRewardResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRedeemRewardResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRedeemRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRedeemRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

