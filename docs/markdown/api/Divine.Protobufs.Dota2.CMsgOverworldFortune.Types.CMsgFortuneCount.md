# <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount"></a> Class CMsgOverworldFortune.Types.CMsgFortuneCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldFortune.Types.CMsgFortuneCount : IMessage<CMsgOverworldFortune.Types.CMsgFortuneCount>, IEquatable<CMsgOverworldFortune.Types.CMsgFortuneCount>, IDeepCloneable<CMsgOverworldFortune.Types.CMsgFortuneCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldFortune.Types.CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)

#### Implements

IMessage<CMsgOverworldFortune.Types.CMsgFortuneCount\>, 
[IEquatable<CMsgOverworldFortune.Types.CMsgFortuneCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldFortune.Types.CMsgFortuneCount\>, 
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
[EnumerableExtensions.In<CMsgOverworldFortune.Types.CMsgFortuneCount\>\(CMsgOverworldFortune.Types.CMsgFortuneCount, params CMsgOverworldFortune.Types.CMsgFortuneCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount__ctor"></a> CMsgFortuneCount\(\)

```csharp
public CMsgFortuneCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount__ctor_Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_"></a> CMsgFortuneCount\(CMsgFortuneCount\)

```csharp
public CMsgFortuneCount(CMsgOverworldFortune.Types.CMsgFortuneCount other)
```

#### Parameters

`other` [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.md).[CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_FortuneFieldNumber"></a> FortuneFieldNumber

```csharp
public const int FortuneFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Fortune"></a> Fortune

```csharp
public uint Fortune { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_HasFortune"></a> HasFortune

```csharp
public bool HasFortune { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldFortune.Types.CMsgFortuneCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.md).[CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_ClearFortune"></a> ClearFortune\(\)

```csharp
public void ClearFortune()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldFortune.Types.CMsgFortuneCount Clone()
```

#### Returns

 [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.md).[CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_Equals_Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_"></a> Equals\(CMsgFortuneCount\)

```csharp
public bool Equals(CMsgOverworldFortune.Types.CMsgFortuneCount other)
```

#### Parameters

`other` [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.md).[CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_"></a> MergeFrom\(CMsgFortuneCount\)

```csharp
public void MergeFrom(CMsgOverworldFortune.Types.CMsgFortuneCount other)
```

#### Parameters

`other` [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.md).[CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Types_CMsgFortuneCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

