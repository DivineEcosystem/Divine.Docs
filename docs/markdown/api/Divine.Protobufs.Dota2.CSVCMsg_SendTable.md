# <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable"></a> Class CSVCMsg\_SendTable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_SendTable : IMessage<CSVCMsg_SendTable>, IEquatable<CSVCMsg_SendTable>, IDeepCloneable<CSVCMsg_SendTable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md)

#### Implements

IMessage<CSVCMsg\_SendTable\>, 
[IEquatable<CSVCMsg\_SendTable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_SendTable\>, 
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
[EnumerableExtensions.In<CSVCMsg\_SendTable\>\(CSVCMsg\_SendTable, params CSVCMsg\_SendTable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable__ctor"></a> CSVCMsg\_SendTable\(\)

```csharp
public CSVCMsg_SendTable()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable__ctor_Divine_Protobufs_Dota2_CSVCMsg_SendTable_"></a> CSVCMsg\_SendTable\(CSVCMsg\_SendTable\)

```csharp
public CSVCMsg_SendTable(CSVCMsg_SendTable other)
```

#### Parameters

`other` [CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_IsEndFieldNumber"></a> IsEndFieldNumber

```csharp
public const int IsEndFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_NeedsDecoderFieldNumber"></a> NeedsDecoderFieldNumber

```csharp
public const int NeedsDecoderFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_NetTableNameFieldNumber"></a> NetTableNameFieldNumber

```csharp
public const int NetTableNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_PropsFieldNumber"></a> PropsFieldNumber

```csharp
public const int PropsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_HasIsEnd"></a> HasIsEnd

```csharp
public bool HasIsEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_HasNeedsDecoder"></a> HasNeedsDecoder

```csharp
public bool HasNeedsDecoder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_HasNetTableName"></a> HasNetTableName

```csharp
public bool HasNetTableName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_IsEnd"></a> IsEnd

```csharp
public bool IsEnd { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_NeedsDecoder"></a> NeedsDecoder

```csharp
public bool NeedsDecoder { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_NetTableName"></a> NetTableName

```csharp
public string NetTableName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_SendTable> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_Props"></a> Props

```csharp
public RepeatedField<CSVCMsg_SendTable.Types.sendprop_t> Props { get; }
```

#### Property Value

 RepeatedField<[CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.Types.md).[sendprop\_t](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.Types.sendprop\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_ClearIsEnd"></a> ClearIsEnd\(\)

```csharp
public void ClearIsEnd()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_ClearNeedsDecoder"></a> ClearNeedsDecoder\(\)

```csharp
public void ClearNeedsDecoder()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_ClearNetTableName"></a> ClearNetTableName\(\)

```csharp
public void ClearNetTableName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_SendTable Clone()
```

#### Returns

 [CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_Equals_Divine_Protobufs_Dota2_CSVCMsg_SendTable_"></a> Equals\(CSVCMsg\_SendTable\)

```csharp
public bool Equals(CSVCMsg_SendTable other)
```

#### Parameters

`other` [CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_SendTable_"></a> MergeFrom\(CSVCMsg\_SendTable\)

```csharp
public void MergeFrom(CSVCMsg_SendTable other)
```

#### Parameters

`other` [CSVCMsg\_SendTable](Divine.Protobufs.Dota2.CSVCMsg\_SendTable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SendTable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

