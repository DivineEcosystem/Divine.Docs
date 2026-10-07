# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse"></a> Class CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse : IMessage<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse>, IEquatable<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse>, IDeepCloneable<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md)

#### Implements

IMessage<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\>, 
[IEquatable<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\>\(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse, params CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse__ctor"></a> CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\(\)

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_"></a> CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\)

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_AvailableSessionsListFieldNumber"></a> AvailableSessionsListFieldNumber

```csharp
public const int AvailableSessionsListFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_AvailableSessionsList"></a> AvailableSessionsList

```csharp
public CMsgAvailablePrivateCoachingSessionList AvailableSessionsList { get; set; }
```

#### Property Value

 [CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse Clone()
```

#### Returns

 [CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_"></a> Equals\(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\)

```csharp
public bool Equals(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_"></a> MergeFrom\(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAvailablePrivateCoachingSessionsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

