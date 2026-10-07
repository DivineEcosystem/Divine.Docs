# <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier"></a> Class CScenarioEnt\_Courier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CScenarioEnt_Courier : IMessage<CScenarioEnt_Courier>, IEquatable<CScenarioEnt_Courier>, IDeepCloneable<CScenarioEnt_Courier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)

#### Implements

IMessage<CScenarioEnt\_Courier\>, 
[IEquatable<CScenarioEnt\_Courier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CScenarioEnt\_Courier\>, 
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
[EnumerableExtensions.In<CScenarioEnt\_Courier\>\(CScenarioEnt\_Courier, params CScenarioEnt\_Courier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier__ctor"></a> CScenarioEnt\_Courier\(\)

```csharp
public CScenarioEnt_Courier()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier__ctor_Divine_Protobufs_Dota2_CScenarioEnt_Courier_"></a> CScenarioEnt\_Courier\(CScenarioEnt\_Courier\)

```csharp
public CScenarioEnt_Courier(CScenarioEnt_Courier other)
```

#### Parameters

`other` [CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_CooldownFieldNumber"></a> CooldownFieldNumber

```csharp
public const int CooldownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_OwnerPlayerIdFieldNumber"></a> OwnerPlayerIdFieldNumber

```csharp
public const int OwnerPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_Cooldown"></a> Cooldown

```csharp
public float Cooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_HasCooldown"></a> HasCooldown

```csharp
public bool HasCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_HasOwnerPlayerId"></a> HasOwnerPlayerId

```csharp
public bool HasOwnerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_OwnerPlayerId"></a> OwnerPlayerId

```csharp
public int OwnerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_Parser"></a> Parser

```csharp
public static MessageParser<CScenarioEnt_Courier> Parser { get; }
```

#### Property Value

 MessageParser<[CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)\>

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_TeamNumber"></a> TeamNumber

```csharp
public int TeamNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_ClearCooldown"></a> ClearCooldown\(\)

```csharp
public void ClearCooldown()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_ClearOwnerPlayerId"></a> ClearOwnerPlayerId\(\)

```csharp
public void ClearOwnerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_Clone"></a> Clone\(\)

```csharp
public CScenarioEnt_Courier Clone()
```

#### Returns

 [CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_Equals_Divine_Protobufs_Dota2_CScenarioEnt_Courier_"></a> Equals\(CScenarioEnt\_Courier\)

```csharp
public bool Equals(CScenarioEnt_Courier other)
```

#### Parameters

`other` [CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_MergeFrom_Divine_Protobufs_Dota2_CScenarioEnt_Courier_"></a> MergeFrom\(CScenarioEnt\_Courier\)

```csharp
public void MergeFrom(CScenarioEnt_Courier other)
```

#### Parameters

`other` [CScenarioEnt\_Courier](Divine.Protobufs.Dota2.CScenarioEnt\_Courier.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_Courier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

