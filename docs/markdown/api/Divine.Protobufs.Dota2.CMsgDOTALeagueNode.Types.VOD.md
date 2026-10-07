# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD"></a> Class CMsgDOTALeagueNode.Types.VOD

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueNode.Types.VOD : IMessage<CMsgDOTALeagueNode.Types.VOD>, IEquatable<CMsgDOTALeagueNode.Types.VOD>, IDeepCloneable<CMsgDOTALeagueNode.Types.VOD>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueNode.Types.VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)

#### Implements

IMessage<CMsgDOTALeagueNode.Types.VOD\>, 
[IEquatable<CMsgDOTALeagueNode.Types.VOD\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueNode.Types.VOD\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueNode.Types.VOD\>\(CMsgDOTALeagueNode.Types.VOD, params CMsgDOTALeagueNode.Types.VOD\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD__ctor"></a> VOD\(\)

```csharp
public VOD()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_"></a> VOD\(VOD\)

```csharp
public VOD(CMsgDOTALeagueNode.Types.VOD other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_SeriesGameFieldNumber"></a> SeriesGameFieldNumber

```csharp
public const int SeriesGameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_StreamIdFieldNumber"></a> StreamIdFieldNumber

```csharp
public const int StreamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_HasSeriesGame"></a> HasSeriesGame

```csharp
public bool HasSeriesGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_HasStreamId"></a> HasStreamId

```csharp
public bool HasStreamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueNode.Types.VOD> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_SeriesGame"></a> SeriesGame

```csharp
public uint SeriesGame { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_StreamId"></a> StreamId

```csharp
public uint StreamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_ClearSeriesGame"></a> ClearSeriesGame\(\)

```csharp
public void ClearSeriesGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_ClearStreamId"></a> ClearStreamId\(\)

```csharp
public void ClearStreamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueNode.Types.VOD Clone()
```

#### Returns

 [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_"></a> Equals\(VOD\)

```csharp
public bool Equals(CMsgDOTALeagueNode.Types.VOD other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_"></a> MergeFrom\(VOD\)

```csharp
public void MergeFrom(CMsgDOTALeagueNode.Types.VOD other)
```

#### Parameters

`other` [CMsgDOTALeagueNode](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.md).[VOD](Divine.Protobufs.Dota2.CMsgDOTALeagueNode.Types.VOD.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueNode_Types_VOD_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

