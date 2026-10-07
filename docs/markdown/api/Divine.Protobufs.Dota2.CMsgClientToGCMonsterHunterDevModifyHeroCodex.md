# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex"></a> Class CMsgClientToGCMonsterHunterDevModifyHeroCodex

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevModifyHeroCodex : IMessage<CMsgClientToGCMonsterHunterDevModifyHeroCodex>, IEquatable<CMsgClientToGCMonsterHunterDevModifyHeroCodex>, IDeepCloneable<CMsgClientToGCMonsterHunterDevModifyHeroCodex>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevModifyHeroCodex](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodex.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevModifyHeroCodex\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevModifyHeroCodex\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevModifyHeroCodex\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevModifyHeroCodex\>\(CMsgClientToGCMonsterHunterDevModifyHeroCodex, params CMsgClientToGCMonsterHunterDevModifyHeroCodex\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex__ctor"></a> CMsgClientToGCMonsterHunterDevModifyHeroCodex\(\)

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_"></a> CMsgClientToGCMonsterHunterDevModifyHeroCodex\(CMsgClientToGCMonsterHunterDevModifyHeroCodex\)

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodex(CMsgClientToGCMonsterHunterDevModifyHeroCodex other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevModifyHeroCodex](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodex.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_ActionsFieldNumber"></a> ActionsFieldNumber

```csharp
public const int ActionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_Actions"></a> Actions

```csharp
public RepeatedField<CMsgDevModifyCodexAction> Actions { get; }
```

#### Property Value

 RepeatedField<[CMsgDevModifyCodexAction](Divine.Protobufs.Dota2.CMsgDevModifyCodexAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevModifyHeroCodex> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevModifyHeroCodex](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodex.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodex Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevModifyHeroCodex](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodex.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_"></a> Equals\(CMsgClientToGCMonsterHunterDevModifyHeroCodex\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevModifyHeroCodex other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevModifyHeroCodex](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodex.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevModifyHeroCodex\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevModifyHeroCodex other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevModifyHeroCodex](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodex.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodex_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

