# <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio"></a> Class CUserMessageSendAudio

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageSendAudio : IMessage<CUserMessageSendAudio>, IEquatable<CUserMessageSendAudio>, IDeepCloneable<CUserMessageSendAudio>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageSendAudio](Divine.Protobufs.Dota2.CUserMessageSendAudio.md)

#### Implements

IMessage<CUserMessageSendAudio\>, 
[IEquatable<CUserMessageSendAudio\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageSendAudio\>, 
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
[EnumerableExtensions.In<CUserMessageSendAudio\>\(CUserMessageSendAudio, params CUserMessageSendAudio\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio__ctor"></a> CUserMessageSendAudio\(\)

```csharp
public CUserMessageSendAudio()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio__ctor_Divine_Protobufs_Dota2_CUserMessageSendAudio_"></a> CUserMessageSendAudio\(CUserMessageSendAudio\)

```csharp
public CUserMessageSendAudio(CUserMessageSendAudio other)
```

#### Parameters

`other` [CUserMessageSendAudio](Divine.Protobufs.Dota2.CUserMessageSendAudio.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_SoundnameFieldNumber"></a> SoundnameFieldNumber

```csharp
public const int SoundnameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_StopFieldNumber"></a> StopFieldNumber

```csharp
public const int StopFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_HasSoundname"></a> HasSoundname

```csharp
public bool HasSoundname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_HasStop"></a> HasStop

```csharp
public bool HasStop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageSendAudio> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageSendAudio](Divine.Protobufs.Dota2.CUserMessageSendAudio.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Soundname"></a> Soundname

```csharp
public string Soundname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Stop"></a> Stop

```csharp
public bool Stop { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_ClearSoundname"></a> ClearSoundname\(\)

```csharp
public void ClearSoundname()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_ClearStop"></a> ClearStop\(\)

```csharp
public void ClearStop()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Clone"></a> Clone\(\)

```csharp
public CUserMessageSendAudio Clone()
```

#### Returns

 [CUserMessageSendAudio](Divine.Protobufs.Dota2.CUserMessageSendAudio.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_Equals_Divine_Protobufs_Dota2_CUserMessageSendAudio_"></a> Equals\(CUserMessageSendAudio\)

```csharp
public bool Equals(CUserMessageSendAudio other)
```

#### Parameters

`other` [CUserMessageSendAudio](Divine.Protobufs.Dota2.CUserMessageSendAudio.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_MergeFrom_Divine_Protobufs_Dota2_CUserMessageSendAudio_"></a> MergeFrom\(CUserMessageSendAudio\)

```csharp
public void MergeFrom(CUserMessageSendAudio other)
```

#### Parameters

`other` [CUserMessageSendAudio](Divine.Protobufs.Dota2.CUserMessageSendAudio.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageSendAudio_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

