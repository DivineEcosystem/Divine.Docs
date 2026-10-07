# <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence"></a> Class CMsgApplyEggEssence

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgApplyEggEssence : IMessage<CMsgApplyEggEssence>, IEquatable<CMsgApplyEggEssence>, IDeepCloneable<CMsgApplyEggEssence>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgApplyEggEssence](Divine.Protobufs.Dota2.CMsgApplyEggEssence.md)

#### Implements

IMessage<CMsgApplyEggEssence\>, 
[IEquatable<CMsgApplyEggEssence\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgApplyEggEssence\>, 
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
[EnumerableExtensions.In<CMsgApplyEggEssence\>\(CMsgApplyEggEssence, params CMsgApplyEggEssence\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence__ctor"></a> CMsgApplyEggEssence\(\)

```csharp
public CMsgApplyEggEssence()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence__ctor_Divine_Protobufs_Dota2_CMsgApplyEggEssence_"></a> CMsgApplyEggEssence\(CMsgApplyEggEssence\)

```csharp
public CMsgApplyEggEssence(CMsgApplyEggEssence other)
```

#### Parameters

`other` [CMsgApplyEggEssence](Divine.Protobufs.Dota2.CMsgApplyEggEssence.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_EggItemIdFieldNumber"></a> EggItemIdFieldNumber

```csharp
public const int EggItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_EssenceItemIdFieldNumber"></a> EssenceItemIdFieldNumber

```csharp
public const int EssenceItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_EggItemId"></a> EggItemId

```csharp
public ulong EggItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_EssenceItemId"></a> EssenceItemId

```csharp
public ulong EssenceItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_HasEggItemId"></a> HasEggItemId

```csharp
public bool HasEggItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_HasEssenceItemId"></a> HasEssenceItemId

```csharp
public bool HasEssenceItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_Parser"></a> Parser

```csharp
public static MessageParser<CMsgApplyEggEssence> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgApplyEggEssence](Divine.Protobufs.Dota2.CMsgApplyEggEssence.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_ClearEggItemId"></a> ClearEggItemId\(\)

```csharp
public void ClearEggItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_ClearEssenceItemId"></a> ClearEssenceItemId\(\)

```csharp
public void ClearEssenceItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_Clone"></a> Clone\(\)

```csharp
public CMsgApplyEggEssence Clone()
```

#### Returns

 [CMsgApplyEggEssence](Divine.Protobufs.Dota2.CMsgApplyEggEssence.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_Equals_Divine_Protobufs_Dota2_CMsgApplyEggEssence_"></a> Equals\(CMsgApplyEggEssence\)

```csharp
public bool Equals(CMsgApplyEggEssence other)
```

#### Parameters

`other` [CMsgApplyEggEssence](Divine.Protobufs.Dota2.CMsgApplyEggEssence.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_MergeFrom_Divine_Protobufs_Dota2_CMsgApplyEggEssence_"></a> MergeFrom\(CMsgApplyEggEssence\)

```csharp
public void MergeFrom(CMsgApplyEggEssence other)
```

#### Parameters

`other` [CMsgApplyEggEssence](Divine.Protobufs.Dota2.CMsgApplyEggEssence.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyEggEssence_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

