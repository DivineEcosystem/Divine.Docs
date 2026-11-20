# <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged"></a> Class CUserMessageEntitySpawnGroupChanged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageEntitySpawnGroupChanged : IMessage<CUserMessageEntitySpawnGroupChanged>, IEquatable<CUserMessageEntitySpawnGroupChanged>, IDeepCloneable<CUserMessageEntitySpawnGroupChanged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageEntitySpawnGroupChanged](Divine.Protobufs.Dota2.CUserMessageEntitySpawnGroupChanged.md)

#### Implements

IMessage<CUserMessageEntitySpawnGroupChanged\>, 
[IEquatable<CUserMessageEntitySpawnGroupChanged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageEntitySpawnGroupChanged\>, 
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
[EnumerableExtensions.In<CUserMessageEntitySpawnGroupChanged\>\(CUserMessageEntitySpawnGroupChanged, params CUserMessageEntitySpawnGroupChanged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged__ctor"></a> CUserMessageEntitySpawnGroupChanged\(\)

```csharp
public CUserMessageEntitySpawnGroupChanged()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged__ctor_Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_"></a> CUserMessageEntitySpawnGroupChanged\(CUserMessageEntitySpawnGroupChanged\)

```csharp
public CUserMessageEntitySpawnGroupChanged(CUserMessageEntitySpawnGroupChanged other)
```

#### Parameters

`other` [CUserMessageEntitySpawnGroupChanged](Divine.Protobufs.Dota2.CUserMessageEntitySpawnGroupChanged.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_EntityHandlesFieldNumber"></a> EntityHandlesFieldNumber

```csharp
public const int EntityHandlesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_SpawnGroupHandleFieldNumber"></a> SpawnGroupHandleFieldNumber

```csharp
public const int SpawnGroupHandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_EntityHandles"></a> EntityHandles

```csharp
public RepeatedField<uint> EntityHandles { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_HasSpawnGroupHandle"></a> HasSpawnGroupHandle

```csharp
public bool HasSpawnGroupHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageEntitySpawnGroupChanged> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageEntitySpawnGroupChanged](Divine.Protobufs.Dota2.CUserMessageEntitySpawnGroupChanged.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_SpawnGroupHandle"></a> SpawnGroupHandle

```csharp
public uint SpawnGroupHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_ClearSpawnGroupHandle"></a> ClearSpawnGroupHandle\(\)

```csharp
public void ClearSpawnGroupHandle()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_Clone"></a> Clone\(\)

```csharp
public CUserMessageEntitySpawnGroupChanged Clone()
```

#### Returns

 [CUserMessageEntitySpawnGroupChanged](Divine.Protobufs.Dota2.CUserMessageEntitySpawnGroupChanged.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_Equals_Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_"></a> Equals\(CUserMessageEntitySpawnGroupChanged\)

```csharp
public bool Equals(CUserMessageEntitySpawnGroupChanged other)
```

#### Parameters

`other` [CUserMessageEntitySpawnGroupChanged](Divine.Protobufs.Dota2.CUserMessageEntitySpawnGroupChanged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_MergeFrom_Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_"></a> MergeFrom\(CUserMessageEntitySpawnGroupChanged\)

```csharp
public void MergeFrom(CUserMessageEntitySpawnGroupChanged other)
```

#### Parameters

`other` [CUserMessageEntitySpawnGroupChanged](Divine.Protobufs.Dota2.CUserMessageEntitySpawnGroupChanged.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageEntitySpawnGroupChanged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

