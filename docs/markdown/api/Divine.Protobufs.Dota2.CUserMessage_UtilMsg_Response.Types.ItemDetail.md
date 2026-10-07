# <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail"></a> Class CUserMessage\_UtilMsg\_Response.Types.ItemDetail

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_UtilMsg_Response.Types.ItemDetail : IMessage<CUserMessage_UtilMsg_Response.Types.ItemDetail>, IEquatable<CUserMessage_UtilMsg_Response.Types.ItemDetail>, IDeepCloneable<CUserMessage_UtilMsg_Response.Types.ItemDetail>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_UtilMsg\_Response.Types.ItemDetail](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.ItemDetail.md)

#### Implements

IMessage<CUserMessage\_UtilMsg\_Response.Types.ItemDetail\>, 
[IEquatable<CUserMessage\_UtilMsg\_Response.Types.ItemDetail\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_UtilMsg\_Response.Types.ItemDetail\>, 
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
[EnumerableExtensions.In<CUserMessage\_UtilMsg\_Response.Types.ItemDetail\>\(CUserMessage\_UtilMsg\_Response.Types.ItemDetail, params CUserMessage\_UtilMsg\_Response.Types.ItemDetail\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail__ctor"></a> ItemDetail\(\)

```csharp
public ItemDetail()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail__ctor_Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_"></a> ItemDetail\(ItemDetail\)

```csharp
public ItemDetail(CUserMessage_UtilMsg_Response.Types.ItemDetail other)
```

#### Parameters

`other` [CUserMessage\_UtilMsg\_Response](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.md).[ItemDetail](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.ItemDetail.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_CrcFieldNumber"></a> CrcFieldNumber

```csharp
public const int CrcFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_HashFieldNumber"></a> HashFieldNumber

```csharp
public const int HashFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Crc"></a> Crc

```csharp
public int Crc { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_HasCrc"></a> HasCrc

```csharp
public bool HasCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Hash"></a> Hash

```csharp
public int Hash { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_HasHash"></a> HasHash

```csharp
public bool HasHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Index"></a> Index

```csharp
public int Index { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_UtilMsg_Response.Types.ItemDetail> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_UtilMsg\_Response](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.md).[ItemDetail](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.ItemDetail.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_ClearCrc"></a> ClearCrc\(\)

```csharp
public void ClearCrc()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_ClearHash"></a> ClearHash\(\)

```csharp
public void ClearHash()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Clone"></a> Clone\(\)

```csharp
public CUserMessage_UtilMsg_Response.Types.ItemDetail Clone()
```

#### Returns

 [CUserMessage\_UtilMsg\_Response](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.md).[ItemDetail](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.ItemDetail.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_Equals_Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_"></a> Equals\(ItemDetail\)

```csharp
public bool Equals(CUserMessage_UtilMsg_Response.Types.ItemDetail other)
```

#### Parameters

`other` [CUserMessage\_UtilMsg\_Response](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.md).[ItemDetail](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.ItemDetail.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_"></a> MergeFrom\(ItemDetail\)

```csharp
public void MergeFrom(CUserMessage_UtilMsg_Response.Types.ItemDetail other)
```

#### Parameters

`other` [CUserMessage\_UtilMsg\_Response](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.md).[ItemDetail](Divine.Protobufs.Dota2.CUserMessage\_UtilMsg\_Response.Types.ItemDetail.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UtilMsg_Response_Types_ItemDetail_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

