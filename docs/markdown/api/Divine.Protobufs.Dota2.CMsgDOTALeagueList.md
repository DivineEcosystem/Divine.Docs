# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList"></a> Class CMsgDOTALeagueList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueList : IMessage<CMsgDOTALeagueList>, IEquatable<CMsgDOTALeagueList>, IDeepCloneable<CMsgDOTALeagueList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueList](Divine.Protobufs.Dota2.CMsgDOTALeagueList.md)

#### Implements

IMessage<CMsgDOTALeagueList\>, 
[IEquatable<CMsgDOTALeagueList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueList\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueList\>\(CMsgDOTALeagueList, params CMsgDOTALeagueList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList__ctor"></a> CMsgDOTALeagueList\(\)

```csharp
public CMsgDOTALeagueList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueList_"></a> CMsgDOTALeagueList\(CMsgDOTALeagueList\)

```csharp
public CMsgDOTALeagueList(CMsgDOTALeagueList other)
```

#### Parameters

`other` [CMsgDOTALeagueList](Divine.Protobufs.Dota2.CMsgDOTALeagueList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_LeaguesFieldNumber"></a> LeaguesFieldNumber

```csharp
public const int LeaguesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_Leagues"></a> Leagues

```csharp
public RepeatedField<CMsgDOTALeague> Leagues { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueList](Divine.Protobufs.Dota2.CMsgDOTALeagueList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueList Clone()
```

#### Returns

 [CMsgDOTALeagueList](Divine.Protobufs.Dota2.CMsgDOTALeagueList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueList_"></a> Equals\(CMsgDOTALeagueList\)

```csharp
public bool Equals(CMsgDOTALeagueList other)
```

#### Parameters

`other` [CMsgDOTALeagueList](Divine.Protobufs.Dota2.CMsgDOTALeagueList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueList_"></a> MergeFrom\(CMsgDOTALeagueList\)

```csharp
public void MergeFrom(CMsgDOTALeagueList other)
```

#### Parameters

`other` [CMsgDOTALeagueList](Divine.Protobufs.Dota2.CMsgDOTALeagueList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

