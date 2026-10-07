# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert"></a> Class CDOTAClientMsg\_InnateAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_InnateAlert : IMessage<CDOTAClientMsg_InnateAlert>, IEquatable<CDOTAClientMsg_InnateAlert>, IDeepCloneable<CDOTAClientMsg_InnateAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_InnateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_InnateAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_InnateAlert\>, 
[IEquatable<CDOTAClientMsg\_InnateAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_InnateAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_InnateAlert\>\(CDOTAClientMsg\_InnateAlert, params CDOTAClientMsg\_InnateAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert__ctor"></a> CDOTAClientMsg\_InnateAlert\(\)

```csharp
public CDOTAClientMsg_InnateAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_"></a> CDOTAClientMsg\_InnateAlert\(CDOTAClientMsg\_InnateAlert\)

```csharp
public CDOTAClientMsg_InnateAlert(CDOTAClientMsg_InnateAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_InnateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_InnateAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_AbilityEntindexFieldNumber"></a> AbilityEntindexFieldNumber

```csharp
public const int AbilityEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_CtrlHeldFieldNumber"></a> CtrlHeldFieldNumber

```csharp
public const int CtrlHeldFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_AbilityEntindex"></a> AbilityEntindex

```csharp
public uint AbilityEntindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_CtrlHeld"></a> CtrlHeld

```csharp
public bool CtrlHeld { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_HasAbilityEntindex"></a> HasAbilityEntindex

```csharp
public bool HasAbilityEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_HasCtrlHeld"></a> HasCtrlHeld

```csharp
public bool HasCtrlHeld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_InnateAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_InnateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_InnateAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_ClearAbilityEntindex"></a> ClearAbilityEntindex\(\)

```csharp
public void ClearAbilityEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_ClearCtrlHeld"></a> ClearCtrlHeld\(\)

```csharp
public void ClearCtrlHeld()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_InnateAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_InnateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_InnateAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_"></a> Equals\(CDOTAClientMsg\_InnateAlert\)

```csharp
public bool Equals(CDOTAClientMsg_InnateAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_InnateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_InnateAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_"></a> MergeFrom\(CDOTAClientMsg\_InnateAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_InnateAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_InnateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_InnateAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InnateAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

