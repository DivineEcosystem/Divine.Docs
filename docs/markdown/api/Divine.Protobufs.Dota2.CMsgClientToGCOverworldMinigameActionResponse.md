# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse"></a> Class CMsgClientToGCOverworldMinigameActionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldMinigameActionResponse : IMessage<CMsgClientToGCOverworldMinigameActionResponse>, IEquatable<CMsgClientToGCOverworldMinigameActionResponse>, IDeepCloneable<CMsgClientToGCOverworldMinigameActionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldMinigameActionResponse\>, 
[IEquatable<CMsgClientToGCOverworldMinigameActionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldMinigameActionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldMinigameActionResponse\>\(CMsgClientToGCOverworldMinigameActionResponse, params CMsgClientToGCOverworldMinigameActionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse__ctor"></a> CMsgClientToGCOverworldMinigameActionResponse\(\)

```csharp
public CMsgClientToGCOverworldMinigameActionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_"></a> CMsgClientToGCOverworldMinigameActionResponse\(CMsgClientToGCOverworldMinigameActionResponse\)

```csharp
public CMsgClientToGCOverworldMinigameActionResponse(CMsgClientToGCOverworldMinigameActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldMinigameActionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldMinigameActionResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldMinigameActionResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_"></a> Equals\(CMsgClientToGCOverworldMinigameActionResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldMinigameActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_"></a> MergeFrom\(CMsgClientToGCOverworldMinigameActionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldMinigameActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldMinigameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldMinigameActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldMinigameActionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

