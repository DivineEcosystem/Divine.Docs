# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse"></a> Class CMsgClientToGCMatchesMinimalResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMatchesMinimalResponse : IMessage<CMsgClientToGCMatchesMinimalResponse>, IEquatable<CMsgClientToGCMatchesMinimalResponse>, IDeepCloneable<CMsgClientToGCMatchesMinimalResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMatchesMinimalResponse](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalResponse.md)

#### Implements

IMessage<CMsgClientToGCMatchesMinimalResponse\>, 
[IEquatable<CMsgClientToGCMatchesMinimalResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMatchesMinimalResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMatchesMinimalResponse\>\(CMsgClientToGCMatchesMinimalResponse, params CMsgClientToGCMatchesMinimalResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse__ctor"></a> CMsgClientToGCMatchesMinimalResponse\(\)

```csharp
public CMsgClientToGCMatchesMinimalResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_"></a> CMsgClientToGCMatchesMinimalResponse\(CMsgClientToGCMatchesMinimalResponse\)

```csharp
public CMsgClientToGCMatchesMinimalResponse(CMsgClientToGCMatchesMinimalResponse other)
```

#### Parameters

`other` [CMsgClientToGCMatchesMinimalResponse](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_LastMatchFieldNumber"></a> LastMatchFieldNumber

```csharp
public const int LastMatchFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_HasLastMatch"></a> HasLastMatch

```csharp
public bool HasLastMatch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_LastMatch"></a> LastMatch

```csharp
public bool LastMatch { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTAMatchMinimal> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMatchesMinimalResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMatchesMinimalResponse](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_ClearLastMatch"></a> ClearLastMatch\(\)

```csharp
public void ClearLastMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMatchesMinimalResponse Clone()
```

#### Returns

 [CMsgClientToGCMatchesMinimalResponse](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_"></a> Equals\(CMsgClientToGCMatchesMinimalResponse\)

```csharp
public bool Equals(CMsgClientToGCMatchesMinimalResponse other)
```

#### Parameters

`other` [CMsgClientToGCMatchesMinimalResponse](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_"></a> MergeFrom\(CMsgClientToGCMatchesMinimalResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMatchesMinimalResponse other)
```

#### Parameters

`other` [CMsgClientToGCMatchesMinimalResponse](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

