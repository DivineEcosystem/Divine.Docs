# <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo"></a> Class CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo : IMessage<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo>, IEquatable<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo>, IDeepCloneable<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)

#### Implements

IMessage<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo\>, 
[IEquatable<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo\>, 
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
[EnumerableExtensions.In<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo\>\(CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo, params CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo__ctor"></a> PlayerCardInfo\(\)

```csharp
public PlayerCardInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo__ctor_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_"></a> PlayerCardInfo\(PlayerCardInfo\)

```csharp
public PlayerCardInfo(CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.md).[PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_PackedBonusesFieldNumber"></a> PackedBonusesFieldNumber

```csharp
public const int PackedBonusesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_PlayerCardItemIdFieldNumber"></a> PlayerCardItemIdFieldNumber

```csharp
public const int PlayerCardItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_HasPackedBonuses"></a> HasPackedBonuses

```csharp
public bool HasPackedBonuses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_HasPlayerCardItemId"></a> HasPlayerCardItemId

```csharp
public bool HasPlayerCardItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_PackedBonuses"></a> PackedBonuses

```csharp
public ulong PackedBonuses { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.md).[PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_PlayerCardItemId"></a> PlayerCardItemId

```csharp
public ulong PlayerCardItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_ClearPackedBonuses"></a> ClearPackedBonuses\(\)

```csharp
public void ClearPackedBonuses()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_ClearPlayerCardItemId"></a> ClearPlayerCardItemId\(\)

```csharp
public void ClearPlayerCardItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo Clone()
```

#### Returns

 [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.md).[PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_Equals_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_"></a> Equals\(PlayerCardInfo\)

```csharp
public bool Equals(CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.md).[PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_"></a> MergeFrom\(PlayerCardInfo\)

```csharp
public void MergeFrom(CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.md).[PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Types_PlayerCardInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

