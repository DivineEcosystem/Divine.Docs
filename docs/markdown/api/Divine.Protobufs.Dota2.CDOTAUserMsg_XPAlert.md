# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert"></a> Class CDOTAUserMsg\_XPAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_XPAlert : IMessage<CDOTAUserMsg_XPAlert>, IEquatable<CDOTAUserMsg_XPAlert>, IDeepCloneable<CDOTAUserMsg_XPAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_XPAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_XPAlert\>, 
[IEquatable<CDOTAUserMsg\_XPAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_XPAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_XPAlert\>\(CDOTAUserMsg\_XPAlert, params CDOTAUserMsg\_XPAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert__ctor"></a> CDOTAUserMsg\_XPAlert\(\)

```csharp
public CDOTAUserMsg_XPAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_"></a> CDOTAUserMsg\_XPAlert\(CDOTAUserMsg\_XPAlert\)

```csharp
public CDOTAUserMsg_XPAlert(CDOTAUserMsg_XPAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_XPAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_XPAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_XPAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_XPAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_XPAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_"></a> Equals\(CDOTAUserMsg\_XPAlert\)

```csharp
public bool Equals(CDOTAUserMsg_XPAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_XPAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_"></a> MergeFrom\(CDOTAUserMsg\_XPAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_XPAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_XPAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_XPAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_XPAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

