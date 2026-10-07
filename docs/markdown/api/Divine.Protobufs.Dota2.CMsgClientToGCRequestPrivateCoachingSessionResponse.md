# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse"></a> Class CMsgClientToGCRequestPrivateCoachingSessionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPrivateCoachingSessionResponse : IMessage<CMsgClientToGCRequestPrivateCoachingSessionResponse>, IEquatable<CMsgClientToGCRequestPrivateCoachingSessionResponse>, IDeepCloneable<CMsgClientToGCRequestPrivateCoachingSessionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestPrivateCoachingSessionResponse\>, 
[IEquatable<CMsgClientToGCRequestPrivateCoachingSessionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPrivateCoachingSessionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPrivateCoachingSessionResponse\>\(CMsgClientToGCRequestPrivateCoachingSessionResponse, params CMsgClientToGCRequestPrivateCoachingSessionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse__ctor"></a> CMsgClientToGCRequestPrivateCoachingSessionResponse\(\)

```csharp
public CMsgClientToGCRequestPrivateCoachingSessionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_"></a> CMsgClientToGCRequestPrivateCoachingSessionResponse\(CMsgClientToGCRequestPrivateCoachingSessionResponse\)

```csharp
public CMsgClientToGCRequestPrivateCoachingSessionResponse(CMsgClientToGCRequestPrivateCoachingSessionResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_CoachingSessionFieldNumber"></a> CoachingSessionFieldNumber

```csharp
public const int CoachingSessionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_CoachingSession"></a> CoachingSession

```csharp
public CMsgPrivateCoachingSession CoachingSession { get; set; }
```

#### Property Value

 [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPrivateCoachingSessionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestPrivateCoachingSessionResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPrivateCoachingSessionResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_"></a> Equals\(CMsgClientToGCRequestPrivateCoachingSessionResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestPrivateCoachingSessionResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_"></a> MergeFrom\(CMsgClientToGCRequestPrivateCoachingSessionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPrivateCoachingSessionResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPrivateCoachingSessionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPrivateCoachingSessionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

