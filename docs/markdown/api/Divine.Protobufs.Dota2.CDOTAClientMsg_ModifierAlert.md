# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert"></a> Class CDOTAClientMsg\_ModifierAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ModifierAlert : IMessage<CDOTAClientMsg_ModifierAlert>, IEquatable<CDOTAClientMsg_ModifierAlert>, IDeepCloneable<CDOTAClientMsg_ModifierAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ModifierAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_ModifierAlert\>, 
[IEquatable<CDOTAClientMsg\_ModifierAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ModifierAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ModifierAlert\>\(CDOTAClientMsg\_ModifierAlert, params CDOTAClientMsg\_ModifierAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert__ctor"></a> CDOTAClientMsg\_ModifierAlert\(\)

```csharp
public CDOTAClientMsg_ModifierAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_"></a> CDOTAClientMsg\_ModifierAlert\(CDOTAClientMsg\_ModifierAlert\)

```csharp
public CDOTAClientMsg_ModifierAlert(CDOTAClientMsg_ModifierAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ModifierAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_BuffInternalIndexFieldNumber"></a> BuffInternalIndexFieldNumber

```csharp
public const int BuffInternalIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_BuffInternalIndex"></a> BuffInternalIndex

```csharp
public int BuffInternalIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_HasBuffInternalIndex"></a> HasBuffInternalIndex

```csharp
public bool HasBuffInternalIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ModifierAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ModifierAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_ClearBuffInternalIndex"></a> ClearBuffInternalIndex\(\)

```csharp
public void ClearBuffInternalIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ModifierAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ModifierAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_"></a> Equals\(CDOTAClientMsg\_ModifierAlert\)

```csharp
public bool Equals(CDOTAClientMsg_ModifierAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ModifierAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_"></a> MergeFrom\(CDOTAClientMsg\_ModifierAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_ModifierAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_ModifierAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ModifierAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

