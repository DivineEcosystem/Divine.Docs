# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert"></a> Class CDOTAClientMsg\_TipAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_TipAlert : IMessage<CDOTAClientMsg_TipAlert>, IEquatable<CDOTAClientMsg_TipAlert>, IDeepCloneable<CDOTAClientMsg_TipAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TipAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_TipAlert\>, 
[IEquatable<CDOTAClientMsg\_TipAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_TipAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_TipAlert\>\(CDOTAClientMsg\_TipAlert, params CDOTAClientMsg\_TipAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert__ctor"></a> CDOTAClientMsg\_TipAlert\(\)

```csharp
public CDOTAClientMsg_TipAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_"></a> CDOTAClientMsg\_TipAlert\(CDOTAClientMsg\_TipAlert\)

```csharp
public CDOTAClientMsg_TipAlert(CDOTAClientMsg_TipAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TipAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_TipTextFieldNumber"></a> TipTextFieldNumber

```csharp
public const int TipTextFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_HasTipText"></a> HasTipText

```csharp
public bool HasTipText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_TipAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TipAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_TipText"></a> TipText

```csharp
public string TipText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_ClearTipText"></a> ClearTipText\(\)

```csharp
public void ClearTipText()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_TipAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TipAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_"></a> Equals\(CDOTAClientMsg\_TipAlert\)

```csharp
public bool Equals(CDOTAClientMsg_TipAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TipAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_"></a> MergeFrom\(CDOTAClientMsg\_TipAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_TipAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TipAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TipAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

