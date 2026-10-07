# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker"></a> Class CDOTAClientMsg\_AddOverwatchReportMarker

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AddOverwatchReportMarker : IMessage<CDOTAClientMsg_AddOverwatchReportMarker>, IEquatable<CDOTAClientMsg_AddOverwatchReportMarker>, IDeepCloneable<CDOTAClientMsg_AddOverwatchReportMarker>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AddOverwatchReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddOverwatchReportMarker.md)

#### Implements

IMessage<CDOTAClientMsg\_AddOverwatchReportMarker\>, 
[IEquatable<CDOTAClientMsg\_AddOverwatchReportMarker\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AddOverwatchReportMarker\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AddOverwatchReportMarker\>\(CDOTAClientMsg\_AddOverwatchReportMarker, params CDOTAClientMsg\_AddOverwatchReportMarker\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker__ctor"></a> CDOTAClientMsg\_AddOverwatchReportMarker\(\)

```csharp
public CDOTAClientMsg_AddOverwatchReportMarker()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_"></a> CDOTAClientMsg\_AddOverwatchReportMarker\(CDOTAClientMsg\_AddOverwatchReportMarker\)

```csharp
public CDOTAClientMsg_AddOverwatchReportMarker(CDOTAClientMsg_AddOverwatchReportMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddOverwatchReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddOverwatchReportMarker.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_ReasonFieldNumber"></a> ReasonFieldNumber

```csharp
public const int ReasonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_SecondsAgoFieldNumber"></a> SecondsAgoFieldNumber

```csharp
public const int SecondsAgoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_HasReason"></a> HasReason

```csharp
public bool HasReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_HasSecondsAgo"></a> HasSecondsAgo

```csharp
public bool HasSecondsAgo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AddOverwatchReportMarker> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AddOverwatchReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddOverwatchReportMarker.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_Reason"></a> Reason

```csharp
public EOverwatchReportReason Reason { get; set; }
```

#### Property Value

 [EOverwatchReportReason](Divine.Protobufs.Dota2.EOverwatchReportReason.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_SecondsAgo"></a> SecondsAgo

```csharp
public uint SecondsAgo { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_ClearReason"></a> ClearReason\(\)

```csharp
public void ClearReason()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_ClearSecondsAgo"></a> ClearSecondsAgo\(\)

```csharp
public void ClearSecondsAgo()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AddOverwatchReportMarker Clone()
```

#### Returns

 [CDOTAClientMsg\_AddOverwatchReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddOverwatchReportMarker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_"></a> Equals\(CDOTAClientMsg\_AddOverwatchReportMarker\)

```csharp
public bool Equals(CDOTAClientMsg_AddOverwatchReportMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddOverwatchReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddOverwatchReportMarker.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_"></a> MergeFrom\(CDOTAClientMsg\_AddOverwatchReportMarker\)

```csharp
public void MergeFrom(CDOTAClientMsg_AddOverwatchReportMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddOverwatchReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddOverwatchReportMarker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddOverwatchReportMarker_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

