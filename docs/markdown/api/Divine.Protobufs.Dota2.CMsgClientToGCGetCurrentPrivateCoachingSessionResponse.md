# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse"></a> Class CMsgClientToGCGetCurrentPrivateCoachingSessionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetCurrentPrivateCoachingSessionResponse : IMessage<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse>, IEquatable<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse>, IDeepCloneable<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md)

#### Implements

IMessage<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\>, 
[IEquatable<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\>\(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse, params CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse__ctor"></a> CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\(\)

```csharp
public CMsgClientToGCGetCurrentPrivateCoachingSessionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_"></a> CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\)

```csharp
public CMsgClientToGCGetCurrentPrivateCoachingSessionResponse(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_CurrentSessionFieldNumber"></a> CurrentSessionFieldNumber

```csharp
public const int CurrentSessionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_CurrentSession"></a> CurrentSession

```csharp
public CMsgPrivateCoachingSession CurrentSession { get; set; }
```

#### Property Value

 [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetCurrentPrivateCoachingSessionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetCurrentPrivateCoachingSessionResponse Clone()
```

#### Returns

 [CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_"></a> Equals\(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\)

```csharp
public bool Equals(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_"></a> MergeFrom\(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetCurrentPrivateCoachingSessionResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetCurrentPrivateCoachingSessionResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetCurrentPrivateCoachingSessionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetCurrentPrivateCoachingSessionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

