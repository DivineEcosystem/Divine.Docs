# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions"></a> Class CMsgClientToGCCancelUnfinalizedTransactions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCancelUnfinalizedTransactions : IMessage<CMsgClientToGCCancelUnfinalizedTransactions>, IEquatable<CMsgClientToGCCancelUnfinalizedTransactions>, IDeepCloneable<CMsgClientToGCCancelUnfinalizedTransactions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCancelUnfinalizedTransactions](Divine.Protobufs.Dota2.CMsgClientToGCCancelUnfinalizedTransactions.md)

#### Implements

IMessage<CMsgClientToGCCancelUnfinalizedTransactions\>, 
[IEquatable<CMsgClientToGCCancelUnfinalizedTransactions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCancelUnfinalizedTransactions\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCancelUnfinalizedTransactions\>\(CMsgClientToGCCancelUnfinalizedTransactions, params CMsgClientToGCCancelUnfinalizedTransactions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions__ctor"></a> CMsgClientToGCCancelUnfinalizedTransactions\(\)

```csharp
public CMsgClientToGCCancelUnfinalizedTransactions()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_"></a> CMsgClientToGCCancelUnfinalizedTransactions\(CMsgClientToGCCancelUnfinalizedTransactions\)

```csharp
public CMsgClientToGCCancelUnfinalizedTransactions(CMsgClientToGCCancelUnfinalizedTransactions other)
```

#### Parameters

`other` [CMsgClientToGCCancelUnfinalizedTransactions](Divine.Protobufs.Dota2.CMsgClientToGCCancelUnfinalizedTransactions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_UnusedFieldNumber"></a> UnusedFieldNumber

```csharp
public const int UnusedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_HasUnused"></a> HasUnused

```csharp
public bool HasUnused { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCancelUnfinalizedTransactions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCancelUnfinalizedTransactions](Divine.Protobufs.Dota2.CMsgClientToGCCancelUnfinalizedTransactions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_Unused"></a> Unused

```csharp
public uint Unused { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_ClearUnused"></a> ClearUnused\(\)

```csharp
public void ClearUnused()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCancelUnfinalizedTransactions Clone()
```

#### Returns

 [CMsgClientToGCCancelUnfinalizedTransactions](Divine.Protobufs.Dota2.CMsgClientToGCCancelUnfinalizedTransactions.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_"></a> Equals\(CMsgClientToGCCancelUnfinalizedTransactions\)

```csharp
public bool Equals(CMsgClientToGCCancelUnfinalizedTransactions other)
```

#### Parameters

`other` [CMsgClientToGCCancelUnfinalizedTransactions](Divine.Protobufs.Dota2.CMsgClientToGCCancelUnfinalizedTransactions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_"></a> MergeFrom\(CMsgClientToGCCancelUnfinalizedTransactions\)

```csharp
public void MergeFrom(CMsgClientToGCCancelUnfinalizedTransactions other)
```

#### Parameters

`other` [CMsgClientToGCCancelUnfinalizedTransactions](Divine.Protobufs.Dota2.CMsgClientToGCCancelUnfinalizedTransactions.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelUnfinalizedTransactions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

