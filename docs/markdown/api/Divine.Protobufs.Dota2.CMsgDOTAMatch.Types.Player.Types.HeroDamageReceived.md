# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived"></a> Class CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived : IMessage<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived>, IEquatable<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived>, IDeepCloneable<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)

#### Implements

IMessage<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived\>, 
[IEquatable<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived\>\(CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived, params CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived__ctor"></a> HeroDamageReceived\(\)

```csharp
public HeroDamageReceived()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_"></a> HeroDamageReceived\(HeroDamageReceived\)

```csharp
public HeroDamageReceived(CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_DamageTypeFieldNumber"></a> DamageTypeFieldNumber

```csharp
public const int DamageTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_PostReductionFieldNumber"></a> PostReductionFieldNumber

```csharp
public const int PostReductionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_PreReductionFieldNumber"></a> PreReductionFieldNumber

```csharp
public const int PreReductionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_DamageType"></a> DamageType

```csharp
public CMsgDOTAMatch.Types.Player.Types.HeroDamageType DamageType { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageType](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageType.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_HasDamageType"></a> HasDamageType

```csharp
public bool HasDamageType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_HasPostReduction"></a> HasPostReduction

```csharp
public bool HasPostReduction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_HasPreReduction"></a> HasPreReduction

```csharp
public bool HasPreReduction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_PostReduction"></a> PostReduction

```csharp
public uint PostReduction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_PreReduction"></a> PreReduction

```csharp
public uint PreReduction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_ClearDamageType"></a> ClearDamageType\(\)

```csharp
public void ClearDamageType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_ClearPostReduction"></a> ClearPostReduction\(\)

```csharp
public void ClearPostReduction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_ClearPreReduction"></a> ClearPreReduction\(\)

```csharp
public void ClearPreReduction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived Clone()
```

#### Returns

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_"></a> Equals\(HeroDamageReceived\)

```csharp
public bool Equals(CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_"></a> MergeFrom\(HeroDamageReceived\)

```csharp
public void MergeFrom(CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.md).[HeroDamageReceived](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.Player.Types.HeroDamageReceived.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_Player_Types_HeroDamageReceived_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

