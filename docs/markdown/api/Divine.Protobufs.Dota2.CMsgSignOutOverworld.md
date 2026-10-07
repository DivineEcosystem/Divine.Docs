# <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld"></a> Class CMsgSignOutOverworld

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutOverworld : IMessage<CMsgSignOutOverworld>, IEquatable<CMsgSignOutOverworld>, IDeepCloneable<CMsgSignOutOverworld>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md)

#### Implements

IMessage<CMsgSignOutOverworld\>, 
[IEquatable<CMsgSignOutOverworld\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutOverworld\>, 
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
[EnumerableExtensions.In<CMsgSignOutOverworld\>\(CMsgSignOutOverworld, params CMsgSignOutOverworld\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld__ctor"></a> CMsgSignOutOverworld\(\)

```csharp
public CMsgSignOutOverworld()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld__ctor_Divine_Protobufs_Dota2_CMsgSignOutOverworld_"></a> CMsgSignOutOverworld\(CMsgSignOutOverworld\)

```csharp
public CMsgSignOutOverworld(CMsgSignOutOverworld other)
```

#### Parameters

`other` [CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutOverworld> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutOverworld.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutOverworld.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutOverworld.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutOverworld Clone()
```

#### Returns

 [CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_Equals_Divine_Protobufs_Dota2_CMsgSignOutOverworld_"></a> Equals\(CMsgSignOutOverworld\)

```csharp
public bool Equals(CMsgSignOutOverworld other)
```

#### Parameters

`other` [CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutOverworld_"></a> MergeFrom\(CMsgSignOutOverworld\)

```csharp
public void MergeFrom(CMsgSignOutOverworld other)
```

#### Parameters

`other` [CMsgSignOutOverworld](Divine.Protobufs.Dota2.CMsgSignOutOverworld.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutOverworld_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

