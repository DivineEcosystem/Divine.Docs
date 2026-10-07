# <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting"></a> Class CMsgFightingGame\_GameData\_Fighting

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFightingGame_GameData_Fighting : IMessage<CMsgFightingGame_GameData_Fighting>, IEquatable<CMsgFightingGame_GameData_Fighting>, IDeepCloneable<CMsgFightingGame_GameData_Fighting>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)

#### Implements

IMessage<CMsgFightingGame\_GameData\_Fighting\>, 
[IEquatable<CMsgFightingGame\_GameData\_Fighting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFightingGame\_GameData\_Fighting\>, 
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
[EnumerableExtensions.In<CMsgFightingGame\_GameData\_Fighting\>\(CMsgFightingGame\_GameData\_Fighting, params CMsgFightingGame\_GameData\_Fighting\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting__ctor"></a> CMsgFightingGame\_GameData\_Fighting\(\)

```csharp
public CMsgFightingGame_GameData_Fighting()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting__ctor_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_"></a> CMsgFightingGame\_GameData\_Fighting\(CMsgFightingGame\_GameData\_Fighting\)

```csharp
public CMsgFightingGame_GameData_Fighting(CMsgFightingGame_GameData_Fighting other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_InputSampleFieldNumber"></a> InputSampleFieldNumber

```csharp
public const int InputSampleFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_InputStartFrameFieldNumber"></a> InputStartFrameFieldNumber

```csharp
public const int InputStartFrameFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_LastAckedFrameFieldNumber"></a> LastAckedFrameFieldNumber

```csharp
public const int LastAckedFrameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_LastCrcFrameFieldNumber"></a> LastCrcFrameFieldNumber

```csharp
public const int LastCrcFrameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_LastCrcValueFieldNumber"></a> LastCrcValueFieldNumber

```csharp
public const int LastCrcValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_NowFieldNumber"></a> NowFieldNumber

```csharp
public const int NowFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_PeerAckTimeFieldNumber"></a> PeerAckTimeFieldNumber

```csharp
public const int PeerAckTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasInputStartFrame"></a> HasInputStartFrame

```csharp
public bool HasInputStartFrame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasLastAckedFrame"></a> HasLastAckedFrame

```csharp
public bool HasLastAckedFrame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasLastCrcFrame"></a> HasLastCrcFrame

```csharp
public bool HasLastCrcFrame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasLastCrcValue"></a> HasLastCrcValue

```csharp
public bool HasLastCrcValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasNow"></a> HasNow

```csharp
public bool HasNow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasPeerAckTime"></a> HasPeerAckTime

```csharp
public bool HasPeerAckTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_InputSample"></a> InputSample

```csharp
public RepeatedField<CMsgFightingGame_GameData_Fighting.Types.InputSample> InputSample { get; }
```

#### Property Value

 RepeatedField<[CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.md).[InputSample](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.Types.InputSample.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_InputStartFrame"></a> InputStartFrame

```csharp
public int InputStartFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_LastAckedFrame"></a> LastAckedFrame

```csharp
public int LastAckedFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_LastCrcFrame"></a> LastCrcFrame

```csharp
public int LastCrcFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_LastCrcValue"></a> LastCrcValue

```csharp
public uint LastCrcValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Now"></a> Now

```csharp
public float Now { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFightingGame_GameData_Fighting> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_PeerAckTime"></a> PeerAckTime

```csharp
public float PeerAckTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_PlayerId"></a> PlayerId

```csharp
public uint PlayerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearInputStartFrame"></a> ClearInputStartFrame\(\)

```csharp
public void ClearInputStartFrame()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearLastAckedFrame"></a> ClearLastAckedFrame\(\)

```csharp
public void ClearLastAckedFrame()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearLastCrcFrame"></a> ClearLastCrcFrame\(\)

```csharp
public void ClearLastCrcFrame()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearLastCrcValue"></a> ClearLastCrcValue\(\)

```csharp
public void ClearLastCrcValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearNow"></a> ClearNow\(\)

```csharp
public void ClearNow()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearPeerAckTime"></a> ClearPeerAckTime\(\)

```csharp
public void ClearPeerAckTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Clone"></a> Clone\(\)

```csharp
public CMsgFightingGame_GameData_Fighting Clone()
```

#### Returns

 [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_Equals_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_"></a> Equals\(CMsgFightingGame\_GameData\_Fighting\)

```csharp
public bool Equals(CMsgFightingGame_GameData_Fighting other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_MergeFrom_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_"></a> MergeFrom\(CMsgFightingGame\_GameData\_Fighting\)

```csharp
public void MergeFrom(CMsgFightingGame_GameData_Fighting other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_Fighting](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_Fighting.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_Fighting_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

