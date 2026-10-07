# <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter"></a> Class CMsgSignOutMonsterHunter

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutMonsterHunter : IMessage<CMsgSignOutMonsterHunter>, IEquatable<CMsgSignOutMonsterHunter>, IDeepCloneable<CMsgSignOutMonsterHunter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md)

#### Implements

IMessage<CMsgSignOutMonsterHunter\>, 
[IEquatable<CMsgSignOutMonsterHunter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutMonsterHunter\>, 
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
[EnumerableExtensions.In<CMsgSignOutMonsterHunter\>\(CMsgSignOutMonsterHunter, params CMsgSignOutMonsterHunter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter__ctor"></a> CMsgSignOutMonsterHunter\(\)

```csharp
public CMsgSignOutMonsterHunter()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter__ctor_Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_"></a> CMsgSignOutMonsterHunter\(CMsgSignOutMonsterHunter\)

```csharp
public CMsgSignOutMonsterHunter(CMsgSignOutMonsterHunter other)
```

#### Parameters

`other` [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutMonsterHunter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutMonsterHunter.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutMonsterHunter Clone()
```

#### Returns

 [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_Equals_Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_"></a> Equals\(CMsgSignOutMonsterHunter\)

```csharp
public bool Equals(CMsgSignOutMonsterHunter other)
```

#### Parameters

`other` [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_"></a> MergeFrom\(CMsgSignOutMonsterHunter\)

```csharp
public void MergeFrom(CMsgSignOutMonsterHunter other)
```

#### Parameters

`other` [CMsgSignOutMonsterHunter](Divine.Protobufs.Dota2.CMsgSignOutMonsterHunter.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMonsterHunter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

