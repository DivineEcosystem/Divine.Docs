# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer"></a> Class CMsgClientToGCRemoveFilteredPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRemoveFilteredPlayer : IMessage<CMsgClientToGCRemoveFilteredPlayer>, IEquatable<CMsgClientToGCRemoveFilteredPlayer>, IDeepCloneable<CMsgClientToGCRemoveFilteredPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRemoveFilteredPlayer](Divine.Protobufs.Dota2.CMsgClientToGCRemoveFilteredPlayer.md)

#### Implements

IMessage<CMsgClientToGCRemoveFilteredPlayer\>, 
[IEquatable<CMsgClientToGCRemoveFilteredPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRemoveFilteredPlayer\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRemoveFilteredPlayer\>\(CMsgClientToGCRemoveFilteredPlayer, params CMsgClientToGCRemoveFilteredPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer__ctor"></a> CMsgClientToGCRemoveFilteredPlayer\(\)

```csharp
public CMsgClientToGCRemoveFilteredPlayer()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_"></a> CMsgClientToGCRemoveFilteredPlayer\(CMsgClientToGCRemoveFilteredPlayer\)

```csharp
public CMsgClientToGCRemoveFilteredPlayer(CMsgClientToGCRemoveFilteredPlayer other)
```

#### Parameters

`other` [CMsgClientToGCRemoveFilteredPlayer](Divine.Protobufs.Dota2.CMsgClientToGCRemoveFilteredPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_AccountIdToRemoveFieldNumber"></a> AccountIdToRemoveFieldNumber

```csharp
public const int AccountIdToRemoveFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_AccountIdToRemove"></a> AccountIdToRemove

```csharp
public uint AccountIdToRemove { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_HasAccountIdToRemove"></a> HasAccountIdToRemove

```csharp
public bool HasAccountIdToRemove { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRemoveFilteredPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRemoveFilteredPlayer](Divine.Protobufs.Dota2.CMsgClientToGCRemoveFilteredPlayer.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_ClearAccountIdToRemove"></a> ClearAccountIdToRemove\(\)

```csharp
public void ClearAccountIdToRemove()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRemoveFilteredPlayer Clone()
```

#### Returns

 [CMsgClientToGCRemoveFilteredPlayer](Divine.Protobufs.Dota2.CMsgClientToGCRemoveFilteredPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_"></a> Equals\(CMsgClientToGCRemoveFilteredPlayer\)

```csharp
public bool Equals(CMsgClientToGCRemoveFilteredPlayer other)
```

#### Parameters

`other` [CMsgClientToGCRemoveFilteredPlayer](Divine.Protobufs.Dota2.CMsgClientToGCRemoveFilteredPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_"></a> MergeFrom\(CMsgClientToGCRemoveFilteredPlayer\)

```csharp
public void MergeFrom(CMsgClientToGCRemoveFilteredPlayer other)
```

#### Parameters

`other` [CMsgClientToGCRemoveFilteredPlayer](Divine.Protobufs.Dota2.CMsgClientToGCRemoveFilteredPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveFilteredPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

