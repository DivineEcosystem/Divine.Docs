# <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData"></a> Class CCLCMsg\_VoiceData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_VoiceData : IMessage<CCLCMsg_VoiceData>, IEquatable<CCLCMsg_VoiceData>, IDeepCloneable<CCLCMsg_VoiceData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_VoiceData](Divine.Protobufs.Dota2.CCLCMsg\_VoiceData.md)

#### Implements

IMessage<CCLCMsg\_VoiceData\>, 
[IEquatable<CCLCMsg\_VoiceData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_VoiceData\>, 
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
[EnumerableExtensions.In<CCLCMsg\_VoiceData\>\(CCLCMsg\_VoiceData, params CCLCMsg\_VoiceData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData__ctor"></a> CCLCMsg\_VoiceData\(\)

```csharp
public CCLCMsg_VoiceData()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData__ctor_Divine_Protobufs_Dota2_CCLCMsg_VoiceData_"></a> CCLCMsg\_VoiceData\(CCLCMsg\_VoiceData\)

```csharp
public CCLCMsg_VoiceData(CCLCMsg_VoiceData other)
```

#### Parameters

`other` [CCLCMsg\_VoiceData](Divine.Protobufs.Dota2.CCLCMsg\_VoiceData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_AudioFieldNumber"></a> AudioFieldNumber

```csharp
public const int AudioFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_XuidFieldNumber"></a> XuidFieldNumber

```csharp
public const int XuidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Audio"></a> Audio

```csharp
public CMsgVoiceAudio Audio { get; set; }
```

#### Property Value

 [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_HasXuid"></a> HasXuid

```csharp
public bool HasXuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_VoiceData> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_VoiceData](Divine.Protobufs.Dota2.CCLCMsg\_VoiceData.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Xuid"></a> Xuid

```csharp
public ulong Xuid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_ClearXuid"></a> ClearXuid\(\)

```csharp
public void ClearXuid()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_VoiceData Clone()
```

#### Returns

 [CCLCMsg\_VoiceData](Divine.Protobufs.Dota2.CCLCMsg\_VoiceData.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_Equals_Divine_Protobufs_Dota2_CCLCMsg_VoiceData_"></a> Equals\(CCLCMsg\_VoiceData\)

```csharp
public bool Equals(CCLCMsg_VoiceData other)
```

#### Parameters

`other` [CCLCMsg\_VoiceData](Divine.Protobufs.Dota2.CCLCMsg\_VoiceData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_VoiceData_"></a> MergeFrom\(CCLCMsg\_VoiceData\)

```csharp
public void MergeFrom(CCLCMsg_VoiceData other)
```

#### Parameters

`other` [CCLCMsg\_VoiceData](Divine.Protobufs.Dota2.CCLCMsg\_VoiceData.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_VoiceData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

