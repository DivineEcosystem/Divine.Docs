# <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo"></a> Class CMsgShowcaseReportsRollupInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseReportsRollupInfo : IMessage<CMsgShowcaseReportsRollupInfo>, IEquatable<CMsgShowcaseReportsRollupInfo>, IDeepCloneable<CMsgShowcaseReportsRollupInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)

#### Implements

IMessage<CMsgShowcaseReportsRollupInfo\>, 
[IEquatable<CMsgShowcaseReportsRollupInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseReportsRollupInfo\>, 
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
[EnumerableExtensions.In<CMsgShowcaseReportsRollupInfo\>\(CMsgShowcaseReportsRollupInfo, params CMsgShowcaseReportsRollupInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo__ctor"></a> CMsgShowcaseReportsRollupInfo\(\)

```csharp
public CMsgShowcaseReportsRollupInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo__ctor_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_"></a> CMsgShowcaseReportsRollupInfo\(CMsgShowcaseReportsRollupInfo\)

```csharp
public CMsgShowcaseReportsRollupInfo(CMsgShowcaseReportsRollupInfo other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_EndTimestampFieldNumber"></a> EndTimestampFieldNumber

```csharp
public const int EndTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_RollupIdFieldNumber"></a> RollupIdFieldNumber

```csharp
public const int RollupIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_EndTimestamp"></a> EndTimestamp

```csharp
public uint EndTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_HasEndTimestamp"></a> HasEndTimestamp

```csharp
public bool HasEndTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_HasRollupId"></a> HasRollupId

```csharp
public bool HasRollupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseReportsRollupInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_RollupId"></a> RollupId

```csharp
public uint RollupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_ClearEndTimestamp"></a> ClearEndTimestamp\(\)

```csharp
public void ClearEndTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_ClearRollupId"></a> ClearRollupId\(\)

```csharp
public void ClearRollupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseReportsRollupInfo Clone()
```

#### Returns

 [CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_Equals_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_"></a> Equals\(CMsgShowcaseReportsRollupInfo\)

```csharp
public bool Equals(CMsgShowcaseReportsRollupInfo other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_"></a> MergeFrom\(CMsgShowcaseReportsRollupInfo\)

```csharp
public void MergeFrom(CMsgShowcaseReportsRollupInfo other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

