# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens"></a> Class CMsgClientToGCOverworldGiftTokens

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldGiftTokens : IMessage<CMsgClientToGCOverworldGiftTokens>, IEquatable<CMsgClientToGCOverworldGiftTokens>, IDeepCloneable<CMsgClientToGCOverworldGiftTokens>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldGiftTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokens.md)

#### Implements

IMessage<CMsgClientToGCOverworldGiftTokens\>, 
[IEquatable<CMsgClientToGCOverworldGiftTokens\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldGiftTokens\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldGiftTokens\>\(CMsgClientToGCOverworldGiftTokens, params CMsgClientToGCOverworldGiftTokens\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens__ctor"></a> CMsgClientToGCOverworldGiftTokens\(\)

```csharp
public CMsgClientToGCOverworldGiftTokens()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_"></a> CMsgClientToGCOverworldGiftTokens\(CMsgClientToGCOverworldGiftTokens\)

```csharp
public CMsgClientToGCOverworldGiftTokens(CMsgClientToGCOverworldGiftTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGiftTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokens.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_PeriodicResourceIdFieldNumber"></a> PeriodicResourceIdFieldNumber

```csharp
public const int PeriodicResourceIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_RecipientAccountIdFieldNumber"></a> RecipientAccountIdFieldNumber

```csharp
public const int RecipientAccountIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_TokenGiftFieldNumber"></a> TokenGiftFieldNumber

```csharp
public const int TokenGiftFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_HasPeriodicResourceId"></a> HasPeriodicResourceId

```csharp
public bool HasPeriodicResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_HasRecipientAccountId"></a> HasRecipientAccountId

```csharp
public bool HasRecipientAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldGiftTokens> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldGiftTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokens.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_PeriodicResourceId"></a> PeriodicResourceId

```csharp
public uint PeriodicResourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_RecipientAccountId"></a> RecipientAccountId

```csharp
public uint RecipientAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_TokenGift"></a> TokenGift

```csharp
public CMsgOverworldTokenCount TokenGift { get; set; }
```

#### Property Value

 [CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_ClearPeriodicResourceId"></a> ClearPeriodicResourceId\(\)

```csharp
public void ClearPeriodicResourceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_ClearRecipientAccountId"></a> ClearRecipientAccountId\(\)

```csharp
public void ClearRecipientAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldGiftTokens Clone()
```

#### Returns

 [CMsgClientToGCOverworldGiftTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_"></a> Equals\(CMsgClientToGCOverworldGiftTokens\)

```csharp
public bool Equals(CMsgClientToGCOverworldGiftTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGiftTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokens.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_"></a> MergeFrom\(CMsgClientToGCOverworldGiftTokens\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldGiftTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGiftTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokens_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

