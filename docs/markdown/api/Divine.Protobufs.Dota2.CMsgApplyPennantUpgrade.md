# <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade"></a> Class CMsgApplyPennantUpgrade

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgApplyPennantUpgrade : IMessage<CMsgApplyPennantUpgrade>, IEquatable<CMsgApplyPennantUpgrade>, IDeepCloneable<CMsgApplyPennantUpgrade>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgApplyPennantUpgrade](Divine.Protobufs.Dota2.CMsgApplyPennantUpgrade.md)

#### Implements

IMessage<CMsgApplyPennantUpgrade\>, 
[IEquatable<CMsgApplyPennantUpgrade\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgApplyPennantUpgrade\>, 
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
[EnumerableExtensions.In<CMsgApplyPennantUpgrade\>\(CMsgApplyPennantUpgrade, params CMsgApplyPennantUpgrade\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade__ctor"></a> CMsgApplyPennantUpgrade\(\)

```csharp
public CMsgApplyPennantUpgrade()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade__ctor_Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_"></a> CMsgApplyPennantUpgrade\(CMsgApplyPennantUpgrade\)

```csharp
public CMsgApplyPennantUpgrade(CMsgApplyPennantUpgrade other)
```

#### Parameters

`other` [CMsgApplyPennantUpgrade](Divine.Protobufs.Dota2.CMsgApplyPennantUpgrade.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_PennantItemIdFieldNumber"></a> PennantItemIdFieldNumber

```csharp
public const int PennantItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_UpgradeItemIdFieldNumber"></a> UpgradeItemIdFieldNumber

```csharp
public const int UpgradeItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_HasPennantItemId"></a> HasPennantItemId

```csharp
public bool HasPennantItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_HasUpgradeItemId"></a> HasUpgradeItemId

```csharp
public bool HasUpgradeItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_Parser"></a> Parser

```csharp
public static MessageParser<CMsgApplyPennantUpgrade> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgApplyPennantUpgrade](Divine.Protobufs.Dota2.CMsgApplyPennantUpgrade.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_PennantItemId"></a> PennantItemId

```csharp
public ulong PennantItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_UpgradeItemId"></a> UpgradeItemId

```csharp
public ulong UpgradeItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_ClearPennantItemId"></a> ClearPennantItemId\(\)

```csharp
public void ClearPennantItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_ClearUpgradeItemId"></a> ClearUpgradeItemId\(\)

```csharp
public void ClearUpgradeItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_Clone"></a> Clone\(\)

```csharp
public CMsgApplyPennantUpgrade Clone()
```

#### Returns

 [CMsgApplyPennantUpgrade](Divine.Protobufs.Dota2.CMsgApplyPennantUpgrade.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_Equals_Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_"></a> Equals\(CMsgApplyPennantUpgrade\)

```csharp
public bool Equals(CMsgApplyPennantUpgrade other)
```

#### Parameters

`other` [CMsgApplyPennantUpgrade](Divine.Protobufs.Dota2.CMsgApplyPennantUpgrade.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_MergeFrom_Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_"></a> MergeFrom\(CMsgApplyPennantUpgrade\)

```csharp
public void MergeFrom(CMsgApplyPennantUpgrade other)
```

#### Parameters

`other` [CMsgApplyPennantUpgrade](Divine.Protobufs.Dota2.CMsgApplyPennantUpgrade.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyPennantUpgrade_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

