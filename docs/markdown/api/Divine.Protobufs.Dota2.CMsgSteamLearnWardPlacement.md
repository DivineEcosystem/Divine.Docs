# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement"></a> Class CMsgSteamLearnWardPlacement

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnWardPlacement : IMessage<CMsgSteamLearnWardPlacement>, IEquatable<CMsgSteamLearnWardPlacement>, IDeepCloneable<CMsgSteamLearnWardPlacement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md)

#### Implements

IMessage<CMsgSteamLearnWardPlacement\>, 
[IEquatable<CMsgSteamLearnWardPlacement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnWardPlacement\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnWardPlacement\>\(CMsgSteamLearnWardPlacement, params CMsgSteamLearnWardPlacement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement__ctor"></a> CMsgSteamLearnWardPlacement\(\)

```csharp
public CMsgSteamLearnWardPlacement()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_"></a> CMsgSteamLearnWardPlacement\(CMsgSteamLearnWardPlacement\)

```csharp
public CMsgSteamLearnWardPlacement(CMsgSteamLearnWardPlacement other)
```

#### Parameters

`other` [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_ExistingWardLocsFieldNumber"></a> ExistingWardLocsFieldNumber

```csharp
public const int ExistingWardLocsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_WardLocFieldNumber"></a> WardLocFieldNumber

```csharp
public const int WardLocFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_ExistingWardLocs"></a> ExistingWardLocs

```csharp
public RepeatedField<CMsgSteamLearnWardPlacement.Types.Location> ExistingWardLocs { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnWardPlacement> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_WardLoc"></a> WardLoc

```csharp
public CMsgSteamLearnWardPlacement.Types.Location WardLoc { get; set; }
```

#### Property Value

 [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnWardPlacement Clone()
```

#### Returns

 [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_"></a> Equals\(CMsgSteamLearnWardPlacement\)

```csharp
public bool Equals(CMsgSteamLearnWardPlacement other)
```

#### Parameters

`other` [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_"></a> MergeFrom\(CMsgSteamLearnWardPlacement\)

```csharp
public void MergeFrom(CMsgSteamLearnWardPlacement other)
```

#### Parameters

`other` [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

