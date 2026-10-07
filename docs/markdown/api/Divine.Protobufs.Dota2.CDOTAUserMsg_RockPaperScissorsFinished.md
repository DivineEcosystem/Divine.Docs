# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished"></a> Class CDOTAUserMsg\_RockPaperScissorsFinished

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_RockPaperScissorsFinished : IMessage<CDOTAUserMsg_RockPaperScissorsFinished>, IEquatable<CDOTAUserMsg_RockPaperScissorsFinished>, IDeepCloneable<CDOTAUserMsg_RockPaperScissorsFinished>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_RockPaperScissorsFinished](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsFinished.md)

#### Implements

IMessage<CDOTAUserMsg\_RockPaperScissorsFinished\>, 
[IEquatable<CDOTAUserMsg\_RockPaperScissorsFinished\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_RockPaperScissorsFinished\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_RockPaperScissorsFinished\>\(CDOTAUserMsg\_RockPaperScissorsFinished, params CDOTAUserMsg\_RockPaperScissorsFinished\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished__ctor"></a> CDOTAUserMsg\_RockPaperScissorsFinished\(\)

```csharp
public CDOTAUserMsg_RockPaperScissorsFinished()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_"></a> CDOTAUserMsg\_RockPaperScissorsFinished\(CDOTAUserMsg\_RockPaperScissorsFinished\)

```csharp
public CDOTAUserMsg_RockPaperScissorsFinished(CDOTAUserMsg_RockPaperScissorsFinished other)
```

#### Parameters

`other` [CDOTAUserMsg\_RockPaperScissorsFinished](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsFinished.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Player1ChoiceFieldNumber"></a> Player1ChoiceFieldNumber

```csharp
public const int Player1ChoiceFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Player2ChoiceFieldNumber"></a> Player2ChoiceFieldNumber

```csharp
public const int Player2ChoiceFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_PlayerId1FieldNumber"></a> PlayerId1FieldNumber

```csharp
public const int PlayerId1FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_PlayerId2FieldNumber"></a> PlayerId2FieldNumber

```csharp
public const int PlayerId2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_HasPlayer1Choice"></a> HasPlayer1Choice

```csharp
public bool HasPlayer1Choice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_HasPlayer2Choice"></a> HasPlayer2Choice

```csharp
public bool HasPlayer2Choice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_HasPlayerId1"></a> HasPlayerId1

```csharp
public bool HasPlayerId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_HasPlayerId2"></a> HasPlayerId2

```csharp
public bool HasPlayerId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_RockPaperScissorsFinished> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_RockPaperScissorsFinished](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsFinished.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Player1Choice"></a> Player1Choice

```csharp
public int Player1Choice { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Player2Choice"></a> Player2Choice

```csharp
public int Player2Choice { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_PlayerId1"></a> PlayerId1

```csharp
public int PlayerId1 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_PlayerId2"></a> PlayerId2

```csharp
public int PlayerId2 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_ClearPlayer1Choice"></a> ClearPlayer1Choice\(\)

```csharp
public void ClearPlayer1Choice()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_ClearPlayer2Choice"></a> ClearPlayer2Choice\(\)

```csharp
public void ClearPlayer2Choice()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_ClearPlayerId1"></a> ClearPlayerId1\(\)

```csharp
public void ClearPlayerId1()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_ClearPlayerId2"></a> ClearPlayerId2\(\)

```csharp
public void ClearPlayerId2()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_RockPaperScissorsFinished Clone()
```

#### Returns

 [CDOTAUserMsg\_RockPaperScissorsFinished](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsFinished.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_"></a> Equals\(CDOTAUserMsg\_RockPaperScissorsFinished\)

```csharp
public bool Equals(CDOTAUserMsg_RockPaperScissorsFinished other)
```

#### Parameters

`other` [CDOTAUserMsg\_RockPaperScissorsFinished](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsFinished.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_"></a> MergeFrom\(CDOTAUserMsg\_RockPaperScissorsFinished\)

```csharp
public void MergeFrom(CDOTAUserMsg_RockPaperScissorsFinished other)
```

#### Parameters

`other` [CDOTAUserMsg\_RockPaperScissorsFinished](Divine.Protobufs.Dota2.CDOTAUserMsg\_RockPaperScissorsFinished.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RockPaperScissorsFinished_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

