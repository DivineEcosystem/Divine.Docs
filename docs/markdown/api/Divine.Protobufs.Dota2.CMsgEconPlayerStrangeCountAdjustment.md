# <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment"></a> Class CMsgEconPlayerStrangeCountAdjustment

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEconPlayerStrangeCountAdjustment : IMessage<CMsgEconPlayerStrangeCountAdjustment>, IEquatable<CMsgEconPlayerStrangeCountAdjustment>, IDeepCloneable<CMsgEconPlayerStrangeCountAdjustment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)

#### Implements

IMessage<CMsgEconPlayerStrangeCountAdjustment\>, 
[IEquatable<CMsgEconPlayerStrangeCountAdjustment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEconPlayerStrangeCountAdjustment\>, 
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
[EnumerableExtensions.In<CMsgEconPlayerStrangeCountAdjustment\>\(CMsgEconPlayerStrangeCountAdjustment, params CMsgEconPlayerStrangeCountAdjustment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment__ctor"></a> CMsgEconPlayerStrangeCountAdjustment\(\)

```csharp
public CMsgEconPlayerStrangeCountAdjustment()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment__ctor_Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_"></a> CMsgEconPlayerStrangeCountAdjustment\(CMsgEconPlayerStrangeCountAdjustment\)

```csharp
public CMsgEconPlayerStrangeCountAdjustment(CMsgEconPlayerStrangeCountAdjustment other)
```

#### Parameters

`other` [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_StrangeCountAdjustmentsFieldNumber"></a> StrangeCountAdjustmentsFieldNumber

```csharp
public const int StrangeCountAdjustmentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_TurboModeFieldNumber"></a> TurboModeFieldNumber

```csharp
public const int TurboModeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_HasTurboMode"></a> HasTurboMode

```csharp
public bool HasTurboMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEconPlayerStrangeCountAdjustment> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_StrangeCountAdjustments"></a> StrangeCountAdjustments

```csharp
public RepeatedField<CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment> StrangeCountAdjustments { get; }
```

#### Property Value

 RepeatedField<[CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md).[Types](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.md).[CStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.Types.CStrangeCountAdjustment.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_TurboMode"></a> TurboMode

```csharp
public bool TurboMode { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_ClearTurboMode"></a> ClearTurboMode\(\)

```csharp
public void ClearTurboMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Clone"></a> Clone\(\)

```csharp
public CMsgEconPlayerStrangeCountAdjustment Clone()
```

#### Returns

 [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_Equals_Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_"></a> Equals\(CMsgEconPlayerStrangeCountAdjustment\)

```csharp
public bool Equals(CMsgEconPlayerStrangeCountAdjustment other)
```

#### Parameters

`other` [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_MergeFrom_Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_"></a> MergeFrom\(CMsgEconPlayerStrangeCountAdjustment\)

```csharp
public void MergeFrom(CMsgEconPlayerStrangeCountAdjustment other)
```

#### Parameters

`other` [CMsgEconPlayerStrangeCountAdjustment](Divine.Protobufs.Dota2.CMsgEconPlayerStrangeCountAdjustment.md)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEconPlayerStrangeCountAdjustment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

