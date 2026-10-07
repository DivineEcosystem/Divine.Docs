# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune"></a> Class CMsgClientToGCOverworldRequestFortune

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldRequestFortune : IMessage<CMsgClientToGCOverworldRequestFortune>, IEquatable<CMsgClientToGCOverworldRequestFortune>, IDeepCloneable<CMsgClientToGCOverworldRequestFortune>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldRequestFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortune.md)

#### Implements

IMessage<CMsgClientToGCOverworldRequestFortune\>, 
[IEquatable<CMsgClientToGCOverworldRequestFortune\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldRequestFortune\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldRequestFortune\>\(CMsgClientToGCOverworldRequestFortune, params CMsgClientToGCOverworldRequestFortune\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune__ctor"></a> CMsgClientToGCOverworldRequestFortune\(\)

```csharp
public CMsgClientToGCOverworldRequestFortune()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_"></a> CMsgClientToGCOverworldRequestFortune\(CMsgClientToGCOverworldRequestFortune\)

```csharp
public CMsgClientToGCOverworldRequestFortune(CMsgClientToGCOverworldRequestFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortune.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldRequestFortune> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldRequestFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortune.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldRequestFortune Clone()
```

#### Returns

 [CMsgClientToGCOverworldRequestFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_"></a> Equals\(CMsgClientToGCOverworldRequestFortune\)

```csharp
public bool Equals(CMsgClientToGCOverworldRequestFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_"></a> MergeFrom\(CMsgClientToGCOverworldRequestFortune\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldRequestFortune other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestFortune](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestFortune_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

