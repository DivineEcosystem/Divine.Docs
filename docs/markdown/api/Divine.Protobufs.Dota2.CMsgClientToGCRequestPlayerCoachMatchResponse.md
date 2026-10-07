# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse"></a> Class CMsgClientToGCRequestPlayerCoachMatchResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerCoachMatchResponse : IMessage<CMsgClientToGCRequestPlayerCoachMatchResponse>, IEquatable<CMsgClientToGCRequestPlayerCoachMatchResponse>, IDeepCloneable<CMsgClientToGCRequestPlayerCoachMatchResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerCoachMatchResponse\>, 
[IEquatable<CMsgClientToGCRequestPlayerCoachMatchResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerCoachMatchResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerCoachMatchResponse\>\(CMsgClientToGCRequestPlayerCoachMatchResponse, params CMsgClientToGCRequestPlayerCoachMatchResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse__ctor"></a> CMsgClientToGCRequestPlayerCoachMatchResponse\(\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatchResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_"></a> CMsgClientToGCRequestPlayerCoachMatchResponse\(CMsgClientToGCRequestPlayerCoachMatchResponse\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatchResponse(CMsgClientToGCRequestPlayerCoachMatchResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_CoachMatchFieldNumber"></a> CoachMatchFieldNumber

```csharp
public const int CoachMatchFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_CoachMatch"></a> CoachMatch

```csharp
public CMsgPlayerCoachMatch CoachMatch { get; set; }
```

#### Property Value

 [CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerCoachMatchResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestPlayerCoachMatchResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerCoachMatchResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_"></a> Equals\(CMsgClientToGCRequestPlayerCoachMatchResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerCoachMatchResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_"></a> MergeFrom\(CMsgClientToGCRequestPlayerCoachMatchResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerCoachMatchResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerCoachMatchResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerCoachMatchResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerCoachMatchResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

