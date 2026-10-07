# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert"></a> Class CDOTAUserMsg\_CourierKilledAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CourierKilledAlert : IMessage<CDOTAUserMsg_CourierKilledAlert>, IEquatable<CDOTAUserMsg_CourierKilledAlert>, IDeepCloneable<CDOTAUserMsg_CourierKilledAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_CourierKilledAlert\>, 
[IEquatable<CDOTAUserMsg\_CourierKilledAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CourierKilledAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CourierKilledAlert\>\(CDOTAUserMsg\_CourierKilledAlert, params CDOTAUserMsg\_CourierKilledAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert__ctor"></a> CDOTAUserMsg\_CourierKilledAlert\(\)

```csharp
public CDOTAUserMsg_CourierKilledAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_"></a> CDOTAUserMsg\_CourierKilledAlert\(CDOTAUserMsg\_CourierKilledAlert\)

```csharp
public CDOTAUserMsg_CourierKilledAlert(CDOTAUserMsg_CourierKilledAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_EntityHandleFieldNumber"></a> EntityHandleFieldNumber

```csharp
public const int EntityHandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_GoldValueFieldNumber"></a> GoldValueFieldNumber

```csharp
public const int GoldValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_KillerPlayerIdFieldNumber"></a> KillerPlayerIdFieldNumber

```csharp
public const int KillerPlayerIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_LostItemsFieldNumber"></a> LostItemsFieldNumber

```csharp
public const int LostItemsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_OwningPlayerIdFieldNumber"></a> OwningPlayerIdFieldNumber

```csharp
public const int OwningPlayerIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_EntityHandle"></a> EntityHandle

```csharp
public uint EntityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_GoldValue"></a> GoldValue

```csharp
public uint GoldValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_HasEntityHandle"></a> HasEntityHandle

```csharp
public bool HasEntityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_HasGoldValue"></a> HasGoldValue

```csharp
public bool HasGoldValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_HasKillerPlayerId"></a> HasKillerPlayerId

```csharp
public bool HasKillerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_HasOwningPlayerId"></a> HasOwningPlayerId

```csharp
public bool HasOwningPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_KillerPlayerId"></a> KillerPlayerId

```csharp
public int KillerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_LostItems"></a> LostItems

```csharp
public RepeatedField<CDOTAUserMsg_CourierKilledAlert.Types.LostItem> LostItems { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.md).[LostItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.Types.LostItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_OwningPlayerId"></a> OwningPlayerId

```csharp
public int OwningPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CourierKilledAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Timestamp"></a> Timestamp

```csharp
public int Timestamp { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ClearEntityHandle"></a> ClearEntityHandle\(\)

```csharp
public void ClearEntityHandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ClearGoldValue"></a> ClearGoldValue\(\)

```csharp
public void ClearGoldValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ClearKillerPlayerId"></a> ClearKillerPlayerId\(\)

```csharp
public void ClearKillerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ClearOwningPlayerId"></a> ClearOwningPlayerId\(\)

```csharp
public void ClearOwningPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CourierKilledAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_"></a> Equals\(CDOTAUserMsg\_CourierKilledAlert\)

```csharp
public bool Equals(CDOTAUserMsg_CourierKilledAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_"></a> MergeFrom\(CDOTAUserMsg\_CourierKilledAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_CourierKilledAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_CourierKilledAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_CourierKilledAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CourierKilledAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

