# <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable"></a> Class CSVCMsg\_CreateStringTable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_CreateStringTable : IMessage<CSVCMsg_CreateStringTable>, IEquatable<CSVCMsg_CreateStringTable>, IDeepCloneable<CSVCMsg_CreateStringTable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_CreateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_CreateStringTable.md)

#### Implements

IMessage<CSVCMsg\_CreateStringTable\>, 
[IEquatable<CSVCMsg\_CreateStringTable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_CreateStringTable\>, 
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
[EnumerableExtensions.In<CSVCMsg\_CreateStringTable\>\(CSVCMsg\_CreateStringTable, params CSVCMsg\_CreateStringTable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable__ctor"></a> CSVCMsg\_CreateStringTable\(\)

```csharp
public CSVCMsg_CreateStringTable()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable__ctor_Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_"></a> CSVCMsg\_CreateStringTable\(CSVCMsg\_CreateStringTable\)

```csharp
public CSVCMsg_CreateStringTable(CSVCMsg_CreateStringTable other)
```

#### Parameters

`other` [CSVCMsg\_CreateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_CreateStringTable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_DataCompressedFieldNumber"></a> DataCompressedFieldNumber

```csharp
public const int DataCompressedFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_NumEntriesFieldNumber"></a> NumEntriesFieldNumber

```csharp
public const int NumEntriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_StringDataFieldNumber"></a> StringDataFieldNumber

```csharp
public const int StringDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UncompressedSizeFieldNumber"></a> UncompressedSizeFieldNumber

```csharp
public const int UncompressedSizeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UserDataFixedSizeFieldNumber"></a> UserDataFixedSizeFieldNumber

```csharp
public const int UserDataFixedSizeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UserDataSizeBitsFieldNumber"></a> UserDataSizeBitsFieldNumber

```csharp
public const int UserDataSizeBitsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UserDataSizeFieldNumber"></a> UserDataSizeFieldNumber

```csharp
public const int UserDataSizeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UsingVarintBitcountsFieldNumber"></a> UsingVarintBitcountsFieldNumber

```csharp
public const int UsingVarintBitcountsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_DataCompressed"></a> DataCompressed

```csharp
public bool DataCompressed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Flags"></a> Flags

```csharp
public int Flags { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasDataCompressed"></a> HasDataCompressed

```csharp
public bool HasDataCompressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasNumEntries"></a> HasNumEntries

```csharp
public bool HasNumEntries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasStringData"></a> HasStringData

```csharp
public bool HasStringData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasUncompressedSize"></a> HasUncompressedSize

```csharp
public bool HasUncompressedSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasUserDataFixedSize"></a> HasUserDataFixedSize

```csharp
public bool HasUserDataFixedSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasUserDataSize"></a> HasUserDataSize

```csharp
public bool HasUserDataSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasUserDataSizeBits"></a> HasUserDataSizeBits

```csharp
public bool HasUserDataSizeBits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_HasUsingVarintBitcounts"></a> HasUsingVarintBitcounts

```csharp
public bool HasUsingVarintBitcounts { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_NumEntries"></a> NumEntries

```csharp
public int NumEntries { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_CreateStringTable> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_CreateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_CreateStringTable.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_StringData"></a> StringData

```csharp
public ByteString StringData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UncompressedSize"></a> UncompressedSize

```csharp
public int UncompressedSize { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UserDataFixedSize"></a> UserDataFixedSize

```csharp
public bool UserDataFixedSize { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UserDataSize"></a> UserDataSize

```csharp
public int UserDataSize { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UserDataSizeBits"></a> UserDataSizeBits

```csharp
public int UserDataSizeBits { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_UsingVarintBitcounts"></a> UsingVarintBitcounts

```csharp
public bool UsingVarintBitcounts { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearDataCompressed"></a> ClearDataCompressed\(\)

```csharp
public void ClearDataCompressed()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearNumEntries"></a> ClearNumEntries\(\)

```csharp
public void ClearNumEntries()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearStringData"></a> ClearStringData\(\)

```csharp
public void ClearStringData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearUncompressedSize"></a> ClearUncompressedSize\(\)

```csharp
public void ClearUncompressedSize()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearUserDataFixedSize"></a> ClearUserDataFixedSize\(\)

```csharp
public void ClearUserDataFixedSize()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearUserDataSize"></a> ClearUserDataSize\(\)

```csharp
public void ClearUserDataSize()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearUserDataSizeBits"></a> ClearUserDataSizeBits\(\)

```csharp
public void ClearUserDataSizeBits()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ClearUsingVarintBitcounts"></a> ClearUsingVarintBitcounts\(\)

```csharp
public void ClearUsingVarintBitcounts()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_CreateStringTable Clone()
```

#### Returns

 [CSVCMsg\_CreateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_CreateStringTable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_Equals_Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_"></a> Equals\(CSVCMsg\_CreateStringTable\)

```csharp
public bool Equals(CSVCMsg_CreateStringTable other)
```

#### Parameters

`other` [CSVCMsg\_CreateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_CreateStringTable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_"></a> MergeFrom\(CSVCMsg\_CreateStringTable\)

```csharp
public void MergeFrom(CSVCMsg_CreateStringTable other)
```

#### Parameters

`other` [CSVCMsg\_CreateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_CreateStringTable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CreateStringTable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

