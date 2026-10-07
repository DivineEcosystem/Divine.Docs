# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat"></a> Class CMsgDotaScenario.Types.HeroHeroFloat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.HeroHeroFloat : IMessage<CMsgDotaScenario.Types.HeroHeroFloat>, IEquatable<CMsgDotaScenario.Types.HeroHeroFloat>, IDeepCloneable<CMsgDotaScenario.Types.HeroHeroFloat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.HeroHeroFloat](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroFloat.md)

#### Implements

IMessage<CMsgDotaScenario.Types.HeroHeroFloat\>, 
[IEquatable<CMsgDotaScenario.Types.HeroHeroFloat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.HeroHeroFloat\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.HeroHeroFloat\>\(CMsgDotaScenario.Types.HeroHeroFloat, params CMsgDotaScenario.Types.HeroHeroFloat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat__ctor"></a> HeroHeroFloat\(\)

```csharp
public HeroHeroFloat()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_"></a> HeroHeroFloat\(HeroHeroFloat\)

```csharp
public HeroHeroFloat(CMsgDotaScenario.Types.HeroHeroFloat other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroFloat](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroFloat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.HeroHeroFloat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroFloat](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroFloat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.HeroHeroFloat Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroFloat](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroFloat.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_"></a> Equals\(HeroHeroFloat\)

```csharp
public bool Equals(CMsgDotaScenario.Types.HeroHeroFloat other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroFloat](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroFloat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_"></a> MergeFrom\(HeroHeroFloat\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.HeroHeroFloat other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroHeroFloat](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroHeroFloat.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroHeroFloat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

