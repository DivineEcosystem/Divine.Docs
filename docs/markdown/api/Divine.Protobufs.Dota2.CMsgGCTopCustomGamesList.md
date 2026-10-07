# <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList"></a> Class CMsgGCTopCustomGamesList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCTopCustomGamesList : IMessage<CMsgGCTopCustomGamesList>, IEquatable<CMsgGCTopCustomGamesList>, IDeepCloneable<CMsgGCTopCustomGamesList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCTopCustomGamesList](Divine.Protobufs.Dota2.CMsgGCTopCustomGamesList.md)

#### Implements

IMessage<CMsgGCTopCustomGamesList\>, 
[IEquatable<CMsgGCTopCustomGamesList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCTopCustomGamesList\>, 
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
[EnumerableExtensions.In<CMsgGCTopCustomGamesList\>\(CMsgGCTopCustomGamesList, params CMsgGCTopCustomGamesList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList__ctor"></a> CMsgGCTopCustomGamesList\(\)

```csharp
public CMsgGCTopCustomGamesList()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList__ctor_Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_"></a> CMsgGCTopCustomGamesList\(CMsgGCTopCustomGamesList\)

```csharp
public CMsgGCTopCustomGamesList(CMsgGCTopCustomGamesList other)
```

#### Parameters

`other` [CMsgGCTopCustomGamesList](Divine.Protobufs.Dota2.CMsgGCTopCustomGamesList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_GameOfTheDayFieldNumber"></a> GameOfTheDayFieldNumber

```csharp
public const int GameOfTheDayFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_TopCustomGamesFieldNumber"></a> TopCustomGamesFieldNumber

```csharp
public const int TopCustomGamesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_GameOfTheDay"></a> GameOfTheDay

```csharp
public ulong GameOfTheDay { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_HasGameOfTheDay"></a> HasGameOfTheDay

```csharp
public bool HasGameOfTheDay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCTopCustomGamesList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCTopCustomGamesList](Divine.Protobufs.Dota2.CMsgGCTopCustomGamesList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_TopCustomGames"></a> TopCustomGames

```csharp
public RepeatedField<ulong> TopCustomGames { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_ClearGameOfTheDay"></a> ClearGameOfTheDay\(\)

```csharp
public void ClearGameOfTheDay()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_Clone"></a> Clone\(\)

```csharp
public CMsgGCTopCustomGamesList Clone()
```

#### Returns

 [CMsgGCTopCustomGamesList](Divine.Protobufs.Dota2.CMsgGCTopCustomGamesList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_Equals_Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_"></a> Equals\(CMsgGCTopCustomGamesList\)

```csharp
public bool Equals(CMsgGCTopCustomGamesList other)
```

#### Parameters

`other` [CMsgGCTopCustomGamesList](Divine.Protobufs.Dota2.CMsgGCTopCustomGamesList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_MergeFrom_Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_"></a> MergeFrom\(CMsgGCTopCustomGamesList\)

```csharp
public void MergeFrom(CMsgGCTopCustomGamesList other)
```

#### Parameters

`other` [CMsgGCTopCustomGamesList](Divine.Protobufs.Dota2.CMsgGCTopCustomGamesList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCTopCustomGamesList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

