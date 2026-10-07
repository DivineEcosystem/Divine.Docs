# <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups"></a> Class CDemoSpawnGroups

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoSpawnGroups : IMessage<CDemoSpawnGroups>, IEquatable<CDemoSpawnGroups>, IDeepCloneable<CDemoSpawnGroups>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoSpawnGroups](Divine.Protobufs.Dota2.CDemoSpawnGroups.md)

#### Implements

IMessage<CDemoSpawnGroups\>, 
[IEquatable<CDemoSpawnGroups\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoSpawnGroups\>, 
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
[EnumerableExtensions.In<CDemoSpawnGroups\>\(CDemoSpawnGroups, params CDemoSpawnGroups\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups__ctor"></a> CDemoSpawnGroups\(\)

```csharp
public CDemoSpawnGroups()
```

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups__ctor_Divine_Protobufs_Dota2_CDemoSpawnGroups_"></a> CDemoSpawnGroups\(CDemoSpawnGroups\)

```csharp
public CDemoSpawnGroups(CDemoSpawnGroups other)
```

#### Parameters

`other` [CDemoSpawnGroups](Divine.Protobufs.Dota2.CDemoSpawnGroups.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_MsgsFieldNumber"></a> MsgsFieldNumber

```csharp
public const int MsgsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_Msgs"></a> Msgs

```csharp
public RepeatedField<ByteString> Msgs { get; }
```

#### Property Value

 RepeatedField<ByteString\>

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_Parser"></a> Parser

```csharp
public static MessageParser<CDemoSpawnGroups> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoSpawnGroups](Divine.Protobufs.Dota2.CDemoSpawnGroups.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_Clone"></a> Clone\(\)

```csharp
public CDemoSpawnGroups Clone()
```

#### Returns

 [CDemoSpawnGroups](Divine.Protobufs.Dota2.CDemoSpawnGroups.md)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_Equals_Divine_Protobufs_Dota2_CDemoSpawnGroups_"></a> Equals\(CDemoSpawnGroups\)

```csharp
public bool Equals(CDemoSpawnGroups other)
```

#### Parameters

`other` [CDemoSpawnGroups](Divine.Protobufs.Dota2.CDemoSpawnGroups.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_MergeFrom_Divine_Protobufs_Dota2_CDemoSpawnGroups_"></a> MergeFrom\(CDemoSpawnGroups\)

```csharp
public void MergeFrom(CDemoSpawnGroups other)
```

#### Parameters

`other` [CDemoSpawnGroups](Divine.Protobufs.Dota2.CDemoSpawnGroups.md)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoSpawnGroups_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

