# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit"></a> Class CDOTAUserMsg\_ReplaceQueryUnit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ReplaceQueryUnit : IMessage<CDOTAUserMsg_ReplaceQueryUnit>, IEquatable<CDOTAUserMsg_ReplaceQueryUnit>, IDeepCloneable<CDOTAUserMsg_ReplaceQueryUnit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ReplaceQueryUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReplaceQueryUnit.md)

#### Implements

IMessage<CDOTAUserMsg\_ReplaceQueryUnit\>, 
[IEquatable<CDOTAUserMsg\_ReplaceQueryUnit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ReplaceQueryUnit\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ReplaceQueryUnit\>\(CDOTAUserMsg\_ReplaceQueryUnit, params CDOTAUserMsg\_ReplaceQueryUnit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit__ctor"></a> CDOTAUserMsg\_ReplaceQueryUnit\(\)

```csharp
public CDOTAUserMsg_ReplaceQueryUnit()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_"></a> CDOTAUserMsg\_ReplaceQueryUnit\(CDOTAUserMsg\_ReplaceQueryUnit\)

```csharp
public CDOTAUserMsg_ReplaceQueryUnit(CDOTAUserMsg_ReplaceQueryUnit other)
```

#### Parameters

`other` [CDOTAUserMsg\_ReplaceQueryUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReplaceQueryUnit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_SourceEntindexFieldNumber"></a> SourceEntindexFieldNumber

```csharp
public const int SourceEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_HasSourceEntindex"></a> HasSourceEntindex

```csharp
public bool HasSourceEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ReplaceQueryUnit> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ReplaceQueryUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReplaceQueryUnit.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_SourceEntindex"></a> SourceEntindex

```csharp
public int SourceEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_ClearSourceEntindex"></a> ClearSourceEntindex\(\)

```csharp
public void ClearSourceEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ReplaceQueryUnit Clone()
```

#### Returns

 [CDOTAUserMsg\_ReplaceQueryUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReplaceQueryUnit.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_"></a> Equals\(CDOTAUserMsg\_ReplaceQueryUnit\)

```csharp
public bool Equals(CDOTAUserMsg_ReplaceQueryUnit other)
```

#### Parameters

`other` [CDOTAUserMsg\_ReplaceQueryUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReplaceQueryUnit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_"></a> MergeFrom\(CDOTAUserMsg\_ReplaceQueryUnit\)

```csharp
public void MergeFrom(CDOTAUserMsg_ReplaceQueryUnit other)
```

#### Parameters

`other` [CDOTAUserMsg\_ReplaceQueryUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_ReplaceQueryUnit.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ReplaceQueryUnit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

