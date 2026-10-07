# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots"></a> Class CMsgClientToGCSetProfileCardSlots

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetProfileCardSlots : IMessage<CMsgClientToGCSetProfileCardSlots>, IEquatable<CMsgClientToGCSetProfileCardSlots>, IDeepCloneable<CMsgClientToGCSetProfileCardSlots>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md)

#### Implements

IMessage<CMsgClientToGCSetProfileCardSlots\>, 
[IEquatable<CMsgClientToGCSetProfileCardSlots\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetProfileCardSlots\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetProfileCardSlots\>\(CMsgClientToGCSetProfileCardSlots, params CMsgClientToGCSetProfileCardSlots\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots__ctor"></a> CMsgClientToGCSetProfileCardSlots\(\)

```csharp
public CMsgClientToGCSetProfileCardSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_"></a> CMsgClientToGCSetProfileCardSlots\(CMsgClientToGCSetProfileCardSlots\)

```csharp
public CMsgClientToGCSetProfileCardSlots(CMsgClientToGCSetProfileCardSlots other)
```

#### Parameters

`other` [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_SlotsFieldNumber"></a> SlotsFieldNumber

```csharp
public const int SlotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetProfileCardSlots> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Slots"></a> Slots

```csharp
public RepeatedField<CMsgClientToGCSetProfileCardSlots.Types.CardSlot> Slots { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.md).[CardSlot](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.Types.CardSlot.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetProfileCardSlots Clone()
```

#### Returns

 [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_"></a> Equals\(CMsgClientToGCSetProfileCardSlots\)

```csharp
public bool Equals(CMsgClientToGCSetProfileCardSlots other)
```

#### Parameters

`other` [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_"></a> MergeFrom\(CMsgClientToGCSetProfileCardSlots\)

```csharp
public void MergeFrom(CMsgClientToGCSetProfileCardSlots other)
```

#### Parameters

`other` [CMsgClientToGCSetProfileCardSlots](Divine.Protobufs.Dota2.CMsgClientToGCSetProfileCardSlots.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetProfileCardSlots_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

