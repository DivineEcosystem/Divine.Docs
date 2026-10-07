# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert"></a> Class CDOTAUserMsg\_EmptyItemSlotAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_EmptyItemSlotAlert : IMessage<CDOTAUserMsg_EmptyItemSlotAlert>, IEquatable<CDOTAUserMsg_EmptyItemSlotAlert>, IDeepCloneable<CDOTAUserMsg_EmptyItemSlotAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_EmptyItemSlotAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyItemSlotAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_EmptyItemSlotAlert\>, 
[IEquatable<CDOTAUserMsg\_EmptyItemSlotAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_EmptyItemSlotAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_EmptyItemSlotAlert\>\(CDOTAUserMsg\_EmptyItemSlotAlert, params CDOTAUserMsg\_EmptyItemSlotAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert__ctor"></a> CDOTAUserMsg\_EmptyItemSlotAlert\(\)

```csharp
public CDOTAUserMsg_EmptyItemSlotAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_"></a> CDOTAUserMsg\_EmptyItemSlotAlert\(CDOTAUserMsg\_EmptyItemSlotAlert\)

```csharp
public CDOTAUserMsg_EmptyItemSlotAlert(CDOTAUserMsg_EmptyItemSlotAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EmptyItemSlotAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyItemSlotAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_CooldownSecondsFieldNumber"></a> CooldownSecondsFieldNumber

```csharp
public const int CooldownSecondsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_SlotIndexFieldNumber"></a> SlotIndexFieldNumber

```csharp
public const int SlotIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_CooldownSeconds"></a> CooldownSeconds

```csharp
public int CooldownSeconds { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_HasCooldownSeconds"></a> HasCooldownSeconds

```csharp
public bool HasCooldownSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_HasSlotIndex"></a> HasSlotIndex

```csharp
public bool HasSlotIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_EmptyItemSlotAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_EmptyItemSlotAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyItemSlotAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_SlotIndex"></a> SlotIndex

```csharp
public int SlotIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_ClearCooldownSeconds"></a> ClearCooldownSeconds\(\)

```csharp
public void ClearCooldownSeconds()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_ClearSlotIndex"></a> ClearSlotIndex\(\)

```csharp
public void ClearSlotIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_EmptyItemSlotAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_EmptyItemSlotAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyItemSlotAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_"></a> Equals\(CDOTAUserMsg\_EmptyItemSlotAlert\)

```csharp
public bool Equals(CDOTAUserMsg_EmptyItemSlotAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EmptyItemSlotAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyItemSlotAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_"></a> MergeFrom\(CDOTAUserMsg\_EmptyItemSlotAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_EmptyItemSlotAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EmptyItemSlotAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyItemSlotAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyItemSlotAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

