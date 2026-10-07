# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse"></a> Class CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse : IMessage<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse>, IEquatable<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse>, IDeepCloneable<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md)

#### Implements

IMessage<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\>, 
[IEquatable<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\>\(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse, params CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse__ctor"></a> CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\(\)

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_"></a> CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\)

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_CoachingSessionSummaryFieldNumber"></a> CoachingSessionSummaryFieldNumber

```csharp
public const int CoachingSessionSummaryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_CoachingSessionSummary"></a> CoachingSessionSummary

```csharp
public CMsgAvailablePrivateCoachingSessionSummary CoachingSessionSummary { get; set; }
```

#### Property Value

 [CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse Clone()
```

#### Returns

 [CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_"></a> Equals\(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\)

```csharp
public bool Equals(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_"></a> MergeFrom\(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsSummaryResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

