# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5"></a> Class CMsgSteamLearnMatchStateV5

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnMatchStateV5 : IMessage<CMsgSteamLearnMatchStateV5>, IEquatable<CMsgSteamLearnMatchStateV5>, IDeepCloneable<CMsgSteamLearnMatchStateV5>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md)

#### Implements

IMessage<CMsgSteamLearnMatchStateV5\>, 
[IEquatable<CMsgSteamLearnMatchStateV5\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnMatchStateV5\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnMatchStateV5\>\(CMsgSteamLearnMatchStateV5, params CMsgSteamLearnMatchStateV5\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5__ctor"></a> CMsgSteamLearnMatchStateV5\(\)

```csharp
public CMsgSteamLearnMatchStateV5()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_"></a> CMsgSteamLearnMatchStateV5\(CMsgSteamLearnMatchStateV5\)

```csharp
public CMsgSteamLearnMatchStateV5(CMsgSteamLearnMatchStateV5 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_DireStateFieldNumber"></a> DireStateFieldNumber

```csharp
public const int DireStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_RadiantStateFieldNumber"></a> RadiantStateFieldNumber

```csharp
public const int RadiantStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_DireState"></a> DireState

```csharp
public CMsgSteamLearnMatchStateV5.Types.TeamState DireState { get; set; }
```

#### Property Value

 [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnMatchStateV5> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_RadiantState"></a> RadiantState

```csharp
public CMsgSteamLearnMatchStateV5.Types.TeamState RadiantState { get; set; }
```

#### Property Value

 [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.md).[TeamState](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.Types.TeamState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnMatchStateV5 Clone()
```

#### Returns

 [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_"></a> Equals\(CMsgSteamLearnMatchStateV5\)

```csharp
public bool Equals(CMsgSteamLearnMatchStateV5 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_"></a> MergeFrom\(CMsgSteamLearnMatchStateV5\)

```csharp
public void MergeFrom(CMsgSteamLearnMatchStateV5 other)
```

#### Parameters

`other` [CMsgSteamLearnMatchStateV5](Divine.Protobufs.Dota2.CMsgSteamLearnMatchStateV5.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnMatchStateV5_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

