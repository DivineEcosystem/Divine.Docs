# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit"></a> Class CDOTAUserMsg\_PauseMinigameData.Types.DataBit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_PauseMinigameData.Types.DataBit : IMessage<CDOTAUserMsg_PauseMinigameData.Types.DataBit>, IEquatable<CDOTAUserMsg_PauseMinigameData.Types.DataBit>, IDeepCloneable<CDOTAUserMsg_PauseMinigameData.Types.DataBit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_PauseMinigameData.Types.DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)

#### Implements

IMessage<CDOTAUserMsg\_PauseMinigameData.Types.DataBit\>, 
[IEquatable<CDOTAUserMsg\_PauseMinigameData.Types.DataBit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_PauseMinigameData.Types.DataBit\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_PauseMinigameData.Types.DataBit\>\(CDOTAUserMsg\_PauseMinigameData.Types.DataBit, params CDOTAUserMsg\_PauseMinigameData.Types.DataBit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit__ctor"></a> DataBit\(\)

```csharp
public DataBit()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_"></a> DataBit\(DataBit\)

```csharp
public DataBit(CDOTAUserMsg_PauseMinigameData.Types.DataBit other)
```

#### Parameters

`other` [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.md).[DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_DataExtraFieldNumber"></a> DataExtraFieldNumber

```csharp
public const int DataExtraFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Data"></a> Data

```csharp
public int Data { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_DataExtra"></a> DataExtra

```csharp
public long DataExtra { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_HasDataExtra"></a> HasDataExtra

```csharp
public bool HasDataExtra { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Index"></a> Index

```csharp
public uint Index { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_PauseMinigameData.Types.DataBit> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.md).[DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_ClearDataExtra"></a> ClearDataExtra\(\)

```csharp
public void ClearDataExtra()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_PauseMinigameData.Types.DataBit Clone()
```

#### Returns

 [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.md).[DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_"></a> Equals\(DataBit\)

```csharp
public bool Equals(CDOTAUserMsg_PauseMinigameData.Types.DataBit other)
```

#### Parameters

`other` [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.md).[DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_"></a> MergeFrom\(DataBit\)

```csharp
public void MergeFrom(CDOTAUserMsg_PauseMinigameData.Types.DataBit other)
```

#### Parameters

`other` [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.md).[DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Types_DataBit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

