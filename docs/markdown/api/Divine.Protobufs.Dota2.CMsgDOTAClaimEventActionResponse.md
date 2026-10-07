# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse"></a> Class CMsgDOTAClaimEventActionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionResponse : IMessage<CMsgDOTAClaimEventActionResponse>, IEquatable<CMsgDOTAClaimEventActionResponse>, IDeepCloneable<CMsgDOTAClaimEventActionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionResponse\>, 
[IEquatable<CMsgDOTAClaimEventActionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionResponse\>\(CMsgDOTAClaimEventActionResponse, params CMsgDOTAClaimEventActionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse__ctor"></a> CMsgDOTAClaimEventActionResponse\(\)

```csharp
public CMsgDOTAClaimEventActionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_"></a> CMsgDOTAClaimEventActionResponse\(CMsgDOTAClaimEventActionResponse\)

```csharp
public CMsgDOTAClaimEventActionResponse(CMsgDOTAClaimEventActionResponse other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_RewardResultsFieldNumber"></a> RewardResultsFieldNumber

```csharp
public const int RewardResultsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Result"></a> Result

```csharp
public CMsgDOTAClaimEventActionResponse.Types.ResultCode Result { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[ResultCode](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.ResultCode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_RewardResults"></a> RewardResults

```csharp
public RepeatedField<CMsgDOTAClaimEventActionResponse.Types.GrantedRewardData> RewardResults { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[GrantedRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.GrantedRewardData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionResponse Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_"></a> Equals\(CMsgDOTAClaimEventActionResponse\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionResponse other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_"></a> MergeFrom\(CMsgDOTAClaimEventActionResponse\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionResponse other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

