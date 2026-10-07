# <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse"></a> Class CMsgGCRankedPlayerInfoSubmitResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRankedPlayerInfoSubmitResponse : IMessage<CMsgGCRankedPlayerInfoSubmitResponse>, IEquatable<CMsgGCRankedPlayerInfoSubmitResponse>, IDeepCloneable<CMsgGCRankedPlayerInfoSubmitResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md)

#### Implements

IMessage<CMsgGCRankedPlayerInfoSubmitResponse\>, 
[IEquatable<CMsgGCRankedPlayerInfoSubmitResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRankedPlayerInfoSubmitResponse\>, 
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
[EnumerableExtensions.In<CMsgGCRankedPlayerInfoSubmitResponse\>\(CMsgGCRankedPlayerInfoSubmitResponse, params CMsgGCRankedPlayerInfoSubmitResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse__ctor"></a> CMsgGCRankedPlayerInfoSubmitResponse\(\)

```csharp
public CMsgGCRankedPlayerInfoSubmitResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse__ctor_Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_"></a> CMsgGCRankedPlayerInfoSubmitResponse\(CMsgGCRankedPlayerInfoSubmitResponse\)

```csharp
public CMsgGCRankedPlayerInfoSubmitResponse(CMsgGCRankedPlayerInfoSubmitResponse other)
```

#### Parameters

`other` [CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRankedPlayerInfoSubmitResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_Result"></a> Result

```csharp
public CMsgGCRankedPlayerInfoSubmitResponse.Types.EResult Result { get; set; }
```

#### Property Value

 [CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.Types.EResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCRankedPlayerInfoSubmitResponse Clone()
```

#### Returns

 [CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_Equals_Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_"></a> Equals\(CMsgGCRankedPlayerInfoSubmitResponse\)

```csharp
public bool Equals(CMsgGCRankedPlayerInfoSubmitResponse other)
```

#### Parameters

`other` [CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_"></a> MergeFrom\(CMsgGCRankedPlayerInfoSubmitResponse\)

```csharp
public void MergeFrom(CMsgGCRankedPlayerInfoSubmitResponse other)
```

#### Parameters

`other` [CMsgGCRankedPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmitResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmitResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

