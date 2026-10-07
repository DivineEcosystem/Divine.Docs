# <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus"></a> Class CMsgGCToGCCanUseDropRateBonus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCCanUseDropRateBonus : IMessage<CMsgGCToGCCanUseDropRateBonus>, IEquatable<CMsgGCToGCCanUseDropRateBonus>, IDeepCloneable<CMsgGCToGCCanUseDropRateBonus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCCanUseDropRateBonus](Divine.Protobufs.Dota2.CMsgGCToGCCanUseDropRateBonus.md)

#### Implements

IMessage<CMsgGCToGCCanUseDropRateBonus\>, 
[IEquatable<CMsgGCToGCCanUseDropRateBonus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCCanUseDropRateBonus\>, 
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
[EnumerableExtensions.In<CMsgGCToGCCanUseDropRateBonus\>\(CMsgGCToGCCanUseDropRateBonus, params CMsgGCToGCCanUseDropRateBonus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus__ctor"></a> CMsgGCToGCCanUseDropRateBonus\(\)

```csharp
public CMsgGCToGCCanUseDropRateBonus()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus__ctor_Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_"></a> CMsgGCToGCCanUseDropRateBonus\(CMsgGCToGCCanUseDropRateBonus\)

```csharp
public CMsgGCToGCCanUseDropRateBonus(CMsgGCToGCCanUseDropRateBonus other)
```

#### Parameters

`other` [CMsgGCToGCCanUseDropRateBonus](Divine.Protobufs.Dota2.CMsgGCToGCCanUseDropRateBonus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_AllowEqualRateFieldNumber"></a> AllowEqualRateFieldNumber

```csharp
public const int AllowEqualRateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_BoosterTypeFieldNumber"></a> BoosterTypeFieldNumber

```csharp
public const int BoosterTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_DropRateBonusFieldNumber"></a> DropRateBonusFieldNumber

```csharp
public const int DropRateBonusFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ExclusiveItemDefFieldNumber"></a> ExclusiveItemDefFieldNumber

```csharp
public const int ExclusiveItemDefFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_AllowEqualRate"></a> AllowEqualRate

```csharp
public bool AllowEqualRate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_BoosterType"></a> BoosterType

```csharp
public uint BoosterType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_DropRateBonus"></a> DropRateBonus

```csharp
public float DropRateBonus { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ExclusiveItemDef"></a> ExclusiveItemDef

```csharp
public uint ExclusiveItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_HasAllowEqualRate"></a> HasAllowEqualRate

```csharp
public bool HasAllowEqualRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_HasBoosterType"></a> HasBoosterType

```csharp
public bool HasBoosterType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_HasDropRateBonus"></a> HasDropRateBonus

```csharp
public bool HasDropRateBonus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_HasExclusiveItemDef"></a> HasExclusiveItemDef

```csharp
public bool HasExclusiveItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCCanUseDropRateBonus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCCanUseDropRateBonus](Divine.Protobufs.Dota2.CMsgGCToGCCanUseDropRateBonus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ClearAllowEqualRate"></a> ClearAllowEqualRate\(\)

```csharp
public void ClearAllowEqualRate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ClearBoosterType"></a> ClearBoosterType\(\)

```csharp
public void ClearBoosterType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ClearDropRateBonus"></a> ClearDropRateBonus\(\)

```csharp
public void ClearDropRateBonus()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ClearExclusiveItemDef"></a> ClearExclusiveItemDef\(\)

```csharp
public void ClearExclusiveItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCCanUseDropRateBonus Clone()
```

#### Returns

 [CMsgGCToGCCanUseDropRateBonus](Divine.Protobufs.Dota2.CMsgGCToGCCanUseDropRateBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_Equals_Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_"></a> Equals\(CMsgGCToGCCanUseDropRateBonus\)

```csharp
public bool Equals(CMsgGCToGCCanUseDropRateBonus other)
```

#### Parameters

`other` [CMsgGCToGCCanUseDropRateBonus](Divine.Protobufs.Dota2.CMsgGCToGCCanUseDropRateBonus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_"></a> MergeFrom\(CMsgGCToGCCanUseDropRateBonus\)

```csharp
public void MergeFrom(CMsgGCToGCCanUseDropRateBonus other)
```

#### Parameters

`other` [CMsgGCToGCCanUseDropRateBonus](Divine.Protobufs.Dota2.CMsgGCToGCCanUseDropRateBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCCanUseDropRateBonus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

