# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune"></a> Class CMsgClientToGCOverworldDevClearFortune

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevClearFortune : IMessage<CMsgClientToGCOverworldDevClearFortune>, IEquatable<CMsgClientToGCOverworldDevClearFortune>, IDeepCloneable<CMsgClientToGCOverworldDevClearFortune>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevClearFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortune.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevClearFortune\>, 
[IEquatable<CMsgClientToGCOverworldDevClearFortune\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevClearFortune\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevClearFortune\>\(CMsgClientToGCOverworldDevClearFortune, params CMsgClientToGCOverworldDevClearFortune\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune__ctor"></a> CMsgClientToGCOverworldDevClearFortune\(\)

```csharp
public CMsgClientToGCOverworldDevClearFortune()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_"></a> CMsgClientToGCOverworldDevClearFortune\(CMsgClientToGCOverworldDevClearFortune\)

```csharp
public CMsgClientToGCOverworldDevClearFortune(CMsgClientToGCOverworldDevClearFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortune.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_FortuneIdFieldNumber"></a> FortuneIdFieldNumber

```csharp
public const int FortuneIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_FortuneId"></a> FortuneId

```csharp
public uint FortuneId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_HasFortuneId"></a> HasFortuneId

```csharp
public bool HasFortuneId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevClearFortune> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevClearFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortune.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_ClearFortuneId"></a> ClearFortuneId\(\)

```csharp
public void ClearFortuneId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevClearFortune Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevClearFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_"></a> Equals\(CMsgClientToGCOverworldDevClearFortune\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevClearFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_"></a> MergeFrom\(CMsgClientToGCOverworldDevClearFortune\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevClearFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearFortune_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

