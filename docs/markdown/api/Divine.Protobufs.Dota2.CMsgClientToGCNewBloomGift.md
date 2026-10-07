# <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift"></a> Class CMsgClientToGCNewBloomGift

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCNewBloomGift : IMessage<CMsgClientToGCNewBloomGift>, IEquatable<CMsgClientToGCNewBloomGift>, IDeepCloneable<CMsgClientToGCNewBloomGift>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgClientToGCNewBloomGift.md)

#### Implements

IMessage<CMsgClientToGCNewBloomGift\>, 
[IEquatable<CMsgClientToGCNewBloomGift\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCNewBloomGift\>, 
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
[EnumerableExtensions.In<CMsgClientToGCNewBloomGift\>\(CMsgClientToGCNewBloomGift, params CMsgClientToGCNewBloomGift\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift__ctor"></a> CMsgClientToGCNewBloomGift\(\)

```csharp
public CMsgClientToGCNewBloomGift()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift__ctor_Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_"></a> CMsgClientToGCNewBloomGift\(CMsgClientToGCNewBloomGift\)

```csharp
public CMsgClientToGCNewBloomGift(CMsgClientToGCNewBloomGift other)
```

#### Parameters

`other` [CMsgClientToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgClientToGCNewBloomGift.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_DefindexFieldNumber"></a> DefindexFieldNumber

```csharp
public const int DefindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_TargetAccountIdsFieldNumber"></a> TargetAccountIdsFieldNumber

```csharp
public const int TargetAccountIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_Defindex"></a> Defindex

```csharp
public uint Defindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_HasDefindex"></a> HasDefindex

```csharp
public bool HasDefindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCNewBloomGift> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgClientToGCNewBloomGift.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_TargetAccountIds"></a> TargetAccountIds

```csharp
public RepeatedField<uint> TargetAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_ClearDefindex"></a> ClearDefindex\(\)

```csharp
public void ClearDefindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCNewBloomGift Clone()
```

#### Returns

 [CMsgClientToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgClientToGCNewBloomGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_Equals_Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_"></a> Equals\(CMsgClientToGCNewBloomGift\)

```csharp
public bool Equals(CMsgClientToGCNewBloomGift other)
```

#### Parameters

`other` [CMsgClientToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgClientToGCNewBloomGift.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_"></a> MergeFrom\(CMsgClientToGCNewBloomGift\)

```csharp
public void MergeFrom(CMsgClientToGCNewBloomGift other)
```

#### Parameters

`other` [CMsgClientToGCNewBloomGift](Divine.Protobufs.Dota2.CMsgClientToGCNewBloomGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNewBloomGift_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

