# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry"></a> Class CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ContextualTips_Subscribe_Entry : IMessage<CDOTAClientMsg_ContextualTips_Subscribe_Entry>, IEquatable<CDOTAClientMsg_ContextualTips_Subscribe_Entry>, IDeepCloneable<CDOTAClientMsg_ContextualTips_Subscribe_Entry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry](Divine.Protobufs.Dota2.CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry.md)

#### Implements

IMessage<CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\>, 
[IEquatable<CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\>\(CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry, params CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry__ctor"></a> CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\(\)

```csharp
public CDOTAClientMsg_ContextualTips_Subscribe_Entry()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_"></a> CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\(CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\)

```csharp
public CDOTAClientMsg_ContextualTips_Subscribe_Entry(CDOTAClientMsg_ContextualTips_Subscribe_Entry other)
```

#### Parameters

`other` [CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry](Divine.Protobufs.Dota2.CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_PriorDisplayCountFieldNumber"></a> PriorDisplayCountFieldNumber

```csharp
public const int PriorDisplayCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_TipIdFieldNumber"></a> TipIdFieldNumber

```csharp
public const int TipIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_UnsubscribeFieldNumber"></a> UnsubscribeFieldNumber

```csharp
public const int UnsubscribeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_VariantsSeenFieldNumber"></a> VariantsSeenFieldNumber

```csharp
public const int VariantsSeenFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_HasPriorDisplayCount"></a> HasPriorDisplayCount

```csharp
public bool HasPriorDisplayCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_HasTipId"></a> HasTipId

```csharp
public bool HasTipId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_HasUnsubscribe"></a> HasUnsubscribe

```csharp
public bool HasUnsubscribe { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ContextualTips_Subscribe_Entry> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry](Divine.Protobufs.Dota2.CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_PriorDisplayCount"></a> PriorDisplayCount

```csharp
public int PriorDisplayCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_TipId"></a> TipId

```csharp
public int TipId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_Unsubscribe"></a> Unsubscribe

```csharp
public bool Unsubscribe { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_VariantsSeen"></a> VariantsSeen

```csharp
public RepeatedField<int> VariantsSeen { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_ClearPriorDisplayCount"></a> ClearPriorDisplayCount\(\)

```csharp
public void ClearPriorDisplayCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_ClearTipId"></a> ClearTipId\(\)

```csharp
public void ClearTipId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_ClearUnsubscribe"></a> ClearUnsubscribe\(\)

```csharp
public void ClearUnsubscribe()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ContextualTips_Subscribe_Entry Clone()
```

#### Returns

 [CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry](Divine.Protobufs.Dota2.CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_"></a> Equals\(CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\)

```csharp
public bool Equals(CDOTAClientMsg_ContextualTips_Subscribe_Entry other)
```

#### Parameters

`other` [CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry](Divine.Protobufs.Dota2.CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_"></a> MergeFrom\(CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry\)

```csharp
public void MergeFrom(CDOTAClientMsg_ContextualTips_Subscribe_Entry other)
```

#### Parameters

`other` [CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry](Divine.Protobufs.Dota2.CDOTAClientMsg\_ContextualTips\_Subscribe\_Entry.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ContextualTips_Subscribe_Entry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

