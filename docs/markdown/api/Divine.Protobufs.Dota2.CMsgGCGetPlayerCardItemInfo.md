# <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo"></a> Class CMsgGCGetPlayerCardItemInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetPlayerCardItemInfo : IMessage<CMsgGCGetPlayerCardItemInfo>, IEquatable<CMsgGCGetPlayerCardItemInfo>, IDeepCloneable<CMsgGCGetPlayerCardItemInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetPlayerCardItemInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfo.md)

#### Implements

IMessage<CMsgGCGetPlayerCardItemInfo\>, 
[IEquatable<CMsgGCGetPlayerCardItemInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetPlayerCardItemInfo\>, 
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
[EnumerableExtensions.In<CMsgGCGetPlayerCardItemInfo\>\(CMsgGCGetPlayerCardItemInfo, params CMsgGCGetPlayerCardItemInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo__ctor"></a> CMsgGCGetPlayerCardItemInfo\(\)

```csharp
public CMsgGCGetPlayerCardItemInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo__ctor_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_"></a> CMsgGCGetPlayerCardItemInfo\(CMsgGCGetPlayerCardItemInfo\)

```csharp
public CMsgGCGetPlayerCardItemInfo(CMsgGCGetPlayerCardItemInfo other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_AllForEventFieldNumber"></a> AllForEventFieldNumber

```csharp
public const int AllForEventFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_PlayerCardItemIdsFieldNumber"></a> PlayerCardItemIdsFieldNumber

```csharp
public const int PlayerCardItemIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_AllForEvent"></a> AllForEvent

```csharp
public uint AllForEvent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_HasAllForEvent"></a> HasAllForEvent

```csharp
public bool HasAllForEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetPlayerCardItemInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetPlayerCardItemInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_PlayerCardItemIds"></a> PlayerCardItemIds

```csharp
public RepeatedField<ulong> PlayerCardItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_ClearAllForEvent"></a> ClearAllForEvent\(\)

```csharp
public void ClearAllForEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetPlayerCardItemInfo Clone()
```

#### Returns

 [CMsgGCGetPlayerCardItemInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_Equals_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_"></a> Equals\(CMsgGCGetPlayerCardItemInfo\)

```csharp
public bool Equals(CMsgGCGetPlayerCardItemInfo other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_"></a> MergeFrom\(CMsgGCGetPlayerCardItemInfo\)

```csharp
public void MergeFrom(CMsgGCGetPlayerCardItemInfo other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

