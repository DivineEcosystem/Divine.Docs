# <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate"></a> Class CMsgGCToGCUnlockCrate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCUnlockCrate : IMessage<CMsgGCToGCUnlockCrate>, IEquatable<CMsgGCToGCUnlockCrate>, IDeepCloneable<CMsgGCToGCUnlockCrate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgGCToGCUnlockCrate.md)

#### Implements

IMessage<CMsgGCToGCUnlockCrate\>, 
[IEquatable<CMsgGCToGCUnlockCrate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCUnlockCrate\>, 
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
[EnumerableExtensions.In<CMsgGCToGCUnlockCrate\>\(CMsgGCToGCUnlockCrate, params CMsgGCToGCUnlockCrate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate__ctor"></a> CMsgGCToGCUnlockCrate\(\)

```csharp
public CMsgGCToGCUnlockCrate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate__ctor_Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_"></a> CMsgGCToGCUnlockCrate\(CMsgGCToGCUnlockCrate\)

```csharp
public CMsgGCToGCUnlockCrate(CMsgGCToGCUnlockCrate other)
```

#### Parameters

`other` [CMsgGCToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgGCToGCUnlockCrate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_CrateItemIdFieldNumber"></a> CrateItemIdFieldNumber

```csharp
public const int CrateItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_KeyItemIdFieldNumber"></a> KeyItemIdFieldNumber

```csharp
public const int KeyItemIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_CrateItemId"></a> CrateItemId

```csharp
public ulong CrateItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_HasCrateItemId"></a> HasCrateItemId

```csharp
public bool HasCrateItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_HasKeyItemId"></a> HasKeyItemId

```csharp
public bool HasKeyItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_KeyItemId"></a> KeyItemId

```csharp
public ulong KeyItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCUnlockCrate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgGCToGCUnlockCrate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_ClearCrateItemId"></a> ClearCrateItemId\(\)

```csharp
public void ClearCrateItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_ClearKeyItemId"></a> ClearKeyItemId\(\)

```csharp
public void ClearKeyItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCUnlockCrate Clone()
```

#### Returns

 [CMsgGCToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgGCToGCUnlockCrate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_Equals_Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_"></a> Equals\(CMsgGCToGCUnlockCrate\)

```csharp
public bool Equals(CMsgGCToGCUnlockCrate other)
```

#### Parameters

`other` [CMsgGCToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgGCToGCUnlockCrate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_"></a> MergeFrom\(CMsgGCToGCUnlockCrate\)

```csharp
public void MergeFrom(CMsgGCToGCUnlockCrate other)
```

#### Parameters

`other` [CMsgGCToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgGCToGCUnlockCrate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUnlockCrate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

