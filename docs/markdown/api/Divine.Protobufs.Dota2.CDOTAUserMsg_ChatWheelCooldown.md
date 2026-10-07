# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown"></a> Class CDOTAUserMsg\_ChatWheelCooldown

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ChatWheelCooldown : IMessage<CDOTAUserMsg_ChatWheelCooldown>, IEquatable<CDOTAUserMsg_ChatWheelCooldown>, IDeepCloneable<CDOTAUserMsg_ChatWheelCooldown>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ChatWheelCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatWheelCooldown.md)

#### Implements

IMessage<CDOTAUserMsg\_ChatWheelCooldown\>, 
[IEquatable<CDOTAUserMsg\_ChatWheelCooldown\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ChatWheelCooldown\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ChatWheelCooldown\>\(CDOTAUserMsg\_ChatWheelCooldown, params CDOTAUserMsg\_ChatWheelCooldown\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown__ctor"></a> CDOTAUserMsg\_ChatWheelCooldown\(\)

```csharp
public CDOTAUserMsg_ChatWheelCooldown()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_"></a> CDOTAUserMsg\_ChatWheelCooldown\(CDOTAUserMsg\_ChatWheelCooldown\)

```csharp
public CDOTAUserMsg_ChatWheelCooldown(CDOTAUserMsg_ChatWheelCooldown other)
```

#### Parameters

`other` [CDOTAUserMsg\_ChatWheelCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatWheelCooldown.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_CooldownRemainingFieldNumber"></a> CooldownRemainingFieldNumber

```csharp
public const int CooldownRemainingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_MessageIdFieldNumber"></a> MessageIdFieldNumber

```csharp
public const int MessageIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_CooldownRemaining"></a> CooldownRemaining

```csharp
public float CooldownRemaining { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_HasCooldownRemaining"></a> HasCooldownRemaining

```csharp
public bool HasCooldownRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_HasMessageId"></a> HasMessageId

```csharp
public bool HasMessageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_MessageId"></a> MessageId

```csharp
public uint MessageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ChatWheelCooldown> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ChatWheelCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatWheelCooldown.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_ClearCooldownRemaining"></a> ClearCooldownRemaining\(\)

```csharp
public void ClearCooldownRemaining()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_ClearMessageId"></a> ClearMessageId\(\)

```csharp
public void ClearMessageId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ChatWheelCooldown Clone()
```

#### Returns

 [CDOTAUserMsg\_ChatWheelCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatWheelCooldown.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_"></a> Equals\(CDOTAUserMsg\_ChatWheelCooldown\)

```csharp
public bool Equals(CDOTAUserMsg_ChatWheelCooldown other)
```

#### Parameters

`other` [CDOTAUserMsg\_ChatWheelCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatWheelCooldown.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_"></a> MergeFrom\(CDOTAUserMsg\_ChatWheelCooldown\)

```csharp
public void MergeFrom(CDOTAUserMsg_ChatWheelCooldown other)
```

#### Parameters

`other` [CDOTAUserMsg\_ChatWheelCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_ChatWheelCooldown.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ChatWheelCooldown_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

