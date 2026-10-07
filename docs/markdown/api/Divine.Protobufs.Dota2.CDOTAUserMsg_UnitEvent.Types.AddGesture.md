# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture"></a> Class CDOTAUserMsg\_UnitEvent.Types.AddGesture

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UnitEvent.Types.AddGesture : IMessage<CDOTAUserMsg_UnitEvent.Types.AddGesture>, IEquatable<CDOTAUserMsg_UnitEvent.Types.AddGesture>, IDeepCloneable<CDOTAUserMsg_UnitEvent.Types.AddGesture>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UnitEvent.Types.AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)

#### Implements

IMessage<CDOTAUserMsg\_UnitEvent.Types.AddGesture\>, 
[IEquatable<CDOTAUserMsg\_UnitEvent.Types.AddGesture\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UnitEvent.Types.AddGesture\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UnitEvent.Types.AddGesture\>\(CDOTAUserMsg\_UnitEvent.Types.AddGesture, params CDOTAUserMsg\_UnitEvent.Types.AddGesture\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture__ctor"></a> AddGesture\(\)

```csharp
public AddGesture()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_"></a> AddGesture\(AddGesture\)

```csharp
public AddGesture(CDOTAUserMsg_UnitEvent.Types.AddGesture other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ActivityFieldNumber"></a> ActivityFieldNumber

```csharp
public const int ActivityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_FadeInFieldNumber"></a> FadeInFieldNumber

```csharp
public const int FadeInFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_FadeOutFieldNumber"></a> FadeOutFieldNumber

```csharp
public const int FadeOutFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_PlaybackRateFieldNumber"></a> PlaybackRateFieldNumber

```csharp
public const int PlaybackRateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_SequenceVariantFieldNumber"></a> SequenceVariantFieldNumber

```csharp
public const int SequenceVariantFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Activity"></a> Activity

```csharp
public int Activity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_FadeIn"></a> FadeIn

```csharp
public float FadeIn { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_FadeOut"></a> FadeOut

```csharp
public float FadeOut { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_HasActivity"></a> HasActivity

```csharp
public bool HasActivity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_HasFadeIn"></a> HasFadeIn

```csharp
public bool HasFadeIn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_HasFadeOut"></a> HasFadeOut

```csharp
public bool HasFadeOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_HasPlaybackRate"></a> HasPlaybackRate

```csharp
public bool HasPlaybackRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_HasSequenceVariant"></a> HasSequenceVariant

```csharp
public bool HasSequenceVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UnitEvent.Types.AddGesture> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_PlaybackRate"></a> PlaybackRate

```csharp
public float PlaybackRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_SequenceVariant"></a> SequenceVariant

```csharp
public int SequenceVariant { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Slot"></a> Slot

```csharp
public int Slot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ClearActivity"></a> ClearActivity\(\)

```csharp
public void ClearActivity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ClearFadeIn"></a> ClearFadeIn\(\)

```csharp
public void ClearFadeIn()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ClearFadeOut"></a> ClearFadeOut\(\)

```csharp
public void ClearFadeOut()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ClearPlaybackRate"></a> ClearPlaybackRate\(\)

```csharp
public void ClearPlaybackRate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ClearSequenceVariant"></a> ClearSequenceVariant\(\)

```csharp
public void ClearSequenceVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UnitEvent.Types.AddGesture Clone()
```

#### Returns

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_"></a> Equals\(AddGesture\)

```csharp
public bool Equals(CDOTAUserMsg_UnitEvent.Types.AddGesture other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_"></a> MergeFrom\(AddGesture\)

```csharp
public void MergeFrom(CDOTAUserMsg_UnitEvent.Types.AddGesture other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_AddGesture_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

