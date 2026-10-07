# <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse"></a> Class CMsgGCPlayerInfoSubmitResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCPlayerInfoSubmitResponse : IMessage<CMsgGCPlayerInfoSubmitResponse>, IEquatable<CMsgGCPlayerInfoSubmitResponse>, IDeepCloneable<CMsgGCPlayerInfoSubmitResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md)

#### Implements

IMessage<CMsgGCPlayerInfoSubmitResponse\>, 
[IEquatable<CMsgGCPlayerInfoSubmitResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCPlayerInfoSubmitResponse\>, 
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
[EnumerableExtensions.In<CMsgGCPlayerInfoSubmitResponse\>\(CMsgGCPlayerInfoSubmitResponse, params CMsgGCPlayerInfoSubmitResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse__ctor"></a> CMsgGCPlayerInfoSubmitResponse\(\)

```csharp
public CMsgGCPlayerInfoSubmitResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse__ctor_Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_"></a> CMsgGCPlayerInfoSubmitResponse\(CMsgGCPlayerInfoSubmitResponse\)

```csharp
public CMsgGCPlayerInfoSubmitResponse(CMsgGCPlayerInfoSubmitResponse other)
```

#### Parameters

`other` [CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCPlayerInfoSubmitResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_Result"></a> Result

```csharp
public CMsgGCPlayerInfoSubmitResponse.Types.EResult Result { get; set; }
```

#### Property Value

 [CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.Types.EResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCPlayerInfoSubmitResponse Clone()
```

#### Returns

 [CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_Equals_Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_"></a> Equals\(CMsgGCPlayerInfoSubmitResponse\)

```csharp
public bool Equals(CMsgGCPlayerInfoSubmitResponse other)
```

#### Parameters

`other` [CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_"></a> MergeFrom\(CMsgGCPlayerInfoSubmitResponse\)

```csharp
public void MergeFrom(CMsgGCPlayerInfoSubmitResponse other)
```

#### Parameters

`other` [CMsgGCPlayerInfoSubmitResponse](Divine.Protobufs.Dota2.CMsgGCPlayerInfoSubmitResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCPlayerInfoSubmitResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

