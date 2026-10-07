# <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData"></a> Class CSVCMsg\_EncryptedData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_EncryptedData : IMessage<CSVCMsg_EncryptedData>, IEquatable<CSVCMsg_EncryptedData>, IDeepCloneable<CSVCMsg_EncryptedData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_EncryptedData](Divine.Protobufs.Dota2.CSVCMsg\_EncryptedData.md)

#### Implements

IMessage<CSVCMsg\_EncryptedData\>, 
[IEquatable<CSVCMsg\_EncryptedData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_EncryptedData\>, 
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
[EnumerableExtensions.In<CSVCMsg\_EncryptedData\>\(CSVCMsg\_EncryptedData, params CSVCMsg\_EncryptedData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData__ctor"></a> CSVCMsg\_EncryptedData\(\)

```csharp
public CSVCMsg_EncryptedData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData__ctor_Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_"></a> CSVCMsg\_EncryptedData\(CSVCMsg\_EncryptedData\)

```csharp
public CSVCMsg_EncryptedData(CSVCMsg_EncryptedData other)
```

#### Parameters

`other` [CSVCMsg\_EncryptedData](Divine.Protobufs.Dota2.CSVCMsg\_EncryptedData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_EncryptedFieldNumber"></a> EncryptedFieldNumber

```csharp
public const int EncryptedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_KeyTypeFieldNumber"></a> KeyTypeFieldNumber

```csharp
public const int KeyTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_Encrypted"></a> Encrypted

```csharp
public ByteString Encrypted { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_HasEncrypted"></a> HasEncrypted

```csharp
public bool HasEncrypted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_HasKeyType"></a> HasKeyType

```csharp
public bool HasKeyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_KeyType"></a> KeyType

```csharp
public int KeyType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_EncryptedData> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_EncryptedData](Divine.Protobufs.Dota2.CSVCMsg\_EncryptedData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_ClearEncrypted"></a> ClearEncrypted\(\)

```csharp
public void ClearEncrypted()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_ClearKeyType"></a> ClearKeyType\(\)

```csharp
public void ClearKeyType()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_EncryptedData Clone()
```

#### Returns

 [CSVCMsg\_EncryptedData](Divine.Protobufs.Dota2.CSVCMsg\_EncryptedData.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_Equals_Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_"></a> Equals\(CSVCMsg\_EncryptedData\)

```csharp
public bool Equals(CSVCMsg_EncryptedData other)
```

#### Parameters

`other` [CSVCMsg\_EncryptedData](Divine.Protobufs.Dota2.CSVCMsg\_EncryptedData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_"></a> MergeFrom\(CSVCMsg\_EncryptedData\)

```csharp
public void MergeFrom(CSVCMsg_EncryptedData other)
```

#### Parameters

`other` [CSVCMsg\_EncryptedData](Divine.Protobufs.Dota2.CSVCMsg\_EncryptedData.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_EncryptedData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

