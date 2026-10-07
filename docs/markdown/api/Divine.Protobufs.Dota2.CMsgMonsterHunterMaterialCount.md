# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount"></a> Class CMsgMonsterHunterMaterialCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterMaterialCount : IMessage<CMsgMonsterHunterMaterialCount>, IEquatable<CMsgMonsterHunterMaterialCount>, IDeepCloneable<CMsgMonsterHunterMaterialCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)

#### Implements

IMessage<CMsgMonsterHunterMaterialCount\>, 
[IEquatable<CMsgMonsterHunterMaterialCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterMaterialCount\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterMaterialCount\>\(CMsgMonsterHunterMaterialCount, params CMsgMonsterHunterMaterialCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount__ctor"></a> CMsgMonsterHunterMaterialCount\(\)

```csharp
public CMsgMonsterHunterMaterialCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_"></a> CMsgMonsterHunterMaterialCount\(CMsgMonsterHunterMaterialCount\)

```csharp
public CMsgMonsterHunterMaterialCount(CMsgMonsterHunterMaterialCount other)
```

#### Parameters

`other` [CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_MaterialCountFieldNumber"></a> MaterialCountFieldNumber

```csharp
public const int MaterialCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_MaterialIdFieldNumber"></a> MaterialIdFieldNumber

```csharp
public const int MaterialIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_HasMaterialCount"></a> HasMaterialCount

```csharp
public bool HasMaterialCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_HasMaterialId"></a> HasMaterialId

```csharp
public bool HasMaterialId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_MaterialCount"></a> MaterialCount

```csharp
public uint MaterialCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_MaterialId"></a> MaterialId

```csharp
public uint MaterialId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterMaterialCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_ClearMaterialCount"></a> ClearMaterialCount\(\)

```csharp
public void ClearMaterialCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_ClearMaterialId"></a> ClearMaterialId\(\)

```csharp
public void ClearMaterialId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterMaterialCount Clone()
```

#### Returns

 [CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_"></a> Equals\(CMsgMonsterHunterMaterialCount\)

```csharp
public bool Equals(CMsgMonsterHunterMaterialCount other)
```

#### Parameters

`other` [CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_"></a> MergeFrom\(CMsgMonsterHunterMaterialCount\)

```csharp
public void MergeFrom(CMsgMonsterHunterMaterialCount other)
```

#### Parameters

`other` [CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

