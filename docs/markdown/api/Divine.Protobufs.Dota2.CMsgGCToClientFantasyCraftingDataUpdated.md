# <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated"></a> Class CMsgGCToClientFantasyCraftingDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientFantasyCraftingDataUpdated : IMessage<CMsgGCToClientFantasyCraftingDataUpdated>, IEquatable<CMsgGCToClientFantasyCraftingDataUpdated>, IDeepCloneable<CMsgGCToClientFantasyCraftingDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientFantasyCraftingDataUpdated\>, 
[IEquatable<CMsgGCToClientFantasyCraftingDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientFantasyCraftingDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientFantasyCraftingDataUpdated\>\(CMsgGCToClientFantasyCraftingDataUpdated, params CMsgGCToClientFantasyCraftingDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated__ctor"></a> CMsgGCToClientFantasyCraftingDataUpdated\(\)

```csharp
public CMsgGCToClientFantasyCraftingDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_"></a> CMsgGCToClientFantasyCraftingDataUpdated\(CMsgGCToClientFantasyCraftingDataUpdated\)

```csharp
public CMsgGCToClientFantasyCraftingDataUpdated(CMsgGCToClientFantasyCraftingDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_TabletDataFieldNumber"></a> TabletDataFieldNumber

```csharp
public const int TabletDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientFantasyCraftingDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_TabletData"></a> TabletData

```csharp
public CMsgDotaFantasyCraftingTabletData TabletData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_UserData"></a> UserData

```csharp
public CMsgDotaFantasyCraftingUserData UserData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientFantasyCraftingDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_"></a> Equals\(CMsgGCToClientFantasyCraftingDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientFantasyCraftingDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_"></a> MergeFrom\(CMsgGCToClientFantasyCraftingDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientFantasyCraftingDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientFantasyCraftingDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientFantasyCraftingDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFantasyCraftingDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

