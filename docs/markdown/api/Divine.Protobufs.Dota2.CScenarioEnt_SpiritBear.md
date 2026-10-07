# <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear"></a> Class CScenarioEnt\_SpiritBear

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CScenarioEnt_SpiritBear : IMessage<CScenarioEnt_SpiritBear>, IEquatable<CScenarioEnt_SpiritBear>, IDeepCloneable<CScenarioEnt_SpiritBear>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)

#### Implements

IMessage<CScenarioEnt\_SpiritBear\>, 
[IEquatable<CScenarioEnt\_SpiritBear\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CScenarioEnt\_SpiritBear\>, 
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
[EnumerableExtensions.In<CScenarioEnt\_SpiritBear\>\(CScenarioEnt\_SpiritBear, params CScenarioEnt\_SpiritBear\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear__ctor"></a> CScenarioEnt\_SpiritBear\(\)

```csharp
public CScenarioEnt_SpiritBear()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear__ctor_Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_"></a> CScenarioEnt\_SpiritBear\(CScenarioEnt\_SpiritBear\)

```csharp
public CScenarioEnt_SpiritBear(CScenarioEnt_SpiritBear other)
```

#### Parameters

`other` [CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_OwnerIdFieldNumber"></a> OwnerIdFieldNumber

```csharp
public const int OwnerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_HasOwnerId"></a> HasOwnerId

```csharp
public bool HasOwnerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_OwnerId"></a> OwnerId

```csharp
public int OwnerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_Parser"></a> Parser

```csharp
public static MessageParser<CScenarioEnt_SpiritBear> Parser { get; }
```

#### Property Value

 MessageParser<[CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)\>

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_TeamId"></a> TeamId

```csharp
public int TeamId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_ClearOwnerId"></a> ClearOwnerId\(\)

```csharp
public void ClearOwnerId()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_Clone"></a> Clone\(\)

```csharp
public CScenarioEnt_SpiritBear Clone()
```

#### Returns

 [CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_Equals_Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_"></a> Equals\(CScenarioEnt\_SpiritBear\)

```csharp
public bool Equals(CScenarioEnt_SpiritBear other)
```

#### Parameters

`other` [CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_MergeFrom_Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_"></a> MergeFrom\(CScenarioEnt\_SpiritBear\)

```csharp
public void MergeFrom(CScenarioEnt_SpiritBear other)
```

#### Parameters

`other` [CScenarioEnt\_SpiritBear](Divine.Protobufs.Dota2.CScenarioEnt\_SpiritBear.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_SpiritBear_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

