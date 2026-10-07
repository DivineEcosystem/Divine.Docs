# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames"></a> Class CMsgDOTALeagueLiveGames

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueLiveGames : IMessage<CMsgDOTALeagueLiveGames>, IEquatable<CMsgDOTALeagueLiveGames>, IDeepCloneable<CMsgDOTALeagueLiveGames>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md)

#### Implements

IMessage<CMsgDOTALeagueLiveGames\>, 
[IEquatable<CMsgDOTALeagueLiveGames\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueLiveGames\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueLiveGames\>\(CMsgDOTALeagueLiveGames, params CMsgDOTALeagueLiveGames\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames__ctor"></a> CMsgDOTALeagueLiveGames\(\)

```csharp
public CMsgDOTALeagueLiveGames()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_"></a> CMsgDOTALeagueLiveGames\(CMsgDOTALeagueLiveGames\)

```csharp
public CMsgDOTALeagueLiveGames(CMsgDOTALeagueLiveGames other)
```

#### Parameters

`other` [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_GamesFieldNumber"></a> GamesFieldNumber

```csharp
public const int GamesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Games"></a> Games

```csharp
public RepeatedField<CMsgDOTALeagueLiveGames.Types.LiveGame> Games { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.Types.LiveGame.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueLiveGames> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueLiveGames Clone()
```

#### Returns

 [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_"></a> Equals\(CMsgDOTALeagueLiveGames\)

```csharp
public bool Equals(CMsgDOTALeagueLiveGames other)
```

#### Parameters

`other` [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_"></a> MergeFrom\(CMsgDOTALeagueLiveGames\)

```csharp
public void MergeFrom(CMsgDOTALeagueLiveGames other)
```

#### Parameters

`other` [CMsgDOTALeagueLiveGames](Divine.Protobufs.Dota2.CMsgDOTALeagueLiveGames.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueLiveGames_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

