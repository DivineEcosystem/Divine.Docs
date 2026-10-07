# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create"></a> Class CDOTAUserMsg\_CustomHudElement\_Create

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CustomHudElement_Create : IMessage<CDOTAUserMsg_CustomHudElement_Create>, IEquatable<CDOTAUserMsg_CustomHudElement_Create>, IDeepCloneable<CDOTAUserMsg_CustomHudElement_Create>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CustomHudElement\_Create](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Create.md)

#### Implements

IMessage<CDOTAUserMsg\_CustomHudElement\_Create\>, 
[IEquatable<CDOTAUserMsg\_CustomHudElement\_Create\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CustomHudElement\_Create\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CustomHudElement\_Create\>\(CDOTAUserMsg\_CustomHudElement\_Create, params CDOTAUserMsg\_CustomHudElement\_Create\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create__ctor"></a> CDOTAUserMsg\_CustomHudElement\_Create\(\)

```csharp
public CDOTAUserMsg_CustomHudElement_Create()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_"></a> CDOTAUserMsg\_CustomHudElement\_Create\(CDOTAUserMsg\_CustomHudElement\_Create\)

```csharp
public CDOTAUserMsg_CustomHudElement_Create(CDOTAUserMsg_CustomHudElement_Create other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Create](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Create.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_ElementIdFieldNumber"></a> ElementIdFieldNumber

```csharp
public const int ElementIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_LayoutFilenameFieldNumber"></a> LayoutFilenameFieldNumber

```csharp
public const int LayoutFilenameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_ElementId"></a> ElementId

```csharp
public string ElementId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_HasElementId"></a> HasElementId

```csharp
public bool HasElementId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_HasLayoutFilename"></a> HasLayoutFilename

```csharp
public bool HasLayoutFilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_LayoutFilename"></a> LayoutFilename

```csharp
public string LayoutFilename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CustomHudElement_Create> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CustomHudElement\_Create](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Create.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_ClearElementId"></a> ClearElementId\(\)

```csharp
public void ClearElementId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_ClearLayoutFilename"></a> ClearLayoutFilename\(\)

```csharp
public void ClearLayoutFilename()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CustomHudElement_Create Clone()
```

#### Returns

 [CDOTAUserMsg\_CustomHudElement\_Create](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Create.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_"></a> Equals\(CDOTAUserMsg\_CustomHudElement\_Create\)

```csharp
public bool Equals(CDOTAUserMsg_CustomHudElement_Create other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Create](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Create.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_"></a> MergeFrom\(CDOTAUserMsg\_CustomHudElement\_Create\)

```csharp
public void MergeFrom(CDOTAUserMsg_CustomHudElement_Create other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHudElement\_Create](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHudElement\_Create.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHudElement_Create_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

