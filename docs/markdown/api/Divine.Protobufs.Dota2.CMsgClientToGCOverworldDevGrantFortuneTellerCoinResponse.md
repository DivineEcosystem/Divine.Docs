# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse"></a> Class CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse : IMessage<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse>, IEquatable<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse>, IDeepCloneable<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\>, 
[IEquatable<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\>\(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse, params CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse__ctor"></a> CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\(\)

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_"></a> CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\)

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_"></a> Equals\(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_"></a> MergeFrom\(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantFortuneTellerCoinResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

