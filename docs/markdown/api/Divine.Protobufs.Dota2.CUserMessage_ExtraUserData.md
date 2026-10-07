# <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData"></a> Class CUserMessage\_ExtraUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_ExtraUserData : IMessage<CUserMessage_ExtraUserData>, IEquatable<CUserMessage_ExtraUserData>, IDeepCloneable<CUserMessage_ExtraUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_ExtraUserData](Divine.Protobufs.Dota2.CUserMessage\_ExtraUserData.md)

#### Implements

IMessage<CUserMessage\_ExtraUserData\>, 
[IEquatable<CUserMessage\_ExtraUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_ExtraUserData\>, 
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
[EnumerableExtensions.In<CUserMessage\_ExtraUserData\>\(CUserMessage\_ExtraUserData, params CUserMessage\_ExtraUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData__ctor"></a> CUserMessage\_ExtraUserData\(\)

```csharp
public CUserMessage_ExtraUserData()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData__ctor_Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_"></a> CUserMessage\_ExtraUserData\(CUserMessage\_ExtraUserData\)

```csharp
public CUserMessage_ExtraUserData(CUserMessage_ExtraUserData other)
```

#### Parameters

`other` [CUserMessage\_ExtraUserData](Divine.Protobufs.Dota2.CUserMessage\_ExtraUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Detail1FieldNumber"></a> Detail1FieldNumber

```csharp
public const int Detail1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Detail2FieldNumber"></a> Detail2FieldNumber

```csharp
public const int Detail2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_ItemFieldNumber"></a> ItemFieldNumber

```csharp
public const int ItemFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Value1FieldNumber"></a> Value1FieldNumber

```csharp
public const int Value1FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Value2FieldNumber"></a> Value2FieldNumber

```csharp
public const int Value2FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Detail1"></a> Detail1

```csharp
public RepeatedField<ByteString> Detail1 { get; }
```

#### Property Value

 RepeatedField<ByteString\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Detail2"></a> Detail2

```csharp
public RepeatedField<ByteString> Detail2 { get; }
```

#### Property Value

 RepeatedField<ByteString\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_HasItem"></a> HasItem

```csharp
public bool HasItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_HasValue1"></a> HasValue1

```csharp
public bool HasValue1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_HasValue2"></a> HasValue2

```csharp
public bool HasValue2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Item"></a> Item

```csharp
public int Item { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_ExtraUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_ExtraUserData](Divine.Protobufs.Dota2.CUserMessage\_ExtraUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Value1"></a> Value1

```csharp
public long Value1 { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Value2"></a> Value2

```csharp
public long Value2 { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_ClearItem"></a> ClearItem\(\)

```csharp
public void ClearItem()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_ClearValue1"></a> ClearValue1\(\)

```csharp
public void ClearValue1()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_ClearValue2"></a> ClearValue2\(\)

```csharp
public void ClearValue2()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Clone"></a> Clone\(\)

```csharp
public CUserMessage_ExtraUserData Clone()
```

#### Returns

 [CUserMessage\_ExtraUserData](Divine.Protobufs.Dota2.CUserMessage\_ExtraUserData.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_Equals_Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_"></a> Equals\(CUserMessage\_ExtraUserData\)

```csharp
public bool Equals(CUserMessage_ExtraUserData other)
```

#### Parameters

`other` [CUserMessage\_ExtraUserData](Divine.Protobufs.Dota2.CUserMessage\_ExtraUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_"></a> MergeFrom\(CUserMessage\_ExtraUserData\)

```csharp
public void MergeFrom(CUserMessage_ExtraUserData other)
```

#### Parameters

`other` [CUserMessage\_ExtraUserData](Divine.Protobufs.Dota2.CUserMessage\_ExtraUserData.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_ExtraUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

