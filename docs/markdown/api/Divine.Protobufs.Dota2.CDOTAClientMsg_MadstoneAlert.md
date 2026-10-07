# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert"></a> Class CDOTAClientMsg\_MadstoneAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_MadstoneAlert : IMessage<CDOTAClientMsg_MadstoneAlert>, IEquatable<CDOTAClientMsg_MadstoneAlert>, IDeepCloneable<CDOTAClientMsg_MadstoneAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MadstoneAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_MadstoneAlert\>, 
[IEquatable<CDOTAClientMsg\_MadstoneAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_MadstoneAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_MadstoneAlert\>\(CDOTAClientMsg\_MadstoneAlert, params CDOTAClientMsg\_MadstoneAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert__ctor"></a> CDOTAClientMsg\_MadstoneAlert\(\)

```csharp
public CDOTAClientMsg_MadstoneAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_"></a> CDOTAClientMsg\_MadstoneAlert\(CDOTAClientMsg\_MadstoneAlert\)

```csharp
public CDOTAClientMsg_MadstoneAlert(CDOTAClientMsg_MadstoneAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MadstoneAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_MadstoneAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MadstoneAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_MadstoneAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MadstoneAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_"></a> Equals\(CDOTAClientMsg\_MadstoneAlert\)

```csharp
public bool Equals(CDOTAClientMsg_MadstoneAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MadstoneAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_"></a> MergeFrom\(CDOTAClientMsg\_MadstoneAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_MadstoneAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_MadstoneAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MadstoneAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

