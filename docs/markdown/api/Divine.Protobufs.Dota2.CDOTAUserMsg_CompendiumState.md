# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState"></a> Class CDOTAUserMsg\_CompendiumState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CompendiumState : IMessage<CDOTAUserMsg_CompendiumState>, IEquatable<CDOTAUserMsg_CompendiumState>, IDeepCloneable<CDOTAUserMsg_CompendiumState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CompendiumState](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumState.md)

#### Implements

IMessage<CDOTAUserMsg\_CompendiumState\>, 
[IEquatable<CDOTAUserMsg\_CompendiumState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CompendiumState\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CompendiumState\>\(CDOTAUserMsg\_CompendiumState, params CDOTAUserMsg\_CompendiumState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState__ctor"></a> CDOTAUserMsg\_CompendiumState\(\)

```csharp
public CDOTAUserMsg_CompendiumState()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_"></a> CDOTAUserMsg\_CompendiumState\(CDOTAUserMsg\_CompendiumState\)

```csharp
public CDOTAUserMsg_CompendiumState(CDOTAUserMsg_CompendiumState other)
```

#### Parameters

`other` [CDOTAUserMsg\_CompendiumState](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_CompendiumPlayersFieldNumber"></a> CompendiumPlayersFieldNumber

```csharp
public const int CompendiumPlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_CompendiumPlayers"></a> CompendiumPlayers

```csharp
public RepeatedField<CDOTAUserMsg_CompendiumStatePlayer> CompendiumPlayers { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CompendiumState> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CompendiumState](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CompendiumState Clone()
```

#### Returns

 [CDOTAUserMsg\_CompendiumState](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumState.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_"></a> Equals\(CDOTAUserMsg\_CompendiumState\)

```csharp
public bool Equals(CDOTAUserMsg_CompendiumState other)
```

#### Parameters

`other` [CDOTAUserMsg\_CompendiumState](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_"></a> MergeFrom\(CDOTAUserMsg\_CompendiumState\)

```csharp
public void MergeFrom(CDOTAUserMsg_CompendiumState other)
```

#### Parameters

`other` [CDOTAUserMsg\_CompendiumState](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumState.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

