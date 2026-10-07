# <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift"></a> Class CMsgSQLGCToGCRevokeUntrustedGift

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSQLGCToGCRevokeUntrustedGift : IMessage<CMsgSQLGCToGCRevokeUntrustedGift>, IEquatable<CMsgSQLGCToGCRevokeUntrustedGift>, IDeepCloneable<CMsgSQLGCToGCRevokeUntrustedGift>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSQLGCToGCRevokeUntrustedGift](Divine.Protobufs.Dota2.CMsgSQLGCToGCRevokeUntrustedGift.md)

#### Implements

IMessage<CMsgSQLGCToGCRevokeUntrustedGift\>, 
[IEquatable<CMsgSQLGCToGCRevokeUntrustedGift\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSQLGCToGCRevokeUntrustedGift\>, 
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
[EnumerableExtensions.In<CMsgSQLGCToGCRevokeUntrustedGift\>\(CMsgSQLGCToGCRevokeUntrustedGift, params CMsgSQLGCToGCRevokeUntrustedGift\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift__ctor"></a> CMsgSQLGCToGCRevokeUntrustedGift\(\)

```csharp
public CMsgSQLGCToGCRevokeUntrustedGift()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift__ctor_Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_"></a> CMsgSQLGCToGCRevokeUntrustedGift\(CMsgSQLGCToGCRevokeUntrustedGift\)

```csharp
public CMsgSQLGCToGCRevokeUntrustedGift(CMsgSQLGCToGCRevokeUntrustedGift other)
```

#### Parameters

`other` [CMsgSQLGCToGCRevokeUntrustedGift](Divine.Protobufs.Dota2.CMsgSQLGCToGCRevokeUntrustedGift.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_SentItemIdFieldNumber"></a> SentItemIdFieldNumber

```csharp
public const int SentItemIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_HasSentItemId"></a> HasSentItemId

```csharp
public bool HasSentItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSQLGCToGCRevokeUntrustedGift> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSQLGCToGCRevokeUntrustedGift](Divine.Protobufs.Dota2.CMsgSQLGCToGCRevokeUntrustedGift.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_SentItemId"></a> SentItemId

```csharp
public ulong SentItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_ClearSentItemId"></a> ClearSentItemId\(\)

```csharp
public void ClearSentItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_Clone"></a> Clone\(\)

```csharp
public CMsgSQLGCToGCRevokeUntrustedGift Clone()
```

#### Returns

 [CMsgSQLGCToGCRevokeUntrustedGift](Divine.Protobufs.Dota2.CMsgSQLGCToGCRevokeUntrustedGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_Equals_Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_"></a> Equals\(CMsgSQLGCToGCRevokeUntrustedGift\)

```csharp
public bool Equals(CMsgSQLGCToGCRevokeUntrustedGift other)
```

#### Parameters

`other` [CMsgSQLGCToGCRevokeUntrustedGift](Divine.Protobufs.Dota2.CMsgSQLGCToGCRevokeUntrustedGift.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_MergeFrom_Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_"></a> MergeFrom\(CMsgSQLGCToGCRevokeUntrustedGift\)

```csharp
public void MergeFrom(CMsgSQLGCToGCRevokeUntrustedGift other)
```

#### Parameters

`other` [CMsgSQLGCToGCRevokeUntrustedGift](Divine.Protobufs.Dota2.CMsgSQLGCToGCRevokeUntrustedGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCRevokeUntrustedGift_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

