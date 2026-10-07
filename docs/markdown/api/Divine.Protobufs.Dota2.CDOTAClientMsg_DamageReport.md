# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport"></a> Class CDOTAClientMsg\_DamageReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_DamageReport : IMessage<CDOTAClientMsg_DamageReport>, IEquatable<CDOTAClientMsg_DamageReport>, IDeepCloneable<CDOTAClientMsg_DamageReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_DamageReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_DamageReport.md)

#### Implements

IMessage<CDOTAClientMsg\_DamageReport\>, 
[IEquatable<CDOTAClientMsg\_DamageReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_DamageReport\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_DamageReport\>\(CDOTAClientMsg\_DamageReport, params CDOTAClientMsg\_DamageReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport__ctor"></a> CDOTAClientMsg\_DamageReport\(\)

```csharp
public CDOTAClientMsg_DamageReport()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_"></a> CDOTAClientMsg\_DamageReport\(CDOTAClientMsg\_DamageReport\)

```csharp
public CDOTAClientMsg_DamageReport(CDOTAClientMsg_DamageReport other)
```

#### Parameters

`other` [CDOTAClientMsg\_DamageReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_DamageReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_BroadcastFieldNumber"></a> BroadcastFieldNumber

```csharp
public const int BroadcastFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_DamageAmountFieldNumber"></a> DamageAmountFieldNumber

```csharp
public const int DamageAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_SourceHeroIdFieldNumber"></a> SourceHeroIdFieldNumber

```csharp
public const int SourceHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_TargetHeroIdFieldNumber"></a> TargetHeroIdFieldNumber

```csharp
public const int TargetHeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_Broadcast"></a> Broadcast

```csharp
public bool Broadcast { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_DamageAmount"></a> DamageAmount

```csharp
public int DamageAmount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_HasBroadcast"></a> HasBroadcast

```csharp
public bool HasBroadcast { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_HasDamageAmount"></a> HasDamageAmount

```csharp
public bool HasDamageAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_HasSourceHeroId"></a> HasSourceHeroId

```csharp
public bool HasSourceHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_HasTargetHeroId"></a> HasTargetHeroId

```csharp
public bool HasTargetHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_DamageReport> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_DamageReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_DamageReport.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_SourceHeroId"></a> SourceHeroId

```csharp
public int SourceHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_TargetHeroId"></a> TargetHeroId

```csharp
public int TargetHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_ClearBroadcast"></a> ClearBroadcast\(\)

```csharp
public void ClearBroadcast()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_ClearDamageAmount"></a> ClearDamageAmount\(\)

```csharp
public void ClearDamageAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_ClearSourceHeroId"></a> ClearSourceHeroId\(\)

```csharp
public void ClearSourceHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_ClearTargetHeroId"></a> ClearTargetHeroId\(\)

```csharp
public void ClearTargetHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_DamageReport Clone()
```

#### Returns

 [CDOTAClientMsg\_DamageReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_DamageReport.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_"></a> Equals\(CDOTAClientMsg\_DamageReport\)

```csharp
public bool Equals(CDOTAClientMsg_DamageReport other)
```

#### Parameters

`other` [CDOTAClientMsg\_DamageReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_DamageReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_"></a> MergeFrom\(CDOTAClientMsg\_DamageReport\)

```csharp
public void MergeFrom(CDOTAClientMsg_DamageReport other)
```

#### Parameters

`other` [CDOTAClientMsg\_DamageReport](Divine.Protobufs.Dota2.CDOTAClientMsg\_DamageReport.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_DamageReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

