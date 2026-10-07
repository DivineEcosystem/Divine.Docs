# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled"></a> Class CDOTAUserMsg\_DuelOpponentKilled

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_DuelOpponentKilled : IMessage<CDOTAUserMsg_DuelOpponentKilled>, IEquatable<CDOTAUserMsg_DuelOpponentKilled>, IDeepCloneable<CDOTAUserMsg_DuelOpponentKilled>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_DuelOpponentKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelOpponentKilled.md)

#### Implements

IMessage<CDOTAUserMsg\_DuelOpponentKilled\>, 
[IEquatable<CDOTAUserMsg\_DuelOpponentKilled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_DuelOpponentKilled\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_DuelOpponentKilled\>\(CDOTAUserMsg\_DuelOpponentKilled, params CDOTAUserMsg\_DuelOpponentKilled\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled__ctor"></a> CDOTAUserMsg\_DuelOpponentKilled\(\)

```csharp
public CDOTAUserMsg_DuelOpponentKilled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_"></a> CDOTAUserMsg\_DuelOpponentKilled\(CDOTAUserMsg\_DuelOpponentKilled\)

```csharp
public CDOTAUserMsg_DuelOpponentKilled(CDOTAUserMsg_DuelOpponentKilled other)
```

#### Parameters

`other` [CDOTAUserMsg\_DuelOpponentKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelOpponentKilled.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_PlayerIdLoserFieldNumber"></a> PlayerIdLoserFieldNumber

```csharp
public const int PlayerIdLoserFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_PlayerIdWinnerFieldNumber"></a> PlayerIdWinnerFieldNumber

```csharp
public const int PlayerIdWinnerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_HasPlayerIdLoser"></a> HasPlayerIdLoser

```csharp
public bool HasPlayerIdLoser { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_HasPlayerIdWinner"></a> HasPlayerIdWinner

```csharp
public bool HasPlayerIdWinner { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_DuelOpponentKilled> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_DuelOpponentKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelOpponentKilled.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_PlayerIdLoser"></a> PlayerIdLoser

```csharp
public int PlayerIdLoser { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_PlayerIdWinner"></a> PlayerIdWinner

```csharp
public int PlayerIdWinner { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_ClearPlayerIdLoser"></a> ClearPlayerIdLoser\(\)

```csharp
public void ClearPlayerIdLoser()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_ClearPlayerIdWinner"></a> ClearPlayerIdWinner\(\)

```csharp
public void ClearPlayerIdWinner()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_DuelOpponentKilled Clone()
```

#### Returns

 [CDOTAUserMsg\_DuelOpponentKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelOpponentKilled.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_"></a> Equals\(CDOTAUserMsg\_DuelOpponentKilled\)

```csharp
public bool Equals(CDOTAUserMsg_DuelOpponentKilled other)
```

#### Parameters

`other` [CDOTAUserMsg\_DuelOpponentKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelOpponentKilled.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_"></a> MergeFrom\(CDOTAUserMsg\_DuelOpponentKilled\)

```csharp
public void MergeFrom(CDOTAUserMsg_DuelOpponentKilled other)
```

#### Parameters

`other` [CDOTAUserMsg\_DuelOpponentKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelOpponentKilled.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelOpponentKilled_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

