# <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage"></a> Class CMsgMatchConsumableUsage.Types.PlayerUsage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchConsumableUsage.Types.PlayerUsage : IMessage<CMsgMatchConsumableUsage.Types.PlayerUsage>, IEquatable<CMsgMatchConsumableUsage.Types.PlayerUsage>, IDeepCloneable<CMsgMatchConsumableUsage.Types.PlayerUsage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchConsumableUsage.Types.PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)

#### Implements

IMessage<CMsgMatchConsumableUsage.Types.PlayerUsage\>, 
[IEquatable<CMsgMatchConsumableUsage.Types.PlayerUsage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchConsumableUsage.Types.PlayerUsage\>, 
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
[EnumerableExtensions.In<CMsgMatchConsumableUsage.Types.PlayerUsage\>\(CMsgMatchConsumableUsage.Types.PlayerUsage, params CMsgMatchConsumableUsage.Types.PlayerUsage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage__ctor"></a> PlayerUsage\(\)

```csharp
public PlayerUsage()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage__ctor_Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_"></a> PlayerUsage\(PlayerUsage\)

```csharp
public PlayerUsage(CMsgMatchConsumableUsage.Types.PlayerUsage other)
```

#### Parameters

`other` [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md).[Types](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.md).[PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_ConsumablesUsedFieldNumber"></a> ConsumablesUsedFieldNumber

```csharp
public const int ConsumablesUsedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_ConsumablesUsed"></a> ConsumablesUsed

```csharp
public RepeatedField<CMsgConsumableUsage> ConsumablesUsed { get; }
```

#### Property Value

 RepeatedField<[CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchConsumableUsage.Types.PlayerUsage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md).[Types](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.md).[PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_Clone"></a> Clone\(\)

```csharp
public CMsgMatchConsumableUsage.Types.PlayerUsage Clone()
```

#### Returns

 [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md).[Types](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.md).[PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_Equals_Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_"></a> Equals\(PlayerUsage\)

```csharp
public bool Equals(CMsgMatchConsumableUsage.Types.PlayerUsage other)
```

#### Parameters

`other` [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md).[Types](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.md).[PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_"></a> MergeFrom\(PlayerUsage\)

```csharp
public void MergeFrom(CMsgMatchConsumableUsage.Types.PlayerUsage other)
```

#### Parameters

`other` [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md).[Types](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.md).[PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Types_PlayerUsage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

