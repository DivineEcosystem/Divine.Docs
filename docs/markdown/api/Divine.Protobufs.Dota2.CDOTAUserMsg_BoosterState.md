# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState"></a> Class CDOTAUserMsg\_BoosterState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_BoosterState : IMessage<CDOTAUserMsg_BoosterState>, IEquatable<CDOTAUserMsg_BoosterState>, IDeepCloneable<CDOTAUserMsg_BoosterState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_BoosterState](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterState.md)

#### Implements

IMessage<CDOTAUserMsg\_BoosterState\>, 
[IEquatable<CDOTAUserMsg\_BoosterState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_BoosterState\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_BoosterState\>\(CDOTAUserMsg\_BoosterState, params CDOTAUserMsg\_BoosterState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState__ctor"></a> CDOTAUserMsg\_BoosterState\(\)

```csharp
public CDOTAUserMsg_BoosterState()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_"></a> CDOTAUserMsg\_BoosterState\(CDOTAUserMsg\_BoosterState\)

```csharp
public CDOTAUserMsg_BoosterState(CDOTAUserMsg_BoosterState other)
```

#### Parameters

`other` [CDOTAUserMsg\_BoosterState](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_BoostedPlayersFieldNumber"></a> BoostedPlayersFieldNumber

```csharp
public const int BoostedPlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_BoostedPlayers"></a> BoostedPlayers

```csharp
public RepeatedField<CDOTAUserMsg_BoosterStatePlayer> BoostedPlayers { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_BoosterState> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_BoosterState](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_BoosterState Clone()
```

#### Returns

 [CDOTAUserMsg\_BoosterState](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterState.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_"></a> Equals\(CDOTAUserMsg\_BoosterState\)

```csharp
public bool Equals(CDOTAUserMsg_BoosterState other)
```

#### Parameters

`other` [CDOTAUserMsg\_BoosterState](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_"></a> MergeFrom\(CDOTAUserMsg\_BoosterState\)

```csharp
public void MergeFrom(CDOTAUserMsg_BoosterState other)
```

#### Parameters

`other` [CDOTAUserMsg\_BoosterState](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterState.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

