# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo"></a> Class CMsgDOTADPCProfileInfo.Types.FantasyInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCProfileInfo.Types.FantasyInfo : IMessage<CMsgDOTADPCProfileInfo.Types.FantasyInfo>, IEquatable<CMsgDOTADPCProfileInfo.Types.FantasyInfo>, IDeepCloneable<CMsgDOTADPCProfileInfo.Types.FantasyInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCProfileInfo.Types.FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)

#### Implements

IMessage<CMsgDOTADPCProfileInfo.Types.FantasyInfo\>, 
[IEquatable<CMsgDOTADPCProfileInfo.Types.FantasyInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCProfileInfo.Types.FantasyInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCProfileInfo.Types.FantasyInfo\>\(CMsgDOTADPCProfileInfo.Types.FantasyInfo, params CMsgDOTADPCProfileInfo.Types.FantasyInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo__ctor"></a> FantasyInfo\(\)

```csharp
public FantasyInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_"></a> FantasyInfo\(FantasyInfo\)

```csharp
public FantasyInfo(CMsgDOTADPCProfileInfo.Types.FantasyInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ShardWinningsFieldNumber"></a> ShardWinningsFieldNumber

```csharp
public const int ShardWinningsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Top50FinishesFieldNumber"></a> Top50FinishesFieldNumber

```csharp
public const int Top50FinishesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Top75FinishesFieldNumber"></a> Top75FinishesFieldNumber

```csharp
public const int Top75FinishesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Top90FinishesFieldNumber"></a> Top90FinishesFieldNumber

```csharp
public const int Top90FinishesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_HasShardWinnings"></a> HasShardWinnings

```csharp
public bool HasShardWinnings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_HasTop50Finishes"></a> HasTop50Finishes

```csharp
public bool HasTop50Finishes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_HasTop75Finishes"></a> HasTop75Finishes

```csharp
public bool HasTop75Finishes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_HasTop90Finishes"></a> HasTop90Finishes

```csharp
public bool HasTop90Finishes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCProfileInfo.Types.FantasyInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ShardWinnings"></a> ShardWinnings

```csharp
public uint ShardWinnings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Top50Finishes"></a> Top50Finishes

```csharp
public uint Top50Finishes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Top75Finishes"></a> Top75Finishes

```csharp
public uint Top75Finishes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Top90Finishes"></a> Top90Finishes

```csharp
public uint Top90Finishes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ClearShardWinnings"></a> ClearShardWinnings\(\)

```csharp
public void ClearShardWinnings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ClearTop50Finishes"></a> ClearTop50Finishes\(\)

```csharp
public void ClearTop50Finishes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ClearTop75Finishes"></a> ClearTop75Finishes\(\)

```csharp
public void ClearTop75Finishes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ClearTop90Finishes"></a> ClearTop90Finishes\(\)

```csharp
public void ClearTop90Finishes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCProfileInfo.Types.FantasyInfo Clone()
```

#### Returns

 [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_"></a> Equals\(FantasyInfo\)

```csharp
public bool Equals(CMsgDOTADPCProfileInfo.Types.FantasyInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_"></a> MergeFrom\(FantasyInfo\)

```csharp
public void MergeFrom(CMsgDOTADPCProfileInfo.Types.FantasyInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Types_FantasyInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

