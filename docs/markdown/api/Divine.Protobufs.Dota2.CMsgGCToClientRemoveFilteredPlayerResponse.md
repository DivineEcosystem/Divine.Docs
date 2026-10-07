# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse"></a> Class CMsgGCToClientRemoveFilteredPlayerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRemoveFilteredPlayerResponse : IMessage<CMsgGCToClientRemoveFilteredPlayerResponse>, IEquatable<CMsgGCToClientRemoveFilteredPlayerResponse>, IDeepCloneable<CMsgGCToClientRemoveFilteredPlayerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md)

#### Implements

IMessage<CMsgGCToClientRemoveFilteredPlayerResponse\>, 
[IEquatable<CMsgGCToClientRemoveFilteredPlayerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRemoveFilteredPlayerResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRemoveFilteredPlayerResponse\>\(CMsgGCToClientRemoveFilteredPlayerResponse, params CMsgGCToClientRemoveFilteredPlayerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse__ctor"></a> CMsgGCToClientRemoveFilteredPlayerResponse\(\)

```csharp
public CMsgGCToClientRemoveFilteredPlayerResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_"></a> CMsgGCToClientRemoveFilteredPlayerResponse\(CMsgGCToClientRemoveFilteredPlayerResponse\)

```csharp
public CMsgGCToClientRemoveFilteredPlayerResponse(CMsgGCToClientRemoveFilteredPlayerResponse other)
```

#### Parameters

`other` [CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRemoveFilteredPlayerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_Result"></a> Result

```csharp
public CMsgGCToClientRemoveFilteredPlayerResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRemoveFilteredPlayerResponse Clone()
```

#### Returns

 [CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_"></a> Equals\(CMsgGCToClientRemoveFilteredPlayerResponse\)

```csharp
public bool Equals(CMsgGCToClientRemoveFilteredPlayerResponse other)
```

#### Parameters

`other` [CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_"></a> MergeFrom\(CMsgGCToClientRemoveFilteredPlayerResponse\)

```csharp
public void MergeFrom(CMsgGCToClientRemoveFilteredPlayerResponse other)
```

#### Parameters

`other` [CMsgGCToClientRemoveFilteredPlayerResponse](Divine.Protobufs.Dota2.CMsgGCToClientRemoveFilteredPlayerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRemoveFilteredPlayerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

