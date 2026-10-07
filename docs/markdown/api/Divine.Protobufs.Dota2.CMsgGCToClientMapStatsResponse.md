# <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse"></a> Class CMsgGCToClientMapStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientMapStatsResponse : IMessage<CMsgGCToClientMapStatsResponse>, IEquatable<CMsgGCToClientMapStatsResponse>, IDeepCloneable<CMsgGCToClientMapStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md)

#### Implements

IMessage<CMsgGCToClientMapStatsResponse\>, 
[IEquatable<CMsgGCToClientMapStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientMapStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientMapStatsResponse\>\(CMsgGCToClientMapStatsResponse, params CMsgGCToClientMapStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse__ctor"></a> CMsgGCToClientMapStatsResponse\(\)

```csharp
public CMsgGCToClientMapStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_"></a> CMsgGCToClientMapStatsResponse\(CMsgGCToClientMapStatsResponse\)

```csharp
public CMsgGCToClientMapStatsResponse(CMsgGCToClientMapStatsResponse other)
```

#### Parameters

`other` [CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_GlobalStatsFieldNumber"></a> GlobalStatsFieldNumber

```csharp
public const int GlobalStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_PersonalStatsFieldNumber"></a> PersonalStatsFieldNumber

```csharp
public const int PersonalStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_GlobalStats"></a> GlobalStats

```csharp
public CMsgGlobalMapStats GlobalStats { get; set; }
```

#### Property Value

 [CMsgGlobalMapStats](Divine.Protobufs.Dota2.CMsgGlobalMapStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientMapStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_PersonalStats"></a> PersonalStats

```csharp
public CMsgMapStatsSnapshot PersonalStats { get; set; }
```

#### Property Value

 [CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_Response"></a> Response

```csharp
public CMsgGCToClientMapStatsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientMapStatsResponse Clone()
```

#### Returns

 [CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_"></a> Equals\(CMsgGCToClientMapStatsResponse\)

```csharp
public bool Equals(CMsgGCToClientMapStatsResponse other)
```

#### Parameters

`other` [CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_"></a> MergeFrom\(CMsgGCToClientMapStatsResponse\)

```csharp
public void MergeFrom(CMsgGCToClientMapStatsResponse other)
```

#### Parameters

`other` [CMsgGCToClientMapStatsResponse](Divine.Protobufs.Dota2.CMsgGCToClientMapStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMapStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

