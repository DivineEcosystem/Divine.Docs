# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse"></a> Class CMsgClientToGCRequestActiveGuildContractsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestActiveGuildContractsResponse : IMessage<CMsgClientToGCRequestActiveGuildContractsResponse>, IEquatable<CMsgClientToGCRequestActiveGuildContractsResponse>, IDeepCloneable<CMsgClientToGCRequestActiveGuildContractsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestActiveGuildContractsResponse\>, 
[IEquatable<CMsgClientToGCRequestActiveGuildContractsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestActiveGuildContractsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestActiveGuildContractsResponse\>\(CMsgClientToGCRequestActiveGuildContractsResponse, params CMsgClientToGCRequestActiveGuildContractsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse__ctor"></a> CMsgClientToGCRequestActiveGuildContractsResponse\(\)

```csharp
public CMsgClientToGCRequestActiveGuildContractsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_"></a> CMsgClientToGCRequestActiveGuildContractsResponse\(CMsgClientToGCRequestActiveGuildContractsResponse\)

```csharp
public CMsgClientToGCRequestActiveGuildContractsResponse(CMsgClientToGCRequestActiveGuildContractsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ActiveChallengesFieldNumber"></a> ActiveChallengesFieldNumber

```csharp
public const int ActiveChallengesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ActiveContractsFieldNumber"></a> ActiveContractsFieldNumber

```csharp
public const int ActiveContractsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ActiveChallenges"></a> ActiveChallenges

```csharp
public CMsgGuildChallenge ActiveChallenges { get; set; }
```

#### Property Value

 [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ActiveContracts"></a> ActiveContracts

```csharp
public CMsgGuildActiveContracts ActiveContracts { get; set; }
```

#### Property Value

 [CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestActiveGuildContractsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestActiveGuildContractsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestActiveGuildContractsResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_"></a> Equals\(CMsgClientToGCRequestActiveGuildContractsResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestActiveGuildContractsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_"></a> MergeFrom\(CMsgClientToGCRequestActiveGuildContractsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestActiveGuildContractsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestActiveGuildContractsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildContractsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildContractsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

