# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress"></a> Class CDOTAUserMsg\_WK\_Arcana\_Progress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_WK_Arcana_Progress : IMessage<CDOTAUserMsg_WK_Arcana_Progress>, IEquatable<CDOTAUserMsg_WK_Arcana_Progress>, IDeepCloneable<CDOTAUserMsg_WK_Arcana_Progress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_WK\_Arcana\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_WK\_Arcana\_Progress.md)

#### Implements

IMessage<CDOTAUserMsg\_WK\_Arcana\_Progress\>, 
[IEquatable<CDOTAUserMsg\_WK\_Arcana\_Progress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_WK\_Arcana\_Progress\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_WK\_Arcana\_Progress\>\(CDOTAUserMsg\_WK\_Arcana\_Progress, params CDOTAUserMsg\_WK\_Arcana\_Progress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress__ctor"></a> CDOTAUserMsg\_WK\_Arcana\_Progress\(\)

```csharp
public CDOTAUserMsg_WK_Arcana_Progress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_"></a> CDOTAUserMsg\_WK\_Arcana\_Progress\(CDOTAUserMsg\_WK\_Arcana\_Progress\)

```csharp
public CDOTAUserMsg_WK_Arcana_Progress(CDOTAUserMsg_WK_Arcana_Progress other)
```

#### Parameters

`other` [CDOTAUserMsg\_WK\_Arcana\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_WK\_Arcana\_Progress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_ArcanaLevelFieldNumber"></a> ArcanaLevelFieldNumber

```csharp
public const int ArcanaLevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_ArcanaLevel"></a> ArcanaLevel

```csharp
public uint ArcanaLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_HasArcanaLevel"></a> HasArcanaLevel

```csharp
public bool HasArcanaLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_WK_Arcana_Progress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_WK\_Arcana\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_WK\_Arcana\_Progress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_ClearArcanaLevel"></a> ClearArcanaLevel\(\)

```csharp
public void ClearArcanaLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_WK_Arcana_Progress Clone()
```

#### Returns

 [CDOTAUserMsg\_WK\_Arcana\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_WK\_Arcana\_Progress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_"></a> Equals\(CDOTAUserMsg\_WK\_Arcana\_Progress\)

```csharp
public bool Equals(CDOTAUserMsg_WK_Arcana_Progress other)
```

#### Parameters

`other` [CDOTAUserMsg\_WK\_Arcana\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_WK\_Arcana\_Progress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_"></a> MergeFrom\(CDOTAUserMsg\_WK\_Arcana\_Progress\)

```csharp
public void MergeFrom(CDOTAUserMsg_WK_Arcana_Progress other)
```

#### Parameters

`other` [CDOTAUserMsg\_WK\_Arcana\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_WK\_Arcana\_Progress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WK_Arcana_Progress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

