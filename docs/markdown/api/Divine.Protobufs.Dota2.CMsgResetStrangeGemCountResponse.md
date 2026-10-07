# <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse"></a> Class CMsgResetStrangeGemCountResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgResetStrangeGemCountResponse : IMessage<CMsgResetStrangeGemCountResponse>, IEquatable<CMsgResetStrangeGemCountResponse>, IDeepCloneable<CMsgResetStrangeGemCountResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md)

#### Implements

IMessage<CMsgResetStrangeGemCountResponse\>, 
[IEquatable<CMsgResetStrangeGemCountResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgResetStrangeGemCountResponse\>, 
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
[EnumerableExtensions.In<CMsgResetStrangeGemCountResponse\>\(CMsgResetStrangeGemCountResponse, params CMsgResetStrangeGemCountResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse__ctor"></a> CMsgResetStrangeGemCountResponse\(\)

```csharp
public CMsgResetStrangeGemCountResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse__ctor_Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_"></a> CMsgResetStrangeGemCountResponse\(CMsgResetStrangeGemCountResponse\)

```csharp
public CMsgResetStrangeGemCountResponse(CMsgResetStrangeGemCountResponse other)
```

#### Parameters

`other` [CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgResetStrangeGemCountResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_Response"></a> Response

```csharp
public CMsgResetStrangeGemCountResponse.Types.EResetGem Response { get; set; }
```

#### Property Value

 [CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md).[Types](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.Types.md).[EResetGem](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.Types.EResetGem.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_Clone"></a> Clone\(\)

```csharp
public CMsgResetStrangeGemCountResponse Clone()
```

#### Returns

 [CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_Equals_Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_"></a> Equals\(CMsgResetStrangeGemCountResponse\)

```csharp
public bool Equals(CMsgResetStrangeGemCountResponse other)
```

#### Parameters

`other` [CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_"></a> MergeFrom\(CMsgResetStrangeGemCountResponse\)

```csharp
public void MergeFrom(CMsgResetStrangeGemCountResponse other)
```

#### Parameters

`other` [CMsgResetStrangeGemCountResponse](Divine.Protobufs.Dota2.CMsgResetStrangeGemCountResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgResetStrangeGemCountResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

