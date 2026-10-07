# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune"></a> Class CMsgClientToGCOverworldDevSetFortune

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevSetFortune : IMessage<CMsgClientToGCOverworldDevSetFortune>, IEquatable<CMsgClientToGCOverworldDevSetFortune>, IDeepCloneable<CMsgClientToGCOverworldDevSetFortune>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevSetFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortune.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevSetFortune\>, 
[IEquatable<CMsgClientToGCOverworldDevSetFortune\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevSetFortune\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevSetFortune\>\(CMsgClientToGCOverworldDevSetFortune, params CMsgClientToGCOverworldDevSetFortune\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune__ctor"></a> CMsgClientToGCOverworldDevSetFortune\(\)

```csharp
public CMsgClientToGCOverworldDevSetFortune()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_"></a> CMsgClientToGCOverworldDevSetFortune\(CMsgClientToGCOverworldDevSetFortune\)

```csharp
public CMsgClientToGCOverworldDevSetFortune(CMsgClientToGCOverworldDevSetFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevSetFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortune.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_FortuneIdFieldNumber"></a> FortuneIdFieldNumber

```csharp
public const int FortuneIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_FortuneId"></a> FortuneId

```csharp
public uint FortuneId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_HasFortuneId"></a> HasFortuneId

```csharp
public bool HasFortuneId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevSetFortune> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevSetFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortune.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_ClearFortuneId"></a> ClearFortuneId\(\)

```csharp
public void ClearFortuneId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevSetFortune Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevSetFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_"></a> Equals\(CMsgClientToGCOverworldDevSetFortune\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevSetFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevSetFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_"></a> MergeFrom\(CMsgClientToGCOverworldDevSetFortune\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevSetFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevSetFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevSetFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevSetFortune_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

