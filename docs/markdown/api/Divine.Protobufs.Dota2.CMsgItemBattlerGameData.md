# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData"></a> Class CMsgItemBattlerGameData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerGameData : IMessage<CMsgItemBattlerGameData>, IEquatable<CMsgItemBattlerGameData>, IDeepCloneable<CMsgItemBattlerGameData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerGameData](Divine.Protobufs.Dota2.CMsgItemBattlerGameData.md)

#### Implements

IMessage<CMsgItemBattlerGameData\>, 
[IEquatable<CMsgItemBattlerGameData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerGameData\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerGameData\>\(CMsgItemBattlerGameData, params CMsgItemBattlerGameData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData__ctor"></a> CMsgItemBattlerGameData\(\)

```csharp
public CMsgItemBattlerGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerGameData_"></a> CMsgItemBattlerGameData\(CMsgItemBattlerGameData\)

```csharp
public CMsgItemBattlerGameData(CMsgItemBattlerGameData other)
```

#### Parameters

`other` [CMsgItemBattlerGameData](Divine.Protobufs.Dota2.CMsgItemBattlerGameData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_SeedFieldNumber"></a> SeedFieldNumber

```csharp
public const int SeedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_WorldDataFieldNumber"></a> WorldDataFieldNumber

```csharp
public const int WorldDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_HasSeed"></a> HasSeed

```csharp
public bool HasSeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerGameData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerGameData](Divine.Protobufs.Dota2.CMsgItemBattlerGameData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_Seed"></a> Seed

```csharp
public uint Seed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_WorldData"></a> WorldData

```csharp
public CMsgItemBattlerWorldData WorldData { get; set; }
```

#### Property Value

 [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_ClearSeed"></a> ClearSeed\(\)

```csharp
public void ClearSeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerGameData Clone()
```

#### Returns

 [CMsgItemBattlerGameData](Divine.Protobufs.Dota2.CMsgItemBattlerGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerGameData_"></a> Equals\(CMsgItemBattlerGameData\)

```csharp
public bool Equals(CMsgItemBattlerGameData other)
```

#### Parameters

`other` [CMsgItemBattlerGameData](Divine.Protobufs.Dota2.CMsgItemBattlerGameData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerGameData_"></a> MergeFrom\(CMsgItemBattlerGameData\)

```csharp
public void MergeFrom(CMsgItemBattlerGameData other)
```

#### Parameters

`other` [CMsgItemBattlerGameData](Divine.Protobufs.Dota2.CMsgItemBattlerGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerGameData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

