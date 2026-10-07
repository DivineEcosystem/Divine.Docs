# <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse"></a> Class CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse : IMessage<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse>, IEquatable<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse>, IDeepCloneable<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md)

#### Implements

IMessage<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\>, 
[IEquatable<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\>\(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse, params CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse__ctor"></a> CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\(\)

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_"></a> CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\)

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse other)
```

#### Parameters

`other` [CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_Result"></a> Result

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse Clone()
```

#### Returns

 [CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_"></a> Equals\(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\)

```csharp
public bool Equals(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse other)
```

#### Parameters

`other` [CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_"></a> MergeFrom\(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse\)

```csharp
public void MergeFrom(CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse other)
```

#### Parameters

`other` [CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobbyResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

