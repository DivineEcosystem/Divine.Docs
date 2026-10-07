# <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment"></a> Class CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment : IMessage<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment>, IEquatable<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment>, IDeepCloneable<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)

#### Implements

IMessage<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment\>, 
[IEquatable<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment\>, 
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
[EnumerableExtensions.In<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment\>\(CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment, params CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment__ctor"></a> CStrangeCountAdjustment\(\)

```csharp
public CStrangeCountAdjustment()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment__ctor_Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_"></a> CStrangeCountAdjustment\(CStrangeCountAdjustment\)

```csharp
public CStrangeCountAdjustment(CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment other)
```

#### Parameters

`other` [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md).[Types](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.md).[CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_AdjustmentFieldNumber"></a> AdjustmentFieldNumber

```csharp
public const int AdjustmentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_Adjustment"></a> Adjustment

```csharp
public uint Adjustment { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_EventType"></a> EventType

```csharp
public uint EventType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_HasAdjustment"></a> HasAdjustment

```csharp
public bool HasAdjustment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md).[Types](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.md).[CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_ClearAdjustment"></a> ClearAdjustment\(\)

```csharp
public void ClearAdjustment()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_Clone"></a> Clone\(\)

```csharp
public CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment Clone()
```

#### Returns

 [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md).[Types](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.md).[CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_Equals_Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_"></a> Equals\(CStrangeCountAdjustment\)

```csharp
public bool Equals(CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment other)
```

#### Parameters

`other` [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md).[Types](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.md).[CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_MergeFrom_Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_"></a> MergeFrom\(CStrangeCountAdjustment\)

```csharp
public void MergeFrom(CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment other)
```

#### Parameters

`other` [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md).[Types](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.md).[CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Types_CStrangeCountAdjustment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

