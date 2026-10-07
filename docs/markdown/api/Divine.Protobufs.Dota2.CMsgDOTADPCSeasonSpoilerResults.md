# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults"></a> Class CMsgDOTADPCSeasonSpoilerResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSeasonSpoilerResults : IMessage<CMsgDOTADPCSeasonSpoilerResults>, IEquatable<CMsgDOTADPCSeasonSpoilerResults>, IDeepCloneable<CMsgDOTADPCSeasonSpoilerResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSeasonSpoilerResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonSpoilerResults.md)

#### Implements

IMessage<CMsgDOTADPCSeasonSpoilerResults\>, 
[IEquatable<CMsgDOTADPCSeasonSpoilerResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSeasonSpoilerResults\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSeasonSpoilerResults\>\(CMsgDOTADPCSeasonSpoilerResults, params CMsgDOTADPCSeasonSpoilerResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults__ctor"></a> CMsgDOTADPCSeasonSpoilerResults\(\)

```csharp
public CMsgDOTADPCSeasonSpoilerResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_"></a> CMsgDOTADPCSeasonSpoilerResults\(CMsgDOTADPCSeasonSpoilerResults\)

```csharp
public CMsgDOTADPCSeasonSpoilerResults(CMsgDOTADPCSeasonSpoilerResults other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonSpoilerResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonSpoilerResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_SavedResultsFieldNumber"></a> SavedResultsFieldNumber

```csharp
public const int SavedResultsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_TimeLastUpdatedFieldNumber"></a> TimeLastUpdatedFieldNumber

```csharp
public const int TimeLastUpdatedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_HasTimeLastUpdated"></a> HasTimeLastUpdated

```csharp
public bool HasTimeLastUpdated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSeasonSpoilerResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSeasonSpoilerResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonSpoilerResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_SavedResults"></a> SavedResults

```csharp
public CMsgDOTADPCSeasonResults SavedResults { get; set; }
```

#### Property Value

 [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_TimeLastUpdated"></a> TimeLastUpdated

```csharp
public uint TimeLastUpdated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_ClearTimeLastUpdated"></a> ClearTimeLastUpdated\(\)

```csharp
public void ClearTimeLastUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSeasonSpoilerResults Clone()
```

#### Returns

 [CMsgDOTADPCSeasonSpoilerResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonSpoilerResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_"></a> Equals\(CMsgDOTADPCSeasonSpoilerResults\)

```csharp
public bool Equals(CMsgDOTADPCSeasonSpoilerResults other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonSpoilerResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonSpoilerResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_"></a> MergeFrom\(CMsgDOTADPCSeasonSpoilerResults\)

```csharp
public void MergeFrom(CMsgDOTADPCSeasonSpoilerResults other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonSpoilerResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonSpoilerResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonSpoilerResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

