# <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse"></a> Class CMsgDOTAStartTriviaSessionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAStartTriviaSessionResponse : IMessage<CMsgDOTAStartTriviaSessionResponse>, IEquatable<CMsgDOTAStartTriviaSessionResponse>, IDeepCloneable<CMsgDOTAStartTriviaSessionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAStartTriviaSessionResponse](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSessionResponse.md)

#### Implements

IMessage<CMsgDOTAStartTriviaSessionResponse\>, 
[IEquatable<CMsgDOTAStartTriviaSessionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAStartTriviaSessionResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAStartTriviaSessionResponse\>\(CMsgDOTAStartTriviaSessionResponse, params CMsgDOTAStartTriviaSessionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse__ctor"></a> CMsgDOTAStartTriviaSessionResponse\(\)

```csharp
public CMsgDOTAStartTriviaSessionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_"></a> CMsgDOTAStartTriviaSessionResponse\(CMsgDOTAStartTriviaSessionResponse\)

```csharp
public CMsgDOTAStartTriviaSessionResponse(CMsgDOTAStartTriviaSessionResponse other)
```

#### Parameters

`other` [CMsgDOTAStartTriviaSessionResponse](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSessionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_CurrentTimestampFieldNumber"></a> CurrentTimestampFieldNumber

```csharp
public const int CurrentTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_TriviaEnabledFieldNumber"></a> TriviaEnabledFieldNumber

```csharp
public const int TriviaEnabledFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_CurrentTimestamp"></a> CurrentTimestamp

```csharp
public uint CurrentTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_HasCurrentTimestamp"></a> HasCurrentTimestamp

```csharp
public bool HasCurrentTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_HasTriviaEnabled"></a> HasTriviaEnabled

```csharp
public bool HasTriviaEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAStartTriviaSessionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAStartTriviaSessionResponse](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSessionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_TriviaEnabled"></a> TriviaEnabled

```csharp
public bool TriviaEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_ClearCurrentTimestamp"></a> ClearCurrentTimestamp\(\)

```csharp
public void ClearCurrentTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_ClearTriviaEnabled"></a> ClearTriviaEnabled\(\)

```csharp
public void ClearTriviaEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAStartTriviaSessionResponse Clone()
```

#### Returns

 [CMsgDOTAStartTriviaSessionResponse](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSessionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_"></a> Equals\(CMsgDOTAStartTriviaSessionResponse\)

```csharp
public bool Equals(CMsgDOTAStartTriviaSessionResponse other)
```

#### Parameters

`other` [CMsgDOTAStartTriviaSessionResponse](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSessionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_"></a> MergeFrom\(CMsgDOTAStartTriviaSessionResponse\)

```csharp
public void MergeFrom(CMsgDOTAStartTriviaSessionResponse other)
```

#### Parameters

`other` [CMsgDOTAStartTriviaSessionResponse](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSessionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSessionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

