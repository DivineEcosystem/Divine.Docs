# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold"></a> Class CDOTAUserMsg\_SendFinalGold

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SendFinalGold : IMessage<CDOTAUserMsg_SendFinalGold>, IEquatable<CDOTAUserMsg_SendFinalGold>, IDeepCloneable<CDOTAUserMsg_SendFinalGold>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SendFinalGold](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendFinalGold.md)

#### Implements

IMessage<CDOTAUserMsg\_SendFinalGold\>, 
[IEquatable<CDOTAUserMsg\_SendFinalGold\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SendFinalGold\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SendFinalGold\>\(CDOTAUserMsg\_SendFinalGold, params CDOTAUserMsg\_SendFinalGold\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold__ctor"></a> CDOTAUserMsg\_SendFinalGold\(\)

```csharp
public CDOTAUserMsg_SendFinalGold()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_"></a> CDOTAUserMsg\_SendFinalGold\(CDOTAUserMsg\_SendFinalGold\)

```csharp
public CDOTAUserMsg_SendFinalGold(CDOTAUserMsg_SendFinalGold other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendFinalGold](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendFinalGold.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_ReliableGoldFieldNumber"></a> ReliableGoldFieldNumber

```csharp
public const int ReliableGoldFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_UnreliableGoldFieldNumber"></a> UnreliableGoldFieldNumber

```csharp
public const int UnreliableGoldFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SendFinalGold> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SendFinalGold](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendFinalGold.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_ReliableGold"></a> ReliableGold

```csharp
public RepeatedField<uint> ReliableGold { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_UnreliableGold"></a> UnreliableGold

```csharp
public RepeatedField<uint> UnreliableGold { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SendFinalGold Clone()
```

#### Returns

 [CDOTAUserMsg\_SendFinalGold](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendFinalGold.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_"></a> Equals\(CDOTAUserMsg\_SendFinalGold\)

```csharp
public bool Equals(CDOTAUserMsg_SendFinalGold other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendFinalGold](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendFinalGold.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_"></a> MergeFrom\(CDOTAUserMsg\_SendFinalGold\)

```csharp
public void MergeFrom(CDOTAUserMsg_SendFinalGold other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendFinalGold](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendFinalGold.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendFinalGold_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

