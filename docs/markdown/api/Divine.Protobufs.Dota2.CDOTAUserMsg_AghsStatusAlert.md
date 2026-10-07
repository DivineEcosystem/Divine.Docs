# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert"></a> Class CDOTAUserMsg\_AghsStatusAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_AghsStatusAlert : IMessage<CDOTAUserMsg_AghsStatusAlert>, IEquatable<CDOTAUserMsg_AghsStatusAlert>, IDeepCloneable<CDOTAUserMsg_AghsStatusAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_AghsStatusAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_AghsStatusAlert\>, 
[IEquatable<CDOTAUserMsg\_AghsStatusAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_AghsStatusAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_AghsStatusAlert\>\(CDOTAUserMsg\_AghsStatusAlert, params CDOTAUserMsg\_AghsStatusAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert__ctor"></a> CDOTAUserMsg\_AghsStatusAlert\(\)

```csharp
public CDOTAUserMsg_AghsStatusAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_"></a> CDOTAUserMsg\_AghsStatusAlert\(CDOTAUserMsg\_AghsStatusAlert\)

```csharp
public CDOTAUserMsg_AghsStatusAlert(CDOTAUserMsg_AghsStatusAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_AghsStatusAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_AlertTypeFieldNumber"></a> AlertTypeFieldNumber

```csharp
public const int AlertTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasScepterFieldNumber"></a> HasScepterFieldNumber

```csharp
public const int HasScepterFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasShardFieldNumber"></a> HasShardFieldNumber

```csharp
public const int HasShardFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_AlertType"></a> AlertType

```csharp
public uint AlertType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasAlertType"></a> HasAlertType

```csharp
public bool HasAlertType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasHasScepter"></a> HasHasScepter

```csharp
public bool HasHasScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasHasShard"></a> HasHasShard

```csharp
public bool HasHasShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasScepter"></a> HasScepter

```csharp
public bool HasScepter { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasShard"></a> HasShard

```csharp
public bool HasShard { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_AghsStatusAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_AghsStatusAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ClearAlertType"></a> ClearAlertType\(\)

```csharp
public void ClearAlertType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ClearHasScepter"></a> ClearHasScepter\(\)

```csharp
public void ClearHasScepter()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ClearHasShard"></a> ClearHasShard\(\)

```csharp
public void ClearHasShard()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_AghsStatusAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_AghsStatusAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_"></a> Equals\(CDOTAUserMsg\_AghsStatusAlert\)

```csharp
public bool Equals(CDOTAUserMsg_AghsStatusAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_AghsStatusAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_"></a> MergeFrom\(CDOTAUserMsg\_AghsStatusAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_AghsStatusAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_AghsStatusAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_AghsStatusAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AghsStatusAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

