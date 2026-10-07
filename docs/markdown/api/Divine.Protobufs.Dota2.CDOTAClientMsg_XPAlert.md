# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert"></a> Class CDOTAClientMsg\_XPAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_XPAlert : IMessage<CDOTAClientMsg_XPAlert>, IEquatable<CDOTAClientMsg_XPAlert>, IDeepCloneable<CDOTAClientMsg_XPAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_XPAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_XPAlert\>, 
[IEquatable<CDOTAClientMsg\_XPAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_XPAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_XPAlert\>\(CDOTAClientMsg\_XPAlert, params CDOTAClientMsg\_XPAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert__ctor"></a> CDOTAClientMsg\_XPAlert\(\)

```csharp
public CDOTAClientMsg_XPAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_"></a> CDOTAClientMsg\_XPAlert\(CDOTAClientMsg\_XPAlert\)

```csharp
public CDOTAClientMsg_XPAlert(CDOTAClientMsg_XPAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_XPAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_DamageTakenFieldNumber"></a> DamageTakenFieldNumber

```csharp
public const int DamageTakenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_DamageTaken"></a> DamageTaken

```csharp
public uint DamageTaken { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_HasDamageTaken"></a> HasDamageTaken

```csharp
public bool HasDamageTaken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_XPAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_XPAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_ClearDamageTaken"></a> ClearDamageTaken\(\)

```csharp
public void ClearDamageTaken()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_XPAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_XPAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_"></a> Equals\(CDOTAClientMsg\_XPAlert\)

```csharp
public bool Equals(CDOTAClientMsg_XPAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_XPAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_"></a> MergeFrom\(CDOTAClientMsg\_XPAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_XPAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_XPAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_XPAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

