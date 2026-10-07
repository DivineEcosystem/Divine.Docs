# <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast"></a> Class CDemoSpawnGroupsHLTVBroadcast

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoSpawnGroupsHLTVBroadcast : IMessage<CDemoSpawnGroupsHLTVBroadcast>, IEquatable<CDemoSpawnGroupsHLTVBroadcast>, IDeepCloneable<CDemoSpawnGroupsHLTVBroadcast>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoSpawnGroupsHLTVBroadcast](Divine.Protobufs.Dota2.CDemoSpawnGroupsHLTVBroadcast.md)

#### Implements

IMessage<CDemoSpawnGroupsHLTVBroadcast\>, 
[IEquatable<CDemoSpawnGroupsHLTVBroadcast\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoSpawnGroupsHLTVBroadcast\>, 
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
[EnumerableExtensions.In<CDemoSpawnGroupsHLTVBroadcast\>\(CDemoSpawnGroupsHLTVBroadcast, params CDemoSpawnGroupsHLTVBroadcast\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast__ctor"></a> CDemoSpawnGroupsHLTVBroadcast\(\)

```csharp
public CDemoSpawnGroupsHLTVBroadcast()
```

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast__ctor_Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_"></a> CDemoSpawnGroupsHLTVBroadcast\(CDemoSpawnGroupsHLTVBroadcast\)

```csharp
public CDemoSpawnGroupsHLTVBroadcast(CDemoSpawnGroupsHLTVBroadcast other)
```

#### Parameters

`other` [CDemoSpawnGroupsHLTVBroadcast](Divine.Protobufs.Dota2.CDemoSpawnGroupsHLTVBroadcast.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_Parser"></a> Parser

```csharp
public static MessageParser<CDemoSpawnGroupsHLTVBroadcast> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoSpawnGroupsHLTVBroadcast](Divine.Protobufs.Dota2.CDemoSpawnGroupsHLTVBroadcast.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_Clone"></a> Clone\(\)

```csharp
public CDemoSpawnGroupsHLTVBroadcast Clone()
```

#### Returns

 [CDemoSpawnGroupsHLTVBroadcast](Divine.Protobufs.Dota2.CDemoSpawnGroupsHLTVBroadcast.md)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_Equals_Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_"></a> Equals\(CDemoSpawnGroupsHLTVBroadcast\)

```csharp
public bool Equals(CDemoSpawnGroupsHLTVBroadcast other)
```

#### Parameters

`other` [CDemoSpawnGroupsHLTVBroadcast](Divine.Protobufs.Dota2.CDemoSpawnGroupsHLTVBroadcast.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_MergeFrom_Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_"></a> MergeFrom\(CDemoSpawnGroupsHLTVBroadcast\)

```csharp
public void MergeFrom(CDemoSpawnGroupsHLTVBroadcast other)
```

#### Parameters

`other` [CDemoSpawnGroupsHLTVBroadcast](Divine.Protobufs.Dota2.CDemoSpawnGroupsHLTVBroadcast.md)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroupsHLTVBroadcast_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

