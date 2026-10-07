# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted"></a> Class CDOTAUserMsg\_RockPaperScissorsStarted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_RockPaperScissorsStarted : IMessage<CDOTAUserMsg_RockPaperScissorsStarted>, IEquatable<CDOTAUserMsg_RockPaperScissorsStarted>, IDeepCloneable<CDOTAUserMsg_RockPaperScissorsStarted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_RockPaperScissorsStarted](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsStarted.md)

#### Implements

IMessage<CDOTAUserMsg\_RockPaperScissorsStarted\>, 
[IEquatable<CDOTAUserMsg\_RockPaperScissorsStarted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_RockPaperScissorsStarted\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_RockPaperScissorsStarted\>\(CDOTAUserMsg\_RockPaperScissorsStarted, params CDOTAUserMsg\_RockPaperScissorsStarted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted__ctor"></a> CDOTAUserMsg\_RockPaperScissorsStarted\(\)

```csharp
public CDOTAUserMsg_RockPaperScissorsStarted()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_"></a> CDOTAUserMsg\_RockPaperScissorsStarted\(CDOTAUserMsg\_RockPaperScissorsStarted\)

```csharp
public CDOTAUserMsg_RockPaperScissorsStarted(CDOTAUserMsg_RockPaperScissorsStarted other)
```

#### Parameters

`other` [CDOTAUserMsg\_RockPaperScissorsStarted](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsStarted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_PlayerIdSourceFieldNumber"></a> PlayerIdSourceFieldNumber

```csharp
public const int PlayerIdSourceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_PlayerIdTargetFieldNumber"></a> PlayerIdTargetFieldNumber

```csharp
public const int PlayerIdTargetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_HasPlayerIdSource"></a> HasPlayerIdSource

```csharp
public bool HasPlayerIdSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_HasPlayerIdTarget"></a> HasPlayerIdTarget

```csharp
public bool HasPlayerIdTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_RockPaperScissorsStarted> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_RockPaperScissorsStarted](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsStarted.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_PlayerIdSource"></a> PlayerIdSource

```csharp
public int PlayerIdSource { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_PlayerIdTarget"></a> PlayerIdTarget

```csharp
public int PlayerIdTarget { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_ClearPlayerIdSource"></a> ClearPlayerIdSource\(\)

```csharp
public void ClearPlayerIdSource()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_ClearPlayerIdTarget"></a> ClearPlayerIdTarget\(\)

```csharp
public void ClearPlayerIdTarget()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_RockPaperScissorsStarted Clone()
```

#### Returns

 [CDOTAUserMsg\_RockPaperScissorsStarted](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsStarted.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_"></a> Equals\(CDOTAUserMsg\_RockPaperScissorsStarted\)

```csharp
public bool Equals(CDOTAUserMsg_RockPaperScissorsStarted other)
```

#### Parameters

`other` [CDOTAUserMsg\_RockPaperScissorsStarted](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsStarted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_"></a> MergeFrom\(CDOTAUserMsg\_RockPaperScissorsStarted\)

```csharp
public void MergeFrom(CDOTAUserMsg_RockPaperScissorsStarted other)
```

#### Parameters

`other` [CDOTAUserMsg\_RockPaperScissorsStarted](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsStarted.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsStarted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

