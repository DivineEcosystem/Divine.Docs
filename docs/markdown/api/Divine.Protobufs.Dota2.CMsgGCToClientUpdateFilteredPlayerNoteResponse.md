# <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse"></a> Class CMsgGCToClientUpdateFilteredPlayerNoteResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientUpdateFilteredPlayerNoteResponse : IMessage<CMsgGCToClientUpdateFilteredPlayerNoteResponse>, IEquatable<CMsgGCToClientUpdateFilteredPlayerNoteResponse>, IDeepCloneable<CMsgGCToClientUpdateFilteredPlayerNoteResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md)

#### Implements

IMessage<CMsgGCToClientUpdateFilteredPlayerNoteResponse\>, 
[IEquatable<CMsgGCToClientUpdateFilteredPlayerNoteResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientUpdateFilteredPlayerNoteResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientUpdateFilteredPlayerNoteResponse\>\(CMsgGCToClientUpdateFilteredPlayerNoteResponse, params CMsgGCToClientUpdateFilteredPlayerNoteResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse__ctor"></a> CMsgGCToClientUpdateFilteredPlayerNoteResponse\(\)

```csharp
public CMsgGCToClientUpdateFilteredPlayerNoteResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_"></a> CMsgGCToClientUpdateFilteredPlayerNoteResponse\(CMsgGCToClientUpdateFilteredPlayerNoteResponse\)

```csharp
public CMsgGCToClientUpdateFilteredPlayerNoteResponse(CMsgGCToClientUpdateFilteredPlayerNoteResponse other)
```

#### Parameters

`other` [CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientUpdateFilteredPlayerNoteResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_Result"></a> Result

```csharp
public CMsgGCToClientUpdateFilteredPlayerNoteResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientUpdateFilteredPlayerNoteResponse Clone()
```

#### Returns

 [CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_"></a> Equals\(CMsgGCToClientUpdateFilteredPlayerNoteResponse\)

```csharp
public bool Equals(CMsgGCToClientUpdateFilteredPlayerNoteResponse other)
```

#### Parameters

`other` [CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_"></a> MergeFrom\(CMsgGCToClientUpdateFilteredPlayerNoteResponse\)

```csharp
public void MergeFrom(CMsgGCToClientUpdateFilteredPlayerNoteResponse other)
```

#### Parameters

`other` [CMsgGCToClientUpdateFilteredPlayerNoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientUpdateFilteredPlayerNoteResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientUpdateFilteredPlayerNoteResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

