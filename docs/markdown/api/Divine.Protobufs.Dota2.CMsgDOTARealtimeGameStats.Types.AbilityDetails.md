# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails"></a> Class CMsgDOTARealtimeGameStats.Types.AbilityDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.AbilityDetails : IMessage<CMsgDOTARealtimeGameStats.Types.AbilityDetails>, IEquatable<CMsgDOTARealtimeGameStats.Types.AbilityDetails>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.AbilityDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.AbilityDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.AbilityDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.AbilityDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.AbilityDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.AbilityDetails\>\(CMsgDOTARealtimeGameStats.Types.AbilityDetails, params CMsgDOTARealtimeGameStats.Types.AbilityDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails__ctor"></a> AbilityDetails\(\)

```csharp
public AbilityDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_"></a> AbilityDetails\(AbilityDetails\)

```csharp
public AbilityDetails(CMsgDOTARealtimeGameStats.Types.AbilityDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_CooldownFieldNumber"></a> CooldownFieldNumber

```csharp
public const int CooldownFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_CooldownMaxFieldNumber"></a> CooldownMaxFieldNumber

```csharp
public const int CooldownMaxFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Cooldown"></a> Cooldown

```csharp
public float Cooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_CooldownMax"></a> CooldownMax

```csharp
public float CooldownMax { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_HasCooldown"></a> HasCooldown

```csharp
public bool HasCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_HasCooldownMax"></a> HasCooldownMax

```csharp
public bool HasCooldownMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Id"></a> Id

```csharp
public int Id { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.AbilityDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_ClearCooldown"></a> ClearCooldown\(\)

```csharp
public void ClearCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_ClearCooldownMax"></a> ClearCooldownMax\(\)

```csharp
public void ClearCooldownMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.AbilityDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_"></a> Equals\(AbilityDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.AbilityDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_"></a> MergeFrom\(AbilityDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.AbilityDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[AbilityDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.AbilityDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_AbilityDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

