# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute"></a> Class CDOTAUserMsg\_UnitEvent.Types.SpeechMute

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UnitEvent.Types.SpeechMute : IMessage<CDOTAUserMsg_UnitEvent.Types.SpeechMute>, IEquatable<CDOTAUserMsg_UnitEvent.Types.SpeechMute>, IDeepCloneable<CDOTAUserMsg_UnitEvent.Types.SpeechMute>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UnitEvent.Types.SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)

#### Implements

IMessage<CDOTAUserMsg\_UnitEvent.Types.SpeechMute\>, 
[IEquatable<CDOTAUserMsg\_UnitEvent.Types.SpeechMute\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UnitEvent.Types.SpeechMute\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UnitEvent.Types.SpeechMute\>\(CDOTAUserMsg\_UnitEvent.Types.SpeechMute, params CDOTAUserMsg\_UnitEvent.Types.SpeechMute\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute__ctor"></a> SpeechMute\(\)

```csharp
public SpeechMute()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_"></a> SpeechMute\(SpeechMute\)

```csharp
public SpeechMute(CDOTAUserMsg_UnitEvent.Types.SpeechMute other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_DelayFieldNumber"></a> DelayFieldNumber

```csharp
public const int DelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_Delay"></a> Delay

```csharp
public float Delay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_HasDelay"></a> HasDelay

```csharp
public bool HasDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UnitEvent.Types.SpeechMute> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_ClearDelay"></a> ClearDelay\(\)

```csharp
public void ClearDelay()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UnitEvent.Types.SpeechMute Clone()
```

#### Returns

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_"></a> Equals\(SpeechMute\)

```csharp
public bool Equals(CDOTAUserMsg_UnitEvent.Types.SpeechMute other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_"></a> MergeFrom\(SpeechMute\)

```csharp
public void MergeFrom(CDOTAUserMsg_UnitEvent.Types.SpeechMute other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_SpeechMute_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

