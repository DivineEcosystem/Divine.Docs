# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert"></a> Class CDOTAClientMsg\_AghsStatusAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AghsStatusAlert : IMessage<CDOTAClientMsg_AghsStatusAlert>, IEquatable<CDOTAClientMsg_AghsStatusAlert>, IDeepCloneable<CDOTAClientMsg_AghsStatusAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AghsStatusAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_AghsStatusAlert\>, 
[IEquatable<CDOTAClientMsg\_AghsStatusAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AghsStatusAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AghsStatusAlert\>\(CDOTAClientMsg\_AghsStatusAlert, params CDOTAClientMsg\_AghsStatusAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert__ctor"></a> CDOTAClientMsg\_AghsStatusAlert\(\)

```csharp
public CDOTAClientMsg_AghsStatusAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_"></a> CDOTAClientMsg\_AghsStatusAlert\(CDOTAClientMsg\_AghsStatusAlert\)

```csharp
public CDOTAClientMsg_AghsStatusAlert(CDOTAClientMsg_AghsStatusAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AghsStatusAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_AlertTypeFieldNumber"></a> AlertTypeFieldNumber

```csharp
public const int AlertTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_AlertType"></a> AlertType

```csharp
public uint AlertType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_HasAlertType"></a> HasAlertType

```csharp
public bool HasAlertType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AghsStatusAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AghsStatusAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_ClearAlertType"></a> ClearAlertType\(\)

```csharp
public void ClearAlertType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AghsStatusAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AghsStatusAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_"></a> Equals\(CDOTAClientMsg\_AghsStatusAlert\)

```csharp
public bool Equals(CDOTAClientMsg_AghsStatusAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AghsStatusAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_"></a> MergeFrom\(CDOTAClientMsg\_AghsStatusAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_AghsStatusAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AghsStatusAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AghsStatusAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

