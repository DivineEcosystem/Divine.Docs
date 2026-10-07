# <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions"></a> Class CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions : IMessage<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions>, IEquatable<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions>, IDeepCloneable<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)

#### Implements

IMessage<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions\>, 
[IEquatable<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions\>, 
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
[EnumerableExtensions.In<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions\>\(CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions, params CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions__ctor"></a> PlayerPositions\(\)

```csharp
public PlayerPositions()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions__ctor_Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_"></a> PlayerPositions\(PlayerPositions\)

```csharp
public PlayerPositions(CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.md).[PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_Parser"></a> Parser

```csharp
public static MessageParser<CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.md).[PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_X"></a> X

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_Y"></a> Y

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_Clone"></a> Clone\(\)

```csharp
public CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions Clone()
```

#### Returns

 [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.md).[PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_Equals_Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_"></a> Equals\(PlayerPositions\)

```csharp
public bool Equals(CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.md).[PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_MergeFrom_Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_"></a> MergeFrom\(PlayerPositions\)

```csharp
public void MergeFrom(CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions other)
```

#### Parameters

`other` [CDOTASaveGame](Divine.Protobufs.Dota2.CDOTASaveGame.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.md).[SaveInstance](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.md).[Types](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.md).[PlayerPositions](Divine.Protobufs.Dota2.CDOTASaveGame.Types.SaveInstance.Types.PlayerPositions.md)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTASaveGame_Types_SaveInstance_Types_PlayerPositions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

