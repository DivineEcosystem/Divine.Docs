# <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList"></a> Class CMsgLobbyOverworldFortuneList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyOverworldFortuneList : IMessage<CMsgLobbyOverworldFortuneList>, IEquatable<CMsgLobbyOverworldFortuneList>, IDeepCloneable<CMsgLobbyOverworldFortuneList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyOverworldFortuneList](Divine.Protobufs.Dota2.CMsgLobbyOverworldFortuneList.md)

#### Implements

IMessage<CMsgLobbyOverworldFortuneList\>, 
[IEquatable<CMsgLobbyOverworldFortuneList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyOverworldFortuneList\>, 
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
[EnumerableExtensions.In<CMsgLobbyOverworldFortuneList\>\(CMsgLobbyOverworldFortuneList, params CMsgLobbyOverworldFortuneList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList__ctor"></a> CMsgLobbyOverworldFortuneList\(\)

```csharp
public CMsgLobbyOverworldFortuneList()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList__ctor_Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_"></a> CMsgLobbyOverworldFortuneList\(CMsgLobbyOverworldFortuneList\)

```csharp
public CMsgLobbyOverworldFortuneList(CMsgLobbyOverworldFortuneList other)
```

#### Parameters

`other` [CMsgLobbyOverworldFortuneList](Divine.Protobufs.Dota2.CMsgLobbyOverworldFortuneList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_FortuneFieldNumber"></a> FortuneFieldNumber

```csharp
public const int FortuneFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_AccountId"></a> AccountId

```csharp
public RepeatedField<uint> AccountId { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_Fortune"></a> Fortune

```csharp
public RepeatedField<CMsgOverworldFortune> Fortune { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyOverworldFortuneList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyOverworldFortuneList](Divine.Protobufs.Dota2.CMsgLobbyOverworldFortuneList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyOverworldFortuneList Clone()
```

#### Returns

 [CMsgLobbyOverworldFortuneList](Divine.Protobufs.Dota2.CMsgLobbyOverworldFortuneList.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_Equals_Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_"></a> Equals\(CMsgLobbyOverworldFortuneList\)

```csharp
public bool Equals(CMsgLobbyOverworldFortuneList other)
```

#### Parameters

`other` [CMsgLobbyOverworldFortuneList](Divine.Protobufs.Dota2.CMsgLobbyOverworldFortuneList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_"></a> MergeFrom\(CMsgLobbyOverworldFortuneList\)

```csharp
public void MergeFrom(CMsgLobbyOverworldFortuneList other)
```

#### Parameters

`other` [CMsgLobbyOverworldFortuneList](Divine.Protobufs.Dota2.CMsgLobbyOverworldFortuneList.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyOverworldFortuneList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

