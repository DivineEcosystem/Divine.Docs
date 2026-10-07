# <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff"></a> Class CMatchPlayerPermanentBuff

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchPlayerPermanentBuff : IMessage<CMatchPlayerPermanentBuff>, IEquatable<CMatchPlayerPermanentBuff>, IDeepCloneable<CMatchPlayerPermanentBuff>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)

#### Implements

IMessage<CMatchPlayerPermanentBuff\>, 
[IEquatable<CMatchPlayerPermanentBuff\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchPlayerPermanentBuff\>, 
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
[EnumerableExtensions.In<CMatchPlayerPermanentBuff\>\(CMatchPlayerPermanentBuff, params CMatchPlayerPermanentBuff\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff__ctor"></a> CMatchPlayerPermanentBuff\(\)

```csharp
public CMatchPlayerPermanentBuff()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff__ctor_Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_"></a> CMatchPlayerPermanentBuff\(CMatchPlayerPermanentBuff\)

```csharp
public CMatchPlayerPermanentBuff(CMatchPlayerPermanentBuff other)
```

#### Parameters

`other` [CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_GrantTimeFieldNumber"></a> GrantTimeFieldNumber

```csharp
public const int GrantTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_PermanentBuffFieldNumber"></a> PermanentBuffFieldNumber

```csharp
public const int PermanentBuffFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_StackCountFieldNumber"></a> StackCountFieldNumber

```csharp
public const int StackCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_GrantTime"></a> GrantTime

```csharp
public uint GrantTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_HasGrantTime"></a> HasGrantTime

```csharp
public bool HasGrantTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_HasPermanentBuff"></a> HasPermanentBuff

```csharp
public bool HasPermanentBuff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_HasStackCount"></a> HasStackCount

```csharp
public bool HasStackCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_Parser"></a> Parser

```csharp
public static MessageParser<CMatchPlayerPermanentBuff> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_PermanentBuff"></a> PermanentBuff

```csharp
public uint PermanentBuff { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_StackCount"></a> StackCount

```csharp
public uint StackCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_ClearGrantTime"></a> ClearGrantTime\(\)

```csharp
public void ClearGrantTime()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_ClearPermanentBuff"></a> ClearPermanentBuff\(\)

```csharp
public void ClearPermanentBuff()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_ClearStackCount"></a> ClearStackCount\(\)

```csharp
public void ClearStackCount()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_Clone"></a> Clone\(\)

```csharp
public CMatchPlayerPermanentBuff Clone()
```

#### Returns

 [CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_Equals_Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_"></a> Equals\(CMatchPlayerPermanentBuff\)

```csharp
public bool Equals(CMatchPlayerPermanentBuff other)
```

#### Parameters

`other` [CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_MergeFrom_Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_"></a> MergeFrom\(CMatchPlayerPermanentBuff\)

```csharp
public void MergeFrom(CMatchPlayerPermanentBuff other)
```

#### Parameters

`other` [CMatchPlayerPermanentBuff](Divine.Protobufs.Dota2.CMatchPlayerPermanentBuff.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerPermanentBuff_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

