# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition"></a> Class CDOTAClientMsg\_SetEnemyStartingPosition

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SetEnemyStartingPosition : IMessage<CDOTAClientMsg_SetEnemyStartingPosition>, IEquatable<CDOTAClientMsg_SetEnemyStartingPosition>, IDeepCloneable<CDOTAClientMsg_SetEnemyStartingPosition>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SetEnemyStartingPosition](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetEnemyStartingPosition.md)

#### Implements

IMessage<CDOTAClientMsg\_SetEnemyStartingPosition\>, 
[IEquatable<CDOTAClientMsg\_SetEnemyStartingPosition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SetEnemyStartingPosition\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SetEnemyStartingPosition\>\(CDOTAClientMsg\_SetEnemyStartingPosition, params CDOTAClientMsg\_SetEnemyStartingPosition\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition__ctor"></a> CDOTAClientMsg\_SetEnemyStartingPosition\(\)

```csharp
public CDOTAClientMsg_SetEnemyStartingPosition()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_"></a> CDOTAClientMsg\_SetEnemyStartingPosition\(CDOTAClientMsg\_SetEnemyStartingPosition\)

```csharp
public CDOTAClientMsg_SetEnemyStartingPosition(CDOTAClientMsg_SetEnemyStartingPosition other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetEnemyStartingPosition](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetEnemyStartingPosition.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_EnemyPlayerIdFieldNumber"></a> EnemyPlayerIdFieldNumber

```csharp
public const int EnemyPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_EnemyStartingPositionFieldNumber"></a> EnemyStartingPositionFieldNumber

```csharp
public const int EnemyStartingPositionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_EnemyPlayerId"></a> EnemyPlayerId

```csharp
public int EnemyPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_EnemyStartingPosition"></a> EnemyStartingPosition

```csharp
public uint EnemyStartingPosition { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_HasEnemyPlayerId"></a> HasEnemyPlayerId

```csharp
public bool HasEnemyPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_HasEnemyStartingPosition"></a> HasEnemyStartingPosition

```csharp
public bool HasEnemyStartingPosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SetEnemyStartingPosition> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SetEnemyStartingPosition](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetEnemyStartingPosition.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_ClearEnemyPlayerId"></a> ClearEnemyPlayerId\(\)

```csharp
public void ClearEnemyPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_ClearEnemyStartingPosition"></a> ClearEnemyStartingPosition\(\)

```csharp
public void ClearEnemyStartingPosition()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SetEnemyStartingPosition Clone()
```

#### Returns

 [CDOTAClientMsg\_SetEnemyStartingPosition](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetEnemyStartingPosition.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_"></a> Equals\(CDOTAClientMsg\_SetEnemyStartingPosition\)

```csharp
public bool Equals(CDOTAClientMsg_SetEnemyStartingPosition other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetEnemyStartingPosition](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetEnemyStartingPosition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_"></a> MergeFrom\(CDOTAClientMsg\_SetEnemyStartingPosition\)

```csharp
public void MergeFrom(CDOTAClientMsg_SetEnemyStartingPosition other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetEnemyStartingPosition](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetEnemyStartingPosition.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetEnemyStartingPosition_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

