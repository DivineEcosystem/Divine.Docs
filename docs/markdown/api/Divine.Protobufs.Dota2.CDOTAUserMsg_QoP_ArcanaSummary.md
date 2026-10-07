# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary"></a> Class CDOTAUserMsg\_QoP\_ArcanaSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_QoP_ArcanaSummary : IMessage<CDOTAUserMsg_QoP_ArcanaSummary>, IEquatable<CDOTAUserMsg_QoP_ArcanaSummary>, IDeepCloneable<CDOTAUserMsg_QoP_ArcanaSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_QoP\_ArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_QoP\_ArcanaSummary.md)

#### Implements

IMessage<CDOTAUserMsg\_QoP\_ArcanaSummary\>, 
[IEquatable<CDOTAUserMsg\_QoP\_ArcanaSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_QoP\_ArcanaSummary\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_QoP\_ArcanaSummary\>\(CDOTAUserMsg\_QoP\_ArcanaSummary, params CDOTAUserMsg\_QoP\_ArcanaSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary__ctor"></a> CDOTAUserMsg\_QoP\_ArcanaSummary\(\)

```csharp
public CDOTAUserMsg_QoP_ArcanaSummary()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_"></a> CDOTAUserMsg\_QoP\_ArcanaSummary\(CDOTAUserMsg\_QoP\_ArcanaSummary\)

```csharp
public CDOTAUserMsg_QoP_ArcanaSummary(CDOTAUserMsg_QoP_ArcanaSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_QoP\_ArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_QoP\_ArcanaSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ArcanaLevelFieldNumber"></a> ArcanaLevelFieldNumber

```csharp
public const int ArcanaLevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_PlayersHitFieldNumber"></a> PlayersHitFieldNumber

```csharp
public const int PlayersHitFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_PlayersKilledFieldNumber"></a> PlayersKilledFieldNumber

```csharp
public const int PlayersKilledFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ArcanaLevel"></a> ArcanaLevel

```csharp
public uint ArcanaLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_HasArcanaLevel"></a> HasArcanaLevel

```csharp
public bool HasArcanaLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_HasPlayersHit"></a> HasPlayersHit

```csharp
public bool HasPlayersHit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_HasPlayersKilled"></a> HasPlayersKilled

```csharp
public bool HasPlayersKilled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_QoP_ArcanaSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_QoP\_ArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_QoP\_ArcanaSummary.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_PlayersHit"></a> PlayersHit

```csharp
public uint PlayersHit { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_PlayersKilled"></a> PlayersKilled

```csharp
public uint PlayersKilled { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ClearArcanaLevel"></a> ClearArcanaLevel\(\)

```csharp
public void ClearArcanaLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ClearPlayersHit"></a> ClearPlayersHit\(\)

```csharp
public void ClearPlayersHit()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ClearPlayersKilled"></a> ClearPlayersKilled\(\)

```csharp
public void ClearPlayersKilled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_QoP_ArcanaSummary Clone()
```

#### Returns

 [CDOTAUserMsg\_QoP\_ArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_QoP\_ArcanaSummary.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_"></a> Equals\(CDOTAUserMsg\_QoP\_ArcanaSummary\)

```csharp
public bool Equals(CDOTAUserMsg_QoP_ArcanaSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_QoP\_ArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_QoP\_ArcanaSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_"></a> MergeFrom\(CDOTAUserMsg\_QoP\_ArcanaSummary\)

```csharp
public void MergeFrom(CDOTAUserMsg_QoP_ArcanaSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_QoP\_ArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_QoP\_ArcanaSummary.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QoP_ArcanaSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

