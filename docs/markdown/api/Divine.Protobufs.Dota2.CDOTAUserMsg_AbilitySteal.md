# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal"></a> Class CDOTAUserMsg\_AbilitySteal

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_AbilitySteal : IMessage<CDOTAUserMsg_AbilitySteal>, IEquatable<CDOTAUserMsg_AbilitySteal>, IDeepCloneable<CDOTAUserMsg_AbilitySteal>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_AbilitySteal](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilitySteal.md)

#### Implements

IMessage<CDOTAUserMsg\_AbilitySteal\>, 
[IEquatable<CDOTAUserMsg\_AbilitySteal\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_AbilitySteal\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_AbilitySteal\>\(CDOTAUserMsg\_AbilitySteal, params CDOTAUserMsg\_AbilitySteal\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal__ctor"></a> CDOTAUserMsg\_AbilitySteal\(\)

```csharp
public CDOTAUserMsg_AbilitySteal()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_"></a> CDOTAUserMsg\_AbilitySteal\(CDOTAUserMsg\_AbilitySteal\)

```csharp
public CDOTAUserMsg_AbilitySteal(CDOTAUserMsg_AbilitySteal other)
```

#### Parameters

`other` [CDOTAUserMsg\_AbilitySteal](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilitySteal.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_AbilityLevelFieldNumber"></a> AbilityLevelFieldNumber

```csharp
public const int AbilityLevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_AbilityLevel"></a> AbilityLevel

```csharp
public uint AbilityLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_HasAbilityLevel"></a> HasAbilityLevel

```csharp
public bool HasAbilityLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_AbilitySteal> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_AbilitySteal](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilitySteal.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_ClearAbilityLevel"></a> ClearAbilityLevel\(\)

```csharp
public void ClearAbilityLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_AbilitySteal Clone()
```

#### Returns

 [CDOTAUserMsg\_AbilitySteal](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilitySteal.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_"></a> Equals\(CDOTAUserMsg\_AbilitySteal\)

```csharp
public bool Equals(CDOTAUserMsg_AbilitySteal other)
```

#### Parameters

`other` [CDOTAUserMsg\_AbilitySteal](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilitySteal.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_"></a> MergeFrom\(CDOTAUserMsg\_AbilitySteal\)

```csharp
public void MergeFrom(CDOTAUserMsg_AbilitySteal other)
```

#### Parameters

`other` [CDOTAUserMsg\_AbilitySteal](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilitySteal.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilitySteal_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

