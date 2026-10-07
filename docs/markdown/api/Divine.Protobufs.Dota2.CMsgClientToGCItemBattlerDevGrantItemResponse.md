# <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse"></a> Class CMsgClientToGCItemBattlerDevGrantItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCItemBattlerDevGrantItemResponse : IMessage<CMsgClientToGCItemBattlerDevGrantItemResponse>, IEquatable<CMsgClientToGCItemBattlerDevGrantItemResponse>, IDeepCloneable<CMsgClientToGCItemBattlerDevGrantItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md)

#### Implements

IMessage<CMsgClientToGCItemBattlerDevGrantItemResponse\>, 
[IEquatable<CMsgClientToGCItemBattlerDevGrantItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCItemBattlerDevGrantItemResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCItemBattlerDevGrantItemResponse\>\(CMsgClientToGCItemBattlerDevGrantItemResponse, params CMsgClientToGCItemBattlerDevGrantItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse__ctor"></a> CMsgClientToGCItemBattlerDevGrantItemResponse\(\)

```csharp
public CMsgClientToGCItemBattlerDevGrantItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_"></a> CMsgClientToGCItemBattlerDevGrantItemResponse\(CMsgClientToGCItemBattlerDevGrantItemResponse\)

```csharp
public CMsgClientToGCItemBattlerDevGrantItemResponse(CMsgClientToGCItemBattlerDevGrantItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCItemBattlerDevGrantItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_Response"></a> Response

```csharp
public CMsgClientToGCItemBattlerDevGrantItemResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCItemBattlerDevGrantItemResponse Clone()
```

#### Returns

 [CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_"></a> Equals\(CMsgClientToGCItemBattlerDevGrantItemResponse\)

```csharp
public bool Equals(CMsgClientToGCItemBattlerDevGrantItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_"></a> MergeFrom\(CMsgClientToGCItemBattlerDevGrantItemResponse\)

```csharp
public void MergeFrom(CMsgClientToGCItemBattlerDevGrantItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerDevGrantItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerDevGrantItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerDevGrantItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

