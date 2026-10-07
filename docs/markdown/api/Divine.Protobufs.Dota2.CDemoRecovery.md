# <a id="Divine_Protobufs_Dota2_CDemoRecovery"></a> Class CDemoRecovery

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoRecovery : IMessage<CDemoRecovery>, IEquatable<CDemoRecovery>, IDeepCloneable<CDemoRecovery>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md)

#### Implements

IMessage<CDemoRecovery\>, 
[IEquatable<CDemoRecovery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoRecovery\>, 
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
[EnumerableExtensions.In<CDemoRecovery\>\(CDemoRecovery, params CDemoRecovery\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoRecovery__ctor"></a> CDemoRecovery\(\)

```csharp
public CDemoRecovery()
```

### <a id="Divine_Protobufs_Dota2_CDemoRecovery__ctor_Divine_Protobufs_Dota2_CDemoRecovery_"></a> CDemoRecovery\(CDemoRecovery\)

```csharp
public CDemoRecovery(CDemoRecovery other)
```

#### Parameters

`other` [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_InitialSpawnGroupFieldNumber"></a> InitialSpawnGroupFieldNumber

```csharp
public const int InitialSpawnGroupFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_SpawnGroupMessageFieldNumber"></a> SpawnGroupMessageFieldNumber

```csharp
public const int SpawnGroupMessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_HasSpawnGroupMessage"></a> HasSpawnGroupMessage

```csharp
public bool HasSpawnGroupMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_InitialSpawnGroup"></a> InitialSpawnGroup

```csharp
public CDemoRecovery.Types.DemoInitialSpawnGroupEntry InitialSpawnGroup { get; set; }
```

#### Property Value

 [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md).[Types](Divine.Protobufs.Dota2.CDemoRecovery.Types.md).[DemoInitialSpawnGroupEntry](Divine.Protobufs.Dota2.CDemoRecovery.Types.DemoInitialSpawnGroupEntry.md)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Parser"></a> Parser

```csharp
public static MessageParser<CDemoRecovery> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_SpawnGroupMessage"></a> SpawnGroupMessage

```csharp
public ByteString SpawnGroupMessage { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_ClearSpawnGroupMessage"></a> ClearSpawnGroupMessage\(\)

```csharp
public void ClearSpawnGroupMessage()
```

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Clone"></a> Clone\(\)

```csharp
public CDemoRecovery Clone()
```

#### Returns

 [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_Equals_Divine_Protobufs_Dota2_CDemoRecovery_"></a> Equals\(CDemoRecovery\)

```csharp
public bool Equals(CDemoRecovery other)
```

#### Parameters

`other` [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_MergeFrom_Divine_Protobufs_Dota2_CDemoRecovery_"></a> MergeFrom\(CDemoRecovery\)

```csharp
public void MergeFrom(CDemoRecovery other)
```

#### Parameters

`other` [CDemoRecovery](Divine.Protobufs.Dota2.CDemoRecovery.md)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoRecovery_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

