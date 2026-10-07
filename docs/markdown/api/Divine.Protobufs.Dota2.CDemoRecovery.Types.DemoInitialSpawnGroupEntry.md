# <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry"></a> Class CDemoRecovery.Types.DemoInitialSpawnGroupEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoRecovery.Types.DemoInitialSpawnGroupEntry : IMessage<CDemoRecovery.Types.DemoInitialSpawnGroupEntry>, IEquatable<CDemoRecovery.Types.DemoInitialSpawnGroupEntry>, IDeepCloneable<CDemoRecovery.Types.DemoInitialSpawnGroupEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoRecovery.Types.DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)

#### Implements

IMessage<CDemoRecovery.Types.DemoInitialSpawnGroupEntry\>, 
[IEquatable<CDemoRecovery.Types.DemoInitialSpawnGroupEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoRecovery.Types.DemoInitialSpawnGroupEntry\>, 
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
[EnumerableExtensions.In<CDemoRecovery.Types.DemoInitialSpawnGroupEntry\>\(CDemoRecovery.Types.DemoInitialSpawnGroupEntry, params CDemoRecovery.Types.DemoInitialSpawnGroupEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry__ctor"></a> DemoInitialSpawnGroupEntry\(\)

```csharp
public DemoInitialSpawnGroupEntry()
```

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry__ctor_Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_"></a> DemoInitialSpawnGroupEntry\(DemoInitialSpawnGroupEntry\)

```csharp
public DemoInitialSpawnGroupEntry(CDemoRecovery.Types.DemoInitialSpawnGroupEntry other)
```

#### Parameters

`other` [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md).[Types](Divine.Protobufs.Dota2.CDemoRecovery.Types.md).[DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_SpawngrouphandleFieldNumber"></a> SpawngrouphandleFieldNumber

```csharp
public const int SpawngrouphandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_WasCreatedFieldNumber"></a> WasCreatedFieldNumber

```csharp
public const int WasCreatedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_HasSpawngrouphandle"></a> HasSpawngrouphandle

```csharp
public bool HasSpawngrouphandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_HasWasCreated"></a> HasWasCreated

```csharp
public bool HasWasCreated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_Parser"></a> Parser

```csharp
public static MessageParser<CDemoRecovery.Types.DemoInitialSpawnGroupEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md).[Types](Divine.Protobufs.Dota2.CDemoRecovery.Types.md).[DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_Spawngrouphandle"></a> Spawngrouphandle

```csharp
public uint Spawngrouphandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_WasCreated"></a> WasCreated

```csharp
public bool WasCreated { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_ClearSpawngrouphandle"></a> ClearSpawngrouphandle\(\)

```csharp
public void ClearSpawngrouphandle()
```

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_ClearWasCreated"></a> ClearWasCreated\(\)

```csharp
public void ClearWasCreated()
```

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_Clone"></a> Clone\(\)

```csharp
public CDemoRecovery.Types.DemoInitialSpawnGroupEntry Clone()
```

#### Returns

 [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md).[Types](Divine.Protobufs.Dota2.CDemoRecovery.Types.md).[DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_Equals_Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_"></a> Equals\(DemoInitialSpawnGroupEntry\)

```csharp
public bool Equals(CDemoRecovery.Types.DemoInitialSpawnGroupEntry other)
```

#### Parameters

`other` [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md).[Types](Divine.Protobufs.Dota2.CDemoRecovery.Types.md).[DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_MergeFrom_Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_"></a> MergeFrom\(DemoInitialSpawnGroupEntry\)

```csharp
public void MergeFrom(CDemoRecovery.Types.DemoInitialSpawnGroupEntry other)
```

#### Parameters

`other` [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md).[Types](Divine.Protobufs.Dota2.CDemoRecovery.Types.md).[DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Types_DemoInitialSpawnGroupEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

