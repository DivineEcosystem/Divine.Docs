# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble"></a> Class CDOTAUserMsg\_SpeechBubble

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SpeechBubble : IMessage<CDOTAUserMsg_SpeechBubble>, IEquatable<CDOTAUserMsg_SpeechBubble>, IDeepCloneable<CDOTAUserMsg_SpeechBubble>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SpeechBubble](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpeechBubble.md)

#### Implements

IMessage<CDOTAUserMsg\_SpeechBubble\>, 
[IEquatable<CDOTAUserMsg\_SpeechBubble\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SpeechBubble\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SpeechBubble\>\(CDOTAUserMsg\_SpeechBubble, params CDOTAUserMsg\_SpeechBubble\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble__ctor"></a> CDOTAUserMsg\_SpeechBubble\(\)

```csharp
public CDOTAUserMsg_SpeechBubble()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_"></a> CDOTAUserMsg\_SpeechBubble\(CDOTAUserMsg\_SpeechBubble\)

```csharp
public CDOTAUserMsg_SpeechBubble(CDOTAUserMsg_SpeechBubble other)
```

#### Parameters

`other` [CDOTAUserMsg\_SpeechBubble](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpeechBubble.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_DestroyAllFieldNumber"></a> DestroyAllFieldNumber

```csharp
public const int DestroyAllFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_DestroyAll"></a> DestroyAll

```csharp
public bool DestroyAll { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_HasDestroyAll"></a> HasDestroyAll

```csharp
public bool HasDestroyAll { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SpeechBubble> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SpeechBubble](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpeechBubble.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_ClearDestroyAll"></a> ClearDestroyAll\(\)

```csharp
public void ClearDestroyAll()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SpeechBubble Clone()
```

#### Returns

 [CDOTAUserMsg\_SpeechBubble](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpeechBubble.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_"></a> Equals\(CDOTAUserMsg\_SpeechBubble\)

```csharp
public bool Equals(CDOTAUserMsg_SpeechBubble other)
```

#### Parameters

`other` [CDOTAUserMsg\_SpeechBubble](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpeechBubble.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_"></a> MergeFrom\(CDOTAUserMsg\_SpeechBubble\)

```csharp
public void MergeFrom(CDOTAUserMsg_SpeechBubble other)
```

#### Parameters

`other` [CDOTAUserMsg\_SpeechBubble](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpeechBubble.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpeechBubble_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

