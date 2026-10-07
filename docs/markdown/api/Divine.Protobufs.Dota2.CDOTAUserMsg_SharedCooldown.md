# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown"></a> Class CDOTAUserMsg\_SharedCooldown

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SharedCooldown : IMessage<CDOTAUserMsg_SharedCooldown>, IEquatable<CDOTAUserMsg_SharedCooldown>, IDeepCloneable<CDOTAUserMsg_SharedCooldown>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SharedCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_SharedCooldown.md)

#### Implements

IMessage<CDOTAUserMsg\_SharedCooldown\>, 
[IEquatable<CDOTAUserMsg\_SharedCooldown\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SharedCooldown\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SharedCooldown\>\(CDOTAUserMsg\_SharedCooldown, params CDOTAUserMsg\_SharedCooldown\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown__ctor"></a> CDOTAUserMsg\_SharedCooldown\(\)

```csharp
public CDOTAUserMsg_SharedCooldown()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_"></a> CDOTAUserMsg\_SharedCooldown\(CDOTAUserMsg\_SharedCooldown\)

```csharp
public CDOTAUserMsg_SharedCooldown(CDOTAUserMsg_SharedCooldown other)
```

#### Parameters

`other` [CDOTAUserMsg\_SharedCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_SharedCooldown.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_CooldownFieldNumber"></a> CooldownFieldNumber

```csharp
public const int CooldownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_EntindexFieldNumber"></a> EntindexFieldNumber

```csharp
public const int EntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_NameIndexFieldNumber"></a> NameIndexFieldNumber

```csharp
public const int NameIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Cooldown"></a> Cooldown

```csharp
public float Cooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Entindex"></a> Entindex

```csharp
public int Entindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_HasCooldown"></a> HasCooldown

```csharp
public bool HasCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_HasEntindex"></a> HasEntindex

```csharp
public bool HasEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_HasNameIndex"></a> HasNameIndex

```csharp
public bool HasNameIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_NameIndex"></a> NameIndex

```csharp
public int NameIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SharedCooldown> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SharedCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_SharedCooldown.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_ClearCooldown"></a> ClearCooldown\(\)

```csharp
public void ClearCooldown()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_ClearEntindex"></a> ClearEntindex\(\)

```csharp
public void ClearEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_ClearNameIndex"></a> ClearNameIndex\(\)

```csharp
public void ClearNameIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SharedCooldown Clone()
```

#### Returns

 [CDOTAUserMsg\_SharedCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_SharedCooldown.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_"></a> Equals\(CDOTAUserMsg\_SharedCooldown\)

```csharp
public bool Equals(CDOTAUserMsg_SharedCooldown other)
```

#### Parameters

`other` [CDOTAUserMsg\_SharedCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_SharedCooldown.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_"></a> MergeFrom\(CDOTAUserMsg\_SharedCooldown\)

```csharp
public void MergeFrom(CDOTAUserMsg_SharedCooldown other)
```

#### Parameters

`other` [CDOTAUserMsg\_SharedCooldown](Divine.Protobufs.Dota2.CDOTAUserMsg\_SharedCooldown.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SharedCooldown_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

