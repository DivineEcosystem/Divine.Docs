# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech"></a> Class CDOTAUserMsg\_UnitEvent.Types.Speech

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UnitEvent.Types.Speech : IMessage<CDOTAUserMsg_UnitEvent.Types.Speech>, IEquatable<CDOTAUserMsg_UnitEvent.Types.Speech>, IDeepCloneable<CDOTAUserMsg_UnitEvent.Types.Speech>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UnitEvent.Types.Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)

#### Implements

IMessage<CDOTAUserMsg\_UnitEvent.Types.Speech\>, 
[IEquatable<CDOTAUserMsg\_UnitEvent.Types.Speech\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UnitEvent.Types.Speech\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UnitEvent.Types.Speech\>\(CDOTAUserMsg\_UnitEvent.Types.Speech, params CDOTAUserMsg\_UnitEvent.Types.Speech\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech__ctor"></a> Speech\(\)

```csharp
public Speech()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_"></a> Speech\(Speech\)

```csharp
public Speech(CDOTAUserMsg_UnitEvent.Types.Speech other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_MuteableFieldNumber"></a> MuteableFieldNumber

```csharp
public const int MuteableFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_PredelayFieldNumber"></a> PredelayFieldNumber

```csharp
public const int PredelayFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_RecipientTypeFieldNumber"></a> RecipientTypeFieldNumber

```csharp
public const int RecipientTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ResponseTypeFieldNumber"></a> ResponseTypeFieldNumber

```csharp
public const int ResponseTypeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_SpeechConceptFieldNumber"></a> SpeechConceptFieldNumber

```csharp
public const int SpeechConceptFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_SpeechTargetEntityIndexFieldNumber"></a> SpeechTargetEntityIndexFieldNumber

```csharp
public const int SpeechTargetEntityIndexFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasMuteable"></a> HasMuteable

```csharp
public bool HasMuteable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasRecipientType"></a> HasRecipientType

```csharp
public bool HasRecipientType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasResponseType"></a> HasResponseType

```csharp
public bool HasResponseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasSpeechConcept"></a> HasSpeechConcept

```csharp
public bool HasSpeechConcept { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_HasSpeechTargetEntityIndex"></a> HasSpeechTargetEntityIndex

```csharp
public bool HasSpeechTargetEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Muteable"></a> Muteable

```csharp
public bool Muteable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UnitEvent.Types.Speech> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Predelay"></a> Predelay

```csharp
public CDOTAUserMsg_UnitEvent.Types.Interval Predelay { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_RecipientType"></a> RecipientType

```csharp
public int RecipientType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Response"></a> Response

```csharp
public string Response { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ResponseType"></a> ResponseType

```csharp
public int ResponseType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_SpeechConcept"></a> SpeechConcept

```csharp
public int SpeechConcept { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_SpeechTargetEntityIndex"></a> SpeechTargetEntityIndex

```csharp
public int SpeechTargetEntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearMuteable"></a> ClearMuteable\(\)

```csharp
public void ClearMuteable()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearRecipientType"></a> ClearRecipientType\(\)

```csharp
public void ClearRecipientType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearResponseType"></a> ClearResponseType\(\)

```csharp
public void ClearResponseType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearSpeechConcept"></a> ClearSpeechConcept\(\)

```csharp
public void ClearSpeechConcept()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ClearSpeechTargetEntityIndex"></a> ClearSpeechTargetEntityIndex\(\)

```csharp
public void ClearSpeechTargetEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UnitEvent.Types.Speech Clone()
```

#### Returns

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_"></a> Equals\(Speech\)

```csharp
public bool Equals(CDOTAUserMsg_UnitEvent.Types.Speech other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_"></a> MergeFrom\(Speech\)

```csharp
public void MergeFrom(CDOTAUserMsg_UnitEvent.Types.Speech other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Speech_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

