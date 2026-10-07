# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails"></a> Class CMsgDOTARealtimeGameStats.Types.KillDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.KillDetails : IMessage<CMsgDOTARealtimeGameStats.Types.KillDetails>, IEquatable<CMsgDOTARealtimeGameStats.Types.KillDetails>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.KillDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.KillDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.KillDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.KillDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.KillDetails\>\(CMsgDOTARealtimeGameStats.Types.KillDetails, params CMsgDOTARealtimeGameStats.Types.KillDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails__ctor"></a> KillDetails\(\)

```csharp
public KillDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_"></a> KillDetails\(KillDetails\)

```csharp
public KillDetails(CMsgDOTARealtimeGameStats.Types.KillDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_DeathTimeFieldNumber"></a> DeathTimeFieldNumber

```csharp
public const int DeathTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_KillerPlayerIdFieldNumber"></a> KillerPlayerIdFieldNumber

```csharp
public const int KillerPlayerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_DeathTime"></a> DeathTime

```csharp
public int DeathTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_HasDeathTime"></a> HasDeathTime

```csharp
public bool HasDeathTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_HasKillerPlayerId"></a> HasKillerPlayerId

```csharp
public bool HasKillerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_KillerPlayerId"></a> KillerPlayerId

```csharp
public int KillerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.KillDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_ClearDeathTime"></a> ClearDeathTime\(\)

```csharp
public void ClearDeathTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_ClearKillerPlayerId"></a> ClearKillerPlayerId\(\)

```csharp
public void ClearKillerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.KillDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_"></a> Equals\(KillDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.KillDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_"></a> MergeFrom\(KillDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.KillDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[KillDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.KillDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_KillDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

