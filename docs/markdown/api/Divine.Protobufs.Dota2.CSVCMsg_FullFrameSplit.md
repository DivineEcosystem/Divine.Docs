# <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit"></a> Class CSVCMsg\_FullFrameSplit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_FullFrameSplit : IMessage<CSVCMsg_FullFrameSplit>, IEquatable<CSVCMsg_FullFrameSplit>, IDeepCloneable<CSVCMsg_FullFrameSplit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_FullFrameSplit](Divine.Protobufs.Dota2.CSVCMsg\_FullFrameSplit.md)

#### Implements

IMessage<CSVCMsg\_FullFrameSplit\>, 
[IEquatable<CSVCMsg\_FullFrameSplit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_FullFrameSplit\>, 
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
[EnumerableExtensions.In<CSVCMsg\_FullFrameSplit\>\(CSVCMsg\_FullFrameSplit, params CSVCMsg\_FullFrameSplit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit__ctor"></a> CSVCMsg\_FullFrameSplit\(\)

```csharp
public CSVCMsg_FullFrameSplit()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit__ctor_Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_"></a> CSVCMsg\_FullFrameSplit\(CSVCMsg\_FullFrameSplit\)

```csharp
public CSVCMsg_FullFrameSplit(CSVCMsg_FullFrameSplit other)
```

#### Parameters

`other` [CSVCMsg\_FullFrameSplit](Divine.Protobufs.Dota2.CSVCMsg\_FullFrameSplit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_SectionFieldNumber"></a> SectionFieldNumber

```csharp
public const int SectionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_TotalFieldNumber"></a> TotalFieldNumber

```csharp
public const int TotalFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_HasSection"></a> HasSection

```csharp
public bool HasSection { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_HasTotal"></a> HasTotal

```csharp
public bool HasTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_FullFrameSplit> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_FullFrameSplit](Divine.Protobufs.Dota2.CSVCMsg\_FullFrameSplit.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Section"></a> Section

```csharp
public int Section { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Tick"></a> Tick

```csharp
public int Tick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Total"></a> Total

```csharp
public int Total { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_ClearSection"></a> ClearSection\(\)

```csharp
public void ClearSection()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_ClearTotal"></a> ClearTotal\(\)

```csharp
public void ClearTotal()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_FullFrameSplit Clone()
```

#### Returns

 [CSVCMsg\_FullFrameSplit](Divine.Protobufs.Dota2.CSVCMsg\_FullFrameSplit.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_Equals_Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_"></a> Equals\(CSVCMsg\_FullFrameSplit\)

```csharp
public bool Equals(CSVCMsg_FullFrameSplit other)
```

#### Parameters

`other` [CSVCMsg\_FullFrameSplit](Divine.Protobufs.Dota2.CSVCMsg\_FullFrameSplit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_"></a> MergeFrom\(CSVCMsg\_FullFrameSplit\)

```csharp
public void MergeFrom(CSVCMsg_FullFrameSplit other)
```

#### Parameters

`other` [CSVCMsg\_FullFrameSplit](Divine.Protobufs.Dota2.CSVCMsg\_FullFrameSplit.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FullFrameSplit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

