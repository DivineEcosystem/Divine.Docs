# <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord"></a> Class CMsgPlayerMatchRecord

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerMatchRecord : IMessage<CMsgPlayerMatchRecord>, IEquatable<CMsgPlayerMatchRecord>, IDeepCloneable<CMsgPlayerMatchRecord>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

#### Implements

IMessage<CMsgPlayerMatchRecord\>, 
[IEquatable<CMsgPlayerMatchRecord\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerMatchRecord\>, 
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
[EnumerableExtensions.In<CMsgPlayerMatchRecord\>\(CMsgPlayerMatchRecord, params CMsgPlayerMatchRecord\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord__ctor"></a> CMsgPlayerMatchRecord\(\)

```csharp
public CMsgPlayerMatchRecord()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord__ctor_Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_"></a> CMsgPlayerMatchRecord\(CMsgPlayerMatchRecord\)

```csharp
public CMsgPlayerMatchRecord(CMsgPlayerMatchRecord other)
```

#### Parameters

`other` [CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_LossesFieldNumber"></a> LossesFieldNumber

```csharp
public const int LossesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_HasLosses"></a> HasLosses

```csharp
public bool HasLosses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Losses"></a> Losses

```csharp
public uint Losses { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerMatchRecord> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Wins"></a> Wins

```csharp
public uint Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_ClearLosses"></a> ClearLosses\(\)

```csharp
public void ClearLosses()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerMatchRecord Clone()
```

#### Returns

 [CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_Equals_Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_"></a> Equals\(CMsgPlayerMatchRecord\)

```csharp
public bool Equals(CMsgPlayerMatchRecord other)
```

#### Parameters

`other` [CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_"></a> MergeFrom\(CMsgPlayerMatchRecord\)

```csharp
public void MergeFrom(CMsgPlayerMatchRecord other)
```

#### Parameters

`other` [CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerMatchRecord_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

