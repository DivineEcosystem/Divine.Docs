# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker"></a> Class CDOTAClientMsg\_AddCommunicationsReportMarker

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AddCommunicationsReportMarker : IMessage<CDOTAClientMsg_AddCommunicationsReportMarker>, IEquatable<CDOTAClientMsg_AddCommunicationsReportMarker>, IDeepCloneable<CDOTAClientMsg_AddCommunicationsReportMarker>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AddCommunicationsReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsReportMarker.md)

#### Implements

IMessage<CDOTAClientMsg\_AddCommunicationsReportMarker\>, 
[IEquatable<CDOTAClientMsg\_AddCommunicationsReportMarker\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AddCommunicationsReportMarker\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AddCommunicationsReportMarker\>\(CDOTAClientMsg\_AddCommunicationsReportMarker, params CDOTAClientMsg\_AddCommunicationsReportMarker\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker__ctor"></a> CDOTAClientMsg\_AddCommunicationsReportMarker\(\)

```csharp
public CDOTAClientMsg_AddCommunicationsReportMarker()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_"></a> CDOTAClientMsg\_AddCommunicationsReportMarker\(CDOTAClientMsg\_AddCommunicationsReportMarker\)

```csharp
public CDOTAClientMsg_AddCommunicationsReportMarker(CDOTAClientMsg_AddCommunicationsReportMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddCommunicationsReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsReportMarker.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AddCommunicationsReportMarker> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AddCommunicationsReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsReportMarker.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AddCommunicationsReportMarker Clone()
```

#### Returns

 [CDOTAClientMsg\_AddCommunicationsReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsReportMarker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_"></a> Equals\(CDOTAClientMsg\_AddCommunicationsReportMarker\)

```csharp
public bool Equals(CDOTAClientMsg_AddCommunicationsReportMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddCommunicationsReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsReportMarker.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_"></a> MergeFrom\(CDOTAClientMsg\_AddCommunicationsReportMarker\)

```csharp
public void MergeFrom(CDOTAClientMsg_AddCommunicationsReportMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddCommunicationsReportMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsReportMarker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsReportMarker_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

