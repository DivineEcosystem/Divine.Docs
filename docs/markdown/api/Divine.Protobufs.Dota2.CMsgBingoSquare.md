# <a id="Divine_Protobufs_Dota2_CMsgBingoSquare"></a> Class CMsgBingoSquare

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBingoSquare : IMessage<CMsgBingoSquare>, IEquatable<CMsgBingoSquare>, IDeepCloneable<CMsgBingoSquare>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)

#### Implements

IMessage<CMsgBingoSquare\>, 
[IEquatable<CMsgBingoSquare\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBingoSquare\>, 
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
[EnumerableExtensions.In<CMsgBingoSquare\>\(CMsgBingoSquare, params CMsgBingoSquare\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare__ctor"></a> CMsgBingoSquare\(\)

```csharp
public CMsgBingoSquare()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare__ctor_Divine_Protobufs_Dota2_CMsgBingoSquare_"></a> CMsgBingoSquare\(CMsgBingoSquare\)

```csharp
public CMsgBingoSquare(CMsgBingoSquare other)
```

#### Parameters

`other` [CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_StatIdFieldNumber"></a> StatIdFieldNumber

```csharp
public const int StatIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_StatThresholdFieldNumber"></a> StatThresholdFieldNumber

```csharp
public const int StatThresholdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_UpgradeLevelFieldNumber"></a> UpgradeLevelFieldNumber

```csharp
public const int UpgradeLevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_HasStatId"></a> HasStatId

```csharp
public bool HasStatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_HasStatThreshold"></a> HasStatThreshold

```csharp
public bool HasStatThreshold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_HasUpgradeLevel"></a> HasUpgradeLevel

```csharp
public bool HasUpgradeLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBingoSquare> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_StatId"></a> StatId

```csharp
public uint StatId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_StatThreshold"></a> StatThreshold

```csharp
public int StatThreshold { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_UpgradeLevel"></a> UpgradeLevel

```csharp
public uint UpgradeLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_ClearStatId"></a> ClearStatId\(\)

```csharp
public void ClearStatId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_ClearStatThreshold"></a> ClearStatThreshold\(\)

```csharp
public void ClearStatThreshold()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_ClearUpgradeLevel"></a> ClearUpgradeLevel\(\)

```csharp
public void ClearUpgradeLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_Clone"></a> Clone\(\)

```csharp
public CMsgBingoSquare Clone()
```

#### Returns

 [CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_Equals_Divine_Protobufs_Dota2_CMsgBingoSquare_"></a> Equals\(CMsgBingoSquare\)

```csharp
public bool Equals(CMsgBingoSquare other)
```

#### Parameters

`other` [CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_MergeFrom_Divine_Protobufs_Dota2_CMsgBingoSquare_"></a> MergeFrom\(CMsgBingoSquare\)

```csharp
public void MergeFrom(CMsgBingoSquare other)
```

#### Parameters

`other` [CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBingoSquare_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

