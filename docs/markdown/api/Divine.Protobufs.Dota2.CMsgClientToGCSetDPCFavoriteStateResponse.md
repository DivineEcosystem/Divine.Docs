# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse"></a> Class CMsgClientToGCSetDPCFavoriteStateResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetDPCFavoriteStateResponse : IMessage<CMsgClientToGCSetDPCFavoriteStateResponse>, IEquatable<CMsgClientToGCSetDPCFavoriteStateResponse>, IDeepCloneable<CMsgClientToGCSetDPCFavoriteStateResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md)

#### Implements

IMessage<CMsgClientToGCSetDPCFavoriteStateResponse\>, 
[IEquatable<CMsgClientToGCSetDPCFavoriteStateResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetDPCFavoriteStateResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetDPCFavoriteStateResponse\>\(CMsgClientToGCSetDPCFavoriteStateResponse, params CMsgClientToGCSetDPCFavoriteStateResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse__ctor"></a> CMsgClientToGCSetDPCFavoriteStateResponse\(\)

```csharp
public CMsgClientToGCSetDPCFavoriteStateResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_"></a> CMsgClientToGCSetDPCFavoriteStateResponse\(CMsgClientToGCSetDPCFavoriteStateResponse\)

```csharp
public CMsgClientToGCSetDPCFavoriteStateResponse(CMsgClientToGCSetDPCFavoriteStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetDPCFavoriteStateResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_Result"></a> Result

```csharp
public CMsgClientToGCSetDPCFavoriteStateResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetDPCFavoriteStateResponse Clone()
```

#### Returns

 [CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_"></a> Equals\(CMsgClientToGCSetDPCFavoriteStateResponse\)

```csharp
public bool Equals(CMsgClientToGCSetDPCFavoriteStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_"></a> MergeFrom\(CMsgClientToGCSetDPCFavoriteStateResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSetDPCFavoriteStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetDPCFavoriteStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetDPCFavoriteStateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetDPCFavoriteStateResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

