# <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo"></a> Class CGameInfo.Types.CCSGameInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameInfo.Types.CCSGameInfo : IMessage<CGameInfo.Types.CCSGameInfo>, IEquatable<CGameInfo.Types.CCSGameInfo>, IDeepCloneable<CGameInfo.Types.CCSGameInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameInfo.Types.CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)

#### Implements

IMessage<CGameInfo.Types.CCSGameInfo\>, 
[IEquatable<CGameInfo.Types.CCSGameInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameInfo.Types.CCSGameInfo\>, 
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
[EnumerableExtensions.In<CGameInfo.Types.CCSGameInfo\>\(CGameInfo.Types.CCSGameInfo, params CGameInfo.Types.CCSGameInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo__ctor"></a> CCSGameInfo\(\)

```csharp
public CCSGameInfo()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo__ctor_Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_"></a> CCSGameInfo\(CCSGameInfo\)

```csharp
public CCSGameInfo(CGameInfo.Types.CCSGameInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_RoundStartTicksFieldNumber"></a> RoundStartTicksFieldNumber

```csharp
public const int RoundStartTicksFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_Parser"></a> Parser

```csharp
public static MessageParser<CGameInfo.Types.CCSGameInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_RoundStartTicks"></a> RoundStartTicks

```csharp
public RepeatedField<int> RoundStartTicks { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_Clone"></a> Clone\(\)

```csharp
public CGameInfo.Types.CCSGameInfo Clone()
```

#### Returns

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_Equals_Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_"></a> Equals\(CCSGameInfo\)

```csharp
public bool Equals(CGameInfo.Types.CCSGameInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_MergeFrom_Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_"></a> MergeFrom\(CCSGameInfo\)

```csharp
public void MergeFrom(CGameInfo.Types.CCSGameInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CCSGameInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

