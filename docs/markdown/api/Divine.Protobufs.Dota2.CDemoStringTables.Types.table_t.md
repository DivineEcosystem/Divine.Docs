# <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t"></a> Class CDemoStringTables.Types.table\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoStringTables.Types.table_t : IMessage<CDemoStringTables.Types.table_t>, IEquatable<CDemoStringTables.Types.table_t>, IDeepCloneable<CDemoStringTables.Types.table_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoStringTables.Types.table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)

#### Implements

IMessage<CDemoStringTables.Types.table\_t\>, 
[IEquatable<CDemoStringTables.Types.table\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoStringTables.Types.table\_t\>, 
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
[EnumerableExtensions.In<CDemoStringTables.Types.table\_t\>\(CDemoStringTables.Types.table\_t, params CDemoStringTables.Types.table\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t__ctor"></a> table\_t\(\)

```csharp
public table_t()
```

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t__ctor_Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_"></a> table\_t\(table\_t\)

```csharp
public table_t(CDemoStringTables.Types.table_t other)
```

#### Parameters

`other` [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_ItemsClientsideFieldNumber"></a> ItemsClientsideFieldNumber

```csharp
public const int ItemsClientsideFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_TableFlagsFieldNumber"></a> TableFlagsFieldNumber

```csharp
public const int TableFlagsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_TableNameFieldNumber"></a> TableNameFieldNumber

```csharp
public const int TableNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_HasTableFlags"></a> HasTableFlags

```csharp
public bool HasTableFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_HasTableName"></a> HasTableName

```csharp
public bool HasTableName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_Items"></a> Items

```csharp
public RepeatedField<CDemoStringTables.Types.items_t> Items { get; }
```

#### Property Value

 RepeatedField<[CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[items\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.items\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_ItemsClientside"></a> ItemsClientside

```csharp
public RepeatedField<CDemoStringTables.Types.items_t> ItemsClientside { get; }
```

#### Property Value

 RepeatedField<[CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[items\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.items\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_Parser"></a> Parser

```csharp
public static MessageParser<CDemoStringTables.Types.table_t> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_TableFlags"></a> TableFlags

```csharp
public int TableFlags { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_TableName"></a> TableName

```csharp
public string TableName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_ClearTableFlags"></a> ClearTableFlags\(\)

```csharp
public void ClearTableFlags()
```

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_ClearTableName"></a> ClearTableName\(\)

```csharp
public void ClearTableName()
```

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_Clone"></a> Clone\(\)

```csharp
public CDemoStringTables.Types.table_t Clone()
```

#### Returns

 [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_Equals_Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_"></a> Equals\(table\_t\)

```csharp
public bool Equals(CDemoStringTables.Types.table_t other)
```

#### Parameters

`other` [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_MergeFrom_Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_"></a> MergeFrom\(table\_t\)

```csharp
public void MergeFrom(CDemoStringTables.Types.table_t other)
```

#### Parameters

`other` [CDemoStringTables](Divine.Protobufs.Dota2.CDemoStringTables.md).[Types](Divine.Protobufs.Dota2.CDemoStringTables.Types.md).[table\_t](Divine.Protobufs.Dota2.CDemoStringTables.Types.table\_t.md)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoStringTables_Types_table_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

