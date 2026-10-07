# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse"></a> Class CMsgClientToGCOverworldDevSetFortuneResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevSetFortuneResponse : IMessage<CMsgClientToGCOverworldDevSetFortuneResponse>, IEquatable<CMsgClientToGCOverworldDevSetFortuneResponse>, IDeepCloneable<CMsgClientToGCOverworldDevSetFortuneResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevSetFortuneResponse\>, 
[IEquatable<CMsgClientToGCOverworldDevSetFortuneResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevSetFortuneResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevSetFortuneResponse\>\(CMsgClientToGCOverworldDevSetFortuneResponse, params CMsgClientToGCOverworldDevSetFortuneResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse__ctor"></a> CMsgClientToGCOverworldDevSetFortuneResponse\(\)

```csharp
public CMsgClientToGCOverworldDevSetFortuneResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_"></a> CMsgClientToGCOverworldDevSetFortuneResponse\(CMsgClientToGCOverworldDevSetFortuneResponse\)

```csharp
public CMsgClientToGCOverworldDevSetFortuneResponse(CMsgClientToGCOverworldDevSetFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevSetFortuneResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldDevSetFortuneResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevSetFortuneResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_"></a> Equals\(CMsgClientToGCOverworldDevSetFortuneResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevSetFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_"></a> MergeFrom\(CMsgClientToGCOverworldDevSetFortuneResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevSetFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevSetFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortuneResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortuneResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

