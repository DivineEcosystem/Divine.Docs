# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick"></a> Class CDOTAUserMsg\_SpectatorPlayerClick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SpectatorPlayerClick : IMessage<CDOTAUserMsg_SpectatorPlayerClick>, IEquatable<CDOTAUserMsg_SpectatorPlayerClick>, IDeepCloneable<CDOTAUserMsg_SpectatorPlayerClick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SpectatorPlayerClick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpectatorPlayerClick.md)

#### Implements

IMessage<CDOTAUserMsg\_SpectatorPlayerClick\>, 
[IEquatable<CDOTAUserMsg\_SpectatorPlayerClick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SpectatorPlayerClick\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SpectatorPlayerClick\>\(CDOTAUserMsg\_SpectatorPlayerClick, params CDOTAUserMsg\_SpectatorPlayerClick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick__ctor"></a> CDOTAUserMsg\_SpectatorPlayerClick\(\)

```csharp
public CDOTAUserMsg_SpectatorPlayerClick()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_"></a> CDOTAUserMsg\_SpectatorPlayerClick\(CDOTAUserMsg\_SpectatorPlayerClick\)

```csharp
public CDOTAUserMsg_SpectatorPlayerClick(CDOTAUserMsg_SpectatorPlayerClick other)
```

#### Parameters

`other` [CDOTAUserMsg\_SpectatorPlayerClick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpectatorPlayerClick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_EntindexFieldNumber"></a> EntindexFieldNumber

```csharp
public const int EntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_OrderTypeFieldNumber"></a> OrderTypeFieldNumber

```csharp
public const int OrderTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_TargetIndexFieldNumber"></a> TargetIndexFieldNumber

```csharp
public const int TargetIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_Entindex"></a> Entindex

```csharp
public int Entindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_HasEntindex"></a> HasEntindex

```csharp
public bool HasEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_HasOrderType"></a> HasOrderType

```csharp
public bool HasOrderType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_HasTargetIndex"></a> HasTargetIndex

```csharp
public bool HasTargetIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_OrderType"></a> OrderType

```csharp
public int OrderType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SpectatorPlayerClick> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SpectatorPlayerClick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpectatorPlayerClick.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_TargetIndex"></a> TargetIndex

```csharp
public int TargetIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_ClearEntindex"></a> ClearEntindex\(\)

```csharp
public void ClearEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_ClearOrderType"></a> ClearOrderType\(\)

```csharp
public void ClearOrderType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_ClearTargetIndex"></a> ClearTargetIndex\(\)

```csharp
public void ClearTargetIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SpectatorPlayerClick Clone()
```

#### Returns

 [CDOTAUserMsg\_SpectatorPlayerClick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpectatorPlayerClick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_"></a> Equals\(CDOTAUserMsg\_SpectatorPlayerClick\)

```csharp
public bool Equals(CDOTAUserMsg_SpectatorPlayerClick other)
```

#### Parameters

`other` [CDOTAUserMsg\_SpectatorPlayerClick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpectatorPlayerClick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_"></a> MergeFrom\(CDOTAUserMsg\_SpectatorPlayerClick\)

```csharp
public void MergeFrom(CDOTAUserMsg_SpectatorPlayerClick other)
```

#### Parameters

`other` [CDOTAUserMsg\_SpectatorPlayerClick](Divine.Protobufs.Dota2.CDOTAUserMsg\_SpectatorPlayerClick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SpectatorPlayerClick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

