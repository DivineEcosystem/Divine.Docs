# <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage"></a> Class CMsgMatchConsumableUsage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchConsumableUsage : IMessage<CMsgMatchConsumableUsage>, IEquatable<CMsgMatchConsumableUsage>, IDeepCloneable<CMsgMatchConsumableUsage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md)

#### Implements

IMessage<CMsgMatchConsumableUsage\>, 
[IEquatable<CMsgMatchConsumableUsage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchConsumableUsage\>, 
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
[EnumerableExtensions.In<CMsgMatchConsumableUsage\>\(CMsgMatchConsumableUsage, params CMsgMatchConsumableUsage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage__ctor"></a> CMsgMatchConsumableUsage\(\)

```csharp
public CMsgMatchConsumableUsage()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage__ctor_Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_"></a> CMsgMatchConsumableUsage\(CMsgMatchConsumableUsage\)

```csharp
public CMsgMatchConsumableUsage(CMsgMatchConsumableUsage other)
```

#### Parameters

`other` [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_PlayerConsumablesUsedFieldNumber"></a> PlayerConsumablesUsedFieldNumber

```csharp
public const int PlayerConsumablesUsedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchConsumableUsage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_PlayerConsumablesUsed"></a> PlayerConsumablesUsed

```csharp
public RepeatedField<CMsgMatchConsumableUsage.Types.PlayerUsage> PlayerConsumablesUsed { get; }
```

#### Property Value

 RepeatedField<[CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md).[Types](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.md).[PlayerUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.Types.PlayerUsage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Clone"></a> Clone\(\)

```csharp
public CMsgMatchConsumableUsage Clone()
```

#### Returns

 [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_Equals_Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_"></a> Equals\(CMsgMatchConsumableUsage\)

```csharp
public bool Equals(CMsgMatchConsumableUsage other)
```

#### Parameters

`other` [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_"></a> MergeFrom\(CMsgMatchConsumableUsage\)

```csharp
public void MergeFrom(CMsgMatchConsumableUsage other)
```

#### Parameters

`other` [CMsgMatchConsumableUsage](Divine.Protobufs.Dota2.CMsgMatchConsumableUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchConsumableUsage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

