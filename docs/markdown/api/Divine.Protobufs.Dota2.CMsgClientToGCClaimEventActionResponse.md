# <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse"></a> Class CMsgClientToGCClaimEventActionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCClaimEventActionResponse : IMessage<CMsgClientToGCClaimEventActionResponse>, IEquatable<CMsgClientToGCClaimEventActionResponse>, IDeepCloneable<CMsgClientToGCClaimEventActionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md)

#### Implements

IMessage<CMsgClientToGCClaimEventActionResponse\>, 
[IEquatable<CMsgClientToGCClaimEventActionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCClaimEventActionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCClaimEventActionResponse\>\(CMsgClientToGCClaimEventActionResponse, params CMsgClientToGCClaimEventActionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse__ctor"></a> CMsgClientToGCClaimEventActionResponse\(\)

```csharp
public CMsgClientToGCClaimEventActionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_"></a> CMsgClientToGCClaimEventActionResponse\(CMsgClientToGCClaimEventActionResponse\)

```csharp
public CMsgClientToGCClaimEventActionResponse(CMsgClientToGCClaimEventActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_GrantResultsFieldNumber"></a> GrantResultsFieldNumber

```csharp
public const int GrantResultsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_GrantResults"></a> GrantResults

```csharp
public RepeatedField<CMsgEventActionGrantResult> GrantResults { get; }
```

#### Property Value

 RepeatedField<[CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCClaimEventActionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_Result"></a> Result

```csharp
public CMsgClientToGCClaimEventActionResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCClaimEventActionResponse Clone()
```

#### Returns

 [CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_"></a> Equals\(CMsgClientToGCClaimEventActionResponse\)

```csharp
public bool Equals(CMsgClientToGCClaimEventActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_"></a> MergeFrom\(CMsgClientToGCClaimEventActionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCClaimEventActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimEventActionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

