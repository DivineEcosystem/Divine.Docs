# <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer"></a> Class CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer : IMessage<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer>, IEquatable<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer>, IDeepCloneable<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)

#### Implements

IMessage<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer\>, 
[IEquatable<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer\>, 
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
[EnumerableExtensions.In<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer\>\(CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer, params CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer__ctor"></a> TimedStatsContainer\(\)

```csharp
public TimedStatsContainer()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer__ctor_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_"></a> TimedStatsContainer\(TimedStatsContainer\)

```csharp
public TimedStatsContainer(CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_AllStatsFieldNumber"></a> AllStatsFieldNumber

```csharp
public const int AllStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_LosingStatsFieldNumber"></a> LosingStatsFieldNumber

```csharp
public const int LosingStatsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_LosingStddevsFieldNumber"></a> LosingStddevsFieldNumber

```csharp
public const int LosingStddevsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_WinningStatsFieldNumber"></a> WinningStatsFieldNumber

```csharp
public const int WinningStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_WinningStddevsFieldNumber"></a> WinningStddevsFieldNumber

```csharp
public const int WinningStddevsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_AllStats"></a> AllStats

```csharp
public CMatchPlayerTimedStatAverages AllStats { get; set; }
```

#### Property Value

 [CMatchPlayerTimedStatAverages](Divine.Protobufs.Dota2.CMatchPlayerTimedStatAverages.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_LosingStats"></a> LosingStats

```csharp
public CMatchPlayerTimedStatAverages LosingStats { get; set; }
```

#### Property Value

 [CMatchPlayerTimedStatAverages](Divine.Protobufs.Dota2.CMatchPlayerTimedStatAverages.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_LosingStddevs"></a> LosingStddevs

```csharp
public CMatchPlayerTimedStatStdDeviations LosingStddevs { get; set; }
```

#### Property Value

 [CMatchPlayerTimedStatStdDeviations](Divine.Protobufs.Dota2.CMatchPlayerTimedStatStdDeviations.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_Time"></a> Time

```csharp
public uint Time { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_WinningStats"></a> WinningStats

```csharp
public CMatchPlayerTimedStatAverages WinningStats { get; set; }
```

#### Property Value

 [CMatchPlayerTimedStatAverages](Divine.Protobufs.Dota2.CMatchPlayerTimedStatAverages.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_WinningStddevs"></a> WinningStddevs

```csharp
public CMatchPlayerTimedStatStdDeviations WinningStddevs { get; set; }
```

#### Property Value

 [CMatchPlayerTimedStatStdDeviations](Divine.Protobufs.Dota2.CMatchPlayerTimedStatStdDeviations.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer Clone()
```

#### Returns

 [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_Equals_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_"></a> Equals\(TimedStatsContainer\)

```csharp
public bool Equals(CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_"></a> MergeFrom\(TimedStatsContainer\)

```csharp
public void MergeFrom(CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer other)
```

#### Parameters

`other` [CMsgGCGetHeroTimedStatsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.md).[TimedStatsContainer](Divine.Protobufs.Dota2.CMsgGCGetHeroTimedStatsResponse.Types.TimedStatsContainer.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroTimedStatsResponse_Types_TimedStatsContainer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

