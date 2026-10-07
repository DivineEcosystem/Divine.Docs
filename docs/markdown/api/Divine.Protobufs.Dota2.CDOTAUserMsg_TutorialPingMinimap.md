# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap"></a> Class CDOTAUserMsg\_TutorialPingMinimap

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TutorialPingMinimap : IMessage<CDOTAUserMsg_TutorialPingMinimap>, IEquatable<CDOTAUserMsg_TutorialPingMinimap>, IDeepCloneable<CDOTAUserMsg_TutorialPingMinimap>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TutorialPingMinimap](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialPingMinimap.md)

#### Implements

IMessage<CDOTAUserMsg\_TutorialPingMinimap\>, 
[IEquatable<CDOTAUserMsg\_TutorialPingMinimap\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TutorialPingMinimap\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TutorialPingMinimap\>\(CDOTAUserMsg\_TutorialPingMinimap, params CDOTAUserMsg\_TutorialPingMinimap\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap__ctor"></a> CDOTAUserMsg\_TutorialPingMinimap\(\)

```csharp
public CDOTAUserMsg_TutorialPingMinimap()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_"></a> CDOTAUserMsg\_TutorialPingMinimap\(CDOTAUserMsg\_TutorialPingMinimap\)

```csharp
public CDOTAUserMsg_TutorialPingMinimap(CDOTAUserMsg_TutorialPingMinimap other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialPingMinimap](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialPingMinimap.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PosXFieldNumber"></a> PosXFieldNumber

```csharp
public const int PosXFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PosYFieldNumber"></a> PosYFieldNumber

```csharp
public const int PosYFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PosZFieldNumber"></a> PosZFieldNumber

```csharp
public const int PosZFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_HasPosX"></a> HasPosX

```csharp
public bool HasPosX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_HasPosY"></a> HasPosY

```csharp
public bool HasPosY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_HasPosZ"></a> HasPosZ

```csharp
public bool HasPosZ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TutorialPingMinimap> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TutorialPingMinimap](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialPingMinimap.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PosX"></a> PosX

```csharp
public float PosX { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PosY"></a> PosY

```csharp
public float PosY { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_PosZ"></a> PosZ

```csharp
public float PosZ { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_ClearPosX"></a> ClearPosX\(\)

```csharp
public void ClearPosX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_ClearPosY"></a> ClearPosY\(\)

```csharp
public void ClearPosY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_ClearPosZ"></a> ClearPosZ\(\)

```csharp
public void ClearPosZ()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TutorialPingMinimap Clone()
```

#### Returns

 [CDOTAUserMsg\_TutorialPingMinimap](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialPingMinimap.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_"></a> Equals\(CDOTAUserMsg\_TutorialPingMinimap\)

```csharp
public bool Equals(CDOTAUserMsg_TutorialPingMinimap other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialPingMinimap](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialPingMinimap.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_"></a> MergeFrom\(CDOTAUserMsg\_TutorialPingMinimap\)

```csharp
public void MergeFrom(CDOTAUserMsg_TutorialPingMinimap other)
```

#### Parameters

`other` [CDOTAUserMsg\_TutorialPingMinimap](Divine.Protobufs.Dota2.CDOTAUserMsg\_TutorialPingMinimap.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TutorialPingMinimap_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

