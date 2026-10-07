# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo"></a> Class CMsgDOTADPCProfileInfo.Types.PredictionInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCProfileInfo.Types.PredictionInfo : IMessage<CMsgDOTADPCProfileInfo.Types.PredictionInfo>, IEquatable<CMsgDOTADPCProfileInfo.Types.PredictionInfo>, IDeepCloneable<CMsgDOTADPCProfileInfo.Types.PredictionInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCProfileInfo.Types.PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)

#### Implements

IMessage<CMsgDOTADPCProfileInfo.Types.PredictionInfo\>, 
[IEquatable<CMsgDOTADPCProfileInfo.Types.PredictionInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCProfileInfo.Types.PredictionInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCProfileInfo.Types.PredictionInfo\>\(CMsgDOTADPCProfileInfo.Types.PredictionInfo, params CMsgDOTADPCProfileInfo.Types.PredictionInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo__ctor"></a> PredictionInfo\(\)

```csharp
public PredictionInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_"></a> PredictionInfo\(PredictionInfo\)

```csharp
public PredictionInfo(CMsgDOTADPCProfileInfo.Types.PredictionInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_PercentFieldNumber"></a> PercentFieldNumber

```csharp
public const int PercentFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_ShardWinningsFieldNumber"></a> ShardWinningsFieldNumber

```csharp
public const int ShardWinningsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_HasPercent"></a> HasPercent

```csharp
public bool HasPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_HasShardWinnings"></a> HasShardWinnings

```csharp
public bool HasShardWinnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCProfileInfo.Types.PredictionInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_Percent"></a> Percent

```csharp
public uint Percent { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_ShardWinnings"></a> ShardWinnings

```csharp
public int ShardWinnings { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_ClearPercent"></a> ClearPercent\(\)

```csharp
public void ClearPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_ClearShardWinnings"></a> ClearShardWinnings\(\)

```csharp
public void ClearShardWinnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCProfileInfo.Types.PredictionInfo Clone()
```

#### Returns

 [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_"></a> Equals\(PredictionInfo\)

```csharp
public bool Equals(CMsgDOTADPCProfileInfo.Types.PredictionInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_"></a> MergeFrom\(PredictionInfo\)

```csharp
public void MergeFrom(CMsgDOTADPCProfileInfo.Types.PredictionInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_PredictionInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

