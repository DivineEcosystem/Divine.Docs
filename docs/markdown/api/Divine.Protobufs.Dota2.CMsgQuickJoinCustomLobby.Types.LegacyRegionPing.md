# <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing"></a> Class CMsgQuickJoinCustomLobby.Types.LegacyRegionPing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgQuickJoinCustomLobby.Types.LegacyRegionPing : IMessage<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing>, IEquatable<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing>, IDeepCloneable<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgQuickJoinCustomLobby.Types.LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)

#### Implements

IMessage<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing\>, 
[IEquatable<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing\>, 
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
[EnumerableExtensions.In<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing\>\(CMsgQuickJoinCustomLobby.Types.LegacyRegionPing, params CMsgQuickJoinCustomLobby.Types.LegacyRegionPing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing__ctor"></a> LegacyRegionPing\(\)

```csharp
public LegacyRegionPing()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing__ctor_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_"></a> LegacyRegionPing\(LegacyRegionPing\)

```csharp
public LegacyRegionPing(CMsgQuickJoinCustomLobby.Types.LegacyRegionPing other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md).[Types](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.md).[LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_PingFieldNumber"></a> PingFieldNumber

```csharp
public const int PingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_RegionCodeFieldNumber"></a> RegionCodeFieldNumber

```csharp
public const int RegionCodeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_ServerRegionFieldNumber"></a> ServerRegionFieldNumber

```csharp
public const int ServerRegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_HasPing"></a> HasPing

```csharp
public bool HasPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_HasRegionCode"></a> HasRegionCode

```csharp
public bool HasRegionCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_HasServerRegion"></a> HasServerRegion

```csharp
public bool HasServerRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_Parser"></a> Parser

```csharp
public static MessageParser<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md).[Types](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.md).[LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_Ping"></a> Ping

```csharp
public uint Ping { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_RegionCode"></a> RegionCode

```csharp
public uint RegionCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_ServerRegion"></a> ServerRegion

```csharp
public uint ServerRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_ClearPing"></a> ClearPing\(\)

```csharp
public void ClearPing()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_ClearRegionCode"></a> ClearRegionCode\(\)

```csharp
public void ClearRegionCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_ClearServerRegion"></a> ClearServerRegion\(\)

```csharp
public void ClearServerRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_Clone"></a> Clone\(\)

```csharp
public CMsgQuickJoinCustomLobby.Types.LegacyRegionPing Clone()
```

#### Returns

 [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md).[Types](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.md).[LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_Equals_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_"></a> Equals\(LegacyRegionPing\)

```csharp
public bool Equals(CMsgQuickJoinCustomLobby.Types.LegacyRegionPing other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md).[Types](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.md).[LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_MergeFrom_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_"></a> MergeFrom\(LegacyRegionPing\)

```csharp
public void MergeFrom(CMsgQuickJoinCustomLobby.Types.LegacyRegionPing other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md).[Types](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.md).[LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Types_LegacyRegionPing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

