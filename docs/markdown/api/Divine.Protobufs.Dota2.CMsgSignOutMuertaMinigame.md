# <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame"></a> Class CMsgSignOutMuertaMinigame

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutMuertaMinigame : IMessage<CMsgSignOutMuertaMinigame>, IEquatable<CMsgSignOutMuertaMinigame>, IDeepCloneable<CMsgSignOutMuertaMinigame>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutMuertaMinigame](Divine.Protobufs.Dota2.CMsgSignOutMuertaMinigame.md)

#### Implements

IMessage<CMsgSignOutMuertaMinigame\>, 
[IEquatable<CMsgSignOutMuertaMinigame\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutMuertaMinigame\>, 
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
[EnumerableExtensions.In<CMsgSignOutMuertaMinigame\>\(CMsgSignOutMuertaMinigame, params CMsgSignOutMuertaMinigame\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame__ctor"></a> CMsgSignOutMuertaMinigame\(\)

```csharp
public CMsgSignOutMuertaMinigame()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame__ctor_Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_"></a> CMsgSignOutMuertaMinigame\(CMsgSignOutMuertaMinigame\)

```csharp
public CMsgSignOutMuertaMinigame(CMsgSignOutMuertaMinigame other)
```

#### Parameters

`other` [CMsgSignOutMuertaMinigame](Divine.Protobufs.Dota2.CMsgSignOutMuertaMinigame.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_EventGameDataFieldNumber"></a> EventGameDataFieldNumber

```csharp
public const int EventGameDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_EventGameData"></a> EventGameData

```csharp
public ByteString EventGameData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_HasEventGameData"></a> HasEventGameData

```csharp
public bool HasEventGameData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutMuertaMinigame> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutMuertaMinigame](Divine.Protobufs.Dota2.CMsgSignOutMuertaMinigame.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_ClearEventGameData"></a> ClearEventGameData\(\)

```csharp
public void ClearEventGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutMuertaMinigame Clone()
```

#### Returns

 [CMsgSignOutMuertaMinigame](Divine.Protobufs.Dota2.CMsgSignOutMuertaMinigame.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_Equals_Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_"></a> Equals\(CMsgSignOutMuertaMinigame\)

```csharp
public bool Equals(CMsgSignOutMuertaMinigame other)
```

#### Parameters

`other` [CMsgSignOutMuertaMinigame](Divine.Protobufs.Dota2.CMsgSignOutMuertaMinigame.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_"></a> MergeFrom\(CMsgSignOutMuertaMinigame\)

```csharp
public void MergeFrom(CMsgSignOutMuertaMinigame other)
```

#### Parameters

`other` [CMsgSignOutMuertaMinigame](Divine.Protobufs.Dota2.CMsgSignOutMuertaMinigame.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMuertaMinigame_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

