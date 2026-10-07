# <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir"></a> Class CUserMessageShakeDir

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageShakeDir : IMessage<CUserMessageShakeDir>, IEquatable<CUserMessageShakeDir>, IDeepCloneable<CUserMessageShakeDir>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageShakeDir](Divine.Protobufs.Dota2.CUserMessageShakeDir.md)

#### Implements

IMessage<CUserMessageShakeDir\>, 
[IEquatable<CUserMessageShakeDir\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageShakeDir\>, 
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
[EnumerableExtensions.In<CUserMessageShakeDir\>\(CUserMessageShakeDir, params CUserMessageShakeDir\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir__ctor"></a> CUserMessageShakeDir\(\)

```csharp
public CUserMessageShakeDir()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir__ctor_Divine_Protobufs_Dota2_CUserMessageShakeDir_"></a> CUserMessageShakeDir\(CUserMessageShakeDir\)

```csharp
public CUserMessageShakeDir(CUserMessageShakeDir other)
```

#### Parameters

`other` [CUserMessageShakeDir](Divine.Protobufs.Dota2.CUserMessageShakeDir.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_DirectionFieldNumber"></a> DirectionFieldNumber

```csharp
public const int DirectionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_ShakeFieldNumber"></a> ShakeFieldNumber

```csharp
public const int ShakeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Direction"></a> Direction

```csharp
public CMsgVector Direction { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageShakeDir> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageShakeDir](Divine.Protobufs.Dota2.CUserMessageShakeDir.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Shake"></a> Shake

```csharp
public CUserMessageShake Shake { get; set; }
```

#### Property Value

 [CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Clone"></a> Clone\(\)

```csharp
public CUserMessageShakeDir Clone()
```

#### Returns

 [CUserMessageShakeDir](Divine.Protobufs.Dota2.CUserMessageShakeDir.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_Equals_Divine_Protobufs_Dota2_CUserMessageShakeDir_"></a> Equals\(CUserMessageShakeDir\)

```csharp
public bool Equals(CUserMessageShakeDir other)
```

#### Parameters

`other` [CUserMessageShakeDir](Divine.Protobufs.Dota2.CUserMessageShakeDir.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_MergeFrom_Divine_Protobufs_Dota2_CUserMessageShakeDir_"></a> MergeFrom\(CUserMessageShakeDir\)

```csharp
public void MergeFrom(CUserMessageShakeDir other)
```

#### Parameters

`other` [CUserMessageShakeDir](Divine.Protobufs.Dota2.CUserMessageShakeDir.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageShakeDir_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

