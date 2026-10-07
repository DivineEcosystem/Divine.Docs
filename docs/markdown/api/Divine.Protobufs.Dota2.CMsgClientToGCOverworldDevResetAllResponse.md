# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse"></a> Class CMsgClientToGCOverworldDevResetAllResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevResetAllResponse : IMessage<CMsgClientToGCOverworldDevResetAllResponse>, IEquatable<CMsgClientToGCOverworldDevResetAllResponse>, IDeepCloneable<CMsgClientToGCOverworldDevResetAllResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevResetAllResponse\>, 
[IEquatable<CMsgClientToGCOverworldDevResetAllResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevResetAllResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevResetAllResponse\>\(CMsgClientToGCOverworldDevResetAllResponse, params CMsgClientToGCOverworldDevResetAllResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse__ctor"></a> CMsgClientToGCOverworldDevResetAllResponse\(\)

```csharp
public CMsgClientToGCOverworldDevResetAllResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_"></a> CMsgClientToGCOverworldDevResetAllResponse\(CMsgClientToGCOverworldDevResetAllResponse\)

```csharp
public CMsgClientToGCOverworldDevResetAllResponse(CMsgClientToGCOverworldDevResetAllResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevResetAllResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldDevResetAllResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevResetAllResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_"></a> Equals\(CMsgClientToGCOverworldDevResetAllResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevResetAllResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_"></a> MergeFrom\(CMsgClientToGCOverworldDevResetAllResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevResetAllResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAllResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAllResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

