# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location"></a> Class CMsgSteamLearnWardPlacement.Types.Location

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnWardPlacement.Types.Location : IMessage<CMsgSteamLearnWardPlacement.Types.Location>, IEquatable<CMsgSteamLearnWardPlacement.Types.Location>, IDeepCloneable<CMsgSteamLearnWardPlacement.Types.Location>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnWardPlacement.Types.Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)

#### Implements

IMessage<CMsgSteamLearnWardPlacement.Types.Location\>, 
[IEquatable<CMsgSteamLearnWardPlacement.Types.Location\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnWardPlacement.Types.Location\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnWardPlacement.Types.Location\>\(CMsgSteamLearnWardPlacement.Types.Location, params CMsgSteamLearnWardPlacement.Types.Location\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location__ctor"></a> Location\(\)

```csharp
public Location()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_"></a> Location\(Location\)

```csharp
public Location(CMsgSteamLearnWardPlacement.Types.Location other)
```

#### Parameters

`other` [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnWardPlacement.Types.Location> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_X"></a> X

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_Y"></a> Y

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnWardPlacement.Types.Location Clone()
```

#### Returns

 [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_"></a> Equals\(Location\)

```csharp
public bool Equals(CMsgSteamLearnWardPlacement.Types.Location other)
```

#### Parameters

`other` [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_"></a> MergeFrom\(Location\)

```csharp
public void MergeFrom(CMsgSteamLearnWardPlacement.Types.Location other)
```

#### Parameters

`other` [CMsgSteamLearnWardPlacement](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.md).[Location](Divine.Protobufs.Dota2.CMsgSteamLearnWardPlacement.Types.Location.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnWardPlacement_Types_Location_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

