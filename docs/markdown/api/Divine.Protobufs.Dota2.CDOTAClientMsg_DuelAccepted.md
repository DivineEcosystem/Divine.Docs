# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted"></a> Class CDOTAClientMsg\_DuelAccepted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_DuelAccepted : IMessage<CDOTAClientMsg_DuelAccepted>, IEquatable<CDOTAClientMsg_DuelAccepted>, IDeepCloneable<CDOTAClientMsg_DuelAccepted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_DuelAccepted](Divine.Protobufs.Dota2.CDOTAClientMsg\_DuelAccepted.md)

#### Implements

IMessage<CDOTAClientMsg\_DuelAccepted\>, 
[IEquatable<CDOTAClientMsg\_DuelAccepted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_DuelAccepted\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_DuelAccepted\>\(CDOTAClientMsg\_DuelAccepted, params CDOTAClientMsg\_DuelAccepted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted__ctor"></a> CDOTAClientMsg\_DuelAccepted\(\)

```csharp
public CDOTAClientMsg_DuelAccepted()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_"></a> CDOTAClientMsg\_DuelAccepted\(CDOTAClientMsg\_DuelAccepted\)

```csharp
public CDOTAClientMsg_DuelAccepted(CDOTAClientMsg_DuelAccepted other)
```

#### Parameters

`other` [CDOTAClientMsg\_DuelAccepted](Divine.Protobufs.Dota2.CDOTAClientMsg\_DuelAccepted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_AccepterPlayerIdFieldNumber"></a> AccepterPlayerIdFieldNumber

```csharp
public const int AccepterPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_ChallengerPlayerIdFieldNumber"></a> ChallengerPlayerIdFieldNumber

```csharp
public const int ChallengerPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_AccepterPlayerId"></a> AccepterPlayerId

```csharp
public int AccepterPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_ChallengerPlayerId"></a> ChallengerPlayerId

```csharp
public int ChallengerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_HasAccepterPlayerId"></a> HasAccepterPlayerId

```csharp
public bool HasAccepterPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_HasChallengerPlayerId"></a> HasChallengerPlayerId

```csharp
public bool HasChallengerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_DuelAccepted> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_DuelAccepted](Divine.Protobufs.Dota2.CDOTAClientMsg\_DuelAccepted.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_ClearAccepterPlayerId"></a> ClearAccepterPlayerId\(\)

```csharp
public void ClearAccepterPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_ClearChallengerPlayerId"></a> ClearChallengerPlayerId\(\)

```csharp
public void ClearChallengerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_DuelAccepted Clone()
```

#### Returns

 [CDOTAClientMsg\_DuelAccepted](Divine.Protobufs.Dota2.CDOTAClientMsg\_DuelAccepted.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_"></a> Equals\(CDOTAClientMsg\_DuelAccepted\)

```csharp
public bool Equals(CDOTAClientMsg_DuelAccepted other)
```

#### Parameters

`other` [CDOTAClientMsg\_DuelAccepted](Divine.Protobufs.Dota2.CDOTAClientMsg\_DuelAccepted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_"></a> MergeFrom\(CDOTAClientMsg\_DuelAccepted\)

```csharp
public void MergeFrom(CDOTAClientMsg_DuelAccepted other)
```

#### Parameters

`other` [CDOTAClientMsg\_DuelAccepted](Divine.Protobufs.Dota2.CDOTAClientMsg\_DuelAccepted.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DuelAccepted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

