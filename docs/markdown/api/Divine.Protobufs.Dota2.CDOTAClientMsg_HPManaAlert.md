# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert"></a> Class CDOTAClientMsg\_HPManaAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_HPManaAlert : IMessage<CDOTAClientMsg_HPManaAlert>, IEquatable<CDOTAClientMsg_HPManaAlert>, IDeepCloneable<CDOTAClientMsg_HPManaAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_HPManaAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_HPManaAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_HPManaAlert\>, 
[IEquatable<CDOTAClientMsg\_HPManaAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_HPManaAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_HPManaAlert\>\(CDOTAClientMsg\_HPManaAlert, params CDOTAClientMsg\_HPManaAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert__ctor"></a> CDOTAClientMsg\_HPManaAlert\(\)

```csharp
public CDOTAClientMsg_HPManaAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_"></a> CDOTAClientMsg\_HPManaAlert\(CDOTAClientMsg\_HPManaAlert\)

```csharp
public CDOTAClientMsg_HPManaAlert(CDOTAClientMsg_HPManaAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_HPManaAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_HPManaAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_ShowRawValuesFieldNumber"></a> ShowRawValuesFieldNumber

```csharp
public const int ShowRawValuesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_HasShowRawValues"></a> HasShowRawValues

```csharp
public bool HasShowRawValues { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_HPManaAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_HPManaAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_HPManaAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_ShowRawValues"></a> ShowRawValues

```csharp
public bool ShowRawValues { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_ClearShowRawValues"></a> ClearShowRawValues\(\)

```csharp
public void ClearShowRawValues()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_HPManaAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_HPManaAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_HPManaAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_"></a> Equals\(CDOTAClientMsg\_HPManaAlert\)

```csharp
public bool Equals(CDOTAClientMsg_HPManaAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_HPManaAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_HPManaAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_"></a> MergeFrom\(CDOTAClientMsg\_HPManaAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_HPManaAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_HPManaAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_HPManaAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HPManaAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

