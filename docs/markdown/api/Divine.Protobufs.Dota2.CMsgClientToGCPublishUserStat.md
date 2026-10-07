# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat"></a> Class CMsgClientToGCPublishUserStat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPublishUserStat : IMessage<CMsgClientToGCPublishUserStat>, IEquatable<CMsgClientToGCPublishUserStat>, IDeepCloneable<CMsgClientToGCPublishUserStat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPublishUserStat](Divine.Protobufs.Dota2.CMsgClientToGCPublishUserStat.md)

#### Implements

IMessage<CMsgClientToGCPublishUserStat\>, 
[IEquatable<CMsgClientToGCPublishUserStat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPublishUserStat\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPublishUserStat\>\(CMsgClientToGCPublishUserStat, params CMsgClientToGCPublishUserStat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat__ctor"></a> CMsgClientToGCPublishUserStat\(\)

```csharp
public CMsgClientToGCPublishUserStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_"></a> CMsgClientToGCPublishUserStat\(CMsgClientToGCPublishUserStat\)

```csharp
public CMsgClientToGCPublishUserStat(CMsgClientToGCPublishUserStat other)
```

#### Parameters

`other` [CMsgClientToGCPublishUserStat](Divine.Protobufs.Dota2.CMsgClientToGCPublishUserStat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_ReferenceDataFieldNumber"></a> ReferenceDataFieldNumber

```csharp
public const int ReferenceDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_UserStatsEventFieldNumber"></a> UserStatsEventFieldNumber

```csharp
public const int UserStatsEventFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_HasReferenceData"></a> HasReferenceData

```csharp
public bool HasReferenceData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_HasUserStatsEvent"></a> HasUserStatsEvent

```csharp
public bool HasUserStatsEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPublishUserStat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPublishUserStat](Divine.Protobufs.Dota2.CMsgClientToGCPublishUserStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_ReferenceData"></a> ReferenceData

```csharp
public ulong ReferenceData { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_UserStatsEvent"></a> UserStatsEvent

```csharp
public uint UserStatsEvent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_ClearReferenceData"></a> ClearReferenceData\(\)

```csharp
public void ClearReferenceData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_ClearUserStatsEvent"></a> ClearUserStatsEvent\(\)

```csharp
public void ClearUserStatsEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPublishUserStat Clone()
```

#### Returns

 [CMsgClientToGCPublishUserStat](Divine.Protobufs.Dota2.CMsgClientToGCPublishUserStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_"></a> Equals\(CMsgClientToGCPublishUserStat\)

```csharp
public bool Equals(CMsgClientToGCPublishUserStat other)
```

#### Parameters

`other` [CMsgClientToGCPublishUserStat](Divine.Protobufs.Dota2.CMsgClientToGCPublishUserStat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_"></a> MergeFrom\(CMsgClientToGCPublishUserStat\)

```csharp
public void MergeFrom(CMsgClientToGCPublishUserStat other)
```

#### Parameters

`other` [CMsgClientToGCPublishUserStat](Divine.Protobufs.Dota2.CMsgClientToGCPublishUserStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPublishUserStat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

