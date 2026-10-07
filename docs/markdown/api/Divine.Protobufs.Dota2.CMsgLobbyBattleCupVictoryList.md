# <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList"></a> Class CMsgLobbyBattleCupVictoryList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyBattleCupVictoryList : IMessage<CMsgLobbyBattleCupVictoryList>, IEquatable<CMsgLobbyBattleCupVictoryList>, IDeepCloneable<CMsgLobbyBattleCupVictoryList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyBattleCupVictoryList](Divine.Protobufs.Dota2.CMsgLobbyBattleCupVictoryList.md)

#### Implements

IMessage<CMsgLobbyBattleCupVictoryList\>, 
[IEquatable<CMsgLobbyBattleCupVictoryList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyBattleCupVictoryList\>, 
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
[EnumerableExtensions.In<CMsgLobbyBattleCupVictoryList\>\(CMsgLobbyBattleCupVictoryList, params CMsgLobbyBattleCupVictoryList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList__ctor"></a> CMsgLobbyBattleCupVictoryList\(\)

```csharp
public CMsgLobbyBattleCupVictoryList()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList__ctor_Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_"></a> CMsgLobbyBattleCupVictoryList\(CMsgLobbyBattleCupVictoryList\)

```csharp
public CMsgLobbyBattleCupVictoryList(CMsgLobbyBattleCupVictoryList other)
```

#### Parameters

`other` [CMsgLobbyBattleCupVictoryList](Divine.Protobufs.Dota2.CMsgLobbyBattleCupVictoryList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_WinnersFieldNumber"></a> WinnersFieldNumber

```csharp
public const int WinnersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyBattleCupVictoryList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyBattleCupVictoryList](Divine.Protobufs.Dota2.CMsgLobbyBattleCupVictoryList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_Winners"></a> Winners

```csharp
public RepeatedField<CMsgBattleCupVictory> Winners { get; }
```

#### Property Value

 RepeatedField<[CMsgBattleCupVictory](Divine.Protobufs.Dota2.CMsgBattleCupVictory.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyBattleCupVictoryList Clone()
```

#### Returns

 [CMsgLobbyBattleCupVictoryList](Divine.Protobufs.Dota2.CMsgLobbyBattleCupVictoryList.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_Equals_Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_"></a> Equals\(CMsgLobbyBattleCupVictoryList\)

```csharp
public bool Equals(CMsgLobbyBattleCupVictoryList other)
```

#### Parameters

`other` [CMsgLobbyBattleCupVictoryList](Divine.Protobufs.Dota2.CMsgLobbyBattleCupVictoryList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_"></a> MergeFrom\(CMsgLobbyBattleCupVictoryList\)

```csharp
public void MergeFrom(CMsgLobbyBattleCupVictoryList other)
```

#### Parameters

`other` [CMsgLobbyBattleCupVictoryList](Divine.Protobufs.Dota2.CMsgLobbyBattleCupVictoryList.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyBattleCupVictoryList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

