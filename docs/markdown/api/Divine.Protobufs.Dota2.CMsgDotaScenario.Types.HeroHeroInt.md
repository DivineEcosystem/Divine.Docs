# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt"></a> Class CMsgDotaScenario.Types.HeroHeroInt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.HeroHeroInt : IMessage<CMsgDotaScenario.Types.HeroHeroInt>, IEquatable<CMsgDotaScenario.Types.HeroHeroInt>, IDeepCloneable<CMsgDotaScenario.Types.HeroHeroInt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.HeroHeroInt](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroInt.md)

#### Implements

IMessage<CMsgDotaScenario.Types.HeroHeroInt\>, 
[IEquatable<CMsgDotaScenario.Types.HeroHeroInt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.HeroHeroInt\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.HeroHeroInt\>\(CMsgDotaScenario.Types.HeroHeroInt, params CMsgDotaScenario.Types.HeroHeroInt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt__ctor"></a> HeroHeroInt\(\)

```csharp
public HeroHeroInt()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_"></a> HeroHeroInt\(HeroHeroInt\)

```csharp
public HeroHeroInt(CMsgDotaScenario.Types.HeroHeroInt other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroInt](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroInt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.HeroHeroInt> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroInt](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroInt.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_Value"></a> Value

```csharp
public int Value { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.HeroHeroInt Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroInt](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroInt.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_"></a> Equals\(HeroHeroInt\)

```csharp
public bool Equals(CMsgDotaScenario.Types.HeroHeroInt other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroInt](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroInt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_"></a> MergeFrom\(HeroHeroInt\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.HeroHeroInt other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroInt](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroInt.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroInt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

