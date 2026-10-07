# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate"></a> Class CMsgClientToGCUnlockCrate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnlockCrate : IMessage<CMsgClientToGCUnlockCrate>, IEquatable<CMsgClientToGCUnlockCrate>, IDeepCloneable<CMsgClientToGCUnlockCrate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgClientToGCUnlockCrate.md)

#### Implements

IMessage<CMsgClientToGCUnlockCrate\>, 
[IEquatable<CMsgClientToGCUnlockCrate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnlockCrate\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnlockCrate\>\(CMsgClientToGCUnlockCrate, params CMsgClientToGCUnlockCrate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate__ctor"></a> CMsgClientToGCUnlockCrate\(\)

```csharp
public CMsgClientToGCUnlockCrate()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_"></a> CMsgClientToGCUnlockCrate\(CMsgClientToGCUnlockCrate\)

```csharp
public CMsgClientToGCUnlockCrate(CMsgClientToGCUnlockCrate other)
```

#### Parameters

`other` [CMsgClientToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgClientToGCUnlockCrate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_CrateItemIdFieldNumber"></a> CrateItemIdFieldNumber

```csharp
public const int CrateItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_KeyItemIdFieldNumber"></a> KeyItemIdFieldNumber

```csharp
public const int KeyItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_CrateItemId"></a> CrateItemId

```csharp
public ulong CrateItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_HasCrateItemId"></a> HasCrateItemId

```csharp
public bool HasCrateItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_HasKeyItemId"></a> HasKeyItemId

```csharp
public bool HasKeyItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_KeyItemId"></a> KeyItemId

```csharp
public ulong KeyItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnlockCrate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgClientToGCUnlockCrate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_ClearCrateItemId"></a> ClearCrateItemId\(\)

```csharp
public void ClearCrateItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_ClearKeyItemId"></a> ClearKeyItemId\(\)

```csharp
public void ClearKeyItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnlockCrate Clone()
```

#### Returns

 [CMsgClientToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgClientToGCUnlockCrate.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_"></a> Equals\(CMsgClientToGCUnlockCrate\)

```csharp
public bool Equals(CMsgClientToGCUnlockCrate other)
```

#### Parameters

`other` [CMsgClientToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgClientToGCUnlockCrate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_"></a> MergeFrom\(CMsgClientToGCUnlockCrate\)

```csharp
public void MergeFrom(CMsgClientToGCUnlockCrate other)
```

#### Parameters

`other` [CMsgClientToGCUnlockCrate](Divine.Protobufs.Dota2.CMsgClientToGCUnlockCrate.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnlockCrate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

