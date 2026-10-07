# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse"></a> Class CMsgClientToGCRequestPlayerCoachMatchesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerCoachMatchesResponse : IMessage<CMsgClientToGCRequestPlayerCoachMatchesResponse>, IEquatable<CMsgClientToGCRequestPlayerCoachMatchesResponse>, IDeepCloneable<CMsgClientToGCRequestPlayerCoachMatchesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerCoachMatchesResponse\>, 
[IEquatable<CMsgClientToGCRequestPlayerCoachMatchesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerCoachMatchesResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerCoachMatchesResponse\>\(CMsgClientToGCRequestPlayerCoachMatchesResponse, params CMsgClientToGCRequestPlayerCoachMatchesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse__ctor"></a> CMsgClientToGCRequestPlayerCoachMatchesResponse\(\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatchesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_"></a> CMsgClientToGCRequestPlayerCoachMatchesResponse\(CMsgClientToGCRequestPlayerCoachMatchesResponse\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatchesResponse(CMsgClientToGCRequestPlayerCoachMatchesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_CoachMatchesFieldNumber"></a> CoachMatchesFieldNumber

```csharp
public const int CoachMatchesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_CoachMatches"></a> CoachMatches

```csharp
public RepeatedField<CMsgPlayerCoachMatch> CoachMatches { get; }
```

#### Property Value

 RepeatedField<[CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerCoachMatchesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestPlayerCoachMatchesResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatchesResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_"></a> Equals\(CMsgClientToGCRequestPlayerCoachMatchesResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerCoachMatchesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_"></a> MergeFrom\(CMsgClientToGCRequestPlayerCoachMatchesResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerCoachMatchesResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatchesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

