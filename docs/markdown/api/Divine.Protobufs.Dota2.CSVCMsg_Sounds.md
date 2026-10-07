# <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds"></a> Class CSVCMsg\_Sounds

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_Sounds : IMessage<CSVCMsg_Sounds>, IEquatable<CSVCMsg_Sounds>, IDeepCloneable<CSVCMsg_Sounds>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md)

#### Implements

IMessage<CSVCMsg\_Sounds\>, 
[IEquatable<CSVCMsg\_Sounds\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_Sounds\>, 
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
[EnumerableExtensions.In<CSVCMsg\_Sounds\>\(CSVCMsg\_Sounds, params CSVCMsg\_Sounds\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds__ctor"></a> CSVCMsg\_Sounds\(\)

```csharp
public CSVCMsg_Sounds()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds__ctor_Divine_Protobufs_Dota2_CSVCMsg_Sounds_"></a> CSVCMsg\_Sounds\(CSVCMsg\_Sounds\)

```csharp
public CSVCMsg_Sounds(CSVCMsg_Sounds other)
```

#### Parameters

`other` [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_ReliableSoundFieldNumber"></a> ReliableSoundFieldNumber

```csharp
public const int ReliableSoundFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_SoundsFieldNumber"></a> SoundsFieldNumber

```csharp
public const int SoundsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_HasReliableSound"></a> HasReliableSound

```csharp
public bool HasReliableSound { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_Sounds> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_ReliableSound"></a> ReliableSound

```csharp
public bool ReliableSound { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Sounds"></a> Sounds

```csharp
public RepeatedField<CSVCMsg_Sounds.Types.sounddata_t> Sounds { get; }
```

#### Property Value

 RepeatedField<[CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.md).[sounddata\_t](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.Types.sounddata\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_ClearReliableSound"></a> ClearReliableSound\(\)

```csharp
public void ClearReliableSound()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_Sounds Clone()
```

#### Returns

 [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_Equals_Divine_Protobufs_Dota2_CSVCMsg_Sounds_"></a> Equals\(CSVCMsg\_Sounds\)

```csharp
public bool Equals(CSVCMsg_Sounds other)
```

#### Parameters

`other` [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_Sounds_"></a> MergeFrom\(CSVCMsg\_Sounds\)

```csharp
public void MergeFrom(CSVCMsg_Sounds other)
```

#### Parameters

`other` [CSVCMsg\_Sounds](Divine.Protobufs.Dota2.CSVCMsg\_Sounds.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Sounds_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

