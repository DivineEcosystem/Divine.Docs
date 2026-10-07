# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse"></a> Class CMsgClientToGCSubmitPlayerMatchSurveyResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitPlayerMatchSurveyResponse : IMessage<CMsgClientToGCSubmitPlayerMatchSurveyResponse>, IEquatable<CMsgClientToGCSubmitPlayerMatchSurveyResponse>, IDeepCloneable<CMsgClientToGCSubmitPlayerMatchSurveyResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md)

#### Implements

IMessage<CMsgClientToGCSubmitPlayerMatchSurveyResponse\>, 
[IEquatable<CMsgClientToGCSubmitPlayerMatchSurveyResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitPlayerMatchSurveyResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitPlayerMatchSurveyResponse\>\(CMsgClientToGCSubmitPlayerMatchSurveyResponse, params CMsgClientToGCSubmitPlayerMatchSurveyResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse__ctor"></a> CMsgClientToGCSubmitPlayerMatchSurveyResponse\(\)

```csharp
public CMsgClientToGCSubmitPlayerMatchSurveyResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_"></a> CMsgClientToGCSubmitPlayerMatchSurveyResponse\(CMsgClientToGCSubmitPlayerMatchSurveyResponse\)

```csharp
public CMsgClientToGCSubmitPlayerMatchSurveyResponse(CMsgClientToGCSubmitPlayerMatchSurveyResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_Eresult"></a> Eresult

```csharp
public CMsgClientToGCSubmitPlayerMatchSurveyResponse.Types.EResponse Eresult { get; set; }
```

#### Property Value

 [CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitPlayerMatchSurveyResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitPlayerMatchSurveyResponse Clone()
```

#### Returns

 [CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_"></a> Equals\(CMsgClientToGCSubmitPlayerMatchSurveyResponse\)

```csharp
public bool Equals(CMsgClientToGCSubmitPlayerMatchSurveyResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_"></a> MergeFrom\(CMsgClientToGCSubmitPlayerMatchSurveyResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitPlayerMatchSurveyResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPlayerMatchSurveyResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPlayerMatchSurveyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPlayerMatchSurveyResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

