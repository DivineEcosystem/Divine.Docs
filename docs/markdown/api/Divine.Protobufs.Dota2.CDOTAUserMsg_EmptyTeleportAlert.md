# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert"></a> Class CDOTAUserMsg\_EmptyTeleportAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_EmptyTeleportAlert : IMessage<CDOTAUserMsg_EmptyTeleportAlert>, IEquatable<CDOTAUserMsg_EmptyTeleportAlert>, IDeepCloneable<CDOTAUserMsg_EmptyTeleportAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_EmptyTeleportAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyTeleportAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_EmptyTeleportAlert\>, 
[IEquatable<CDOTAUserMsg\_EmptyTeleportAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_EmptyTeleportAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_EmptyTeleportAlert\>\(CDOTAUserMsg\_EmptyTeleportAlert, params CDOTAUserMsg\_EmptyTeleportAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert__ctor"></a> CDOTAUserMsg\_EmptyTeleportAlert\(\)

```csharp
public CDOTAUserMsg_EmptyTeleportAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_"></a> CDOTAUserMsg\_EmptyTeleportAlert\(CDOTAUserMsg\_EmptyTeleportAlert\)

```csharp
public CDOTAUserMsg_EmptyTeleportAlert(CDOTAUserMsg_EmptyTeleportAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EmptyTeleportAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyTeleportAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_CooldownSecondsFieldNumber"></a> CooldownSecondsFieldNumber

```csharp
public const int CooldownSecondsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_CooldownSeconds"></a> CooldownSeconds

```csharp
public int CooldownSeconds { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_HasCooldownSeconds"></a> HasCooldownSeconds

```csharp
public bool HasCooldownSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_EmptyTeleportAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_EmptyTeleportAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyTeleportAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_ClearCooldownSeconds"></a> ClearCooldownSeconds\(\)

```csharp
public void ClearCooldownSeconds()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_EmptyTeleportAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_EmptyTeleportAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyTeleportAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_"></a> Equals\(CDOTAUserMsg\_EmptyTeleportAlert\)

```csharp
public bool Equals(CDOTAUserMsg_EmptyTeleportAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EmptyTeleportAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyTeleportAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_"></a> MergeFrom\(CDOTAUserMsg\_EmptyTeleportAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_EmptyTeleportAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_EmptyTeleportAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_EmptyTeleportAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_EmptyTeleportAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

