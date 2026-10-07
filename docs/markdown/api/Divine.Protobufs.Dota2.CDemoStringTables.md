# <a id="Divine_Protobufs_Dota2_CDemoStringTables"></a> Class CDemoStringTables

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoStringTables : IMessage<CDemoStringTables>, IEquatable<CDemoStringTables>, IDeepCloneable<CDemoStringTables>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)

#### Implements

IMessage<CDemoStringTables\>, 
[IEquatable<CDemoStringTables\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoStringTables\>, 
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
[EnumerableExtensions.In<CDemoStringTables\>\(CDemoStringTables, params CDemoStringTables\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoStringTables__ctor"></a> CDemoStringTables\(\)

```csharp
public CDemoStringTables()
```

### <a id="Divine_Protobufs_Dota2_CDemoStringTables__ctor_Divine_Protobufs_Dota2_CDemoStringTables_"></a> CDemoStringTables\(CDemoStringTables\)

```csharp
public CDemoStringTables(CDemoStringTables other)
```

#### Parameters

`other` [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_TablesFieldNumber"></a> TablesFieldNumber

```csharp
public const int TablesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Parser"></a> Parser

```csharp
public static MessageParser<CDemoStringTables> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Tables"></a> Tables

```csharp
public RepeatedField<CDemoStringTables.Types.table_t> Tables { get; }
```

#### Property Value

 RepeatedField<[CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Clone"></a> Clone\(\)

```csharp
public CDemoStringTables Clone()
```

#### Returns

 [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Equals_Divine_Protobufs_Dota2_CDemoStringTables_"></a> Equals\(CDemoStringTables\)

```csharp
public bool Equals(CDemoStringTables other)
```

#### Parameters

`other` [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_MergeFrom_Divine_Protobufs_Dota2_CDemoStringTables_"></a> MergeFrom\(CDemoStringTables\)

```csharp
public void MergeFrom(CDemoStringTables other)
```

#### Parameters

`other` [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

