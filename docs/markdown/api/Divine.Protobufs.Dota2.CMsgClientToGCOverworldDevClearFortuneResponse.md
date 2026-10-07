# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse"></a> Class CMsgClientToGCOverworldDevClearFortuneResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevClearFortuneResponse : IMessage<CMsgClientToGCOverworldDevClearFortuneResponse>, IEquatable<CMsgClientToGCOverworldDevClearFortuneResponse>, IDeepCloneable<CMsgClientToGCOverworldDevClearFortuneResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevClearFortuneResponse\>, 
[IEquatable<CMsgClientToGCOverworldDevClearFortuneResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevClearFortuneResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevClearFortuneResponse\>\(CMsgClientToGCOverworldDevClearFortuneResponse, params CMsgClientToGCOverworldDevClearFortuneResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse__ctor"></a> CMsgClientToGCOverworldDevClearFortuneResponse\(\)

```csharp
public CMsgClientToGCOverworldDevClearFortuneResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_"></a> CMsgClientToGCOverworldDevClearFortuneResponse\(CMsgClientToGCOverworldDevClearFortuneResponse\)

```csharp
public CMsgClientToGCOverworldDevClearFortuneResponse(CMsgClientToGCOverworldDevClearFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevClearFortuneResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldDevClearFortuneResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevClearFortuneResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_"></a> Equals\(CMsgClientToGCOverworldDevClearFortuneResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevClearFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_"></a> MergeFrom\(CMsgClientToGCOverworldDevClearFortuneResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevClearFortuneResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearFortuneResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortuneResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortuneResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

