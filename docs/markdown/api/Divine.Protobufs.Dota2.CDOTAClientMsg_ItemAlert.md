# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert"></a> Class CDOTAClientMsg\_ItemAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ItemAlert : IMessage<CDOTAClientMsg_ItemAlert>, IEquatable<CDOTAClientMsg_ItemAlert>, IDeepCloneable<CDOTAClientMsg_ItemAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ItemAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_ItemAlert\>, 
[IEquatable<CDOTAClientMsg\_ItemAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ItemAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ItemAlert\>\(CDOTAClientMsg\_ItemAlert, params CDOTAClientMsg\_ItemAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert__ctor"></a> CDOTAClientMsg\_ItemAlert\(\)

```csharp
public CDOTAClientMsg_ItemAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_"></a> CDOTAClientMsg\_ItemAlert\(CDOTAClientMsg\_ItemAlert\)

```csharp
public CDOTAClientMsg_ItemAlert(CDOTAClientMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ItemAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_ItemAlertFieldNumber"></a> ItemAlertFieldNumber

```csharp
public const int ItemAlertFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_ItemAlert"></a> ItemAlert

```csharp
public CDOTAMsg_ItemAlert ItemAlert { get; set; }
```

#### Property Value

 [CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ItemAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ItemAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ItemAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_"></a> Equals\(CDOTAClientMsg\_ItemAlert\)

```csharp
public bool Equals(CDOTAClientMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ItemAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_"></a> MergeFrom\(CDOTAClientMsg\_ItemAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ItemAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

