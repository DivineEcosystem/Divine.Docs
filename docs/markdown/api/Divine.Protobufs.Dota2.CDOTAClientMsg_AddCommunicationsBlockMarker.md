# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker"></a> Class CDOTAClientMsg\_AddCommunicationsBlockMarker

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AddCommunicationsBlockMarker : IMessage<CDOTAClientMsg_AddCommunicationsBlockMarker>, IEquatable<CDOTAClientMsg_AddCommunicationsBlockMarker>, IDeepCloneable<CDOTAClientMsg_AddCommunicationsBlockMarker>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AddCommunicationsBlockMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsBlockMarker.md)

#### Implements

IMessage<CDOTAClientMsg\_AddCommunicationsBlockMarker\>, 
[IEquatable<CDOTAClientMsg\_AddCommunicationsBlockMarker\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AddCommunicationsBlockMarker\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AddCommunicationsBlockMarker\>\(CDOTAClientMsg\_AddCommunicationsBlockMarker, params CDOTAClientMsg\_AddCommunicationsBlockMarker\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker__ctor"></a> CDOTAClientMsg\_AddCommunicationsBlockMarker\(\)

```csharp
public CDOTAClientMsg_AddCommunicationsBlockMarker()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_"></a> CDOTAClientMsg\_AddCommunicationsBlockMarker\(CDOTAClientMsg\_AddCommunicationsBlockMarker\)

```csharp
public CDOTAClientMsg_AddCommunicationsBlockMarker(CDOTAClientMsg_AddCommunicationsBlockMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddCommunicationsBlockMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsBlockMarker.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AddCommunicationsBlockMarker> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AddCommunicationsBlockMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsBlockMarker.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AddCommunicationsBlockMarker Clone()
```

#### Returns

 [CDOTAClientMsg\_AddCommunicationsBlockMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsBlockMarker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_"></a> Equals\(CDOTAClientMsg\_AddCommunicationsBlockMarker\)

```csharp
public bool Equals(CDOTAClientMsg_AddCommunicationsBlockMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddCommunicationsBlockMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsBlockMarker.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_"></a> MergeFrom\(CDOTAClientMsg\_AddCommunicationsBlockMarker\)

```csharp
public void MergeFrom(CDOTAClientMsg_AddCommunicationsBlockMarker other)
```

#### Parameters

`other` [CDOTAClientMsg\_AddCommunicationsBlockMarker](Divine.Protobufs.Dota2.CDOTAClientMsg\_AddCommunicationsBlockMarker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AddCommunicationsBlockMarker_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

