# <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard"></a> Class CMsgDOTALeaderboards.Types.RegionLeaderboard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeaderboards.Types.RegionLeaderboard : IMessage<CMsgDOTALeaderboards.Types.RegionLeaderboard>, IEquatable<CMsgDOTALeaderboards.Types.RegionLeaderboard>, IDeepCloneable<CMsgDOTALeaderboards.Types.RegionLeaderboard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeaderboards.Types.RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)

#### Implements

IMessage<CMsgDOTALeaderboards.Types.RegionLeaderboard\>, 
[IEquatable<CMsgDOTALeaderboards.Types.RegionLeaderboard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeaderboards.Types.RegionLeaderboard\>, 
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
[EnumerableExtensions.In<CMsgDOTALeaderboards.Types.RegionLeaderboard\>\(CMsgDOTALeaderboards.Types.RegionLeaderboard, params CMsgDOTALeaderboards.Types.RegionLeaderboard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard__ctor"></a> RegionLeaderboard\(\)

```csharp
public RegionLeaderboard()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard__ctor_Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_"></a> RegionLeaderboard\(RegionLeaderboard\)

```csharp
public RegionLeaderboard(CMsgDOTALeaderboards.Types.RegionLeaderboard other)
```

#### Parameters

`other` [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.md).[RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_DivisionFieldNumber"></a> DivisionFieldNumber

```csharp
public const int DivisionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_Division"></a> Division

```csharp
public uint Division { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_HasDivision"></a> HasDivision

```csharp
public bool HasDivision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeaderboards.Types.RegionLeaderboard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.md).[RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_ClearDivision"></a> ClearDivision\(\)

```csharp
public void ClearDivision()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeaderboards.Types.RegionLeaderboard Clone()
```

#### Returns

 [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.md).[RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_Equals_Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_"></a> Equals\(RegionLeaderboard\)

```csharp
public bool Equals(CMsgDOTALeaderboards.Types.RegionLeaderboard other)
```

#### Parameters

`other` [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.md).[RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_"></a> MergeFrom\(RegionLeaderboard\)

```csharp
public void MergeFrom(CMsgDOTALeaderboards.Types.RegionLeaderboard other)
```

#### Parameters

`other` [CMsgDOTALeaderboards](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.md).[RegionLeaderboard](Divine.Protobufs.Dota2.CMsgDOTALeaderboards.Types.RegionLeaderboard.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaderboards_Types_RegionLeaderboard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

