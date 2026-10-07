# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers"></a> Class CDOTAUserMsg\_MutedPlayers

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MutedPlayers : IMessage<CDOTAUserMsg_MutedPlayers>, IEquatable<CDOTAUserMsg_MutedPlayers>, IDeepCloneable<CDOTAUserMsg_MutedPlayers>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MutedPlayers](Divine.Protobufs.Dota2.CDOTAUserMsg\_MutedPlayers.md)

#### Implements

IMessage<CDOTAUserMsg\_MutedPlayers\>, 
[IEquatable<CDOTAUserMsg\_MutedPlayers\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MutedPlayers\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MutedPlayers\>\(CDOTAUserMsg\_MutedPlayers, params CDOTAUserMsg\_MutedPlayers\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers__ctor"></a> CDOTAUserMsg\_MutedPlayers\(\)

```csharp
public CDOTAUserMsg_MutedPlayers()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_"></a> CDOTAUserMsg\_MutedPlayers\(CDOTAUserMsg\_MutedPlayers\)

```csharp
public CDOTAUserMsg_MutedPlayers(CDOTAUserMsg_MutedPlayers other)
```

#### Parameters

`other` [CDOTAUserMsg\_MutedPlayers](Divine.Protobufs.Dota2.CDOTAUserMsg\_MutedPlayers.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_TextMutedPlayerIdsFieldNumber"></a> TextMutedPlayerIdsFieldNumber

```csharp
public const int TextMutedPlayerIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_VoiceMutedPlayerIdsFieldNumber"></a> VoiceMutedPlayerIdsFieldNumber

```csharp
public const int VoiceMutedPlayerIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MutedPlayers> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MutedPlayers](Divine.Protobufs.Dota2.CDOTAUserMsg\_MutedPlayers.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_TextMutedPlayerIds"></a> TextMutedPlayerIds

```csharp
public RepeatedField<int> TextMutedPlayerIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_VoiceMutedPlayerIds"></a> VoiceMutedPlayerIds

```csharp
public RepeatedField<int> VoiceMutedPlayerIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MutedPlayers Clone()
```

#### Returns

 [CDOTAUserMsg\_MutedPlayers](Divine.Protobufs.Dota2.CDOTAUserMsg\_MutedPlayers.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_"></a> Equals\(CDOTAUserMsg\_MutedPlayers\)

```csharp
public bool Equals(CDOTAUserMsg_MutedPlayers other)
```

#### Parameters

`other` [CDOTAUserMsg\_MutedPlayers](Divine.Protobufs.Dota2.CDOTAUserMsg\_MutedPlayers.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_"></a> MergeFrom\(CDOTAUserMsg\_MutedPlayers\)

```csharp
public void MergeFrom(CDOTAUserMsg_MutedPlayers other)
```

#### Parameters

`other` [CDOTAUserMsg\_MutedPlayers](Divine.Protobufs.Dota2.CDOTAUserMsg\_MutedPlayers.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MutedPlayers_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

