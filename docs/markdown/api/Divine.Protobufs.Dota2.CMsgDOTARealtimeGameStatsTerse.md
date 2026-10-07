# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse"></a> Class CMsgDOTARealtimeGameStatsTerse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStatsTerse : IMessage<CMsgDOTARealtimeGameStatsTerse>, IEquatable<CMsgDOTARealtimeGameStatsTerse>, IDeepCloneable<CMsgDOTARealtimeGameStatsTerse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStatsTerse\>, 
[IEquatable<CMsgDOTARealtimeGameStatsTerse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStatsTerse\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStatsTerse\>\(CMsgDOTARealtimeGameStatsTerse, params CMsgDOTARealtimeGameStatsTerse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse__ctor"></a> CMsgDOTARealtimeGameStatsTerse\(\)

```csharp
public CMsgDOTARealtimeGameStatsTerse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_"></a> CMsgDOTARealtimeGameStatsTerse\(CMsgDOTARealtimeGameStatsTerse\)

```csharp
public CMsgDOTARealtimeGameStatsTerse(CMsgDOTARealtimeGameStatsTerse other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_BuildingsFieldNumber"></a> BuildingsFieldNumber

```csharp
public const int BuildingsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_DeltaFrameFieldNumber"></a> DeltaFrameFieldNumber

```csharp
public const int DeltaFrameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_GraphDataFieldNumber"></a> GraphDataFieldNumber

```csharp
public const int GraphDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_MatchFieldNumber"></a> MatchFieldNumber

```csharp
public const int MatchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Buildings"></a> Buildings

```csharp
public RepeatedField<CMsgDOTARealtimeGameStatsTerse.Types.BuildingDetails> Buildings { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[BuildingDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.BuildingDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_DeltaFrame"></a> DeltaFrame

```csharp
public bool DeltaFrame { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_GraphData"></a> GraphData

```csharp
public CMsgDOTARealtimeGameStatsTerse.Types.GraphData GraphData { get; set; }
```

#### Property Value

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_HasDeltaFrame"></a> HasDeltaFrame

```csharp
public bool HasDeltaFrame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Match"></a> Match

```csharp
public CMsgDOTARealtimeGameStatsTerse.Types.MatchDetails Match { get; set; }
```

#### Property Value

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[MatchDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.MatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStatsTerse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_ClearDeltaFrame"></a> ClearDeltaFrame\(\)

```csharp
public void ClearDeltaFrame()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStatsTerse Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_"></a> Equals\(CMsgDOTARealtimeGameStatsTerse\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStatsTerse other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_"></a> MergeFrom\(CMsgDOTARealtimeGameStatsTerse\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStatsTerse other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

