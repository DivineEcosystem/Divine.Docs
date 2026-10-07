# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice"></a> Class CDOTAClientMsg\_RollDice

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RollDice : IMessage<CDOTAClientMsg_RollDice>, IEquatable<CDOTAClientMsg_RollDice>, IDeepCloneable<CDOTAClientMsg_RollDice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RollDice](Divine.Protobufs.Dota2.CDOTAClientMsg\_RollDice.md)

#### Implements

IMessage<CDOTAClientMsg\_RollDice\>, 
[IEquatable<CDOTAClientMsg\_RollDice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RollDice\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RollDice\>\(CDOTAClientMsg\_RollDice, params CDOTAClientMsg\_RollDice\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice__ctor"></a> CDOTAClientMsg\_RollDice\(\)

```csharp
public CDOTAClientMsg_RollDice()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_"></a> CDOTAClientMsg\_RollDice\(CDOTAClientMsg\_RollDice\)

```csharp
public CDOTAClientMsg_RollDice(CDOTAClientMsg_RollDice other)
```

#### Parameters

`other` [CDOTAClientMsg\_RollDice](Divine.Protobufs.Dota2.CDOTAClientMsg\_RollDice.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_RollMaxFieldNumber"></a> RollMaxFieldNumber

```csharp
public const int RollMaxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_RollMinFieldNumber"></a> RollMinFieldNumber

```csharp
public const int RollMinFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_ChannelType"></a> ChannelType

```csharp
public uint ChannelType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_HasRollMax"></a> HasRollMax

```csharp
public bool HasRollMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_HasRollMin"></a> HasRollMin

```csharp
public bool HasRollMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RollDice> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RollDice](Divine.Protobufs.Dota2.CDOTAClientMsg\_RollDice.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_RollMax"></a> RollMax

```csharp
public uint RollMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_RollMin"></a> RollMin

```csharp
public uint RollMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_ClearRollMax"></a> ClearRollMax\(\)

```csharp
public void ClearRollMax()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_ClearRollMin"></a> ClearRollMin\(\)

```csharp
public void ClearRollMin()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RollDice Clone()
```

#### Returns

 [CDOTAClientMsg\_RollDice](Divine.Protobufs.Dota2.CDOTAClientMsg\_RollDice.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_"></a> Equals\(CDOTAClientMsg\_RollDice\)

```csharp
public bool Equals(CDOTAClientMsg_RollDice other)
```

#### Parameters

`other` [CDOTAClientMsg\_RollDice](Divine.Protobufs.Dota2.CDOTAClientMsg\_RollDice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_"></a> MergeFrom\(CDOTAClientMsg\_RollDice\)

```csharp
public void MergeFrom(CDOTAClientMsg_RollDice other)
```

#### Parameters

`other` [CDOTAClientMsg\_RollDice](Divine.Protobufs.Dota2.CDOTAClientMsg\_RollDice.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RollDice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

