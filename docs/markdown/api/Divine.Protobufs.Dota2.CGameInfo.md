# <a id="Divine_Protobufs_Dota2_CGameInfo"></a> Class CGameInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameInfo : IMessage<CGameInfo>, IEquatable<CGameInfo>, IDeepCloneable<CGameInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)

#### Implements

IMessage<CGameInfo\>, 
[IEquatable<CGameInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameInfo\>, 
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
[EnumerableExtensions.In<CGameInfo\>\(CGameInfo, params CGameInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGameInfo__ctor"></a> CGameInfo\(\)

```csharp
public CGameInfo()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo__ctor_Divine_Protobufs_Dota2_CGameInfo_"></a> CGameInfo\(CGameInfo\)

```csharp
public CGameInfo(CGameInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGameInfo_CsFieldNumber"></a> CsFieldNumber

```csharp
public const int CsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_DotaFieldNumber"></a> DotaFieldNumber

```csharp
public const int DotaFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGameInfo_Cs"></a> Cs

```csharp
public CGameInfo.Types.CCSGameInfo Cs { get; set; }
```

#### Property Value

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CCSGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CCSGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGameInfo_Dota"></a> Dota

```csharp
public CGameInfo.Types.CDotaGameInfo Dota { get; set; }
```

#### Property Value

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Parser"></a> Parser

```csharp
public static MessageParser<CGameInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGameInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Clone"></a> Clone\(\)

```csharp
public CGameInfo Clone()
```

#### Returns

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Equals_Divine_Protobufs_Dota2_CGameInfo_"></a> Equals\(CGameInfo\)

```csharp
public bool Equals(CGameInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_MergeFrom_Divine_Protobufs_Dota2_CGameInfo_"></a> MergeFrom\(CGameInfo\)

```csharp
public void MergeFrom(CGameInfo other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGameInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGameInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

