# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse"></a> Class CMsgClientToGCGetTrophyListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetTrophyListResponse : IMessage<CMsgClientToGCGetTrophyListResponse>, IEquatable<CMsgClientToGCGetTrophyListResponse>, IDeepCloneable<CMsgClientToGCGetTrophyListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md)

#### Implements

IMessage<CMsgClientToGCGetTrophyListResponse\>, 
[IEquatable<CMsgClientToGCGetTrophyListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetTrophyListResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetTrophyListResponse\>\(CMsgClientToGCGetTrophyListResponse, params CMsgClientToGCGetTrophyListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse__ctor"></a> CMsgClientToGCGetTrophyListResponse\(\)

```csharp
public CMsgClientToGCGetTrophyListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_"></a> CMsgClientToGCGetTrophyListResponse\(CMsgClientToGCGetTrophyListResponse\)

```csharp
public CMsgClientToGCGetTrophyListResponse(CMsgClientToGCGetTrophyListResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_TrophiesFieldNumber"></a> TrophiesFieldNumber

```csharp
public const int TrophiesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetTrophyListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_Trophies"></a> Trophies

```csharp
public RepeatedField<CMsgClientToGCGetTrophyListResponse.Types.Trophy> Trophies { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.Types.md).[Trophy](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.Types.Trophy.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetTrophyListResponse Clone()
```

#### Returns

 [CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_"></a> Equals\(CMsgClientToGCGetTrophyListResponse\)

```csharp
public bool Equals(CMsgClientToGCGetTrophyListResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_"></a> MergeFrom\(CMsgClientToGCGetTrophyListResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetTrophyListResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetTrophyListResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetTrophyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetTrophyListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

