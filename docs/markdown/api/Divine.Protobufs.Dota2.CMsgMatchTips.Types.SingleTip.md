# <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip"></a> Class CMsgMatchTips.Types.SingleTip

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchTips.Types.SingleTip : IMessage<CMsgMatchTips.Types.SingleTip>, IEquatable<CMsgMatchTips.Types.SingleTip>, IDeepCloneable<CMsgMatchTips.Types.SingleTip>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchTips.Types.SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)

#### Implements

IMessage<CMsgMatchTips.Types.SingleTip\>, 
[IEquatable<CMsgMatchTips.Types.SingleTip\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchTips.Types.SingleTip\>, 
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
[EnumerableExtensions.In<CMsgMatchTips.Types.SingleTip\>\(CMsgMatchTips.Types.SingleTip, params CMsgMatchTips.Types.SingleTip\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip__ctor"></a> SingleTip\(\)

```csharp
public SingleTip()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip__ctor_Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_"></a> SingleTip\(SingleTip\)

```csharp
public SingleTip(CMsgMatchTips.Types.SingleTip other)
```

#### Parameters

`other` [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md).[Types](Divine.Protobufs.Dota2.CMsgMatchTips.Types.md).[SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_SourceAccountIdFieldNumber"></a> SourceAccountIdFieldNumber

```csharp
public const int SourceAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_TipAmountFieldNumber"></a> TipAmountFieldNumber

```csharp
public const int TipAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_HasSourceAccountId"></a> HasSourceAccountId

```csharp
public bool HasSourceAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_HasTipAmount"></a> HasTipAmount

```csharp
public bool HasTipAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchTips.Types.SingleTip> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md).[Types](Divine.Protobufs.Dota2.CMsgMatchTips.Types.md).[SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_SourceAccountId"></a> SourceAccountId

```csharp
public uint SourceAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_TipAmount"></a> TipAmount

```csharp
public uint TipAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_ClearSourceAccountId"></a> ClearSourceAccountId\(\)

```csharp
public void ClearSourceAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_ClearTipAmount"></a> ClearTipAmount\(\)

```csharp
public void ClearTipAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_Clone"></a> Clone\(\)

```csharp
public CMsgMatchTips.Types.SingleTip Clone()
```

#### Returns

 [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md).[Types](Divine.Protobufs.Dota2.CMsgMatchTips.Types.md).[SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_Equals_Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_"></a> Equals\(SingleTip\)

```csharp
public bool Equals(CMsgMatchTips.Types.SingleTip other)
```

#### Parameters

`other` [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md).[Types](Divine.Protobufs.Dota2.CMsgMatchTips.Types.md).[SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_"></a> MergeFrom\(SingleTip\)

```csharp
public void MergeFrom(CMsgMatchTips.Types.SingleTip other)
```

#### Parameters

`other` [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md).[Types](Divine.Protobufs.Dota2.CMsgMatchTips.Types.md).[SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Types_SingleTip_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

